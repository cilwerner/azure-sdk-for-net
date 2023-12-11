// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> Defines the request body for updating SAP Application Instance. </summary>
    public partial class SapApplicationServerInstancePatch
    {
        /// <summary> Initializes a new instance of <see cref="SapApplicationServerInstancePatch"/>. </summary>
        public SapApplicationServerInstancePatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="SapApplicationServerInstancePatch"/>. </summary>
        /// <param name="tags"> Gets or sets the Resource tags. </param>
        internal SapApplicationServerInstancePatch(IDictionary<string, string> tags)
        {
            Tags = tags;
        }

        /// <summary> Gets or sets the Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
