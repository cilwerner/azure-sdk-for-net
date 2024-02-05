// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Consumption.Models
{
    public partial class ConsumptionLotSummary : IUtf8JsonSerializable, IJsonModel<ConsumptionLotSummary>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConsumptionLotSummary>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ConsumptionLotSummary>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionLotSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConsumptionLotSummary)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("eTag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(OriginalAmount))
            {
                writer.WritePropertyName("originalAmount"u8);
                writer.WriteObjectValue(OriginalAmount);
            }
            if (options.Format != "W" && Optional.IsDefined(ClosedBalance))
            {
                writer.WritePropertyName("closedBalance"u8);
                writer.WriteObjectValue(ClosedBalance);
            }
            if (options.Format != "W" && Optional.IsDefined(Source))
            {
                writer.WritePropertyName("source"u8);
                writer.WriteStringValue(Source.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startDate"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(ExpireOn))
            {
                writer.WritePropertyName("expirationDate"u8);
                writer.WriteStringValue(ExpireOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(PoNumber))
            {
                writer.WritePropertyName("poNumber"u8);
                writer.WriteStringValue(PoNumber);
            }
            if (options.Format != "W" && Optional.IsDefined(PurchasedOn))
            {
                writer.WritePropertyName("purchasedDate"u8);
                writer.WriteStringValue(PurchasedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(CreditCurrency))
            {
                writer.WritePropertyName("creditCurrency"u8);
                writer.WriteStringValue(CreditCurrency);
            }
            if (options.Format != "W" && Optional.IsDefined(BillingCurrency))
            {
                writer.WritePropertyName("billingCurrency"u8);
                writer.WriteStringValue(BillingCurrency);
            }
            if (options.Format != "W" && Optional.IsDefined(OriginalAmountInBillingCurrency))
            {
                writer.WritePropertyName("originalAmountInBillingCurrency"u8);
                writer.WriteObjectValue(OriginalAmountInBillingCurrency);
            }
            if (options.Format != "W" && Optional.IsDefined(ClosedBalanceInBillingCurrency))
            {
                writer.WritePropertyName("closedBalanceInBillingCurrency"u8);
                writer.WriteObjectValue(ClosedBalanceInBillingCurrency);
            }
            if (options.Format != "W" && Optional.IsDefined(Reseller))
            {
                writer.WritePropertyName("reseller"u8);
                writer.WriteObjectValue(Reseller);
            }
            writer.WriteEndObject();
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

        ConsumptionLotSummary IJsonModel<ConsumptionLotSummary>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionLotSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConsumptionLotSummary)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConsumptionLotSummary(document.RootElement, options);
        }

        internal static ConsumptionLotSummary DeserializeConsumptionLotSummary(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ETag> eTag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<ConsumptionAmount> originalAmount = default;
            Optional<ConsumptionAmount> closedBalance = default;
            Optional<ConsumptionLotSource> source = default;
            Optional<DateTimeOffset> startDate = default;
            Optional<DateTimeOffset> expirationDate = default;
            Optional<string> poNumber = default;
            Optional<DateTimeOffset> purchasedDate = default;
            Optional<ConsumptionLotStatus> status = default;
            Optional<string> creditCurrency = default;
            Optional<string> billingCurrency = default;
            Optional<ConsumptionAmountWithExchangeRate> originalAmountInBillingCurrency = default;
            Optional<ConsumptionAmountWithExchangeRate> closedBalanceInBillingCurrency = default;
            Optional<ConsumptionReseller> reseller = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("eTag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    eTag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("originalAmount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            originalAmount = ConsumptionAmount.DeserializeConsumptionAmount(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("closedBalance"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            closedBalance = ConsumptionAmount.DeserializeConsumptionAmount(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("source"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            source = new ConsumptionLotSource(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("startDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            startDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("expirationDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            expirationDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("poNumber"u8))
                        {
                            poNumber = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("purchasedDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            purchasedDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new ConsumptionLotStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("creditCurrency"u8))
                        {
                            creditCurrency = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("billingCurrency"u8))
                        {
                            billingCurrency = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("originalAmountInBillingCurrency"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            originalAmountInBillingCurrency = ConsumptionAmountWithExchangeRate.DeserializeConsumptionAmountWithExchangeRate(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("closedBalanceInBillingCurrency"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            closedBalanceInBillingCurrency = ConsumptionAmountWithExchangeRate.DeserializeConsumptionAmountWithExchangeRate(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("reseller"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            reseller = ConsumptionReseller.DeserializeConsumptionReseller(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ConsumptionLotSummary(id, name, type, systemData.Value, originalAmount.Value, closedBalance.Value, Optional.ToNullable(source), Optional.ToNullable(startDate), Optional.ToNullable(expirationDate), poNumber.Value, Optional.ToNullable(purchasedDate), Optional.ToNullable(status), creditCurrency.Value, billingCurrency.Value, originalAmountInBillingCurrency.Value, closedBalanceInBillingCurrency.Value, reseller.Value, Optional.ToNullable(eTag), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConsumptionLotSummary>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionLotSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConsumptionLotSummary)} does not support '{options.Format}' format.");
            }
        }

        ConsumptionLotSummary IPersistableModel<ConsumptionLotSummary>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionLotSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConsumptionLotSummary(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConsumptionLotSummary)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConsumptionLotSummary>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
