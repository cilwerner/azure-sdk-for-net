// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> Workspace properties that can be patched. </summary>
    public partial class VirtualWorkspacePatch
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

        /// <summary> Initializes a new instance of <see cref="VirtualWorkspacePatch"/>. </summary>
        public VirtualWorkspacePatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            ApplicationGroupReferences = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualWorkspacePatch"/>. </summary>
        /// <param name="tags"> tags to be updated. </param>
        /// <param name="description"> Description of Workspace. </param>
        /// <param name="friendlyName"> Friendly name of Workspace. </param>
        /// <param name="applicationGroupReferences"> List of applicationGroup links. </param>
        /// <param name="publicNetworkAccess"> Enabled to allow this resource to be access from the public network. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualWorkspacePatch(IDictionary<string, string> tags, string description, string friendlyName, IList<string> applicationGroupReferences, DesktopVirtualizationPublicNetworkAccess? publicNetworkAccess, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Tags = tags;
            Description = description;
            FriendlyName = friendlyName;
            ApplicationGroupReferences = applicationGroupReferences;
            PublicNetworkAccess = publicNetworkAccess;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> tags to be updated. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Description of Workspace. </summary>
        public string Description { get; set; }
        /// <summary> Friendly name of Workspace. </summary>
        public string FriendlyName { get; set; }
        /// <summary> List of applicationGroup links. </summary>
        public IList<string> ApplicationGroupReferences { get; }
        /// <summary> Enabled to allow this resource to be access from the public network. </summary>
        public DesktopVirtualizationPublicNetworkAccess? PublicNetworkAccess { get; set; }
    }
}
