// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Secrets related to a Machine Learning compute based on AKS. </summary>
    public partial class MachineLearningVirtualMachineSecrets : MachineLearningComputeSecrets
    {
        /// <summary> Initializes a new instance of <see cref="MachineLearningVirtualMachineSecrets"/>. </summary>
        internal MachineLearningVirtualMachineSecrets()
        {
            ComputeType = ComputeType.VirtualMachine;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningVirtualMachineSecrets"/>. </summary>
        /// <param name="computeType"> The type of compute. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="administratorAccount"> Admin credentials for virtual machine. </param>
        internal MachineLearningVirtualMachineSecrets(ComputeType computeType, IDictionary<string, BinaryData> serializedAdditionalRawData, MachineLearningVmSshCredentials administratorAccount) : base(computeType, serializedAdditionalRawData)
        {
            AdministratorAccount = administratorAccount;
            ComputeType = computeType;
        }

        /// <summary> Admin credentials for virtual machine. </summary>
        public MachineLearningVmSshCredentials AdministratorAccount { get; }
    }
}
