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
    public partial class StorageAccountDetails : IUtf8JsonSerializable, IJsonModel<StorageAccountDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StorageAccountDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StorageAccountDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageAccountDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageAccountDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SystemCreatedStorageAccount))
            {
                if (SystemCreatedStorageAccount != null)
                {
                    writer.WritePropertyName("systemCreatedStorageAccount"u8);
                    writer.WriteObjectValue(SystemCreatedStorageAccount);
                }
                else
                {
                    writer.WriteNull("systemCreatedStorageAccount");
                }
            }
            if (Optional.IsDefined(UserCreatedStorageAccount))
            {
                if (UserCreatedStorageAccount != null)
                {
                    writer.WritePropertyName("userCreatedStorageAccount"u8);
                    writer.WriteObjectValue(UserCreatedStorageAccount);
                }
                else
                {
                    writer.WriteNull("userCreatedStorageAccount");
                }
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

        StorageAccountDetails IJsonModel<StorageAccountDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageAccountDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageAccountDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageAccountDetails(document.RootElement, options);
        }

        internal static StorageAccountDetails DeserializeStorageAccountDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SystemCreatedStorageAccount> systemCreatedStorageAccount = default;
            Optional<UserCreatedStorageAccount> userCreatedStorageAccount = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("systemCreatedStorageAccount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        systemCreatedStorageAccount = null;
                        continue;
                    }
                    systemCreatedStorageAccount = SystemCreatedStorageAccount.DeserializeSystemCreatedStorageAccount(property.Value);
                    continue;
                }
                if (property.NameEquals("userCreatedStorageAccount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        userCreatedStorageAccount = null;
                        continue;
                    }
                    userCreatedStorageAccount = UserCreatedStorageAccount.DeserializeUserCreatedStorageAccount(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StorageAccountDetails(systemCreatedStorageAccount.Value, userCreatedStorageAccount.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StorageAccountDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageAccountDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StorageAccountDetails)} does not support '{options.Format}' format.");
            }
        }

        StorageAccountDetails IPersistableModel<StorageAccountDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageAccountDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStorageAccountDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StorageAccountDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<StorageAccountDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
