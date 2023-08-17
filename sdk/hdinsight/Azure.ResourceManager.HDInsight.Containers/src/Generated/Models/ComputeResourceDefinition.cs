// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> The cpu and memory requirement definition. </summary>
    public partial class ComputeResourceDefinition
    {
        /// <summary> Initializes a new instance of ComputeResourceDefinition. </summary>
        /// <param name="cpu"> The required CPU. </param>
        /// <param name="memory"> The required memory in MB, Container memory will be 110 percentile. </param>
        public ComputeResourceDefinition(float cpu, long memory)
        {
            Cpu = cpu;
            Memory = memory;
        }

        /// <summary> The required CPU. </summary>
        public float Cpu { get; set; }
        /// <summary> The required memory in MB, Container memory will be 110 percentile. </summary>
        public long Memory { get; set; }
    }
}
