// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    public partial class ClusterVersion : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ClusterType))
            {
                writer.WritePropertyName("clusterType"u8);
                writer.WriteStringValue(ClusterType);
            }
            if (Optional.IsDefined(ClusterVersionValue))
            {
                writer.WritePropertyName("clusterVersion"u8);
                writer.WriteStringValue(ClusterVersionValue);
            }
            if (Optional.IsDefined(OssVersion))
            {
                writer.WritePropertyName("ossVersion"u8);
                writer.WriteStringValue(OssVersion);
            }
            if (Optional.IsDefined(ClusterPoolVersion))
            {
                writer.WritePropertyName("clusterPoolVersion"u8);
                writer.WriteStringValue(ClusterPoolVersion);
            }
            if (Optional.IsDefined(IsPreview))
            {
                writer.WritePropertyName("isPreview"u8);
                writer.WriteBooleanValue(IsPreview.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ClusterVersion DeserializeClusterVersion(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> clusterType = default;
            Optional<string> clusterVersion = default;
            Optional<string> ossVersion = default;
            Optional<string> clusterPoolVersion = default;
            Optional<bool> isPreview = default;
            Optional<IReadOnlyList<ClusterComponentsItem>> components = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("clusterType"u8))
                        {
                            clusterType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("clusterVersion"u8))
                        {
                            clusterVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ossVersion"u8))
                        {
                            ossVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("clusterPoolVersion"u8))
                        {
                            clusterPoolVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isPreview"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isPreview = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("components"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ClusterComponentsItem> array = new List<ClusterComponentsItem>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ClusterComponentsItem.DeserializeClusterComponentsItem(item));
                            }
                            components = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ClusterVersion(id, name, type, systemData.Value, clusterType.Value, clusterVersion.Value, ossVersion.Value, clusterPoolVersion.Value, Optional.ToNullable(isPreview), Optional.ToList(components));
        }
    }
}
