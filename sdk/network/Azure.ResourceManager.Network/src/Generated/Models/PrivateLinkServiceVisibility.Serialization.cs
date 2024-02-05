// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class PrivateLinkServiceVisibility : IUtf8JsonSerializable, IJsonModel<PrivateLinkServiceVisibility>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PrivateLinkServiceVisibility>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PrivateLinkServiceVisibility>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateLinkServiceVisibility>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PrivateLinkServiceVisibility)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Visible))
            {
                writer.WritePropertyName("visible"u8);
                writer.WriteBooleanValue(Visible.Value);
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

        PrivateLinkServiceVisibility IJsonModel<PrivateLinkServiceVisibility>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateLinkServiceVisibility>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PrivateLinkServiceVisibility)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePrivateLinkServiceVisibility(document.RootElement, options);
        }

        internal static PrivateLinkServiceVisibility DeserializePrivateLinkServiceVisibility(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> visible = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("visible"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    visible = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PrivateLinkServiceVisibility(Optional.ToNullable(visible), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PrivateLinkServiceVisibility>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateLinkServiceVisibility>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PrivateLinkServiceVisibility)} does not support '{options.Format}' format.");
            }
        }

        PrivateLinkServiceVisibility IPersistableModel<PrivateLinkServiceVisibility>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateLinkServiceVisibility>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePrivateLinkServiceVisibility(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PrivateLinkServiceVisibility)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PrivateLinkServiceVisibility>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
