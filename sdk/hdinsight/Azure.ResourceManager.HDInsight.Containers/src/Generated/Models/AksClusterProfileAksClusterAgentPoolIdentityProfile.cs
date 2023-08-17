// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> Identity properties of the AKS cluster agentpool MSI. </summary>
    public partial class AksClusterProfileAksClusterAgentPoolIdentityProfile : IdentityProfile
    {
        /// <summary> Initializes a new instance of AksClusterProfileAksClusterAgentPoolIdentityProfile. </summary>
        /// <param name="msiResourceId"> ResourceId of the MSI. </param>
        /// <param name="msiClientId"> ClientId of the MSI. </param>
        /// <param name="msiObjectId"> ObjectId of the MSI. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="msiResourceId"/>, <paramref name="msiClientId"/> or <paramref name="msiObjectId"/> is null. </exception>
        public AksClusterProfileAksClusterAgentPoolIdentityProfile(ResourceIdentifier msiResourceId, string msiClientId, string msiObjectId) : base(msiResourceId, msiClientId, msiObjectId)
        {
            Argument.AssertNotNull(msiResourceId, nameof(msiResourceId));
            Argument.AssertNotNull(msiClientId, nameof(msiClientId));
            Argument.AssertNotNull(msiObjectId, nameof(msiObjectId));
        }
    }
}
