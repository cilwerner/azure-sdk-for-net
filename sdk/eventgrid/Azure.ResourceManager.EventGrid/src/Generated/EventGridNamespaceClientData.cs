// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.EventGrid.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EventGrid
{
    /// <summary>
    /// A class representing the EventGridNamespaceClient data model.
    /// The Client resource.
    /// </summary>
    public partial class EventGridNamespaceClientData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="EventGridNamespaceClientData"/>. </summary>
        public EventGridNamespaceClientData()
        {
            Attributes = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of <see cref="EventGridNamespaceClientData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="description"> Description for the Client resource. </param>
        /// <param name="authenticationName"> The name presented by the client for authentication. The default value is the name of the resource. </param>
        /// <param name="clientCertificateAuthentication"> The client certificate authentication information. </param>
        /// <param name="state"> Indicates if the client is enabled or not. Default value is Enabled. </param>
        /// <param name="attributes">
        /// Attributes for the client. Supported values are int, bool, string, string[].
        /// Example:
        /// "attributes": { "room": "345", "floor": 12, "deviceTypes": ["Fan", "Light"] }
        /// </param>
        /// <param name="provisioningState"> Provisioning state of the Client resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EventGridNamespaceClientData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string description, string authenticationName, ClientCertificateAuthentication clientCertificateAuthentication, EventGridNamespaceClientState? state, IDictionary<string, BinaryData> attributes, EventGridNamespaceClientProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Description = description;
            AuthenticationName = authenticationName;
            ClientCertificateAuthentication = clientCertificateAuthentication;
            State = state;
            Attributes = attributes;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Description for the Client resource. </summary>
        public string Description { get; set; }
        /// <summary> The name presented by the client for authentication. The default value is the name of the resource. </summary>
        public string AuthenticationName { get; set; }
        /// <summary> The client certificate authentication information. </summary>
        public ClientCertificateAuthentication ClientCertificateAuthentication { get; set; }
        /// <summary> Indicates if the client is enabled or not. Default value is Enabled. </summary>
        public EventGridNamespaceClientState? State { get; set; }
        /// <summary>
        /// Attributes for the client. Supported values are int, bool, string, string[].
        /// Example:
        /// "attributes": { "room": "345", "floor": 12, "deviceTypes": ["Fan", "Light"] }
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
        public IDictionary<string, BinaryData> Attributes { get; }
        /// <summary> Provisioning state of the Client resource. </summary>
        public EventGridNamespaceClientProvisioningState? ProvisioningState { get; }
    }
}
