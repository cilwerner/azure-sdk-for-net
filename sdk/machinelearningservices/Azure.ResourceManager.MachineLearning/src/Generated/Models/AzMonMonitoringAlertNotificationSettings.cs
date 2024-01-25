// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The AzMonMonitoringAlertNotificationSettings. </summary>
    public partial class AzMonMonitoringAlertNotificationSettings : MonitoringAlertNotificationSettingsBase
    {
        /// <summary> Initializes a new instance of <see cref="AzMonMonitoringAlertNotificationSettings"/>. </summary>
        public AzMonMonitoringAlertNotificationSettings()
        {
            AlertNotificationType = MonitoringAlertNotificationType.AzureMonitor;
        }

        /// <summary> Initializes a new instance of <see cref="AzMonMonitoringAlertNotificationSettings"/>. </summary>
        /// <param name="alertNotificationType"> [Required] Specifies the type of signal to monitor. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AzMonMonitoringAlertNotificationSettings(MonitoringAlertNotificationType alertNotificationType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(alertNotificationType, serializedAdditionalRawData)
        {
            AlertNotificationType = alertNotificationType;
        }
    }
}
