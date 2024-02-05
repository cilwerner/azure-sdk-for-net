// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataLakeAnalytics.Models
{
    /// <summary>
    /// Data Lake Analytics account name availability check parameters.
    /// Serialized Name: CheckNameAvailabilityParameters
    /// </summary>
    public partial class DataLakeAnalyticsAccountNameAvailabilityContent
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

        /// <summary> Initializes a new instance of <see cref="DataLakeAnalyticsAccountNameAvailabilityContent"/>. </summary>
        /// <param name="name">
        /// The Data Lake Analytics name to check availability for.
        /// Serialized Name: CheckNameAvailabilityParameters.name
        /// </param>
        /// <param name="resourceType">
        /// The resource type. Note: This should not be set by the user, as the constant value is Microsoft.DataLakeAnalytics/accounts
        /// Serialized Name: CheckNameAvailabilityParameters.type
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public DataLakeAnalyticsAccountNameAvailabilityContent(string name, DataLakeAnalyticsResourceType resourceType)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
            ResourceType = resourceType;
        }

        /// <summary> Initializes a new instance of <see cref="DataLakeAnalyticsAccountNameAvailabilityContent"/>. </summary>
        /// <param name="name">
        /// The Data Lake Analytics name to check availability for.
        /// Serialized Name: CheckNameAvailabilityParameters.name
        /// </param>
        /// <param name="resourceType">
        /// The resource type. Note: This should not be set by the user, as the constant value is Microsoft.DataLakeAnalytics/accounts
        /// Serialized Name: CheckNameAvailabilityParameters.type
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataLakeAnalyticsAccountNameAvailabilityContent(string name, DataLakeAnalyticsResourceType resourceType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            ResourceType = resourceType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DataLakeAnalyticsAccountNameAvailabilityContent"/> for deserialization. </summary>
        internal DataLakeAnalyticsAccountNameAvailabilityContent()
        {
        }

        /// <summary>
        /// The Data Lake Analytics name to check availability for.
        /// Serialized Name: CheckNameAvailabilityParameters.name
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// The resource type. Note: This should not be set by the user, as the constant value is Microsoft.DataLakeAnalytics/accounts
        /// Serialized Name: CheckNameAvailabilityParameters.type
        /// </summary>
        public DataLakeAnalyticsResourceType ResourceType { get; }
    }
}
