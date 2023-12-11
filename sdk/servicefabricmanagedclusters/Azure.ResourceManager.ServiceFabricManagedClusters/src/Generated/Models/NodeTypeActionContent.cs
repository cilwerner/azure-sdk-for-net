// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> Parameters for Node type action. If nodes are not specified on the parameters, the operation will be performed in all nodes of the node type one upgrade domain at a time. </summary>
    public partial class NodeTypeActionContent
    {
        /// <summary> Initializes a new instance of <see cref="NodeTypeActionContent"/>. </summary>
        public NodeTypeActionContent()
        {
            Nodes = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="NodeTypeActionContent"/>. </summary>
        /// <param name="nodes"> List of node names from the node type. </param>
        /// <param name="isForced"> Force the action to go through. </param>
        /// <param name="updateType"> Specifies the way the operation will be performed. </param>
        internal NodeTypeActionContent(IList<string> nodes, bool? isForced, ServiceFabricManagedClusterUpdateType? updateType)
        {
            Nodes = nodes;
            IsForced = isForced;
            UpdateType = updateType;
        }

        /// <summary> List of node names from the node type. </summary>
        public IList<string> Nodes { get; }
        /// <summary> Force the action to go through. </summary>
        public bool? IsForced { get; set; }
        /// <summary> Specifies the way the operation will be performed. </summary>
        public ServiceFabricManagedClusterUpdateType? UpdateType { get; set; }
    }
}
