// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    public partial class ClusterPoolResourcePropertiesAksClusterProfile
    {
        internal static ClusterPoolResourcePropertiesAksClusterProfile DeserializeClusterPoolResourcePropertiesAksClusterProfile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> aksClusterResourceId = default;
            Optional<AksClusterProfileAksClusterAgentPoolIdentityProfile> aksClusterAgentPoolIdentityProfile = default;
            Optional<string> aksVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("aksClusterResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    aksClusterResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("aksClusterAgentPoolIdentityProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    aksClusterAgentPoolIdentityProfile = AksClusterProfileAksClusterAgentPoolIdentityProfile.DeserializeAksClusterProfileAksClusterAgentPoolIdentityProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("aksVersion"u8))
                {
                    aksVersion = property.Value.GetString();
                    continue;
                }
            }
            return new ClusterPoolResourcePropertiesAksClusterProfile(aksClusterResourceId.Value, aksClusterAgentPoolIdentityProfile.Value, aksVersion.Value);
        }
    }
}
