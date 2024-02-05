// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Request parameters for tiering cost info for protected item. </summary>
    public partial class FetchTieringCostSavingsInfoForProtectedItemContent : FetchTieringCostInfoContent
    {
        /// <summary> Initializes a new instance of <see cref="FetchTieringCostSavingsInfoForProtectedItemContent"/>. </summary>
        /// <param name="sourceTierType"> Source tier for the request. </param>
        /// <param name="targetTierType"> target tier for the request. </param>
        /// <param name="containerName"> Name of the protected item container. </param>
        /// <param name="protectedItemName"> Name of the protectedItemName. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/> or <paramref name="protectedItemName"/> is null. </exception>
        public FetchTieringCostSavingsInfoForProtectedItemContent(RecoveryPointTierType sourceTierType, RecoveryPointTierType targetTierType, string containerName, string protectedItemName) : base(sourceTierType, targetTierType)
        {
            Argument.AssertNotNull(containerName, nameof(containerName));
            Argument.AssertNotNull(protectedItemName, nameof(protectedItemName));

            ContainerName = containerName;
            ProtectedItemName = protectedItemName;
            ObjectType = "FetchTieringCostSavingsInfoForProtectedItemRequest";
        }

        /// <summary> Initializes a new instance of <see cref="FetchTieringCostSavingsInfoForProtectedItemContent"/>. </summary>
        /// <param name="sourceTierType"> Source tier for the request. </param>
        /// <param name="targetTierType"> target tier for the request. </param>
        /// <param name="objectType"> This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="containerName"> Name of the protected item container. </param>
        /// <param name="protectedItemName"> Name of the protectedItemName. </param>
        internal FetchTieringCostSavingsInfoForProtectedItemContent(RecoveryPointTierType sourceTierType, RecoveryPointTierType targetTierType, string objectType, IDictionary<string, BinaryData> serializedAdditionalRawData, string containerName, string protectedItemName) : base(sourceTierType, targetTierType, objectType, serializedAdditionalRawData)
        {
            ContainerName = containerName;
            ProtectedItemName = protectedItemName;
            ObjectType = objectType ?? "FetchTieringCostSavingsInfoForProtectedItemRequest";
        }

        /// <summary> Initializes a new instance of <see cref="FetchTieringCostSavingsInfoForProtectedItemContent"/> for deserialization. </summary>
        internal FetchTieringCostSavingsInfoForProtectedItemContent()
        {
        }

        /// <summary> Name of the protected item container. </summary>
        public string ContainerName { get; }
        /// <summary> Name of the protectedItemName. </summary>
        public string ProtectedItemName { get; }
    }
}
