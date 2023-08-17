// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> This is the Autoscale profile for the cluster. This will allow customer to create cluster enabled with Autoscale. </summary>
    public partial class AutoscaleProfile
    {
        /// <summary> Initializes a new instance of AutoscaleProfile. </summary>
        /// <param name="enabled"> This indicates whether auto scale is enabled on HDInsight on AKS cluster. </param>
        public AutoscaleProfile(bool enabled)
        {
            Enabled = enabled;
        }

        /// <summary> Initializes a new instance of AutoscaleProfile. </summary>
        /// <param name="enabled"> This indicates whether auto scale is enabled on HDInsight on AKS cluster. </param>
        /// <param name="gracefulDecommissionTimeout"> This property is for graceful decommission timeout; It has a default setting of 3600 seconds before forced shutdown takes place. This is the maximal time to wait for running containers and applications to complete before transition a DECOMMISSIONING node into DECOMMISSIONED. The default value is 3600 seconds. Negative value (like -1) is handled as infinite timeout. </param>
        /// <param name="autoscaleType"> User to specify which type of Autoscale to be implemented - Scheduled Based or Load Based. </param>
        /// <param name="scheduleBasedConfig"> Profiles of schedule based Autoscale. </param>
        /// <param name="loadBasedConfig"> Profiles of load based Autoscale. </param>
        internal AutoscaleProfile(bool enabled, int? gracefulDecommissionTimeout, AutoscaleType? autoscaleType, ScheduleBasedConfig scheduleBasedConfig, LoadBasedConfig loadBasedConfig)
        {
            Enabled = enabled;
            GracefulDecommissionTimeout = gracefulDecommissionTimeout;
            AutoscaleType = autoscaleType;
            ScheduleBasedConfig = scheduleBasedConfig;
            LoadBasedConfig = loadBasedConfig;
        }

        /// <summary> This indicates whether auto scale is enabled on HDInsight on AKS cluster. </summary>
        public bool Enabled { get; set; }
        /// <summary> This property is for graceful decommission timeout; It has a default setting of 3600 seconds before forced shutdown takes place. This is the maximal time to wait for running containers and applications to complete before transition a DECOMMISSIONING node into DECOMMISSIONED. The default value is 3600 seconds. Negative value (like -1) is handled as infinite timeout. </summary>
        public int? GracefulDecommissionTimeout { get; set; }
        /// <summary> User to specify which type of Autoscale to be implemented - Scheduled Based or Load Based. </summary>
        public AutoscaleType? AutoscaleType { get; set; }
        /// <summary> Profiles of schedule based Autoscale. </summary>
        public ScheduleBasedConfig ScheduleBasedConfig { get; set; }
        /// <summary> Profiles of load based Autoscale. </summary>
        public LoadBasedConfig LoadBasedConfig { get; set; }
    }
}
