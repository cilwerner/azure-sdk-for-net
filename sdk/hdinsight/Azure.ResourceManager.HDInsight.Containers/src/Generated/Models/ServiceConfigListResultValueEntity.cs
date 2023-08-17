// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> Default config details. </summary>
    public partial class ServiceConfigListResultValueEntity
    {
        /// <summary> Initializes a new instance of ServiceConfigListResultValueEntity. </summary>
        /// <param name="value"> Config value. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal ServiceConfigListResultValueEntity(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value;
        }

        /// <summary> Initializes a new instance of ServiceConfigListResultValueEntity. </summary>
        /// <param name="value"> Config value. </param>
        /// <param name="description"> Config description. </param>
        internal ServiceConfigListResultValueEntity(string value, string description)
        {
            Value = value;
            Description = description;
        }

        /// <summary> Config value. </summary>
        public string Value { get; }
        /// <summary> Config description. </summary>
        public string Description { get; }
    }
}
