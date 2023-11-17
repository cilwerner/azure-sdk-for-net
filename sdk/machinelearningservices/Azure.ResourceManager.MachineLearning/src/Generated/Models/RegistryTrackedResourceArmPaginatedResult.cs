// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MachineLearning;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> A paginated list of Registry entities. </summary>
    internal partial class RegistryTrackedResourceArmPaginatedResult
    {
        /// <summary> Initializes a new instance of RegistryTrackedResourceArmPaginatedResult. </summary>
        internal RegistryTrackedResourceArmPaginatedResult()
        {
            Value = new ChangeTrackingList<MachineLearningRegistryData>();
        }

        /// <summary> Initializes a new instance of RegistryTrackedResourceArmPaginatedResult. </summary>
        /// <param name="nextLink"> The link to the next page of Registry objects. If null, there are no additional pages. </param>
        /// <param name="value"> An array of objects of type Registry. </param>
        internal RegistryTrackedResourceArmPaginatedResult(string nextLink, IReadOnlyList<MachineLearningRegistryData> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> The link to the next page of Registry objects. If null, there are no additional pages. </summary>
        public string NextLink { get; }
        /// <summary> An array of objects of type Registry. </summary>
        public IReadOnlyList<MachineLearningRegistryData> Value { get; }
    }
}
