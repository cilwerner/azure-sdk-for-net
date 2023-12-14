// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Resources
{
    public partial class ManagementGroupPolicyDefinitionResource : IJsonModel<PolicyDefinitionData>
    {
        void IJsonModel<PolicyDefinitionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        PolicyDefinitionData IJsonModel<PolicyDefinitionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<PolicyDefinitionData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<PolicyDefinitionData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        PolicyDefinitionData IPersistableModel<PolicyDefinitionData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<PolicyDefinitionData>(data, options);
        }

        string IPersistableModel<PolicyDefinitionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
