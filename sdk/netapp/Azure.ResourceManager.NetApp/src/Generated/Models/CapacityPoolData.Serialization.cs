// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.NetApp.Models;

namespace Azure.ResourceManager.NetApp
{
    public partial class CapacityPoolData : IUtf8JsonSerializable, IJsonModel<CapacityPoolData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CapacityPoolData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CapacityPoolData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CapacityPoolData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CapacityPoolData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(PoolId))
            {
                writer.WritePropertyName("poolId"u8);
                writer.WriteStringValue(PoolId.Value);
            }
            writer.WritePropertyName("size"u8);
            writer.WriteNumberValue(Size);
            writer.WritePropertyName("serviceLevel"u8);
            writer.WriteStringValue(ServiceLevel.ToString());
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (options.Format != "W" && Optional.IsDefined(TotalThroughputMibps))
            {
                writer.WritePropertyName("totalThroughputMibps"u8);
                writer.WriteNumberValue(TotalThroughputMibps.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(UtilizedThroughputMibps))
            {
                writer.WritePropertyName("utilizedThroughputMibps"u8);
                writer.WriteNumberValue(UtilizedThroughputMibps.Value);
            }
            if (Optional.IsDefined(QosType))
            {
                writer.WritePropertyName("qosType"u8);
                writer.WriteStringValue(QosType.Value.ToString());
            }
            if (Optional.IsDefined(IsCoolAccessEnabled))
            {
                writer.WritePropertyName("coolAccess"u8);
                writer.WriteBooleanValue(IsCoolAccessEnabled.Value);
            }
            if (Optional.IsDefined(EncryptionType))
            {
                if (EncryptionType != null)
                {
                    writer.WritePropertyName("encryptionType"u8);
                    writer.WriteStringValue(EncryptionType.Value.ToString());
                }
                else
                {
                    writer.WriteNull("encryptionType");
                }
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        CapacityPoolData IJsonModel<CapacityPoolData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CapacityPoolData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CapacityPoolData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCapacityPoolData(document.RootElement, options);
        }

        internal static CapacityPoolData DeserializeCapacityPoolData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ETag> etag = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<Guid> poolId = default;
            long size = default;
            NetAppFileServiceLevel serviceLevel = default;
            Optional<string> provisioningState = default;
            Optional<float> totalThroughputMibps = default;
            Optional<float> utilizedThroughputMibps = default;
            Optional<CapacityPoolQosType> qosType = default;
            Optional<bool> coolAccess = default;
            Optional<CapacityPoolEncryptionType?> encryptionType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("poolId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            poolId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("size"u8))
                        {
                            size = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("serviceLevel"u8))
                        {
                            serviceLevel = new NetAppFileServiceLevel(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("totalThroughputMibps"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            totalThroughputMibps = property0.Value.GetSingle();
                            continue;
                        }
                        if (property0.NameEquals("utilizedThroughputMibps"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            utilizedThroughputMibps = property0.Value.GetSingle();
                            continue;
                        }
                        if (property0.NameEquals("qosType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            qosType = new CapacityPoolQosType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("coolAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            coolAccess = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("encryptionType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                encryptionType = null;
                                continue;
                            }
                            encryptionType = new CapacityPoolEncryptionType(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CapacityPoolData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, Optional.ToNullable(etag), Optional.ToNullable(poolId), size, serviceLevel, provisioningState.Value, Optional.ToNullable(totalThroughputMibps), Optional.ToNullable(utilizedThroughputMibps), Optional.ToNullable(qosType), Optional.ToNullable(coolAccess), Optional.ToNullable(encryptionType), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CapacityPoolData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CapacityPoolData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CapacityPoolData)} does not support '{options.Format}' format.");
            }
        }

        CapacityPoolData IPersistableModel<CapacityPoolData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CapacityPoolData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCapacityPoolData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CapacityPoolData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CapacityPoolData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
