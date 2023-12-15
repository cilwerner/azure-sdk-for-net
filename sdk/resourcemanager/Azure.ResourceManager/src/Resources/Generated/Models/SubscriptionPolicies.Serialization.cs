// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class SubscriptionPolicies : IUtf8JsonSerializable, IJsonModel<SubscriptionPolicies>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SubscriptionPolicies>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SubscriptionPolicies>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SubscriptionPolicies>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(SubscriptionPolicies)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(LocationPlacementId))
            {
                writer.WritePropertyName("locationPlacementId"u8);
                writer.WriteStringValue(LocationPlacementId);
            }
            if (options.Format != "W" && Optional.IsDefined(QuotaId))
            {
                writer.WritePropertyName("quotaId"u8);
                writer.WriteStringValue(QuotaId);
            }
            if (options.Format != "W" && Optional.IsDefined(SpendingLimit))
            {
                writer.WritePropertyName("spendingLimit"u8);
                writer.WriteStringValue(SpendingLimit.Value.ToSerialString());
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

        SubscriptionPolicies IJsonModel<SubscriptionPolicies>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SubscriptionPolicies>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(SubscriptionPolicies)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSubscriptionPolicies(document.RootElement, options);
        }

        internal static SubscriptionPolicies DeserializeSubscriptionPolicies(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> locationPlacementId = default;
            Optional<string> quotaId = default;
            Optional<SpendingLimit> spendingLimit = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("locationPlacementId"u8))
                {
                    locationPlacementId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("quotaId"u8))
                {
                    quotaId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("spendingLimit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    spendingLimit = property.Value.GetString().ToSpendingLimit();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SubscriptionPolicies(locationPlacementId.Value, quotaId.Value, Optional.ToNullable(spendingLimit), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SubscriptionPolicies>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SubscriptionPolicies>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(SubscriptionPolicies)} does not support '{options.Format}' format.");
            }
        }

        SubscriptionPolicies IPersistableModel<SubscriptionPolicies>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SubscriptionPolicies>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSubscriptionPolicies(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(SubscriptionPolicies)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SubscriptionPolicies>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
