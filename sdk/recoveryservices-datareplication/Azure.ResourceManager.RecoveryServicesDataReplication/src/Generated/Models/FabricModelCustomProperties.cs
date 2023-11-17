// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    /// <summary>
    /// Fabric model custom properties.
    /// Please note <see cref="FabricModelCustomProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AzStackHciFabricModelCustomProperties"/>, <see cref="GeneralFabricModelCustomProperties"/>, <see cref="HyperVMigrateFabricModelCustomProperties"/> and <see cref="VMwareMigrateFabricModelCustomProperties"/>.
    /// </summary>
    public abstract partial class FabricModelCustomProperties
    {
        /// <summary> Initializes a new instance of FabricModelCustomProperties. </summary>
        protected FabricModelCustomProperties()
        {
        }

        /// <summary> Initializes a new instance of FabricModelCustomProperties. </summary>
        /// <param name="instanceType"> Gets or sets the instance type. </param>
        internal FabricModelCustomProperties(string instanceType)
        {
            InstanceType = instanceType;
        }

        /// <summary> Gets or sets the instance type. </summary>
        internal string InstanceType { get; set; }
    }
}
