// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> A2A provider specific input for unplanned failover. </summary>
    public partial class A2AUnplannedFailoverContent : UnplannedFailoverProviderSpecificContent
    {
        /// <summary> Initializes a new instance of <see cref="A2AUnplannedFailoverContent"/>. </summary>
        public A2AUnplannedFailoverContent()
        {
            InstanceType = "A2A";
        }

        /// <summary> Initializes a new instance of <see cref="A2AUnplannedFailoverContent"/>. </summary>
        /// <param name="instanceType"> The class type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="recoveryPointId"> The recovery point id to be passed to failover to a particular recovery point. In case of latest recovery point, null should be passed. </param>
        /// <param name="cloudServiceCreationOption"> A value indicating whether to use recovery cloud service for failover or not. </param>
        internal A2AUnplannedFailoverContent(string instanceType, IDictionary<string, BinaryData> serializedAdditionalRawData, ResourceIdentifier recoveryPointId, string cloudServiceCreationOption) : base(instanceType, serializedAdditionalRawData)
        {
            RecoveryPointId = recoveryPointId;
            CloudServiceCreationOption = cloudServiceCreationOption;
            InstanceType = instanceType ?? "A2A";
        }

        /// <summary> The recovery point id to be passed to failover to a particular recovery point. In case of latest recovery point, null should be passed. </summary>
        public ResourceIdentifier RecoveryPointId { get; set; }
        /// <summary> A value indicating whether to use recovery cloud service for failover or not. </summary>
        public string CloudServiceCreationOption { get; set; }
    }
}
