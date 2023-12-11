// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    /// <summary> The type used for update operations of the TagRule. </summary>
    public partial class NewRelicObservabilityTagRulePatch
    {
        /// <summary> Initializes a new instance of <see cref="NewRelicObservabilityTagRulePatch"/>. </summary>
        public NewRelicObservabilityTagRulePatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NewRelicObservabilityTagRulePatch"/>. </summary>
        /// <param name="logRules"> Set of rules for sending logs for the Monitor resource. </param>
        /// <param name="metricRules"> Set of rules for sending metrics for the Monitor resource. </param>
        internal NewRelicObservabilityTagRulePatch(NewRelicObservabilityLogRules logRules, NewRelicObservabilityMetricRules metricRules)
        {
            LogRules = logRules;
            MetricRules = metricRules;
        }

        /// <summary> Set of rules for sending logs for the Monitor resource. </summary>
        public NewRelicObservabilityLogRules LogRules { get; set; }
        /// <summary> Set of rules for sending metrics for the Monitor resource. </summary>
        public NewRelicObservabilityMetricRules MetricRules { get; set; }
    }
}
