﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Net.Http;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Communication.CallAutomation
{
    /// <summary>
    /// The latest version of the Call Automation.
    /// </summary>
    public class CallAutomationClientOptions : ClientOptions
    {
        /// <summary>
        /// The latest version of the CallAutomation service.
        /// </summary>
        internal const ServiceVersion LatestVersion = ServiceVersion.V2023_10_15;

        internal string ApiVersion { get; }

        /// <summary>
        /// The caller source of the call automation client.
        /// </summary>
        public CommunicationUserIdentifier Source { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallAutomationClientOptions"/>.
        /// </summary>
        public CallAutomationClientOptions(ServiceVersion version = LatestVersion)
        {
            ApiVersion = version switch
            {
                ServiceVersion.V2023_03_06 => "2023-03-06",
                ServiceVersion.V2023_06_15_Preview => "2023-06-15-preview",
                ServiceVersion.V2023_10_15 => "2023-10-15",
                _ => throw new ArgumentOutOfRangeException(nameof(version)),
            };
        }

        /// <summary>
        /// The CallAutomation service version.
        /// </summary>
        public enum ServiceVersion
        {
            /// <summary>
            /// The GA1 of the CallAutomation service.
            /// </summary>
#pragma warning disable CA1707 // Identifiers should not contain underscores
            V2023_03_06 = 1,

            /// <summary>
            /// The beta2 of the CallAutomation service.
            /// </summary>
            V2023_06_15_Preview = 2,

            /// <summary>
            /// The GA2 of the CallAutomation service.
            /// </summary>
            V2023_10_15 = 3
#pragma warning restore CA1707 // Identifiers should not contain underscores
        }
    }
}
