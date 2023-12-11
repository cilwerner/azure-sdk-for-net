// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> The artifact update state properties. </summary>
    internal partial class ArtifactChangeStateProperties
    {
        /// <summary> Initializes a new instance of <see cref="ArtifactChangeStateProperties"/>. </summary>
        public ArtifactChangeStateProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ArtifactChangeStateProperties"/>. </summary>
        /// <param name="artifactState"> The artifact state. </param>
        internal ArtifactChangeStateProperties(ArtifactState? artifactState)
        {
            ArtifactState = artifactState;
        }

        /// <summary> The artifact state. </summary>
        public ArtifactState? ArtifactState { get; set; }
    }
}
