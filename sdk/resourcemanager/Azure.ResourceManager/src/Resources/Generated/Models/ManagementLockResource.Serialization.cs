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
    public partial class ManagementLockResource : IJsonModel<ManagementLockData>
    {
        void IJsonModel<ManagementLockData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        ManagementLockData IJsonModel<ManagementLockData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<ManagementLockData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<ManagementLockData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        ManagementLockData IPersistableModel<ManagementLockData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<ManagementLockData>(data, options);
        }

        string IPersistableModel<ManagementLockData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
