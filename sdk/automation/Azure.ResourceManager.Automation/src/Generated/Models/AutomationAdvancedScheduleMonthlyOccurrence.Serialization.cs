// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    public partial class AutomationAdvancedScheduleMonthlyOccurrence : IUtf8JsonSerializable, IJsonModel<AutomationAdvancedScheduleMonthlyOccurrence>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AutomationAdvancedScheduleMonthlyOccurrence>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AutomationAdvancedScheduleMonthlyOccurrence>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationAdvancedScheduleMonthlyOccurrence>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutomationAdvancedScheduleMonthlyOccurrence)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Occurrence))
            {
                writer.WritePropertyName("occurrence"u8);
                writer.WriteNumberValue(Occurrence.Value);
            }
            if (Optional.IsDefined(Day))
            {
                writer.WritePropertyName("day"u8);
                writer.WriteStringValue(Day.Value.ToString());
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

        AutomationAdvancedScheduleMonthlyOccurrence IJsonModel<AutomationAdvancedScheduleMonthlyOccurrence>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationAdvancedScheduleMonthlyOccurrence>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutomationAdvancedScheduleMonthlyOccurrence)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAutomationAdvancedScheduleMonthlyOccurrence(document.RootElement, options);
        }

        internal static AutomationAdvancedScheduleMonthlyOccurrence DeserializeAutomationAdvancedScheduleMonthlyOccurrence(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> occurrence = default;
            Optional<AutomationDayOfWeek> day = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("occurrence"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    occurrence = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("day"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    day = new AutomationDayOfWeek(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AutomationAdvancedScheduleMonthlyOccurrence(Optional.ToNullable(occurrence), Optional.ToNullable(day), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AutomationAdvancedScheduleMonthlyOccurrence>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationAdvancedScheduleMonthlyOccurrence>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AutomationAdvancedScheduleMonthlyOccurrence)} does not support '{options.Format}' format.");
            }
        }

        AutomationAdvancedScheduleMonthlyOccurrence IPersistableModel<AutomationAdvancedScheduleMonthlyOccurrence>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationAdvancedScheduleMonthlyOccurrence>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAutomationAdvancedScheduleMonthlyOccurrence(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AutomationAdvancedScheduleMonthlyOccurrence)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AutomationAdvancedScheduleMonthlyOccurrence>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
