// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    public partial class PolicySummaryResults : IUtf8JsonSerializable, IJsonModel<PolicySummaryResults>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PolicySummaryResults>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PolicySummaryResults>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicySummaryResults>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PolicySummaryResults)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(QueryResultsUri))
            {
                writer.WritePropertyName("queryResultsUri"u8);
                writer.WriteStringValue(QueryResultsUri.AbsoluteUri);
            }
            if (Optional.IsDefined(NonCompliantResources))
            {
                writer.WritePropertyName("nonCompliantResources"u8);
                writer.WriteNumberValue(NonCompliantResources.Value);
            }
            if (Optional.IsDefined(NonCompliantPolicies))
            {
                writer.WritePropertyName("nonCompliantPolicies"u8);
                writer.WriteNumberValue(NonCompliantPolicies.Value);
            }
            if (Optional.IsCollectionDefined(ResourceDetails))
            {
                writer.WritePropertyName("resourceDetails"u8);
                writer.WriteStartArray();
                foreach (var item in ResourceDetails)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(PolicyDetails))
            {
                writer.WritePropertyName("policyDetails"u8);
                writer.WriteStartArray();
                foreach (var item in PolicyDetails)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(PolicyGroupDetails))
            {
                writer.WritePropertyName("policyGroupDetails"u8);
                writer.WriteStartArray();
                foreach (var item in PolicyGroupDetails)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        PolicySummaryResults IJsonModel<PolicySummaryResults>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicySummaryResults>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PolicySummaryResults)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePolicySummaryResults(document.RootElement, options);
        }

        internal static PolicySummaryResults DeserializePolicySummaryResults(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Uri> queryResultsUri = default;
            Optional<int> nonCompliantResources = default;
            Optional<int> nonCompliantPolicies = default;
            Optional<IReadOnlyList<ComplianceDetail>> resourceDetails = default;
            Optional<IReadOnlyList<ComplianceDetail>> policyDetails = default;
            Optional<IReadOnlyList<ComplianceDetail>> policyGroupDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("queryResultsUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    queryResultsUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("nonCompliantResources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nonCompliantResources = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("nonCompliantPolicies"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nonCompliantPolicies = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("resourceDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ComplianceDetail> array = new List<ComplianceDetail>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ComplianceDetail.DeserializeComplianceDetail(item));
                    }
                    resourceDetails = array;
                    continue;
                }
                if (property.NameEquals("policyDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ComplianceDetail> array = new List<ComplianceDetail>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ComplianceDetail.DeserializeComplianceDetail(item));
                    }
                    policyDetails = array;
                    continue;
                }
                if (property.NameEquals("policyGroupDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ComplianceDetail> array = new List<ComplianceDetail>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ComplianceDetail.DeserializeComplianceDetail(item));
                    }
                    policyGroupDetails = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PolicySummaryResults(queryResultsUri.Value, Optional.ToNullable(nonCompliantResources), Optional.ToNullable(nonCompliantPolicies), Optional.ToList(resourceDetails), Optional.ToList(policyDetails), Optional.ToList(policyGroupDetails), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PolicySummaryResults>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicySummaryResults>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PolicySummaryResults)} does not support '{options.Format}' format.");
            }
        }

        PolicySummaryResults IPersistableModel<PolicySummaryResults>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicySummaryResults>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePolicySummaryResults(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PolicySummaryResults)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PolicySummaryResults>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
