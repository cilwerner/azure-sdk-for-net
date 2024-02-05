// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class NlpSweepSettings : IUtf8JsonSerializable, IJsonModel<NlpSweepSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NlpSweepSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NlpSweepSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NlpSweepSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NlpSweepSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(EarlyTermination))
            {
                if (EarlyTermination != null)
                {
                    writer.WritePropertyName("earlyTermination"u8);
                    writer.WriteObjectValue(EarlyTermination);
                }
                else
                {
                    writer.WriteNull("earlyTermination");
                }
            }
            writer.WritePropertyName("samplingAlgorithm"u8);
            writer.WriteStringValue(SamplingAlgorithm.ToString());
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

        NlpSweepSettings IJsonModel<NlpSweepSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NlpSweepSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NlpSweepSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNlpSweepSettings(document.RootElement, options);
        }

        internal static NlpSweepSettings DeserializeNlpSweepSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<MachineLearningEarlyTerminationPolicy> earlyTermination = default;
            SamplingAlgorithmType samplingAlgorithm = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("earlyTermination"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        earlyTermination = null;
                        continue;
                    }
                    earlyTermination = MachineLearningEarlyTerminationPolicy.DeserializeMachineLearningEarlyTerminationPolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("samplingAlgorithm"u8))
                {
                    samplingAlgorithm = new SamplingAlgorithmType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NlpSweepSettings(earlyTermination.Value, samplingAlgorithm, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NlpSweepSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NlpSweepSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NlpSweepSettings)} does not support '{options.Format}' format.");
            }
        }

        NlpSweepSettings IPersistableModel<NlpSweepSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NlpSweepSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNlpSweepSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NlpSweepSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NlpSweepSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
