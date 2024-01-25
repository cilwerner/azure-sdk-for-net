// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.DataShare.Models
{
    /// <summary> details of synchronization. </summary>
    internal partial class SynchronizationDetailsList
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

        /// <summary> Initializes a new instance of <see cref="SynchronizationDetailsList"/>. </summary>
        /// <param name="value"> Collection of items of type DataTransferObjects. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal SynchronizationDetailsList(IEnumerable<SynchronizationDetails> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="SynchronizationDetailsList"/>. </summary>
        /// <param name="nextLink"> The Url of next result page. </param>
        /// <param name="value"> Collection of items of type DataTransferObjects. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SynchronizationDetailsList(string nextLink, IReadOnlyList<SynchronizationDetails> value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NextLink = nextLink;
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SynchronizationDetailsList"/> for deserialization. </summary>
        internal SynchronizationDetailsList()
        {
        }

        /// <summary> The Url of next result page. </summary>
        public string NextLink { get; }
        /// <summary> Collection of items of type DataTransferObjects. </summary>
        public IReadOnlyList<SynchronizationDetails> Value { get; }
    }
}
