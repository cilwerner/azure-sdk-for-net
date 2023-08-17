// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> The compute profile. </summary>
    internal partial class ComputeProfile
    {
        /// <summary> Initializes a new instance of ComputeProfile. </summary>
        /// <param name="nodes"> The nodes definitions. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nodes"/> is null. </exception>
        public ComputeProfile(IEnumerable<NodeProfile> nodes)
        {
            Argument.AssertNotNull(nodes, nameof(nodes));

            Nodes = nodes.ToList();
        }

        /// <summary> Initializes a new instance of ComputeProfile. </summary>
        /// <param name="nodes"> The nodes definitions. </param>
        internal ComputeProfile(IList<NodeProfile> nodes)
        {
            Nodes = nodes;
        }

        /// <summary> The nodes definitions. </summary>
        public IList<NodeProfile> Nodes { get; }
    }
}
