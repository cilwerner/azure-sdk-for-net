// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> Defines the addon status profile. </summary>
    public partial class ProvisionedClusterAddonStatusProfile
    {
        /// <summary> Initializes a new instance of <see cref="ProvisionedClusterAddonStatusProfile"/>. </summary>
        internal ProvisionedClusterAddonStatusProfile()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ProvisionedClusterAddonStatusProfile"/>. </summary>
        /// <param name="name"> Name of the addon. </param>
        /// <param name="phase"> Observed phase of the addon on the target cluster. Possible values include: 'pending', 'provisioning', 'provisioning {HelmChartInstalled}', 'provisioning {MSICertificateDownloaded}', 'provisioned', 'deleting', 'failed', 'upgrading'. </param>
        /// <param name="ready"> Indicates whether the addon is ready. </param>
        /// <param name="errorMessage"> Error message while deploying the addon. </param>
        internal ProvisionedClusterAddonStatusProfile(string name, ProvisionedClusterAddonPhase? phase, bool? ready, string errorMessage)
        {
            Name = name;
            Phase = phase;
            Ready = ready;
            ErrorMessage = errorMessage;
        }

        /// <summary> Name of the addon. </summary>
        public string Name { get; }
        /// <summary> Observed phase of the addon on the target cluster. Possible values include: 'pending', 'provisioning', 'provisioning {HelmChartInstalled}', 'provisioning {MSICertificateDownloaded}', 'provisioned', 'deleting', 'failed', 'upgrading'. </summary>
        public ProvisionedClusterAddonPhase? Phase { get; }
        /// <summary> Indicates whether the addon is ready. </summary>
        public bool? Ready { get; }
        /// <summary> Error message while deploying the addon. </summary>
        public string ErrorMessage { get; }
    }
}
