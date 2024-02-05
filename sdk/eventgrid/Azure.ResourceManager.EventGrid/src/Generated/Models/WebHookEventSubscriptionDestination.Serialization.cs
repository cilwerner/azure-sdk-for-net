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
    public partial class WebHookEventSubscriptionDestination : IUtf8JsonSerializable, IJsonModel<WebHookEventSubscriptionDestination>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WebHookEventSubscriptionDestination>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WebHookEventSubscriptionDestination>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebHookEventSubscriptionDestination>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebHookEventSubscriptionDestination)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("endpointType"u8);
            writer.WriteStringValue(EndpointType.ToString());
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Endpoint))
            {
                writer.WritePropertyName("endpointUrl"u8);
                writer.WriteStringValue(Endpoint.AbsoluteUri);
            }
            if (options.Format != "W" && Optional.IsDefined(BaseEndpoint))
            {
                writer.WritePropertyName("endpointBaseUrl"u8);
                writer.WriteStringValue(BaseEndpoint.AbsoluteUri);
            }
            if (Optional.IsDefined(MaxEventsPerBatch))
            {
                writer.WritePropertyName("maxEventsPerBatch"u8);
                writer.WriteNumberValue(MaxEventsPerBatch.Value);
            }
            if (Optional.IsDefined(PreferredBatchSizeInKilobytes))
            {
                writer.WritePropertyName("preferredBatchSizeInKilobytes"u8);
                writer.WriteNumberValue(PreferredBatchSizeInKilobytes.Value);
            }
            if (Optional.IsDefined(AzureActiveDirectoryTenantId))
            {
                writer.WritePropertyName("azureActiveDirectoryTenantId"u8);
                writer.WriteStringValue(AzureActiveDirectoryTenantId.Value);
            }
            if (Optional.IsDefined(UriOrAzureActiveDirectoryApplicationId))
            {
                writer.WritePropertyName("azureActiveDirectoryApplicationIdOrUri"u8);
                writer.WriteStringValue(UriOrAzureActiveDirectoryApplicationId);
            }
            if (Optional.IsCollectionDefined(DeliveryAttributeMappings))
            {
                writer.WritePropertyName("deliveryAttributeMappings"u8);
                writer.WriteStartArray();
                foreach (var item in DeliveryAttributeMappings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(MinimumTlsVersionAllowed))
            {
                writer.WritePropertyName("minimumTlsVersionAllowed"u8);
                writer.WriteStringValue(MinimumTlsVersionAllowed.Value.ToString());
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

        WebHookEventSubscriptionDestination IJsonModel<WebHookEventSubscriptionDestination>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebHookEventSubscriptionDestination>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebHookEventSubscriptionDestination)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWebHookEventSubscriptionDestination(document.RootElement, options);
        }

        internal static WebHookEventSubscriptionDestination DeserializeWebHookEventSubscriptionDestination(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            EndpointType endpointType = default;
            Optional<Uri> endpointUri = default;
            Optional<Uri> endpointBaseUri = default;
            Optional<int> maxEventsPerBatch = default;
            Optional<int> preferredBatchSizeInKilobytes = default;
            Optional<Guid> azureActiveDirectoryTenantId = default;
            Optional<string> azureActiveDirectoryApplicationIdOrUri = default;
            Optional<IList<DeliveryAttributeMapping>> deliveryAttributeMappings = default;
            Optional<TlsVersion> minimumTlsVersionAllowed = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("endpointType"u8))
                {
                    endpointType = new EndpointType(property.Value.GetString());
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
                        if (property0.NameEquals("endpointUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            endpointUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("endpointBaseUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            endpointBaseUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("maxEventsPerBatch"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxEventsPerBatch = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("preferredBatchSizeInKilobytes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            preferredBatchSizeInKilobytes = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("azureActiveDirectoryTenantId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            azureActiveDirectoryTenantId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("azureActiveDirectoryApplicationIdOrUri"u8))
                        {
                            azureActiveDirectoryApplicationIdOrUri = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("deliveryAttributeMappings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DeliveryAttributeMapping> array = new List<DeliveryAttributeMapping>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DeliveryAttributeMapping.DeserializeDeliveryAttributeMapping(item));
                            }
                            deliveryAttributeMappings = array;
                            continue;
                        }
                        if (property0.NameEquals("minimumTlsVersionAllowed"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            minimumTlsVersionAllowed = new TlsVersion(property0.Value.GetString());
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
            return new WebHookEventSubscriptionDestination(endpointType, serializedAdditionalRawData, endpointUri.Value, endpointBaseUri.Value, Optional.ToNullable(maxEventsPerBatch), Optional.ToNullable(preferredBatchSizeInKilobytes), Optional.ToNullable(azureActiveDirectoryTenantId), azureActiveDirectoryApplicationIdOrUri.Value, Optional.ToList(deliveryAttributeMappings), Optional.ToNullable(minimumTlsVersionAllowed));
        }

        BinaryData IPersistableModel<WebHookEventSubscriptionDestination>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebHookEventSubscriptionDestination>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WebHookEventSubscriptionDestination)} does not support '{options.Format}' format.");
            }
        }

        WebHookEventSubscriptionDestination IPersistableModel<WebHookEventSubscriptionDestination>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebHookEventSubscriptionDestination>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWebHookEventSubscriptionDestination(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WebHookEventSubscriptionDestination)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<WebHookEventSubscriptionDestination>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
