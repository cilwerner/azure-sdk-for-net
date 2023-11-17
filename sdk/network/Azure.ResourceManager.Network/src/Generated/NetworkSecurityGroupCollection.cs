// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="NetworkSecurityGroupResource" /> and their operations.
    /// Each <see cref="NetworkSecurityGroupResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="NetworkSecurityGroupCollection" /> instance call the GetNetworkSecurityGroups method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class NetworkSecurityGroupCollection : ArmCollection, IEnumerable<NetworkSecurityGroupResource>, IAsyncEnumerable<NetworkSecurityGroupResource>
    {
        private readonly ClientDiagnostics _networkSecurityGroupClientDiagnostics;
        private readonly NetworkSecurityGroupsRestOperations _networkSecurityGroupRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkSecurityGroupCollection"/> class for mocking. </summary>
        protected NetworkSecurityGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkSecurityGroupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkSecurityGroupCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkSecurityGroupClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", NetworkSecurityGroupResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetworkSecurityGroupResource.ResourceType, out string networkSecurityGroupApiVersion);
            _networkSecurityGroupRestClient = new NetworkSecurityGroupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkSecurityGroupApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a network security group in the specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityGroups/{networkSecurityGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityGroups_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="networkSecurityGroupName"> The name of the network security group. </param>
        /// <param name="data"> Parameters supplied to the create or update network security group operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkSecurityGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkSecurityGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NetworkSecurityGroupResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string networkSecurityGroupName, NetworkSecurityGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkSecurityGroupName, nameof(networkSecurityGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkSecurityGroupClientDiagnostics.CreateScope("NetworkSecurityGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _networkSecurityGroupRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, networkSecurityGroupName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<NetworkSecurityGroupResource>(new NetworkSecurityGroupOperationSource(Client), _networkSecurityGroupClientDiagnostics, Pipeline, _networkSecurityGroupRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, networkSecurityGroupName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates a network security group in the specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityGroups/{networkSecurityGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityGroups_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="networkSecurityGroupName"> The name of the network security group. </param>
        /// <param name="data"> Parameters supplied to the create or update network security group operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkSecurityGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkSecurityGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NetworkSecurityGroupResource> CreateOrUpdate(WaitUntil waitUntil, string networkSecurityGroupName, NetworkSecurityGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkSecurityGroupName, nameof(networkSecurityGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkSecurityGroupClientDiagnostics.CreateScope("NetworkSecurityGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _networkSecurityGroupRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, networkSecurityGroupName, data, cancellationToken);
                var operation = new NetworkArmOperation<NetworkSecurityGroupResource>(new NetworkSecurityGroupOperationSource(Client), _networkSecurityGroupClientDiagnostics, Pipeline, _networkSecurityGroupRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, networkSecurityGroupName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets the specified network security group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityGroups/{networkSecurityGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkSecurityGroupName"> The name of the network security group. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkSecurityGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkSecurityGroupName"/> is null. </exception>
        public virtual async Task<Response<NetworkSecurityGroupResource>> GetAsync(string networkSecurityGroupName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkSecurityGroupName, nameof(networkSecurityGroupName));

            using var scope = _networkSecurityGroupClientDiagnostics.CreateScope("NetworkSecurityGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkSecurityGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, networkSecurityGroupName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkSecurityGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified network security group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityGroups/{networkSecurityGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkSecurityGroupName"> The name of the network security group. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkSecurityGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkSecurityGroupName"/> is null. </exception>
        public virtual Response<NetworkSecurityGroupResource> Get(string networkSecurityGroupName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkSecurityGroupName, nameof(networkSecurityGroupName));

            using var scope = _networkSecurityGroupClientDiagnostics.CreateScope("NetworkSecurityGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _networkSecurityGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, networkSecurityGroupName, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkSecurityGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all network security groups in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityGroups_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkSecurityGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkSecurityGroupResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkSecurityGroupRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkSecurityGroupRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NetworkSecurityGroupResource(Client, NetworkSecurityGroupData.DeserializeNetworkSecurityGroupData(e)), _networkSecurityGroupClientDiagnostics, Pipeline, "NetworkSecurityGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all network security groups in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityGroups_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkSecurityGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkSecurityGroupResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkSecurityGroupRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkSecurityGroupRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NetworkSecurityGroupResource(Client, NetworkSecurityGroupData.DeserializeNetworkSecurityGroupData(e)), _networkSecurityGroupClientDiagnostics, Pipeline, "NetworkSecurityGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityGroups/{networkSecurityGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkSecurityGroupName"> The name of the network security group. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkSecurityGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkSecurityGroupName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string networkSecurityGroupName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkSecurityGroupName, nameof(networkSecurityGroupName));

            using var scope = _networkSecurityGroupClientDiagnostics.CreateScope("NetworkSecurityGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await _networkSecurityGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, networkSecurityGroupName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityGroups/{networkSecurityGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkSecurityGroupName"> The name of the network security group. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkSecurityGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkSecurityGroupName"/> is null. </exception>
        public virtual Response<bool> Exists(string networkSecurityGroupName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkSecurityGroupName, nameof(networkSecurityGroupName));

            using var scope = _networkSecurityGroupClientDiagnostics.CreateScope("NetworkSecurityGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = _networkSecurityGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, networkSecurityGroupName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityGroups/{networkSecurityGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkSecurityGroupName"> The name of the network security group. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkSecurityGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkSecurityGroupName"/> is null. </exception>
        public virtual async Task<NullableResponse<NetworkSecurityGroupResource>> GetIfExistsAsync(string networkSecurityGroupName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkSecurityGroupName, nameof(networkSecurityGroupName));

            using var scope = _networkSecurityGroupClientDiagnostics.CreateScope("NetworkSecurityGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _networkSecurityGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, networkSecurityGroupName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<NetworkSecurityGroupResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkSecurityGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkSecurityGroups/{networkSecurityGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkSecurityGroupName"> The name of the network security group. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkSecurityGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkSecurityGroupName"/> is null. </exception>
        public virtual NullableResponse<NetworkSecurityGroupResource> GetIfExists(string networkSecurityGroupName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkSecurityGroupName, nameof(networkSecurityGroupName));

            using var scope = _networkSecurityGroupClientDiagnostics.CreateScope("NetworkSecurityGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _networkSecurityGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, networkSecurityGroupName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<NetworkSecurityGroupResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkSecurityGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkSecurityGroupResource> IEnumerable<NetworkSecurityGroupResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkSecurityGroupResource> IAsyncEnumerable<NetworkSecurityGroupResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
