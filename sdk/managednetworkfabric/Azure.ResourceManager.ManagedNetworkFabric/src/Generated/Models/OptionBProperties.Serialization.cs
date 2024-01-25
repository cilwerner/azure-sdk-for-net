// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class OptionBProperties : IUtf8JsonSerializable, IJsonModel<OptionBProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OptionBProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<OptionBProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OptionBProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OptionBProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(ImportRouteTargets))
            {
                writer.WritePropertyName("importRouteTargets"u8);
                writer.WriteStartArray();
                foreach (var item in ImportRouteTargets)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ExportRouteTargets))
            {
                writer.WritePropertyName("exportRouteTargets"u8);
                writer.WriteStartArray();
                foreach (var item in ExportRouteTargets)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(RouteTargets))
            {
                writer.WritePropertyName("routeTargets"u8);
                writer.WriteObjectValue(RouteTargets);
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

        OptionBProperties IJsonModel<OptionBProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OptionBProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OptionBProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOptionBProperties(document.RootElement, options);
        }

        internal static OptionBProperties DeserializeOptionBProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<string>> importRouteTargets = default;
            Optional<IList<string>> exportRouteTargets = default;
            Optional<RouteTargetInformation> routeTargets = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("importRouteTargets"u8))
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
                    importRouteTargets = array;
                    continue;
                }
                if (property.NameEquals("exportRouteTargets"u8))
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
                    exportRouteTargets = array;
                    continue;
                }
                if (property.NameEquals("routeTargets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    routeTargets = RouteTargetInformation.DeserializeRouteTargetInformation(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new OptionBProperties(Optional.ToList(importRouteTargets), Optional.ToList(exportRouteTargets), routeTargets.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<OptionBProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OptionBProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(OptionBProperties)} does not support '{options.Format}' format.");
            }
        }

        OptionBProperties IPersistableModel<OptionBProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OptionBProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOptionBProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OptionBProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<OptionBProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
