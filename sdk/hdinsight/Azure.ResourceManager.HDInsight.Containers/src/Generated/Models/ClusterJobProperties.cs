// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary>
    /// Properties of cluster job.
    /// Please note <see cref="ClusterJobProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="FlinkJobProperties"/>.
    /// </summary>
    public abstract partial class ClusterJobProperties
    {
        /// <summary> Initializes a new instance of ClusterJobProperties. </summary>
        protected ClusterJobProperties()
        {
        }

        /// <summary> Initializes a new instance of ClusterJobProperties. </summary>
        /// <param name="jobType"> Type of cluster job. </param>
        internal ClusterJobProperties(JobType jobType)
        {
            JobType = jobType;
        }

        /// <summary> Type of cluster job. </summary>
        internal JobType JobType { get; set; }
    }
}
