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
    public partial class ScheduleBasedBackupTriggerContext : IUtf8JsonSerializable, IJsonModel<ScheduleBasedBackupTriggerContext>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ScheduleBasedBackupTriggerContext>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ScheduleBasedBackupTriggerContext>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScheduleBasedBackupTriggerContext>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScheduleBasedBackupTriggerContext)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("schedule"u8);
            writer.WriteObjectValue(Schedule);
            writer.WritePropertyName("taggingCriteria"u8);
            writer.WriteStartArray();
            foreach (var item in TaggingCriteriaList)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
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

        ScheduleBasedBackupTriggerContext IJsonModel<ScheduleBasedBackupTriggerContext>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScheduleBasedBackupTriggerContext>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScheduleBasedBackupTriggerContext)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeScheduleBasedBackupTriggerContext(document.RootElement, options);
        }

        internal static ScheduleBasedBackupTriggerContext DeserializeScheduleBasedBackupTriggerContext(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataProtectionBackupSchedule schedule = default;
            IList<DataProtectionBackupTaggingCriteria> taggingCriteria = default;
            string objectType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("schedule"u8))
                {
                    schedule = DataProtectionBackupSchedule.DeserializeDataProtectionBackupSchedule(property.Value);
                    continue;
                }
                if (property.NameEquals("taggingCriteria"u8))
                {
                    List<DataProtectionBackupTaggingCriteria> array = new List<DataProtectionBackupTaggingCriteria>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataProtectionBackupTaggingCriteria.DeserializeDataProtectionBackupTaggingCriteria(item));
                    }
                    taggingCriteria = array;
                    continue;
                }
                if (property.NameEquals("objectType"u8))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ScheduleBasedBackupTriggerContext(objectType, serializedAdditionalRawData, schedule, taggingCriteria);
        }

        BinaryData IPersistableModel<ScheduleBasedBackupTriggerContext>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScheduleBasedBackupTriggerContext>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ScheduleBasedBackupTriggerContext)} does not support '{options.Format}' format.");
            }
        }

        ScheduleBasedBackupTriggerContext IPersistableModel<ScheduleBasedBackupTriggerContext>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScheduleBasedBackupTriggerContext>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeScheduleBasedBackupTriggerContext(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ScheduleBasedBackupTriggerContext)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ScheduleBasedBackupTriggerContext>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
