// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Blueprint.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Blueprint
{
    /// <summary>
    /// A class representing the PublishedBlueprint data model.
    /// Represents a published blueprint.
    /// </summary>
    public partial class PublishedBlueprintData : ResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="PublishedBlueprintData"/>. </summary>
        public PublishedBlueprintData()
        {
            Parameters = new ChangeTrackingDictionary<string, ParameterDefinition>();
            ResourceGroups = new ChangeTrackingDictionary<string, ResourceGroupDefinition>();
        }

        /// <summary> Initializes a new instance of <see cref="PublishedBlueprintData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="displayName"> One-liner string explain this resource. </param>
        /// <param name="description"> Multi-line explain this resource. </param>
        /// <param name="status"> Status of the blueprint. This field is readonly. </param>
        /// <param name="targetScope"> The scope where this blueprint definition can be assigned. </param>
        /// <param name="parameters"> Parameters required by this blueprint definition. </param>
        /// <param name="resourceGroups"> Resource group placeholders defined by this blueprint definition. </param>
        /// <param name="blueprintName"> Name of the published blueprint definition. </param>
        /// <param name="changeNotes"> Version-specific change notes. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PublishedBlueprintData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string displayName, string description, BlueprintStatus status, BlueprintTargetScope? targetScope, IDictionary<string, ParameterDefinition> parameters, IDictionary<string, ResourceGroupDefinition> resourceGroups, string blueprintName, string changeNotes, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            DisplayName = displayName;
            Description = description;
            Status = status;
            TargetScope = targetScope;
            Parameters = parameters;
            ResourceGroups = resourceGroups;
            BlueprintName = blueprintName;
            ChangeNotes = changeNotes;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> One-liner string explain this resource. </summary>
        public string DisplayName { get; set; }
        /// <summary> Multi-line explain this resource. </summary>
        public string Description { get; set; }
        /// <summary> Status of the blueprint. This field is readonly. </summary>
        public BlueprintStatus Status { get; }
        /// <summary> The scope where this blueprint definition can be assigned. </summary>
        public BlueprintTargetScope? TargetScope { get; set; }
        /// <summary> Parameters required by this blueprint definition. </summary>
        public IDictionary<string, ParameterDefinition> Parameters { get; }
        /// <summary> Resource group placeholders defined by this blueprint definition. </summary>
        public IDictionary<string, ResourceGroupDefinition> ResourceGroups { get; }
        /// <summary> Name of the published blueprint definition. </summary>
        public string BlueprintName { get; set; }
        /// <summary> Version-specific change notes. </summary>
        public string ChangeNotes { get; set; }
    }
}
