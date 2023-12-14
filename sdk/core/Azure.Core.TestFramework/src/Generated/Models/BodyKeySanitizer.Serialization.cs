// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Core.TestFramework.Models
{
    public partial class BodyKeySanitizer : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(JsonPath))
            {
                writer.WritePropertyName("jsonPath"u8);
                writer.WriteStringValue(JsonPath);
            }
            writer.WritePropertyName("value"u8);
            writer.WriteStringValue(Value);
            if (Optional.IsDefined(Regex))
            {
                writer.WritePropertyName("regex"u8);
                writer.WriteStringValue(Regex);
            }
            if (Optional.IsDefined(GroupForReplace))
            {
                writer.WritePropertyName("groupForReplace"u8);
                writer.WriteStringValue(GroupForReplace);
            }
            writer.WriteEndObject();
        }
    }
}
