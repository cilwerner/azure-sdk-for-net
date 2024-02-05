// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Application logs to Azure table storage configuration. </summary>
    public partial class AppServiceTableStorageApplicationLogsConfig
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

        /// <summary> Initializes a new instance of <see cref="AppServiceTableStorageApplicationLogsConfig"/>. </summary>
        /// <param name="sasUriString"> SAS URL to an Azure table with add/query/delete permissions. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sasUriString"/> is null. </exception>
        public AppServiceTableStorageApplicationLogsConfig(string sasUriString)
        {
            Argument.AssertNotNull(sasUriString, nameof(sasUriString));

            SasUriString = sasUriString;
        }

        /// <summary> Initializes a new instance of <see cref="AppServiceTableStorageApplicationLogsConfig"/>. </summary>
        /// <param name="level"> Log level. </param>
        /// <param name="sasUriString"> SAS URL to an Azure table with add/query/delete permissions. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AppServiceTableStorageApplicationLogsConfig(WebAppLogLevel? level, string sasUriString, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Level = level;
            SasUriString = sasUriString;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AppServiceTableStorageApplicationLogsConfig"/> for deserialization. </summary>
        internal AppServiceTableStorageApplicationLogsConfig()
        {
        }

        /// <summary> Log level. </summary>
        public WebAppLogLevel? Level { get; set; }
        /// <summary> SAS URL to an Azure table with add/query/delete permissions. </summary>
        public string SasUriString { get; set; }
    }
}
