// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Issue update Parameters. </summary>
    public partial class ApiIssuePatch
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

        /// <summary> Initializes a new instance of <see cref="ApiIssuePatch"/>. </summary>
        public ApiIssuePatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ApiIssuePatch"/>. </summary>
        /// <param name="createdOn"> Date and time when the issue was created. </param>
        /// <param name="state"> Status of the issue. </param>
        /// <param name="apiId"> A resource identifier for the API the issue was created for. </param>
        /// <param name="title"> The issue title. </param>
        /// <param name="description"> Text describing the issue. </param>
        /// <param name="userId"> A resource identifier for the user created the issue. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApiIssuePatch(DateTimeOffset? createdOn, IssueState? state, ResourceIdentifier apiId, string title, string description, string userId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CreatedOn = createdOn;
            State = state;
            ApiId = apiId;
            Title = title;
            Description = description;
            UserId = userId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Date and time when the issue was created. </summary>
        public DateTimeOffset? CreatedOn { get; set; }
        /// <summary> Status of the issue. </summary>
        public IssueState? State { get; set; }
        /// <summary> A resource identifier for the API the issue was created for. </summary>
        public ResourceIdentifier ApiId { get; set; }
        /// <summary> The issue title. </summary>
        public string Title { get; set; }
        /// <summary> Text describing the issue. </summary>
        public string Description { get; set; }
        /// <summary> A resource identifier for the user created the issue. </summary>
        public string UserId { get; set; }
    }
}
