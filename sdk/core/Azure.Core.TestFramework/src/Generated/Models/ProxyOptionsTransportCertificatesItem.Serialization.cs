// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Core.TestFramework.Models
{
    public partial class ProxyOptionsTransportCertificatesItem : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PemValue))
            {
                writer.WritePropertyName("PemValue"u8);
                writer.WriteStringValue(PemValue);
            }
            if (Optional.IsDefined(PemKey))
            {
                writer.WritePropertyName("PemKey"u8);
                writer.WriteStringValue(PemKey);
            }
            writer.WriteEndObject();
        }
    }
}
