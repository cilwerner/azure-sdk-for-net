// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The configuration settings of the Azure Active Directory login flow. </summary>
    public partial class AppServiceAadLoginFlow
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

        /// <summary> Initializes a new instance of <see cref="AppServiceAadLoginFlow"/>. </summary>
        public AppServiceAadLoginFlow()
        {
            LoginParameters = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="AppServiceAadLoginFlow"/>. </summary>
        /// <param name="loginParameters">
        /// Login parameters to send to the OpenID Connect authorization endpoint when
        /// a user logs in. Each parameter must be in the form "key=value".
        /// </param>
        /// <param name="isWwwAuthenticateDisabled"> &lt;code&gt;true&lt;/code&gt; if the www-authenticate provider should be omitted from the request; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AppServiceAadLoginFlow(IList<string> loginParameters, bool? isWwwAuthenticateDisabled, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            LoginParameters = loginParameters;
            IsWwwAuthenticateDisabled = isWwwAuthenticateDisabled;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// Login parameters to send to the OpenID Connect authorization endpoint when
        /// a user logs in. Each parameter must be in the form "key=value".
        /// </summary>
        public IList<string> LoginParameters { get; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if the www-authenticate provider should be omitted from the request; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? IsWwwAuthenticateDisabled { get; set; }
    }
}
