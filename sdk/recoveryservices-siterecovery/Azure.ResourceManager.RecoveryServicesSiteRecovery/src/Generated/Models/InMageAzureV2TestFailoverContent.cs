// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> InMageAzureV2 provider specific input for test failover. </summary>
    public partial class InMageAzureV2TestFailoverContent : TestFailoverProviderSpecificContent
    {
        /// <summary> Initializes a new instance of InMageAzureV2TestFailoverContent. </summary>
        public InMageAzureV2TestFailoverContent()
        {
            InstanceType = "InMageAzureV2";
        }

        /// <summary> The recovery point id to be passed to test failover to a particular recovery point. In case of latest recovery point, null should be passed. </summary>
        public ResourceIdentifier RecoveryPointId { get; set; }
        /// <summary> A value indicating the inplace OS Upgrade version. </summary>
        public string OSUpgradeVersion { get; set; }
    }
}
