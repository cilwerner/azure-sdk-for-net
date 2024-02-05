// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppAzureActiveDirectoryRegistrationConfiguration : IUtf8JsonSerializable, IJsonModel<ContainerAppAzureActiveDirectoryRegistrationConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppAzureActiveDirectoryRegistrationConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerAppAzureActiveDirectoryRegistrationConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppAzureActiveDirectoryRegistrationConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppAzureActiveDirectoryRegistrationConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(OpenIdIssuer))
            {
                writer.WritePropertyName("openIdIssuer"u8);
                writer.WriteStringValue(OpenIdIssuer);
            }
            if (Optional.IsDefined(ClientId))
            {
                writer.WritePropertyName("clientId"u8);
                writer.WriteStringValue(ClientId);
            }
            if (Optional.IsDefined(ClientSecretSettingName))
            {
                writer.WritePropertyName("clientSecretSettingName"u8);
                writer.WriteStringValue(ClientSecretSettingName);
            }
            if (Optional.IsDefined(ClientSecretCertificateThumbprint))
            {
                writer.WritePropertyName("clientSecretCertificateThumbprint"u8);
                writer.WriteStringValue(ClientSecretCertificateThumbprint);
            }
            if (Optional.IsDefined(ClientSecretCertificateSubjectAlternativeName))
            {
                writer.WritePropertyName("clientSecretCertificateSubjectAlternativeName"u8);
                writer.WriteStringValue(ClientSecretCertificateSubjectAlternativeName);
            }
            if (Optional.IsDefined(ClientSecretCertificateIssuer))
            {
                writer.WritePropertyName("clientSecretCertificateIssuer"u8);
                writer.WriteStringValue(ClientSecretCertificateIssuer);
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

        ContainerAppAzureActiveDirectoryRegistrationConfiguration IJsonModel<ContainerAppAzureActiveDirectoryRegistrationConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppAzureActiveDirectoryRegistrationConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppAzureActiveDirectoryRegistrationConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppAzureActiveDirectoryRegistrationConfiguration(document.RootElement, options);
        }

        internal static ContainerAppAzureActiveDirectoryRegistrationConfiguration DeserializeContainerAppAzureActiveDirectoryRegistrationConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> openIdIssuer = default;
            Optional<string> clientId = default;
            Optional<string> clientSecretSettingName = default;
            Optional<string> clientSecretCertificateThumbprint = default;
            Optional<string> clientSecretCertificateSubjectAlternativeName = default;
            Optional<string> clientSecretCertificateIssuer = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("openIdIssuer"u8))
                {
                    openIdIssuer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientId"u8))
                {
                    clientId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientSecretSettingName"u8))
                {
                    clientSecretSettingName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientSecretCertificateThumbprint"u8))
                {
                    clientSecretCertificateThumbprint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientSecretCertificateSubjectAlternativeName"u8))
                {
                    clientSecretCertificateSubjectAlternativeName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientSecretCertificateIssuer"u8))
                {
                    clientSecretCertificateIssuer = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerAppAzureActiveDirectoryRegistrationConfiguration(openIdIssuer.Value, clientId.Value, clientSecretSettingName.Value, clientSecretCertificateThumbprint.Value, clientSecretCertificateSubjectAlternativeName.Value, clientSecretCertificateIssuer.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerAppAzureActiveDirectoryRegistrationConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppAzureActiveDirectoryRegistrationConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerAppAzureActiveDirectoryRegistrationConfiguration)} does not support '{options.Format}' format.");
            }
        }

        ContainerAppAzureActiveDirectoryRegistrationConfiguration IPersistableModel<ContainerAppAzureActiveDirectoryRegistrationConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppAzureActiveDirectoryRegistrationConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerAppAzureActiveDirectoryRegistrationConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerAppAzureActiveDirectoryRegistrationConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppAzureActiveDirectoryRegistrationConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
