// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.PolicyInsights.Models;

namespace Azure.ResourceManager.PolicyInsights
{
    /// <summary>
    /// A Class representing a PolicyRemediation along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="PolicyRemediationResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetPolicyRemediationResource method.
    /// Otherwise you can get one from its parent resource <see cref="ArmResource"/> using the GetPolicyRemediation method.
    /// </summary>
    public partial class PolicyRemediationResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="PolicyRemediationResource"/> instance. </summary>
        /// <param name="resourceId"> The resourceId. </param>
        /// <param name="remediationName"> The remediationName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string resourceId, string remediationName)
        {
            var resourceId0 = $"{resourceId}/providers/Microsoft.PolicyInsights/remediations/{remediationName}";
            return new ResourceIdentifier(resourceId0);
        }

        private readonly ClientDiagnostics _policyRemediationRemediationsClientDiagnostics;
        private readonly RemediationsRestOperations _policyRemediationRemediationsRestClient;
        private readonly PolicyRemediationData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.PolicyInsights/remediations";

        /// <summary> Initializes a new instance of the <see cref="PolicyRemediationResource"/> class for mocking. </summary>
        protected PolicyRemediationResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PolicyRemediationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal PolicyRemediationResource(ArmClient client, PolicyRemediationData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="PolicyRemediationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal PolicyRemediationResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _policyRemediationRemediationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.PolicyInsights", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string policyRemediationRemediationsApiVersion);
            _policyRemediationRemediationsRestClient = new RemediationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, policyRemediationRemediationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual PolicyRemediationData Data
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

        /// <summary>
        /// Gets an existing remediation at resource scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceId}/providers/Microsoft.PolicyInsights/remediations/{remediationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Remediations_GetAtResource</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PolicyRemediationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PolicyRemediationResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _policyRemediationRemediationsClientDiagnostics.CreateScope("PolicyRemediationResource.Get");
            scope.Start();
            try
            {
                var response = await _policyRemediationRemediationsRestClient.GetAtResourceAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PolicyRemediationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an existing remediation at resource scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceId}/providers/Microsoft.PolicyInsights/remediations/{remediationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Remediations_GetAtResource</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PolicyRemediationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PolicyRemediationResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _policyRemediationRemediationsClientDiagnostics.CreateScope("PolicyRemediationResource.Get");
            scope.Start();
            try
            {
                var response = _policyRemediationRemediationsRestClient.GetAtResource(Id.Parent, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PolicyRemediationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes an existing remediation at individual resource scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceId}/providers/Microsoft.PolicyInsights/remediations/{remediationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Remediations_DeleteAtResource</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PolicyRemediationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation<PolicyRemediationResource>> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _policyRemediationRemediationsClientDiagnostics.CreateScope("PolicyRemediationResource.Delete");
            scope.Start();
            try
            {
                var response = await _policyRemediationRemediationsRestClient.DeleteAtResourceAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new PolicyInsightsArmOperation<PolicyRemediationResource>(Response.FromValue(new PolicyRemediationResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes an existing remediation at individual resource scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceId}/providers/Microsoft.PolicyInsights/remediations/{remediationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Remediations_DeleteAtResource</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PolicyRemediationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation<PolicyRemediationResource> Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _policyRemediationRemediationsClientDiagnostics.CreateScope("PolicyRemediationResource.Delete");
            scope.Start();
            try
            {
                var response = _policyRemediationRemediationsRestClient.DeleteAtResource(Id.Parent, Id.Name, cancellationToken);
                var operation = new PolicyInsightsArmOperation<PolicyRemediationResource>(Response.FromValue(new PolicyRemediationResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates a remediation at resource scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceId}/providers/Microsoft.PolicyInsights/remediations/{remediationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Remediations_CreateOrUpdateAtResource</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PolicyRemediationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The remediation parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<PolicyRemediationResource>> UpdateAsync(WaitUntil waitUntil, PolicyRemediationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _policyRemediationRemediationsClientDiagnostics.CreateScope("PolicyRemediationResource.Update");
            scope.Start();
            try
            {
                var response = await _policyRemediationRemediationsRestClient.CreateOrUpdateAtResourceAsync(Id.Parent, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new PolicyInsightsArmOperation<PolicyRemediationResource>(Response.FromValue(new PolicyRemediationResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates a remediation at resource scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceId}/providers/Microsoft.PolicyInsights/remediations/{remediationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Remediations_CreateOrUpdateAtResource</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PolicyRemediationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The remediation parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<PolicyRemediationResource> Update(WaitUntil waitUntil, PolicyRemediationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _policyRemediationRemediationsClientDiagnostics.CreateScope("PolicyRemediationResource.Update");
            scope.Start();
            try
            {
                var response = _policyRemediationRemediationsRestClient.CreateOrUpdateAtResource(Id.Parent, Id.Name, data, cancellationToken);
                var operation = new PolicyInsightsArmOperation<PolicyRemediationResource>(Response.FromValue(new PolicyRemediationResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all deployments for a remediation at resource scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceId}/providers/Microsoft.PolicyInsights/remediations/{remediationName}/listDeployments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Remediations_ListDeploymentsAtResource</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PolicyRemediationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyQuerySettings"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RemediationDeployment"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RemediationDeployment> GetDeploymentsAsync(PolicyQuerySettings policyQuerySettings = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _policyRemediationRemediationsRestClient.CreateListDeploymentsAtResourceRequest(Id.Parent, Id.Name, policyQuerySettings);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _policyRemediationRemediationsRestClient.CreateListDeploymentsAtResourceNextPageRequest(nextLink, Id.Parent, Id.Name, policyQuerySettings);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => RemediationDeployment.DeserializeRemediationDeployment(e), _policyRemediationRemediationsClientDiagnostics, Pipeline, "PolicyRemediationResource.GetDeployments", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all deployments for a remediation at resource scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceId}/providers/Microsoft.PolicyInsights/remediations/{remediationName}/listDeployments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Remediations_ListDeploymentsAtResource</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PolicyRemediationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyQuerySettings"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RemediationDeployment"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RemediationDeployment> GetDeployments(PolicyQuerySettings policyQuerySettings = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _policyRemediationRemediationsRestClient.CreateListDeploymentsAtResourceRequest(Id.Parent, Id.Name, policyQuerySettings);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _policyRemediationRemediationsRestClient.CreateListDeploymentsAtResourceNextPageRequest(nextLink, Id.Parent, Id.Name, policyQuerySettings);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => RemediationDeployment.DeserializeRemediationDeployment(e), _policyRemediationRemediationsClientDiagnostics, Pipeline, "PolicyRemediationResource.GetDeployments", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Cancel a remediation at resource scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceId}/providers/Microsoft.PolicyInsights/remediations/{remediationName}/cancel</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Remediations_CancelAtResource</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PolicyRemediationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PolicyRemediationResource>> CancelAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _policyRemediationRemediationsClientDiagnostics.CreateScope("PolicyRemediationResource.Cancel");
            scope.Start();
            try
            {
                var response = await _policyRemediationRemediationsRestClient.CancelAtResourceAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new PolicyRemediationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Cancel a remediation at resource scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceId}/providers/Microsoft.PolicyInsights/remediations/{remediationName}/cancel</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Remediations_CancelAtResource</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PolicyRemediationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PolicyRemediationResource> Cancel(CancellationToken cancellationToken = default)
        {
            using var scope = _policyRemediationRemediationsClientDiagnostics.CreateScope("PolicyRemediationResource.Cancel");
            scope.Start();
            try
            {
                var response = _policyRemediationRemediationsRestClient.CancelAtResource(Id.Parent, Id.Name, cancellationToken);
                return Response.FromValue(new PolicyRemediationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
