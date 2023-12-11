// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.ManagementGroups.Models
{
    /// <summary> Management group name availability check parameters. </summary>
    public partial class ManagementGroupNameAvailabilityContent
    {
        /// <summary> Initializes a new instance of <see cref="ManagementGroupNameAvailabilityContent"/>. </summary>
        /// <param name="name"> the name to check for availability. </param>
        /// <param name="resourceType"> fully qualified resource type which includes provider namespace. </param>
        internal ManagementGroupNameAvailabilityContent(string name, ResourceType? resourceType)
        {
            Name = name;
            ResourceType = resourceType;
        }

        /// <summary> the name to check for availability. </summary>
        public string Name { get; set; }
        /// <summary> fully qualified resource type which includes provider namespace. </summary>
        public ResourceType? ResourceType { get; set; }
    }
}
