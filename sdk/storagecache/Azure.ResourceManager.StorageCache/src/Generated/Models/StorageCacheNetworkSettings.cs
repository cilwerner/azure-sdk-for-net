// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using Azure.Core;

namespace Azure.ResourceManager.StorageCache.Models
{
    /// <summary> Cache network settings. </summary>
    public partial class StorageCacheNetworkSettings
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

        /// <summary> Initializes a new instance of <see cref="StorageCacheNetworkSettings"/>. </summary>
        public StorageCacheNetworkSettings()
        {
            UtilityAddresses = new ChangeTrackingList<IPAddress>();
            DnsServers = new ChangeTrackingList<IPAddress>();
        }

        /// <summary> Initializes a new instance of <see cref="StorageCacheNetworkSettings"/>. </summary>
        /// <param name="mtu"> The IPv4 maximum transmission unit configured for the subnet. </param>
        /// <param name="utilityAddresses"> Array of additional IP addresses used by this cache. </param>
        /// <param name="dnsServers"> DNS servers for the cache to use.  It will be set from the network configuration if no value is provided. </param>
        /// <param name="dnsSearchDomain"> DNS search domain. </param>
        /// <param name="ntpServer"> NTP server IP Address or FQDN for the cache to use. The default is time.windows.com. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageCacheNetworkSettings(int? mtu, IReadOnlyList<IPAddress> utilityAddresses, IList<IPAddress> dnsServers, string dnsSearchDomain, string ntpServer, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Mtu = mtu;
            UtilityAddresses = utilityAddresses;
            DnsServers = dnsServers;
            DnsSearchDomain = dnsSearchDomain;
            NtpServer = ntpServer;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The IPv4 maximum transmission unit configured for the subnet. </summary>
        public int? Mtu { get; set; }
        /// <summary> Array of additional IP addresses used by this cache. </summary>
        public IReadOnlyList<IPAddress> UtilityAddresses { get; }
        /// <summary> DNS servers for the cache to use.  It will be set from the network configuration if no value is provided. </summary>
        public IList<IPAddress> DnsServers { get; }
        /// <summary> DNS search domain. </summary>
        public string DnsSearchDomain { get; set; }
        /// <summary> NTP server IP Address or FQDN for the cache to use. The default is time.windows.com. </summary>
        public string NtpServer { get; set; }
    }
}
