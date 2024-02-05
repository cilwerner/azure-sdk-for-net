// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DataShare;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataShare.Models
{
    /// <summary> A Blob container data set mapping. </summary>
    public partial class BlobContainerDataSetMapping : ShareDataSetMappingData
    {
        /// <summary> Initializes a new instance of <see cref="BlobContainerDataSetMapping"/>. </summary>
        /// <param name="containerName"> BLOB Container name. </param>
        /// <param name="dataSetId"> The id of the source data set. </param>
        /// <param name="resourceGroup"> Resource group of storage account. </param>
        /// <param name="storageAccountName"> Storage account name of the source data set. </param>
        /// <param name="subscriptionId"> Subscription id of storage account. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/>, <paramref name="resourceGroup"/>, <paramref name="storageAccountName"/> or <paramref name="subscriptionId"/> is null. </exception>
        public BlobContainerDataSetMapping(string containerName, Guid dataSetId, string resourceGroup, string storageAccountName, string subscriptionId)
        {
            Argument.AssertNotNull(containerName, nameof(containerName));
            Argument.AssertNotNull(resourceGroup, nameof(resourceGroup));
            Argument.AssertNotNull(storageAccountName, nameof(storageAccountName));
            Argument.AssertNotNull(subscriptionId, nameof(subscriptionId));

            ContainerName = containerName;
            DataSetId = dataSetId;
            ResourceGroup = resourceGroup;
            StorageAccountName = storageAccountName;
            SubscriptionId = subscriptionId;
            Kind = DataSetMappingKind.Container;
        }

        /// <summary> Initializes a new instance of <see cref="BlobContainerDataSetMapping"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of data set mapping. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="containerName"> BLOB Container name. </param>
        /// <param name="dataSetId"> The id of the source data set. </param>
        /// <param name="dataSetMappingStatus"> Gets the status of the data set mapping. </param>
        /// <param name="provisioningState"> Provisioning state of the data set mapping. </param>
        /// <param name="resourceGroup"> Resource group of storage account. </param>
        /// <param name="storageAccountName"> Storage account name of the source data set. </param>
        /// <param name="subscriptionId"> Subscription id of storage account. </param>
        internal BlobContainerDataSetMapping(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DataSetMappingKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData, string containerName, Guid dataSetId, DataSetMappingStatus? dataSetMappingStatus, DataShareProvisioningState? provisioningState, string resourceGroup, string storageAccountName, string subscriptionId) : base(id, name, resourceType, systemData, kind, serializedAdditionalRawData)
        {
            ContainerName = containerName;
            DataSetId = dataSetId;
            DataSetMappingStatus = dataSetMappingStatus;
            ProvisioningState = provisioningState;
            ResourceGroup = resourceGroup;
            StorageAccountName = storageAccountName;
            SubscriptionId = subscriptionId;
            Kind = kind;
        }

        /// <summary> Initializes a new instance of <see cref="BlobContainerDataSetMapping"/> for deserialization. </summary>
        internal BlobContainerDataSetMapping()
        {
        }

        /// <summary> BLOB Container name. </summary>
        public string ContainerName { get; set; }
        /// <summary> The id of the source data set. </summary>
        public Guid DataSetId { get; set; }
        /// <summary> Gets the status of the data set mapping. </summary>
        public DataSetMappingStatus? DataSetMappingStatus { get; }
        /// <summary> Provisioning state of the data set mapping. </summary>
        public DataShareProvisioningState? ProvisioningState { get; }
        /// <summary> Resource group of storage account. </summary>
        public string ResourceGroup { get; set; }
        /// <summary> Storage account name of the source data set. </summary>
        public string StorageAccountName { get; set; }
        /// <summary> Subscription id of storage account. </summary>
        public string SubscriptionId { get; set; }
    }
}
