// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    [PersistableModelProxy(typeof(UnknownClusterJobProperties))]
    public partial class ClusterJobProperties : IUtf8JsonSerializable, IJsonModel<ClusterJobProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ClusterJobProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ClusterJobProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterJobProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterJobProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("jobType"u8);
            writer.WriteStringValue(JobType.ToString());
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

        ClusterJobProperties IJsonModel<ClusterJobProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterJobProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterJobProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeClusterJobProperties(document.RootElement, options);
        }

        internal static ClusterJobProperties DeserializeClusterJobProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("jobType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "FlinkJob": return FlinkJobProperties.DeserializeFlinkJobProperties(element);
                }
            }
            return UnknownClusterJobProperties.DeserializeUnknownClusterJobProperties(element);
        }

        BinaryData IPersistableModel<ClusterJobProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterJobProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ClusterJobProperties)} does not support '{options.Format}' format.");
            }
        }

        ClusterJobProperties IPersistableModel<ClusterJobProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterJobProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeClusterJobProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ClusterJobProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ClusterJobProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
