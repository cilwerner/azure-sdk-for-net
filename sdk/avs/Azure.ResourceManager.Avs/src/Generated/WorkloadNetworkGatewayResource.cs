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

namespace Azure.ResourceManager.Avs
{
    /// <summary>
    /// A Class representing a WorkloadNetworkGateway along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="WorkloadNetworkGatewayResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetWorkloadNetworkGatewayResource method.
    /// Otherwise you can get one from its parent resource <see cref="AvsPrivateCloudResource"/> using the GetWorkloadNetworkGateway method.
    /// </summary>
    public partial class WorkloadNetworkGatewayResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="WorkloadNetworkGatewayResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="privateCloudName"> The privateCloudName. </param>
        /// <param name="gatewayId"> The gatewayId. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string privateCloudName, string gatewayId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/gateways/{gatewayId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _workloadNetworkGatewayWorkloadNetworksClientDiagnostics;
        private readonly WorkloadNetworksRestOperations _workloadNetworkGatewayWorkloadNetworksRestClient;
        private readonly WorkloadNetworkGatewayData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.AVS/privateClouds/workloadNetworks/gateways";

        /// <summary> Initializes a new instance of the <see cref="WorkloadNetworkGatewayResource"/> class for mocking. </summary>
        protected WorkloadNetworkGatewayResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="WorkloadNetworkGatewayResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal WorkloadNetworkGatewayResource(ArmClient client, WorkloadNetworkGatewayData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="WorkloadNetworkGatewayResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal WorkloadNetworkGatewayResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _workloadNetworkGatewayWorkloadNetworksClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Avs", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string workloadNetworkGatewayWorkloadNetworksApiVersion);
            _workloadNetworkGatewayWorkloadNetworksRestClient = new WorkloadNetworksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, workloadNetworkGatewayWorkloadNetworksApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual WorkloadNetworkGatewayData Data
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
        /// Get a gateway by id in a private cloud workload network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/gateways/{gatewayId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_GetGateway</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<WorkloadNetworkGatewayResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _workloadNetworkGatewayWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkGatewayResource.Get");
            scope.Start();
            try
            {
                var response = await _workloadNetworkGatewayWorkloadNetworksRestClient.GetGatewayAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WorkloadNetworkGatewayResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a gateway by id in a private cloud workload network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/workloadNetworks/default/gateways/{gatewayId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadNetworks_GetGateway</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<WorkloadNetworkGatewayResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _workloadNetworkGatewayWorkloadNetworksClientDiagnostics.CreateScope("WorkloadNetworkGatewayResource.Get");
            scope.Start();
            try
            {
                var response = _workloadNetworkGatewayWorkloadNetworksRestClient.GetGateway(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WorkloadNetworkGatewayResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
