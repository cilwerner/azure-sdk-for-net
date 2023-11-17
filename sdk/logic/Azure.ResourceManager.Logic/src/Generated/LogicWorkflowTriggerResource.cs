// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Logic.Models;

namespace Azure.ResourceManager.Logic
{
    /// <summary>
    /// A Class representing a LogicWorkflowTrigger along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="LogicWorkflowTriggerResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetLogicWorkflowTriggerResource method.
    /// Otherwise you can get one from its parent resource <see cref="LogicWorkflowResource" /> using the GetLogicWorkflowTrigger method.
    /// </summary>
    public partial class LogicWorkflowTriggerResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="LogicWorkflowTriggerResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="workflowName"> The workflowName. </param>
        /// <param name="triggerName"> The triggerName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string workflowName, string triggerName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/triggers/{triggerName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _logicWorkflowTriggerWorkflowTriggersClientDiagnostics;
        private readonly WorkflowTriggersRestOperations _logicWorkflowTriggerWorkflowTriggersRestClient;
        private readonly LogicWorkflowTriggerData _data;

        /// <summary> Initializes a new instance of the <see cref="LogicWorkflowTriggerResource"/> class for mocking. </summary>
        protected LogicWorkflowTriggerResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "LogicWorkflowTriggerResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal LogicWorkflowTriggerResource(ArmClient client, LogicWorkflowTriggerData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="LogicWorkflowTriggerResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal LogicWorkflowTriggerResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _logicWorkflowTriggerWorkflowTriggersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Logic", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string logicWorkflowTriggerWorkflowTriggersApiVersion);
            _logicWorkflowTriggerWorkflowTriggersRestClient = new WorkflowTriggersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, logicWorkflowTriggerWorkflowTriggersApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Logic/workflows/triggers";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual LogicWorkflowTriggerData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of LogicWorkflowTriggerHistoryResources in the LogicWorkflowTrigger. </summary>
        /// <returns> An object representing collection of LogicWorkflowTriggerHistoryResources and their operations over a LogicWorkflowTriggerHistoryResource. </returns>
        public virtual LogicWorkflowTriggerHistoryCollection GetLogicWorkflowTriggerHistories()
        {
            return GetCachedClient(client => new LogicWorkflowTriggerHistoryCollection(client, Id));
        }

        /// <summary>
        /// Gets a workflow trigger history.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/triggers/{triggerName}/histories/{historyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowTriggerHistories_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="historyName"> The workflow trigger history name. Corresponds to the run name for triggers that resulted in a run. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="historyName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="historyName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<LogicWorkflowTriggerHistoryResource>> GetLogicWorkflowTriggerHistoryAsync(string historyName, CancellationToken cancellationToken = default)
        {
            return await GetLogicWorkflowTriggerHistories().GetAsync(historyName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a workflow trigger history.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/triggers/{triggerName}/histories/{historyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowTriggerHistories_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="historyName"> The workflow trigger history name. Corresponds to the run name for triggers that resulted in a run. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="historyName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="historyName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<LogicWorkflowTriggerHistoryResource> GetLogicWorkflowTriggerHistory(string historyName, CancellationToken cancellationToken = default)
        {
            return GetLogicWorkflowTriggerHistories().Get(historyName, cancellationToken);
        }

        /// <summary>
        /// Gets a workflow trigger.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/triggers/{triggerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowTriggers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<LogicWorkflowTriggerResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _logicWorkflowTriggerWorkflowTriggersClientDiagnostics.CreateScope("LogicWorkflowTriggerResource.Get");
            scope.Start();
            try
            {
                var response = await _logicWorkflowTriggerWorkflowTriggersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LogicWorkflowTriggerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a workflow trigger.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/triggers/{triggerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowTriggers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<LogicWorkflowTriggerResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _logicWorkflowTriggerWorkflowTriggersClientDiagnostics.CreateScope("LogicWorkflowTriggerResource.Get");
            scope.Start();
            try
            {
                var response = _logicWorkflowTriggerWorkflowTriggersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LogicWorkflowTriggerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Resets a workflow trigger.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/triggers/{triggerName}/reset</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowTriggers_Reset</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> ResetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _logicWorkflowTriggerWorkflowTriggersClientDiagnostics.CreateScope("LogicWorkflowTriggerResource.Reset");
            scope.Start();
            try
            {
                var response = await _logicWorkflowTriggerWorkflowTriggersRestClient.ResetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Resets a workflow trigger.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/triggers/{triggerName}/reset</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowTriggers_Reset</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Reset(CancellationToken cancellationToken = default)
        {
            using var scope = _logicWorkflowTriggerWorkflowTriggersClientDiagnostics.CreateScope("LogicWorkflowTriggerResource.Reset");
            scope.Start();
            try
            {
                var response = _logicWorkflowTriggerWorkflowTriggersRestClient.Reset(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Runs a workflow trigger.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/triggers/{triggerName}/run</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowTriggers_Run</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> RunAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _logicWorkflowTriggerWorkflowTriggersClientDiagnostics.CreateScope("LogicWorkflowTriggerResource.Run");
            scope.Start();
            try
            {
                var response = await _logicWorkflowTriggerWorkflowTriggersRestClient.RunAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Runs a workflow trigger.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/triggers/{triggerName}/run</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowTriggers_Run</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Run(CancellationToken cancellationToken = default)
        {
            using var scope = _logicWorkflowTriggerWorkflowTriggersClientDiagnostics.CreateScope("LogicWorkflowTriggerResource.Run");
            scope.Start();
            try
            {
                var response = _logicWorkflowTriggerWorkflowTriggersRestClient.Run(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the trigger schema as JSON.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/triggers/{triggerName}/schemas/json</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowTriggers_GetSchemaJson</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<LogicJsonSchema>> GetSchemaJsonAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _logicWorkflowTriggerWorkflowTriggersClientDiagnostics.CreateScope("LogicWorkflowTriggerResource.GetSchemaJson");
            scope.Start();
            try
            {
                var response = await _logicWorkflowTriggerWorkflowTriggersRestClient.GetSchemaJsonAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the trigger schema as JSON.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/triggers/{triggerName}/schemas/json</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowTriggers_GetSchemaJson</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<LogicJsonSchema> GetSchemaJson(CancellationToken cancellationToken = default)
        {
            using var scope = _logicWorkflowTriggerWorkflowTriggersClientDiagnostics.CreateScope("LogicWorkflowTriggerResource.GetSchemaJson");
            scope.Start();
            try
            {
                var response = _logicWorkflowTriggerWorkflowTriggersRestClient.GetSchemaJson(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Sets the state of a workflow trigger.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/triggers/{triggerName}/setState</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowTriggers_SetState</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The workflow trigger state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response> SetStateAsync(LogicWorkflowTriggerStateActionContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _logicWorkflowTriggerWorkflowTriggersClientDiagnostics.CreateScope("LogicWorkflowTriggerResource.SetState");
            scope.Start();
            try
            {
                var response = await _logicWorkflowTriggerWorkflowTriggersRestClient.SetStateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Sets the state of a workflow trigger.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/triggers/{triggerName}/setState</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowTriggers_SetState</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The workflow trigger state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response SetState(LogicWorkflowTriggerStateActionContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _logicWorkflowTriggerWorkflowTriggersClientDiagnostics.CreateScope("LogicWorkflowTriggerResource.SetState");
            scope.Start();
            try
            {
                var response = _logicWorkflowTriggerWorkflowTriggersRestClient.SetState(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the callback URL for a workflow trigger.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/triggers/{triggerName}/listCallbackUrl</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowTriggers_ListCallbackUrl</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<LogicWorkflowTriggerCallbackUri>> GetCallbackUrlAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _logicWorkflowTriggerWorkflowTriggersClientDiagnostics.CreateScope("LogicWorkflowTriggerResource.GetCallbackUrl");
            scope.Start();
            try
            {
                var response = await _logicWorkflowTriggerWorkflowTriggersRestClient.ListCallbackUrlAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the callback URL for a workflow trigger.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/workflows/{workflowName}/triggers/{triggerName}/listCallbackUrl</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkflowTriggers_ListCallbackUrl</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<LogicWorkflowTriggerCallbackUri> GetCallbackUrl(CancellationToken cancellationToken = default)
        {
            using var scope = _logicWorkflowTriggerWorkflowTriggersClientDiagnostics.CreateScope("LogicWorkflowTriggerResource.GetCallbackUrl");
            scope.Start();
            try
            {
                var response = _logicWorkflowTriggerWorkflowTriggersRestClient.ListCallbackUrl(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
