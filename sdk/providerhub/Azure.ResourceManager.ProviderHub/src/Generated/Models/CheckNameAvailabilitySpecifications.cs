// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The CheckNameAvailabilitySpecifications. </summary>
    public partial class CheckNameAvailabilitySpecifications
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

        /// <summary> Initializes a new instance of <see cref="CheckNameAvailabilitySpecifications"/>. </summary>
        public CheckNameAvailabilitySpecifications()
        {
            ResourceTypesWithCustomValidation = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="CheckNameAvailabilitySpecifications"/>. </summary>
        /// <param name="isDefaultValidationEnabled"></param>
        /// <param name="resourceTypesWithCustomValidation"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CheckNameAvailabilitySpecifications(bool? isDefaultValidationEnabled, IList<string> resourceTypesWithCustomValidation, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsDefaultValidationEnabled = isDefaultValidationEnabled;
            ResourceTypesWithCustomValidation = resourceTypesWithCustomValidation;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the is default validation enabled. </summary>
        public bool? IsDefaultValidationEnabled { get; set; }
        /// <summary> Gets the resource types with custom validation. </summary>
        public IList<string> ResourceTypesWithCustomValidation { get; }
    }
}
