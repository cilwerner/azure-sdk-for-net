// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageMover.Models
{
    [PersistableModelProxy(typeof(UnknownEndpointBaseProperties))]
    public partial class EndpointBaseProperties : IUtf8JsonSerializable, IJsonModel<EndpointBaseProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EndpointBaseProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<EndpointBaseProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EndpointBaseProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EndpointBaseProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("endpointType"u8);
            writer.WriteStringValue(EndpointType.ToString());
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
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

        EndpointBaseProperties IJsonModel<EndpointBaseProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EndpointBaseProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EndpointBaseProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEndpointBaseProperties(document.RootElement, options);
        }

        internal static EndpointBaseProperties DeserializeEndpointBaseProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("endpointType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureStorageBlobContainer": return AzureStorageBlobContainerEndpointProperties.DeserializeAzureStorageBlobContainerEndpointProperties(element);
                    case "AzureStorageSmbFileShare": return AzureStorageSmbFileShareEndpointProperties.DeserializeAzureStorageSmbFileShareEndpointProperties(element);
                    case "NfsMount": return NfsMountEndpointProperties.DeserializeNfsMountEndpointProperties(element);
                    case "SmbMount": return SmbMountEndpointProperties.DeserializeSmbMountEndpointProperties(element);
                }
            }
            return UnknownEndpointBaseProperties.DeserializeUnknownEndpointBaseProperties(element);
        }

        BinaryData IPersistableModel<EndpointBaseProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EndpointBaseProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EndpointBaseProperties)} does not support '{options.Format}' format.");
            }
        }

        EndpointBaseProperties IPersistableModel<EndpointBaseProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EndpointBaseProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEndpointBaseProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EndpointBaseProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<EndpointBaseProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
