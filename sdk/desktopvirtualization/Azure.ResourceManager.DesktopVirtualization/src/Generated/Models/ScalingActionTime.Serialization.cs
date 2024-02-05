// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    public partial class ScalingActionTime : IUtf8JsonSerializable, IJsonModel<ScalingActionTime>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ScalingActionTime>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ScalingActionTime>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScalingActionTime>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScalingActionTime)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("hour"u8);
            writer.WriteNumberValue(Hour);
            writer.WritePropertyName("minute"u8);
            writer.WriteNumberValue(Minute);
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

        ScalingActionTime IJsonModel<ScalingActionTime>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScalingActionTime>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScalingActionTime)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeScalingActionTime(document.RootElement, options);
        }

        internal static ScalingActionTime DeserializeScalingActionTime(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int hour = default;
            int minute = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hour"u8))
                {
                    hour = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minute"u8))
                {
                    minute = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ScalingActionTime(hour, minute, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ScalingActionTime>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScalingActionTime>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ScalingActionTime)} does not support '{options.Format}' format.");
            }
        }

        ScalingActionTime IPersistableModel<ScalingActionTime>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScalingActionTime>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeScalingActionTime(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ScalingActionTime)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ScalingActionTime>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
