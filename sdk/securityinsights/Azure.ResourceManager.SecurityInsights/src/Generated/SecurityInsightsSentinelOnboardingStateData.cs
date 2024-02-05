// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityInsights
{
    /// <summary>
    /// A class representing the SecurityInsightsSentinelOnboardingState data model.
    /// Sentinel onboarding state
    /// </summary>
    public partial class SecurityInsightsSentinelOnboardingStateData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsSentinelOnboardingStateData"/>. </summary>
        public SecurityInsightsSentinelOnboardingStateData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsSentinelOnboardingStateData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="isCustomerManagedKeySet"> Flag that indicates the status of the CMK setting. </param>
        /// <param name="etag"> Etag of the azure resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SecurityInsightsSentinelOnboardingStateData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, bool? isCustomerManagedKeySet, ETag? etag, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            IsCustomerManagedKeySet = isCustomerManagedKeySet;
            ETag = etag;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Flag that indicates the status of the CMK setting. </summary>
        public bool? IsCustomerManagedKeySet { get; set; }
        /// <summary> Etag of the azure resource. </summary>
        public ETag? ETag { get; set; }
    }
}
