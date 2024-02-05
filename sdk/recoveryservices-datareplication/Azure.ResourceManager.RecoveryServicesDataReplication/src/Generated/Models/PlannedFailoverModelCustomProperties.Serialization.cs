// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    [PersistableModelProxy(typeof(UnknownPlannedFailoverModelCustomProperties))]
    public partial class PlannedFailoverModelCustomProperties : IUtf8JsonSerializable, IJsonModel<PlannedFailoverModelCustomProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PlannedFailoverModelCustomProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PlannedFailoverModelCustomProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PlannedFailoverModelCustomProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PlannedFailoverModelCustomProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        PlannedFailoverModelCustomProperties IJsonModel<PlannedFailoverModelCustomProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PlannedFailoverModelCustomProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PlannedFailoverModelCustomProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePlannedFailoverModelCustomProperties(document.RootElement, options);
        }

        internal static PlannedFailoverModelCustomProperties DeserializePlannedFailoverModelCustomProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("instanceType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "HyperVToAzStackHCI": return HyperVToAzStackHciPlannedFailoverModelCustomProperties.DeserializeHyperVToAzStackHciPlannedFailoverModelCustomProperties(element);
                    case "PlannedFailoverModelCustomProperties": return GeneralPlannedFailoverModelCustomProperties.DeserializeGeneralPlannedFailoverModelCustomProperties(element);
                    case "VMwareToAzStackHCI": return VMwareToAzStackHciPlannedFailoverModelCustomProperties.DeserializeVMwareToAzStackHciPlannedFailoverModelCustomProperties(element);
                }
            }
            return UnknownPlannedFailoverModelCustomProperties.DeserializeUnknownPlannedFailoverModelCustomProperties(element);
        }

        BinaryData IPersistableModel<PlannedFailoverModelCustomProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PlannedFailoverModelCustomProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PlannedFailoverModelCustomProperties)} does not support '{options.Format}' format.");
            }
        }

        PlannedFailoverModelCustomProperties IPersistableModel<PlannedFailoverModelCustomProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PlannedFailoverModelCustomProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePlannedFailoverModelCustomProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PlannedFailoverModelCustomProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PlannedFailoverModelCustomProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
