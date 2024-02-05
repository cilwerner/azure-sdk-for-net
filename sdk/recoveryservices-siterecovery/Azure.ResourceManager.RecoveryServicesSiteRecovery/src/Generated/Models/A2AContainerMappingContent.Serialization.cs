// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class A2AContainerMappingContent : IUtf8JsonSerializable, IJsonModel<A2AContainerMappingContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<A2AContainerMappingContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<A2AContainerMappingContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2AContainerMappingContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(A2AContainerMappingContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(AgentAutoUpdateStatus))
            {
                writer.WritePropertyName("agentAutoUpdateStatus"u8);
                writer.WriteStringValue(AgentAutoUpdateStatus.Value.ToString());
            }
            if (Optional.IsDefined(AutomationAccountArmId))
            {
                writer.WritePropertyName("automationAccountArmId"u8);
                writer.WriteStringValue(AutomationAccountArmId);
            }
            if (Optional.IsDefined(AutomationAccountAuthenticationType))
            {
                writer.WritePropertyName("automationAccountAuthenticationType"u8);
                writer.WriteStringValue(AutomationAccountAuthenticationType.Value.ToString());
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        A2AContainerMappingContent IJsonModel<A2AContainerMappingContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2AContainerMappingContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(A2AContainerMappingContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeA2AContainerMappingContent(document.RootElement, options);
        }

        internal static A2AContainerMappingContent DeserializeA2AContainerMappingContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SiteRecoveryAgentAutoUpdateStatus> agentAutoUpdateStatus = default;
            Optional<ResourceIdentifier> automationAccountArmId = default;
            Optional<AutomationAccountAuthenticationType> automationAccountAuthenticationType = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("agentAutoUpdateStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    agentAutoUpdateStatus = new SiteRecoveryAgentAutoUpdateStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("automationAccountArmId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    automationAccountArmId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("automationAccountAuthenticationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    automationAccountAuthenticationType = new AutomationAccountAuthenticationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new A2AContainerMappingContent(instanceType, serializedAdditionalRawData, Optional.ToNullable(agentAutoUpdateStatus), automationAccountArmId.Value, Optional.ToNullable(automationAccountAuthenticationType));
        }

        BinaryData IPersistableModel<A2AContainerMappingContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2AContainerMappingContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(A2AContainerMappingContent)} does not support '{options.Format}' format.");
            }
        }

        A2AContainerMappingContent IPersistableModel<A2AContainerMappingContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2AContainerMappingContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeA2AContainerMappingContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(A2AContainerMappingContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<A2AContainerMappingContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
