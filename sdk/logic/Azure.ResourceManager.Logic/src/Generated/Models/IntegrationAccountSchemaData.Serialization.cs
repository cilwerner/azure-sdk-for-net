// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Logic.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Logic
{
    public partial class IntegrationAccountSchemaData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
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
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("schemaType"u8);
            writer.WriteStringValue(SchemaType.ToString());
            if (Optional.IsDefined(TargetNamespace))
            {
                writer.WritePropertyName("targetNamespace"u8);
                writer.WriteStringValue(TargetNamespace);
            }
            if (Optional.IsDefined(DocumentName))
            {
                writer.WritePropertyName("documentName"u8);
                writer.WriteStringValue(DocumentName);
            }
            if (Optional.IsDefined(FileName))
            {
                writer.WritePropertyName("fileName"u8);
                writer.WriteStringValue(FileName);
            }
            if (Optional.IsDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Metadata);
#else
                using (JsonDocument document = JsonDocument.Parse(Metadata))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(Content))
            {
                writer.WritePropertyName("content"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Content);
#else
                using (JsonDocument document = JsonDocument.Parse(Content))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(ContentType))
            {
                writer.WritePropertyName("contentType"u8);
                writer.WriteStringValue(ContentType.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static IntegrationAccountSchemaData DeserializeIntegrationAccountSchemaData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            IntegrationAccountSchemaType schemaType = default;
            Optional<string> targetNamespace = default;
            Optional<string> documentName = default;
            Optional<string> fileName = default;
            Optional<DateTimeOffset> createdTime = default;
            Optional<DateTimeOffset> changedTime = default;
            Optional<BinaryData> metadata = default;
            Optional<BinaryData> content = default;
            Optional<ContentType> contentType = default;
            Optional<LogicContentLink> contentLink = default;
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("schemaType"u8))
                        {
                            schemaType = new IntegrationAccountSchemaType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("targetNamespace"u8))
                        {
                            targetNamespace = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("documentName"u8))
                        {
                            documentName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("fileName"u8))
                        {
                            fileName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("createdTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("changedTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            changedTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("metadata"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            metadata = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("content"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            content = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("contentType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            contentType = new ContentType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("contentLink"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            contentLink = LogicContentLink.DeserializeLogicContentLink(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new IntegrationAccountSchemaData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, schemaType, targetNamespace.Value, documentName.Value, fileName.Value, Optional.ToNullable(createdTime), Optional.ToNullable(changedTime), metadata.Value, content.Value, Optional.ToNullable(contentType), contentLink.Value);
        }
    }
}
