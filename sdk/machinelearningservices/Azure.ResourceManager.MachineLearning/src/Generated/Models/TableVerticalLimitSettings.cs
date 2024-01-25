// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Job execution constraints. </summary>
    public partial class TableVerticalLimitSettings
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

        /// <summary> Initializes a new instance of <see cref="TableVerticalLimitSettings"/>. </summary>
        public TableVerticalLimitSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TableVerticalLimitSettings"/>. </summary>
        /// <param name="enableEarlyTermination"> Enable early termination, determines whether or not if AutoMLJob will terminate early if there is no score improvement in last 20 iterations. </param>
        /// <param name="exitScore"> Exit score for the AutoML job. </param>
        /// <param name="maxConcurrentTrials"> Maximum Concurrent iterations. </param>
        /// <param name="maxCoresPerTrial"> Max cores per iteration. </param>
        /// <param name="maxNodes"> Maximum nodes to use for the experiment. </param>
        /// <param name="maxTrials"> Number of iterations. </param>
        /// <param name="sweepConcurrentTrials"> Number of concurrent sweeping runs that user wants to trigger. </param>
        /// <param name="sweepTrials"> Number of sweeping runs that user wants to trigger. </param>
        /// <param name="timeout"> AutoML job timeout. </param>
        /// <param name="trialTimeout"> Iteration timeout. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TableVerticalLimitSettings(bool? enableEarlyTermination, double? exitScore, int? maxConcurrentTrials, int? maxCoresPerTrial, int? maxNodes, int? maxTrials, int? sweepConcurrentTrials, int? sweepTrials, TimeSpan? timeout, TimeSpan? trialTimeout, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            EnableEarlyTermination = enableEarlyTermination;
            ExitScore = exitScore;
            MaxConcurrentTrials = maxConcurrentTrials;
            MaxCoresPerTrial = maxCoresPerTrial;
            MaxNodes = maxNodes;
            MaxTrials = maxTrials;
            SweepConcurrentTrials = sweepConcurrentTrials;
            SweepTrials = sweepTrials;
            Timeout = timeout;
            TrialTimeout = trialTimeout;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Enable early termination, determines whether or not if AutoMLJob will terminate early if there is no score improvement in last 20 iterations. </summary>
        public bool? EnableEarlyTermination { get; set; }
        /// <summary> Exit score for the AutoML job. </summary>
        public double? ExitScore { get; set; }
        /// <summary> Maximum Concurrent iterations. </summary>
        public int? MaxConcurrentTrials { get; set; }
        /// <summary> Max cores per iteration. </summary>
        public int? MaxCoresPerTrial { get; set; }
        /// <summary> Maximum nodes to use for the experiment. </summary>
        public int? MaxNodes { get; set; }
        /// <summary> Number of iterations. </summary>
        public int? MaxTrials { get; set; }
        /// <summary> Number of concurrent sweeping runs that user wants to trigger. </summary>
        public int? SweepConcurrentTrials { get; set; }
        /// <summary> Number of sweeping runs that user wants to trigger. </summary>
        public int? SweepTrials { get; set; }
        /// <summary> AutoML job timeout. </summary>
        public TimeSpan? Timeout { get; set; }
        /// <summary> Iteration timeout. </summary>
        public TimeSpan? TrialTimeout { get; set; }
    }
}
