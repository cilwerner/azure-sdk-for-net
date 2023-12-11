// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ArcScVmm.Models
{
    /// <summary> Defines the restore checkpoint action properties. </summary>
    public partial class VirtualMachineRestoreCheckpoint
    {
        /// <summary> Initializes a new instance of <see cref="VirtualMachineRestoreCheckpoint"/>. </summary>
        public VirtualMachineRestoreCheckpoint()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineRestoreCheckpoint"/>. </summary>
        /// <param name="id"> ID of the checkpoint to be restored to. </param>
        internal VirtualMachineRestoreCheckpoint(string id)
        {
            Id = id;
        }

        /// <summary> ID of the checkpoint to be restored to. </summary>
        public string Id { get; set; }
    }
}
