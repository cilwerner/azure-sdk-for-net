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
    internal partial class UnknownMonitoringAlertNotificationSettingsBase : IUtf8JsonSerializable, IJsonModel<MonitoringAlertNotificationSettingsBase>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MonitoringAlertNotificationSettingsBase>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MonitoringAlertNotificationSettingsBase>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitoringAlertNotificationSettingsBase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitoringAlertNotificationSettingsBase)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("alertNotificationType"u8);
            writer.WriteStringValue(AlertNotificationType.ToString());
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

        MonitoringAlertNotificationSettingsBase IJsonModel<MonitoringAlertNotificationSettingsBase>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitoringAlertNotificationSettingsBase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitoringAlertNotificationSettingsBase)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUnknownMonitoringAlertNotificationSettingsBase(document.RootElement, options);
        }

        internal static UnknownMonitoringAlertNotificationSettingsBase DeserializeUnknownMonitoringAlertNotificationSettingsBase(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MonitoringAlertNotificationType alertNotificationType = "Unknown";
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("alertNotificationType"u8))
                {
                    alertNotificationType = new MonitoringAlertNotificationType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UnknownMonitoringAlertNotificationSettingsBase(alertNotificationType, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MonitoringAlertNotificationSettingsBase>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitoringAlertNotificationSettingsBase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MonitoringAlertNotificationSettingsBase)} does not support '{options.Format}' format.");
            }
        }

        MonitoringAlertNotificationSettingsBase IPersistableModel<MonitoringAlertNotificationSettingsBase>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitoringAlertNotificationSettingsBase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeUnknownMonitoringAlertNotificationSettingsBase(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MonitoringAlertNotificationSettingsBase)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MonitoringAlertNotificationSettingsBase>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
