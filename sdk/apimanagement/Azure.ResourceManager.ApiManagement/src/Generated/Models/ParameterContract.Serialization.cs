// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class ParameterContract : IUtf8JsonSerializable, IJsonModel<ParameterContract>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ParameterContract>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ParameterContract>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ParameterContract>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ParameterContract)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ParameterContractType);
            if (Optional.IsDefined(DefaultValue))
            {
                writer.WritePropertyName("defaultValue"u8);
                writer.WriteStringValue(DefaultValue);
            }
            if (Optional.IsDefined(IsRequired))
            {
                writer.WritePropertyName("required"u8);
                writer.WriteBooleanValue(IsRequired.Value);
            }
            if (Optional.IsCollectionDefined(Values))
            {
                writer.WritePropertyName("values"u8);
                writer.WriteStartArray();
                foreach (var item in Values)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SchemaId))
            {
                writer.WritePropertyName("schemaId"u8);
                writer.WriteStringValue(SchemaId);
            }
            if (Optional.IsDefined(TypeName))
            {
                writer.WritePropertyName("typeName"u8);
                writer.WriteStringValue(TypeName);
            }
            if (Optional.IsCollectionDefined(Examples))
            {
                writer.WritePropertyName("examples"u8);
                writer.WriteStartObject();
                foreach (var item in Examples)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
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

        ParameterContract IJsonModel<ParameterContract>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ParameterContract>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ParameterContract)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeParameterContract(document.RootElement, options);
        }

        internal static ParameterContract DeserializeParameterContract(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            Optional<string> description = default;
            string type = default;
            Optional<string> defaultValue = default;
            Optional<bool> required = default;
            Optional<IList<string>> values = default;
            Optional<string> schemaId = default;
            Optional<string> typeName = default;
            Optional<IDictionary<string, ParameterExampleContract>> examples = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("defaultValue"u8))
                {
                    defaultValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("required"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    required = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("values"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    values = array;
                    continue;
                }
                if (property.NameEquals("schemaId"u8))
                {
                    schemaId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("typeName"u8))
                {
                    typeName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("examples"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, ParameterExampleContract> dictionary = new Dictionary<string, ParameterExampleContract>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, ParameterExampleContract.DeserializeParameterExampleContract(property0.Value));
                    }
                    examples = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ParameterContract(name, description.Value, type, defaultValue.Value, Optional.ToNullable(required), Optional.ToList(values), schemaId.Value, typeName.Value, Optional.ToDictionary(examples), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ParameterContract>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ParameterContract>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ParameterContract)} does not support '{options.Format}' format.");
            }
        }

        ParameterContract IPersistableModel<ParameterContract>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ParameterContract>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeParameterContract(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ParameterContract)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ParameterContract>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
