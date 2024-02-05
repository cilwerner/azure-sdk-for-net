// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The Microsoft Defender container agentless discovery K8s configuration. </summary>
    public partial class DefenderCspmAwsOfferingMdcContainersAgentlessDiscoveryK8S
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

        /// <summary> Initializes a new instance of <see cref="DefenderCspmAwsOfferingMdcContainersAgentlessDiscoveryK8S"/>. </summary>
        public DefenderCspmAwsOfferingMdcContainersAgentlessDiscoveryK8S()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DefenderCspmAwsOfferingMdcContainersAgentlessDiscoveryK8S"/>. </summary>
        /// <param name="isEnabled"> Is Microsoft Defender container agentless discovery K8s enabled. </param>
        /// <param name="cloudRoleArn"> The cloud role ARN in AWS for this feature. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DefenderCspmAwsOfferingMdcContainersAgentlessDiscoveryK8S(bool? isEnabled, string cloudRoleArn, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsEnabled = isEnabled;
            CloudRoleArn = cloudRoleArn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Is Microsoft Defender container agentless discovery K8s enabled. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary> The cloud role ARN in AWS for this feature. </summary>
        public string CloudRoleArn { get; set; }
    }
}
