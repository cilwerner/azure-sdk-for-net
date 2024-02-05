// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.KeyVault.Models
{
    public partial class ManagedHSMSecurityDomainProperties : IUtf8JsonSerializable, IJsonModel<ManagedHSMSecurityDomainProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedHSMSecurityDomainProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagedHSMSecurityDomainProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedHSMSecurityDomainProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedHSMSecurityDomainProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ActivationStatus))
            {
                writer.WritePropertyName("activationStatus"u8);
                writer.WriteStringValue(ActivationStatus.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ActivationStatusMessage))
            {
                writer.WritePropertyName("activationStatusMessage"u8);
                writer.WriteStringValue(ActivationStatusMessage);
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

        ManagedHSMSecurityDomainProperties IJsonModel<ManagedHSMSecurityDomainProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedHSMSecurityDomainProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedHSMSecurityDomainProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedHSMSecurityDomainProperties(document.RootElement, options);
        }

        internal static ManagedHSMSecurityDomainProperties DeserializeManagedHSMSecurityDomainProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ManagedHSMSecurityDomainActivationStatus> activationStatus = default;
            Optional<string> activationStatusMessage = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("activationStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    activationStatus = new ManagedHSMSecurityDomainActivationStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("activationStatusMessage"u8))
                {
                    activationStatusMessage = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManagedHSMSecurityDomainProperties(Optional.ToNullable(activationStatus), activationStatusMessage.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedHSMSecurityDomainProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedHSMSecurityDomainProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagedHSMSecurityDomainProperties)} does not support '{options.Format}' format.");
            }
        }

        ManagedHSMSecurityDomainProperties IPersistableModel<ManagedHSMSecurityDomainProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedHSMSecurityDomainProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedHSMSecurityDomainProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedHSMSecurityDomainProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedHSMSecurityDomainProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
