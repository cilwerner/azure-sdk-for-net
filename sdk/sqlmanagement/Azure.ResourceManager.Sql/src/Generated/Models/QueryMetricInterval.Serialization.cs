// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class QueryMetricInterval : IUtf8JsonSerializable, IJsonModel<QueryMetricInterval>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<QueryMetricInterval>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<QueryMetricInterval>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QueryMetricInterval>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(QueryMetricInterval)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(IntervalStartTime))
            {
                writer.WritePropertyName("intervalStartTime"u8);
                writer.WriteStringValue(IntervalStartTime);
            }
            if (options.Format != "W" && Optional.IsDefined(IntervalType))
            {
                writer.WritePropertyName("intervalType"u8);
                writer.WriteStringValue(IntervalType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ExecutionCount))
            {
                writer.WritePropertyName("executionCount"u8);
                writer.WriteNumberValue(ExecutionCount.Value);
            }
            if (Optional.IsCollectionDefined(Metrics))
            {
                writer.WritePropertyName("metrics"u8);
                writer.WriteStartArray();
                foreach (var item in Metrics)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        QueryMetricInterval IJsonModel<QueryMetricInterval>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QueryMetricInterval>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(QueryMetricInterval)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeQueryMetricInterval(document.RootElement, options);
        }

        internal static QueryMetricInterval DeserializeQueryMetricInterval(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> intervalStartTime = default;
            Optional<QueryTimeGrainType> intervalType = default;
            Optional<long> executionCount = default;
            Optional<IList<QueryMetricProperties>> metrics = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("intervalStartTime"u8))
                {
                    intervalStartTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("intervalType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    intervalType = new QueryTimeGrainType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("executionCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    executionCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("metrics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<QueryMetricProperties> array = new List<QueryMetricProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(QueryMetricProperties.DeserializeQueryMetricProperties(item));
                    }
                    metrics = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new QueryMetricInterval(intervalStartTime.Value, Optional.ToNullable(intervalType), Optional.ToNullable(executionCount), Optional.ToList(metrics), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<QueryMetricInterval>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QueryMetricInterval>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(QueryMetricInterval)} does not support '{options.Format}' format.");
            }
        }

        QueryMetricInterval IPersistableModel<QueryMetricInterval>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QueryMetricInterval>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeQueryMetricInterval(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(QueryMetricInterval)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<QueryMetricInterval>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
