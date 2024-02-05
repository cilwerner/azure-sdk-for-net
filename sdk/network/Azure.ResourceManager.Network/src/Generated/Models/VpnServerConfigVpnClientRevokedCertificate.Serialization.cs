// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class VpnServerConfigVpnClientRevokedCertificate : IUtf8JsonSerializable, IJsonModel<VpnServerConfigVpnClientRevokedCertificate>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VpnServerConfigVpnClientRevokedCertificate>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VpnServerConfigVpnClientRevokedCertificate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnServerConfigVpnClientRevokedCertificate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VpnServerConfigVpnClientRevokedCertificate)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Thumbprint))
            {
                writer.WritePropertyName("thumbprint"u8);
                writer.WriteStringValue(Thumbprint);
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

        VpnServerConfigVpnClientRevokedCertificate IJsonModel<VpnServerConfigVpnClientRevokedCertificate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnServerConfigVpnClientRevokedCertificate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VpnServerConfigVpnClientRevokedCertificate)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVpnServerConfigVpnClientRevokedCertificate(document.RootElement, options);
        }

        internal static VpnServerConfigVpnClientRevokedCertificate DeserializeVpnServerConfigVpnClientRevokedCertificate(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> thumbprint = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("thumbprint"u8))
                {
                    thumbprint = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VpnServerConfigVpnClientRevokedCertificate(name.Value, thumbprint.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VpnServerConfigVpnClientRevokedCertificate>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnServerConfigVpnClientRevokedCertificate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VpnServerConfigVpnClientRevokedCertificate)} does not support '{options.Format}' format.");
            }
        }

        VpnServerConfigVpnClientRevokedCertificate IPersistableModel<VpnServerConfigVpnClientRevokedCertificate>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnServerConfigVpnClientRevokedCertificate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVpnServerConfigVpnClientRevokedCertificate(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VpnServerConfigVpnClientRevokedCertificate)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VpnServerConfigVpnClientRevokedCertificate>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
