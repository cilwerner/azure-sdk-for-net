﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis; // Needed for NET6.0 attributes
using System.Globalization;
using System.Threading.Tasks;

namespace Azure.Core.Pipeline
{
    internal class RequestActivityPolicy : HttpPipelinePolicy
    {
        private readonly bool _isDistributedTracingEnabled;
        private readonly string? _resourceProviderNamespace;
        private readonly HttpMessageSanitizer _sanitizer;

        private const string TraceParentHeaderName = "traceparent";
        private const string TraceStateHeaderName = "tracestate";
        private const string RequestIdHeaderName = "Request-Id";

        private static readonly DiagnosticListener s_diagnosticSource = new DiagnosticListener("Azure.Core");
#if NETCOREAPP2_1
        private static readonly object? s_activitySource = ActivityExtensions.CreateActivitySource("Azure.Core.Http");
#else
        private static readonly ActivitySource s_activitySource = new ActivitySource("Azure.Core.Http");
#endif

        public RequestActivityPolicy(bool isDistributedTracingEnabled, string? resourceProviderNamespace, HttpMessageSanitizer httpMessageSanitizer)
        {
            _isDistributedTracingEnabled = isDistributedTracingEnabled;
            _resourceProviderNamespace = resourceProviderNamespace;
            _sanitizer = httpMessageSanitizer;
        }

        public override ValueTask ProcessAsync(HttpMessage message, ReadOnlyMemory<HttpPipelinePolicy> pipeline)
        {
            if (ShouldCreateActivity)
            {
                return ProcessAsync(message, pipeline, true);
            }
            else
            {
                return ProcessNextAsync(message, pipeline, true);
            }
        }

        public override void Process(HttpMessage message, ReadOnlyMemory<HttpPipelinePolicy> pipeline)
        {
            if (ShouldCreateActivity)
            {
                ProcessAsync(message, pipeline, false).EnsureCompleted();
            }
            else
            {
                ProcessNextAsync(message, pipeline, false).EnsureCompleted();
            }
        }

        [DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof(HttpMessage))]
        [DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties, typeof(Exception))]
        private async ValueTask ProcessAsync(HttpMessage message, ReadOnlyMemory<HttpPipelinePolicy> pipeline, bool async)
        {
            using var scope = CreateDiagnosticScope(message);

            bool isActivitySourceEnabled = IsActivitySourceEnabled;

            scope.AddAttribute("http.method", message.Request.Method.Method);
            scope.AddAttribute("http.url", _sanitizer.SanitizeUrl(message.Request.Uri.ToString()));
            scope.AddAttribute(isActivitySourceEnabled ? "az.client_request_id": "requestId", message.Request.ClientRequestId);

            if (isActivitySourceEnabled && message.Request.Uri.Host is string host)
            {
                scope.AddAttribute("net.peer.name", host);
                int port = message.Request.Uri.Port;
                if (port != 443)
                {
                    scope.AddIntegerAttribute("net.peer.port", port);
                }
            }

            if (_resourceProviderNamespace != null)
            {
                scope.AddAttribute("az.namespace", _resourceProviderNamespace);
            }

            if (message.Request.Headers.TryGetValue("User-Agent", out string? userAgent))
            {
                scope.AddAttribute("http.user_agent", userAgent);
            }

            scope.Start();

            try
            {
                if (async)
                {
                    await ProcessNextAsync(message, pipeline, true).ConfigureAwait(false);
                }
                else
                {
                    ProcessNextAsync(message, pipeline, false).EnsureCompleted();
                }
            }
            catch (Exception e)
            {
                ScopeFailed(scope, e);
                throw;
            }

            if (isActivitySourceEnabled)
            {
                scope.AddIntegerAttribute("http.status_code", message.Response.Status);
            }
            else
            {
                scope.AddAttribute("http.status_code", message.Response.Status, static i => i.ToString(CultureInfo.InvariantCulture));
            }

            if (message.Response.Headers.RequestId is string serviceRequestId)
            {
                string requestIdKey = isActivitySourceEnabled ? "az.service_request_id" : "serviceRequestId";
                scope.AddAttribute(requestIdKey, serviceRequestId);
            }

            if (message.Response.IsError)
            {
                scope.AddAttribute("otel.status_code", "ERROR");
                ScopeFailed(scope);
            }
            else
            {
                // Set the status to UNSET so the AppInsights doesn't try to infer it from the status code
                scope.AddAttribute("otel.status_code",  "UNSET");
            }
        }

        [UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026", Justification = "The values being passed into Write have the commonly used properties being preserved with DynamicDependency.")]
        private void ScopeFailed(DiagnosticScope scope, Exception? ex = default)
        {
            if (ex == null)
            {
                scope.Failed();
            }
            scope.Failed(ex);
        }

        [UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026", Justification = "The values being passed into Write have the commonly used properties being preserved with DynamicDependency.")]
        private DiagnosticScope CreateDiagnosticScope(HttpMessage message)
        {
#if NETCOREAPP2_1
            return new DiagnosticScope("Azure.Core.Http.Request", s_diagnosticSource, message, s_activitySource, DiagnosticScope.ActivityKind.Client, false);
#else
            return new DiagnosticScope("Azure.Core.Http.Request", s_diagnosticSource, message, s_activitySource, System.Diagnostics.ActivityKind.Client, false);
#endif
        }

        private static ValueTask ProcessNextAsync(HttpMessage message, ReadOnlyMemory<HttpPipelinePolicy> pipeline, bool async)
        {
            Activity? currentActivity = Activity.Current;

            if (currentActivity != null)
            {
                var currentActivityId = currentActivity.Id ?? string.Empty;
#if NETCOREAPP2_1
                if (currentActivity.IsW3CFormat())
#else
                if (currentActivity.IdFormat == ActivityIdFormat.W3C)
#endif
                {
                    if (!message.Request.Headers.Contains(TraceParentHeaderName))
                    {
                        message.Request.Headers.Add(TraceParentHeaderName, currentActivityId);
#if NETCOREAPP2_1
                        if (currentActivity.GetTraceState() is string traceStateString)
#else
                        if (currentActivity.TraceStateString is string traceStateString)
#endif
                        {
                            message.Request.Headers.Add(TraceStateHeaderName, traceStateString);
                        }
                    }
                }
                else
                {
                    if (!message.Request.Headers.Contains(RequestIdHeaderName))
                    {
                        message.Request.Headers.Add(RequestIdHeaderName, currentActivityId);
                    }
                }
            }

            if (async)
            {
                return ProcessNextAsync(message, pipeline);
            }
            else
            {
                ProcessNext(message, pipeline);
                return default;
            }
        }

        private bool ShouldCreateActivity =>
            _isDistributedTracingEnabled &&
#if NETCOREAPP2_1
            (s_diagnosticSource.IsEnabled() || ActivityExtensions.ActivitySourceHasListeners(s_activitySource));
#else
            (s_diagnosticSource.IsEnabled() || s_activitySource.HasListeners());
#endif

#if NETCOREAPP2_1
        private bool IsActivitySourceEnabled => _isDistributedTracingEnabled && ActivityExtensions.ActivitySourceHasListeners(s_activitySource);
#else
        private bool IsActivitySourceEnabled => _isDistributedTracingEnabled && s_activitySource.HasListeners();
#endif
    }
}
