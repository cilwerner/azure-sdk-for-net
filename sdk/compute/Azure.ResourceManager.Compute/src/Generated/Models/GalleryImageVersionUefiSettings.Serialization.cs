// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class GalleryImageVersionUefiSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(SignatureTemplateNames))
            {
                writer.WritePropertyName("signatureTemplateNames"u8);
                writer.WriteStartArray();
                foreach (var item in SignatureTemplateNames)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AdditionalSignatures))
            {
                writer.WritePropertyName("additionalSignatures"u8);
                writer.WriteObjectValue(AdditionalSignatures);
            }
            writer.WriteEndObject();
        }

        internal static GalleryImageVersionUefiSettings DeserializeGalleryImageVersionUefiSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<UefiSignatureTemplateName>> signatureTemplateNames = default;
            Optional<UefiKeySignatures> additionalSignatures = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("signatureTemplateNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<UefiSignatureTemplateName> array = new List<UefiSignatureTemplateName>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new UefiSignatureTemplateName(item.GetString()));
                    }
                    signatureTemplateNames = array;
                    continue;
                }
                if (property.NameEquals("additionalSignatures"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    additionalSignatures = UefiKeySignatures.DeserializeUefiKeySignatures(property.Value);
                    continue;
                }
            }
            return new GalleryImageVersionUefiSettings(Optional.ToList(signatureTemplateNames), additionalSignatures.Value);
        }
    }
}
