// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> The properties related to a cosmos DB sql container endpoint. </summary>
    public partial class RoutingCosmosDBSqlApiProperties
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RoutingCosmosDBSqlApiProperties"/>. </summary>
        /// <param name="name"> The name that identifies this endpoint. The name can only include alphanumeric characters, periods, underscores, hyphens and has a maximum length of 64 characters. The following names are reserved:  events, fileNotifications, $default. Endpoint names must be unique across endpoint types. </param>
        /// <param name="endpointUri"> The url of the cosmos DB account. It must include the protocol https://. </param>
        /// <param name="databaseName"> The name of the cosmos DB database in the cosmos DB account. </param>
        /// <param name="containerName"> The name of the cosmos DB sql container in the cosmos DB database. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="endpointUri"/>, <paramref name="databaseName"/> or <paramref name="containerName"/> is null. </exception>
        public RoutingCosmosDBSqlApiProperties(string name, Uri endpointUri, string databaseName, string containerName)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(endpointUri, nameof(endpointUri));
            Argument.AssertNotNull(databaseName, nameof(databaseName));
            Argument.AssertNotNull(containerName, nameof(containerName));

            Name = name;
            EndpointUri = endpointUri;
            DatabaseName = databaseName;
            ContainerName = containerName;
        }

        /// <summary> Initializes a new instance of <see cref="RoutingCosmosDBSqlApiProperties"/>. </summary>
        /// <param name="name"> The name that identifies this endpoint. The name can only include alphanumeric characters, periods, underscores, hyphens and has a maximum length of 64 characters. The following names are reserved:  events, fileNotifications, $default. Endpoint names must be unique across endpoint types. </param>
        /// <param name="id"> Id of the cosmos DB sql container endpoint. </param>
        /// <param name="subscriptionId"> The subscription identifier of the cosmos DB account. </param>
        /// <param name="resourceGroup"> The name of the resource group of the cosmos DB account. </param>
        /// <param name="endpointUri"> The url of the cosmos DB account. It must include the protocol https://. </param>
        /// <param name="authenticationType"> Method used to authenticate against the cosmos DB sql container endpoint. </param>
        /// <param name="identity"> Managed identity properties of routing cosmos DB container endpoint. </param>
        /// <param name="primaryKey"> The primary key of the cosmos DB account. </param>
        /// <param name="secondaryKey"> The secondary key of the cosmos DB account. </param>
        /// <param name="databaseName"> The name of the cosmos DB database in the cosmos DB account. </param>
        /// <param name="containerName"> The name of the cosmos DB sql container in the cosmos DB database. </param>
        /// <param name="partitionKeyName"> The name of the partition key associated with this cosmos DB sql container if one exists. This is an optional parameter. </param>
        /// <param name="partitionKeyTemplate"> The template for generating a synthetic partition key value for use with this cosmos DB sql container. The template must include at least one of the following placeholders: {iothub}, {deviceid}, {DD}, {MM}, and {YYYY}. Any one placeholder may be specified at most once, but order and non-placeholder components are arbitrary. This parameter is only required if PartitionKeyName is specified. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RoutingCosmosDBSqlApiProperties(string name, string id, string subscriptionId, string resourceGroup, Uri endpointUri, IotHubAuthenticationType? authenticationType, ManagedIdentity identity, string primaryKey, string secondaryKey, string databaseName, string containerName, string partitionKeyName, string partitionKeyTemplate, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Id = id;
            SubscriptionId = subscriptionId;
            ResourceGroup = resourceGroup;
            EndpointUri = endpointUri;
            AuthenticationType = authenticationType;
            Identity = identity;
            PrimaryKey = primaryKey;
            SecondaryKey = secondaryKey;
            DatabaseName = databaseName;
            ContainerName = containerName;
            PartitionKeyName = partitionKeyName;
            PartitionKeyTemplate = partitionKeyTemplate;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RoutingCosmosDBSqlApiProperties"/> for deserialization. </summary>
        internal RoutingCosmosDBSqlApiProperties()
        {
        }

        /// <summary> The name that identifies this endpoint. The name can only include alphanumeric characters, periods, underscores, hyphens and has a maximum length of 64 characters. The following names are reserved:  events, fileNotifications, $default. Endpoint names must be unique across endpoint types. </summary>
        public string Name { get; set; }
        /// <summary> Id of the cosmos DB sql container endpoint. </summary>
        public string Id { get; }
        /// <summary> The subscription identifier of the cosmos DB account. </summary>
        public string SubscriptionId { get; set; }
        /// <summary> The name of the resource group of the cosmos DB account. </summary>
        public string ResourceGroup { get; set; }
        /// <summary> The url of the cosmos DB account. It must include the protocol https://. </summary>
        public Uri EndpointUri { get; set; }
        /// <summary> Method used to authenticate against the cosmos DB sql container endpoint. </summary>
        public IotHubAuthenticationType? AuthenticationType { get; set; }
        /// <summary> Managed identity properties of routing cosmos DB container endpoint. </summary>
        internal ManagedIdentity Identity { get; set; }
        /// <summary> The user assigned identity. </summary>
        public ResourceIdentifier UserAssignedIdentity
        {
            get => Identity is null ? default : Identity.UserAssignedIdentity;
            set
            {
                if (Identity is null)
                    Identity = new ManagedIdentity();
                Identity.UserAssignedIdentity = value;
            }
        }

        /// <summary> The primary key of the cosmos DB account. </summary>
        public string PrimaryKey { get; set; }
        /// <summary> The secondary key of the cosmos DB account. </summary>
        public string SecondaryKey { get; set; }
        /// <summary> The name of the cosmos DB database in the cosmos DB account. </summary>
        public string DatabaseName { get; set; }
        /// <summary> The name of the cosmos DB sql container in the cosmos DB database. </summary>
        public string ContainerName { get; set; }
        /// <summary> The name of the partition key associated with this cosmos DB sql container if one exists. This is an optional parameter. </summary>
        public string PartitionKeyName { get; set; }
        /// <summary> The template for generating a synthetic partition key value for use with this cosmos DB sql container. The template must include at least one of the following placeholders: {iothub}, {deviceid}, {DD}, {MM}, and {YYYY}. Any one placeholder may be specified at most once, but order and non-placeholder components are arbitrary. This parameter is only required if PartitionKeyName is specified. </summary>
        public string PartitionKeyTemplate { get; set; }
    }
}
