// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The configuration settings of the Apple provider. </summary>
    public partial class AppServiceAppleProvider
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

        /// <summary> Initializes a new instance of <see cref="AppServiceAppleProvider"/>. </summary>
        public AppServiceAppleProvider()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppServiceAppleProvider"/>. </summary>
        /// <param name="isEnabled"> &lt;code&gt;false&lt;/code&gt; if the Apple provider should not be enabled despite the set registration; otherwise, &lt;code&gt;true&lt;/code&gt;. </param>
        /// <param name="registration"> The configuration settings of the Apple registration. </param>
        /// <param name="login"> The configuration settings of the login flow. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AppServiceAppleProvider(bool? isEnabled, AppServiceAppleRegistration registration, LoginScopes login, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsEnabled = isEnabled;
            Registration = registration;
            Login = login;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> &lt;code&gt;false&lt;/code&gt; if the Apple provider should not be enabled despite the set registration; otherwise, &lt;code&gt;true&lt;/code&gt;. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary> The configuration settings of the Apple registration. </summary>
        public AppServiceAppleRegistration Registration { get; set; }
        /// <summary> The configuration settings of the login flow. </summary>
        internal LoginScopes Login { get; set; }
        /// <summary> A list of the scopes that should be requested while authenticating. </summary>
        public IList<string> LoginScopes
        {
            get
            {
                if (Login is null)
                    Login = new LoginScopes();
                return Login.Scopes;
            }
        }
    }
}
