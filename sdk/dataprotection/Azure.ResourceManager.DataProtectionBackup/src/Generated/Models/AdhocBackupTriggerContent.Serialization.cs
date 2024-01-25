// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class AdhocBackupTriggerContent : IUtf8JsonSerializable, IJsonModel<AdhocBackupTriggerContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AdhocBackupTriggerContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AdhocBackupTriggerContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AdhocBackupTriggerContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AdhocBackupTriggerContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("backupRuleOptions"u8);
            writer.WriteObjectValue(BackupRules);
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

        AdhocBackupTriggerContent IJsonModel<AdhocBackupTriggerContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AdhocBackupTriggerContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AdhocBackupTriggerContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAdhocBackupTriggerContent(document.RootElement, options);
        }

        internal static AdhocBackupTriggerContent DeserializeAdhocBackupTriggerContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AdhocBackupRules backupRuleOptions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("backupRuleOptions"u8))
                {
                    backupRuleOptions = AdhocBackupRules.DeserializeAdhocBackupRules(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AdhocBackupTriggerContent(backupRuleOptions, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AdhocBackupTriggerContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AdhocBackupTriggerContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AdhocBackupTriggerContent)} does not support '{options.Format}' format.");
            }
        }

        AdhocBackupTriggerContent IPersistableModel<AdhocBackupTriggerContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AdhocBackupTriggerContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAdhocBackupTriggerContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AdhocBackupTriggerContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AdhocBackupTriggerContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
