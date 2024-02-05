// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class EventGridDomainRegenerateKeyContent : IUtf8JsonSerializable, IJsonModel<EventGridDomainRegenerateKeyContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EventGridDomainRegenerateKeyContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<EventGridDomainRegenerateKeyContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventGridDomainRegenerateKeyContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EventGridDomainRegenerateKeyContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("keyName"u8);
            writer.WriteStringValue(KeyName);
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

        EventGridDomainRegenerateKeyContent IJsonModel<EventGridDomainRegenerateKeyContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventGridDomainRegenerateKeyContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EventGridDomainRegenerateKeyContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEventGridDomainRegenerateKeyContent(document.RootElement, options);
        }

        internal static EventGridDomainRegenerateKeyContent DeserializeEventGridDomainRegenerateKeyContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string keyName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyName"u8))
                {
                    keyName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new EventGridDomainRegenerateKeyContent(keyName, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EventGridDomainRegenerateKeyContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventGridDomainRegenerateKeyContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EventGridDomainRegenerateKeyContent)} does not support '{options.Format}' format.");
            }
        }

        EventGridDomainRegenerateKeyContent IPersistableModel<EventGridDomainRegenerateKeyContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventGridDomainRegenerateKeyContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEventGridDomainRegenerateKeyContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EventGridDomainRegenerateKeyContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<EventGridDomainRegenerateKeyContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
