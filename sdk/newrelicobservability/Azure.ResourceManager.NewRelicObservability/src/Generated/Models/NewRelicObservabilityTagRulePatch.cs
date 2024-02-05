// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    /// <summary> The type used for update operations of the TagRule. </summary>
    public partial class NewRelicObservabilityTagRulePatch
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

        /// <summary> Initializes a new instance of <see cref="NewRelicObservabilityTagRulePatch"/>. </summary>
        public NewRelicObservabilityTagRulePatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NewRelicObservabilityTagRulePatch"/>. </summary>
        /// <param name="logRules"> Set of rules for sending logs for the Monitor resource. </param>
        /// <param name="metricRules"> Set of rules for sending metrics for the Monitor resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NewRelicObservabilityTagRulePatch(NewRelicObservabilityLogRules logRules, NewRelicObservabilityMetricRules metricRules, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            LogRules = logRules;
            MetricRules = metricRules;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Set of rules for sending logs for the Monitor resource. </summary>
        public NewRelicObservabilityLogRules LogRules { get; set; }
        /// <summary> Set of rules for sending metrics for the Monitor resource. </summary>
        public NewRelicObservabilityMetricRules MetricRules { get; set; }
    }
}
