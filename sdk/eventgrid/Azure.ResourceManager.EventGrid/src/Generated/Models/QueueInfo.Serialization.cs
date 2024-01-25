// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class QueueInfo : IUtf8JsonSerializable, IJsonModel<QueueInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<QueueInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<QueueInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QueueInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(QueueInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ReceiveLockDurationInSeconds))
            {
                writer.WritePropertyName("receiveLockDurationInSeconds"u8);
                writer.WriteNumberValue(ReceiveLockDurationInSeconds.Value);
            }
            if (Optional.IsDefined(MaxDeliveryCount))
            {
                writer.WritePropertyName("maxDeliveryCount"u8);
                writer.WriteNumberValue(MaxDeliveryCount.Value);
            }
            if (Optional.IsDefined(DeadLetterDestinationWithResourceIdentity))
            {
                writer.WritePropertyName("deadLetterDestinationWithResourceIdentity"u8);
                writer.WriteObjectValue(DeadLetterDestinationWithResourceIdentity);
            }
            if (Optional.IsDefined(EventTimeToLive))
            {
                writer.WritePropertyName("eventTimeToLive"u8);
                writer.WriteStringValue(EventTimeToLive.Value, "P");
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

        QueueInfo IJsonModel<QueueInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QueueInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(QueueInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeQueueInfo(document.RootElement, options);
        }

        internal static QueueInfo DeserializeQueueInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> receiveLockDurationInSeconds = default;
            Optional<int> maxDeliveryCount = default;
            Optional<DeadLetterWithResourceIdentity> deadLetterDestinationWithResourceIdentity = default;
            Optional<TimeSpan> eventTimeToLive = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("receiveLockDurationInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    receiveLockDurationInSeconds = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxDeliveryCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxDeliveryCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("deadLetterDestinationWithResourceIdentity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deadLetterDestinationWithResourceIdentity = DeadLetterWithResourceIdentity.DeserializeDeadLetterWithResourceIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("eventTimeToLive"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    eventTimeToLive = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new QueueInfo(Optional.ToNullable(receiveLockDurationInSeconds), Optional.ToNullable(maxDeliveryCount), deadLetterDestinationWithResourceIdentity.Value, Optional.ToNullable(eventTimeToLive), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<QueueInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QueueInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(QueueInfo)} does not support '{options.Format}' format.");
            }
        }

        QueueInfo IPersistableModel<QueueInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QueueInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeQueueInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(QueueInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<QueueInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
