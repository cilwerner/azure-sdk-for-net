// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Datadog.Models
{
    public partial class DatadogSetPasswordLink : IUtf8JsonSerializable, IJsonModel<DatadogSetPasswordLink>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DatadogSetPasswordLink>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DatadogSetPasswordLink>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatadogSetPasswordLink>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DatadogSetPasswordLink)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SetPasswordLink))
            {
                writer.WritePropertyName("setPasswordLink"u8);
                writer.WriteStringValue(SetPasswordLink);
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

        DatadogSetPasswordLink IJsonModel<DatadogSetPasswordLink>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatadogSetPasswordLink>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DatadogSetPasswordLink)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDatadogSetPasswordLink(document.RootElement, options);
        }

        internal static DatadogSetPasswordLink DeserializeDatadogSetPasswordLink(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> setPasswordLink = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("setPasswordLink"u8))
                {
                    setPasswordLink = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DatadogSetPasswordLink(setPasswordLink.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DatadogSetPasswordLink>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatadogSetPasswordLink>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DatadogSetPasswordLink)} does not support '{options.Format}' format.");
            }
        }

        DatadogSetPasswordLink IPersistableModel<DatadogSetPasswordLink>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatadogSetPasswordLink>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDatadogSetPasswordLink(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DatadogSetPasswordLink)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DatadogSetPasswordLink>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
