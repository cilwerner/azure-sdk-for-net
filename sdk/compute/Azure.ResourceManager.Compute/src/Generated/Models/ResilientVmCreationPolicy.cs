// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The configuration parameters used while performing resilient VM creation. </summary>
    internal partial class ResilientVmCreationPolicy
    {
        /// <summary> Initializes a new instance of <see cref="ResilientVmCreationPolicy"/>. </summary>
        public ResilientVmCreationPolicy()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ResilientVmCreationPolicy"/>. </summary>
        /// <param name="enabled"> Specifies whether resilient VM creation should be enabled on the virtual machine scale set. The default value is false. </param>
        internal ResilientVmCreationPolicy(bool? enabled)
        {
            Enabled = enabled;
        }

        /// <summary> Specifies whether resilient VM creation should be enabled on the virtual machine scale set. The default value is false. </summary>
        public bool? Enabled { get; set; }
    }
}
