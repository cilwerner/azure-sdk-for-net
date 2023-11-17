// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    /// <summary> The UnknownProtectedItemModelCustomProperties. </summary>
    internal partial class UnknownProtectedItemModelCustomProperties : ProtectedItemModelCustomProperties
    {
        /// <summary> Initializes a new instance of UnknownProtectedItemModelCustomProperties. </summary>
        /// <param name="instanceType"> Gets or sets the instance type. </param>
        internal UnknownProtectedItemModelCustomProperties(string instanceType) : base(instanceType)
        {
            InstanceType = instanceType ?? "Unknown";
        }
    }
}
