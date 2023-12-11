// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The parameters supplied to the update dsc node operation. </summary>
    public partial class DscNodePatch
    {
        /// <summary> Initializes a new instance of <see cref="DscNodePatch"/>. </summary>
        public DscNodePatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DscNodePatch"/>. </summary>
        /// <param name="nodeId"> Gets or sets the id of the dsc node. </param>
        /// <param name="properties"></param>
        internal DscNodePatch(string nodeId, DscNodeUpdateParametersProperties properties)
        {
            NodeId = nodeId;
            Properties = properties;
        }

        /// <summary> Gets or sets the id of the dsc node. </summary>
        public string NodeId { get; set; }
        /// <summary> Gets or sets the properties. </summary>
        internal DscNodeUpdateParametersProperties Properties { get; set; }
        /// <summary> Gets or sets the name of the dsc node configuration. </summary>
        public string DscNodeUpdateParametersName
        {
            get => Properties is null ? default : Properties.Name;
            set
            {
                if (Properties is null)
                    Properties = new DscNodeUpdateParametersProperties();
                Properties.Name = value;
            }
        }
    }
}
