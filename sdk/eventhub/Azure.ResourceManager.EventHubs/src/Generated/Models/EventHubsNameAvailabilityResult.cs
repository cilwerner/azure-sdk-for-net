// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> The Result of the CheckNameAvailability operation. </summary>
    public partial class EventHubsNameAvailabilityResult
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

        /// <summary> Initializes a new instance of <see cref="EventHubsNameAvailabilityResult"/>. </summary>
        internal EventHubsNameAvailabilityResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="EventHubsNameAvailabilityResult"/>. </summary>
        /// <param name="message"> The detailed info regarding the reason associated with the Namespace. </param>
        /// <param name="nameAvailable"> Value indicating Namespace is availability, true if the Namespace is available; otherwise, false. </param>
        /// <param name="reason"> The reason for unavailability of a Namespace. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EventHubsNameAvailabilityResult(string message, bool? nameAvailable, EventHubsNameUnavailableReason? reason, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Message = message;
            NameAvailable = nameAvailable;
            Reason = reason;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The detailed info regarding the reason associated with the Namespace. </summary>
        public string Message { get; }
        /// <summary> Value indicating Namespace is availability, true if the Namespace is available; otherwise, false. </summary>
        public bool? NameAvailable { get; }
        /// <summary> The reason for unavailability of a Namespace. </summary>
        public EventHubsNameUnavailableReason? Reason { get; }
    }
}
