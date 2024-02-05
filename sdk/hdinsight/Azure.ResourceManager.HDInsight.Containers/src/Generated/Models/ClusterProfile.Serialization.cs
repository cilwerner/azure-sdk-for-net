// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    public partial class ClusterProfile : IUtf8JsonSerializable, IJsonModel<ClusterProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ClusterProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ClusterProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterProfile)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("clusterVersion"u8);
            writer.WriteStringValue(ClusterVersion);
            writer.WritePropertyName("ossVersion"u8);
            writer.WriteStringValue(OssVersion);
            if (options.Format != "W" && Optional.IsCollectionDefined(Components))
            {
                writer.WritePropertyName("components"u8);
                writer.WriteStartArray();
                foreach (var item in Components)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("identityProfile"u8);
            writer.WriteObjectValue(IdentityProfile);
            writer.WritePropertyName("authorizationProfile"u8);
            writer.WriteObjectValue(AuthorizationProfile);
            if (Optional.IsDefined(SecretsProfile))
            {
                writer.WritePropertyName("secretsProfile"u8);
                writer.WriteObjectValue(SecretsProfile);
            }
            if (Optional.IsCollectionDefined(ServiceConfigsProfiles))
            {
                writer.WritePropertyName("serviceConfigsProfiles"u8);
                writer.WriteStartArray();
                foreach (var item in ServiceConfigsProfiles)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ConnectivityProfile))
            {
                writer.WritePropertyName("connectivityProfile"u8);
                writer.WriteObjectValue(ConnectivityProfile);
            }
            if (Optional.IsDefined(LogAnalyticsProfile))
            {
                writer.WritePropertyName("logAnalyticsProfile"u8);
                writer.WriteObjectValue(LogAnalyticsProfile);
            }
            if (Optional.IsDefined(PrometheusProfile))
            {
                writer.WritePropertyName("prometheusProfile"u8);
                writer.WriteObjectValue(PrometheusProfile);
            }
            if (Optional.IsDefined(SshProfile))
            {
                writer.WritePropertyName("sshProfile"u8);
                writer.WriteObjectValue(SshProfile);
            }
            if (Optional.IsDefined(AutoscaleProfile))
            {
                writer.WritePropertyName("autoscaleProfile"u8);
                writer.WriteObjectValue(AutoscaleProfile);
            }
            if (Optional.IsCollectionDefined(KafkaProfile))
            {
                writer.WritePropertyName("kafkaProfile"u8);
                writer.WriteStartObject();
                foreach (var item in KafkaProfile)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(TrinoProfile))
            {
                writer.WritePropertyName("trinoProfile"u8);
                writer.WriteObjectValue(TrinoProfile);
            }
            if (Optional.IsCollectionDefined(LlapProfile))
            {
                writer.WritePropertyName("llapProfile"u8);
                writer.WriteStartObject();
                foreach (var item in LlapProfile)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(FlinkProfile))
            {
                writer.WritePropertyName("flinkProfile"u8);
                writer.WriteObjectValue(FlinkProfile);
            }
            if (Optional.IsDefined(SparkProfile))
            {
                writer.WritePropertyName("sparkProfile"u8);
                writer.WriteObjectValue(SparkProfile);
            }
            if (Optional.IsCollectionDefined(StubProfile))
            {
                writer.WritePropertyName("stubProfile"u8);
                writer.WriteStartObject();
                foreach (var item in StubProfile)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(ScriptActionProfiles))
            {
                writer.WritePropertyName("scriptActionProfiles"u8);
                writer.WriteStartArray();
                foreach (var item in ScriptActionProfiles)
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

        ClusterProfile IJsonModel<ClusterProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterProfile)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeClusterProfile(document.RootElement, options);
        }

        internal static ClusterProfile DeserializeClusterProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string clusterVersion = default;
            string ossVersion = default;
            Optional<IReadOnlyList<ClusterComponentItem>> components = default;
            HDInsightIdentityProfile identityProfile = default;
            AuthorizationProfile authorizationProfile = default;
            Optional<ClusterSecretsProfile> secretsProfile = default;
            Optional<IList<ClusterServiceConfigsProfile>> serviceConfigsProfiles = default;
            Optional<ClusterConnectivityProfile> connectivityProfile = default;
            Optional<ClusterLogAnalyticsProfile> logAnalyticsProfile = default;
            Optional<ClusterPrometheusProfile> prometheusProfile = default;
            Optional<ClusterSshProfile> sshProfile = default;
            Optional<ClusterAutoscaleProfile> autoscaleProfile = default;
            Optional<IDictionary<string, BinaryData>> kafkaProfile = default;
            Optional<TrinoProfile> trinoProfile = default;
            Optional<IDictionary<string, BinaryData>> llapProfile = default;
            Optional<FlinkProfile> flinkProfile = default;
            Optional<SparkProfile> sparkProfile = default;
            Optional<IDictionary<string, BinaryData>> stubProfile = default;
            Optional<IList<ScriptActionProfile>> scriptActionProfiles = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clusterVersion"u8))
                {
                    clusterVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ossVersion"u8))
                {
                    ossVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("components"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ClusterComponentItem> array = new List<ClusterComponentItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ClusterComponentItem.DeserializeClusterComponentItem(item));
                    }
                    components = array;
                    continue;
                }
                if (property.NameEquals("identityProfile"u8))
                {
                    identityProfile = HDInsightIdentityProfile.DeserializeHDInsightIdentityProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("authorizationProfile"u8))
                {
                    authorizationProfile = AuthorizationProfile.DeserializeAuthorizationProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("secretsProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    secretsProfile = ClusterSecretsProfile.DeserializeClusterSecretsProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("serviceConfigsProfiles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ClusterServiceConfigsProfile> array = new List<ClusterServiceConfigsProfile>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ClusterServiceConfigsProfile.DeserializeClusterServiceConfigsProfile(item));
                    }
                    serviceConfigsProfiles = array;
                    continue;
                }
                if (property.NameEquals("connectivityProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectivityProfile = ClusterConnectivityProfile.DeserializeClusterConnectivityProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("logAnalyticsProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logAnalyticsProfile = ClusterLogAnalyticsProfile.DeserializeClusterLogAnalyticsProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("prometheusProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    prometheusProfile = ClusterPrometheusProfile.DeserializeClusterPrometheusProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("sshProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sshProfile = ClusterSshProfile.DeserializeClusterSshProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("autoscaleProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoscaleProfile = ClusterAutoscaleProfile.DeserializeClusterAutoscaleProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("kafkaProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, BinaryData.FromString(property0.Value.GetRawText()));
                        }
                    }
                    kafkaProfile = dictionary;
                    continue;
                }
                if (property.NameEquals("trinoProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    trinoProfile = TrinoProfile.DeserializeTrinoProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("llapProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, BinaryData.FromString(property0.Value.GetRawText()));
                        }
                    }
                    llapProfile = dictionary;
                    continue;
                }
                if (property.NameEquals("flinkProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    flinkProfile = FlinkProfile.DeserializeFlinkProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("sparkProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sparkProfile = SparkProfile.DeserializeSparkProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("stubProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, BinaryData.FromString(property0.Value.GetRawText()));
                        }
                    }
                    stubProfile = dictionary;
                    continue;
                }
                if (property.NameEquals("scriptActionProfiles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ScriptActionProfile> array = new List<ScriptActionProfile>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ScriptActionProfile.DeserializeScriptActionProfile(item));
                    }
                    scriptActionProfiles = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ClusterProfile(clusterVersion, ossVersion, Optional.ToList(components), identityProfile, authorizationProfile, secretsProfile.Value, Optional.ToList(serviceConfigsProfiles), connectivityProfile.Value, logAnalyticsProfile.Value, prometheusProfile.Value, sshProfile.Value, autoscaleProfile.Value, Optional.ToDictionary(kafkaProfile), trinoProfile.Value, Optional.ToDictionary(llapProfile), flinkProfile.Value, sparkProfile.Value, Optional.ToDictionary(stubProfile), Optional.ToList(scriptActionProfiles), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ClusterProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ClusterProfile)} does not support '{options.Format}' format.");
            }
        }

        ClusterProfile IPersistableModel<ClusterProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeClusterProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ClusterProfile)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ClusterProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
