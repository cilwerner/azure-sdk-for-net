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
using Azure.ResourceManager.DataLakeAnalytics.Models;

namespace Azure.ResourceManager.DataLakeAnalytics
{
    /// <summary>
    /// A Class representing a DataLakeAnalyticsStorageContainer along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="DataLakeAnalyticsStorageContainerResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetDataLakeAnalyticsStorageContainerResource method.
    /// Otherwise you can get one from its parent resource <see cref="DataLakeAnalyticsStorageAccountInformationResource" /> using the GetDataLakeAnalyticsStorageContainer method.
    /// </summary>
    public partial class DataLakeAnalyticsStorageContainerResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DataLakeAnalyticsStorageContainerResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="accountName"> The accountName. </param>
        /// <param name="storageAccountName"> The storageAccountName. </param>
        /// <param name="containerName"> The containerName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string accountName, string storageAccountName, string containerName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/storageAccounts/{storageAccountName}/containers/{containerName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _dataLakeAnalyticsStorageContainerStorageAccountsClientDiagnostics;
        private readonly StorageAccountsRestOperations _dataLakeAnalyticsStorageContainerStorageAccountsRestClient;
        private readonly DataLakeAnalyticsStorageContainerData _data;

        /// <summary> Initializes a new instance of the <see cref="DataLakeAnalyticsStorageContainerResource"/> class for mocking. </summary>
        protected DataLakeAnalyticsStorageContainerResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "DataLakeAnalyticsStorageContainerResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DataLakeAnalyticsStorageContainerResource(ArmClient client, DataLakeAnalyticsStorageContainerData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DataLakeAnalyticsStorageContainerResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DataLakeAnalyticsStorageContainerResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataLakeAnalyticsStorageContainerStorageAccountsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataLakeAnalytics", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string dataLakeAnalyticsStorageContainerStorageAccountsApiVersion);
            _dataLakeAnalyticsStorageContainerStorageAccountsRestClient = new StorageAccountsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataLakeAnalyticsStorageContainerStorageAccountsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DataLakeAnalytics/accounts/storageAccounts/containers";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DataLakeAnalyticsStorageContainerData Data
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
        /// Gets the specified Azure Storage container associated with the given Data Lake Analytics and Azure Storage accounts.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/storageAccounts/{storageAccountName}/containers/{containerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageAccounts_GetStorageContainer</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DataLakeAnalyticsStorageContainerResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _dataLakeAnalyticsStorageContainerStorageAccountsClientDiagnostics.CreateScope("DataLakeAnalyticsStorageContainerResource.Get");
            scope.Start();
            try
            {
                var response = await _dataLakeAnalyticsStorageContainerStorageAccountsRestClient.GetStorageContainerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataLakeAnalyticsStorageContainerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified Azure Storage container associated with the given Data Lake Analytics and Azure Storage accounts.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/storageAccounts/{storageAccountName}/containers/{containerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageAccounts_GetStorageContainer</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DataLakeAnalyticsStorageContainerResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _dataLakeAnalyticsStorageContainerStorageAccountsClientDiagnostics.CreateScope("DataLakeAnalyticsStorageContainerResource.Get");
            scope.Start();
            try
            {
                var response = _dataLakeAnalyticsStorageContainerStorageAccountsRestClient.GetStorageContainer(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataLakeAnalyticsStorageContainerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the SAS token associated with the specified Data Lake Analytics and Azure Storage account and container combination.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/storageAccounts/{storageAccountName}/containers/{containerName}/listSasTokens</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageAccounts_ListSasTokens</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataLakeAnalyticsSasTokenInformation" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataLakeAnalyticsSasTokenInformation> GetSasTokensAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataLakeAnalyticsStorageContainerStorageAccountsRestClient.CreateListSasTokensRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataLakeAnalyticsStorageContainerStorageAccountsRestClient.CreateListSasTokensNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, DataLakeAnalyticsSasTokenInformation.DeserializeDataLakeAnalyticsSasTokenInformation, _dataLakeAnalyticsStorageContainerStorageAccountsClientDiagnostics, Pipeline, "DataLakeAnalyticsStorageContainerResource.GetSasTokens", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the SAS token associated with the specified Data Lake Analytics and Azure Storage account and container combination.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/storageAccounts/{storageAccountName}/containers/{containerName}/listSasTokens</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageAccounts_ListSasTokens</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataLakeAnalyticsSasTokenInformation" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataLakeAnalyticsSasTokenInformation> GetSasTokens(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataLakeAnalyticsStorageContainerStorageAccountsRestClient.CreateListSasTokensRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataLakeAnalyticsStorageContainerStorageAccountsRestClient.CreateListSasTokensNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, DataLakeAnalyticsSasTokenInformation.DeserializeDataLakeAnalyticsSasTokenInformation, _dataLakeAnalyticsStorageContainerStorageAccountsClientDiagnostics, Pipeline, "DataLakeAnalyticsStorageContainerResource.GetSasTokens", "value", "nextLink", cancellationToken);
        }
    }
}
