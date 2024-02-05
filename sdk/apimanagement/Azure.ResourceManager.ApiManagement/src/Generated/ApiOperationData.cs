// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ApiManagement.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing the ApiOperation data model.
    /// API Operation details.
    /// </summary>
    public partial class ApiOperationData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="ApiOperationData"/>. </summary>
        public ApiOperationData()
        {
            TemplateParameters = new ChangeTrackingList<ParameterContract>();
            Responses = new ChangeTrackingList<ResponseContract>();
        }

        /// <summary> Initializes a new instance of <see cref="ApiOperationData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="templateParameters"> Collection of URL template parameters. </param>
        /// <param name="description"> Description of the operation. May include HTML formatting tags. </param>
        /// <param name="request"> An entity containing request details. </param>
        /// <param name="responses"> Array of Operation responses. </param>
        /// <param name="policies"> Operation Policies. </param>
        /// <param name="displayName"> Operation Name. </param>
        /// <param name="method"> A Valid HTTP Operation Method. Typical Http Methods like GET, PUT, POST but not limited by only them. </param>
        /// <param name="uriTemplate"> Relative URL template identifying the target resource for this operation. May include parameters. Example: /customers/{cid}/orders/{oid}/?date={date}. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApiOperationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IList<ParameterContract> templateParameters, string description, RequestContract request, IList<ResponseContract> responses, string policies, string displayName, string method, string uriTemplate, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            TemplateParameters = templateParameters;
            Description = description;
            Request = request;
            Responses = responses;
            Policies = policies;
            DisplayName = displayName;
            Method = method;
            UriTemplate = uriTemplate;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Collection of URL template parameters. </summary>
        public IList<ParameterContract> TemplateParameters { get; }
        /// <summary> Description of the operation. May include HTML formatting tags. </summary>
        public string Description { get; set; }
        /// <summary> An entity containing request details. </summary>
        public RequestContract Request { get; set; }
        /// <summary> Array of Operation responses. </summary>
        public IList<ResponseContract> Responses { get; }
        /// <summary> Operation Policies. </summary>
        public string Policies { get; set; }
        /// <summary> Operation Name. </summary>
        public string DisplayName { get; set; }
        /// <summary> A Valid HTTP Operation Method. Typical Http Methods like GET, PUT, POST but not limited by only them. </summary>
        public string Method { get; set; }
        /// <summary> Relative URL template identifying the target resource for this operation. May include parameters. Example: /customers/{cid}/orders/{oid}/?date={date}. </summary>
        public string UriTemplate { get; set; }
    }
}
