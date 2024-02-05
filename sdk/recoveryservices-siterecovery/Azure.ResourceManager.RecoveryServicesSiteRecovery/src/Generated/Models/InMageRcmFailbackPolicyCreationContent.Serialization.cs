// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class InMageRcmFailbackPolicyCreationContent : IUtf8JsonSerializable, IJsonModel<InMageRcmFailbackPolicyCreationContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InMageRcmFailbackPolicyCreationContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<InMageRcmFailbackPolicyCreationContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmFailbackPolicyCreationContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InMageRcmFailbackPolicyCreationContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(CrashConsistentFrequencyInMinutes))
            {
                writer.WritePropertyName("crashConsistentFrequencyInMinutes"u8);
                writer.WriteNumberValue(CrashConsistentFrequencyInMinutes.Value);
            }
            if (Optional.IsDefined(AppConsistentFrequencyInMinutes))
            {
                writer.WritePropertyName("appConsistentFrequencyInMinutes"u8);
                writer.WriteNumberValue(AppConsistentFrequencyInMinutes.Value);
            }
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

        InMageRcmFailbackPolicyCreationContent IJsonModel<InMageRcmFailbackPolicyCreationContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmFailbackPolicyCreationContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InMageRcmFailbackPolicyCreationContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInMageRcmFailbackPolicyCreationContent(document.RootElement, options);
        }

        internal static InMageRcmFailbackPolicyCreationContent DeserializeInMageRcmFailbackPolicyCreationContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> crashConsistentFrequencyInMinutes = default;
            Optional<int> appConsistentFrequencyInMinutes = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("crashConsistentFrequencyInMinutes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    crashConsistentFrequencyInMinutes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("appConsistentFrequencyInMinutes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    appConsistentFrequencyInMinutes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new InMageRcmFailbackPolicyCreationContent(instanceType, serializedAdditionalRawData, Optional.ToNullable(crashConsistentFrequencyInMinutes), Optional.ToNullable(appConsistentFrequencyInMinutes));
        }

        BinaryData IPersistableModel<InMageRcmFailbackPolicyCreationContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmFailbackPolicyCreationContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InMageRcmFailbackPolicyCreationContent)} does not support '{options.Format}' format.");
            }
        }

        InMageRcmFailbackPolicyCreationContent IPersistableModel<InMageRcmFailbackPolicyCreationContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmFailbackPolicyCreationContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInMageRcmFailbackPolicyCreationContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InMageRcmFailbackPolicyCreationContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<InMageRcmFailbackPolicyCreationContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
