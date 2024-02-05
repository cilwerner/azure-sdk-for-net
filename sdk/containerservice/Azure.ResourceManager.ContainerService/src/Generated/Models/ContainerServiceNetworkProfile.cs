// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Profile of network configuration. </summary>
    public partial class ContainerServiceNetworkProfile
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

        /// <summary> Initializes a new instance of <see cref="ContainerServiceNetworkProfile"/>. </summary>
        public ContainerServiceNetworkProfile()
        {
            PodCidrs = new ChangeTrackingList<string>();
            ServiceCidrs = new ChangeTrackingList<string>();
            IPFamilies = new ChangeTrackingList<IPFamily>();
        }

        /// <summary> Initializes a new instance of <see cref="ContainerServiceNetworkProfile"/>. </summary>
        /// <param name="networkPlugin"> Network plugin used for building the Kubernetes network. </param>
        /// <param name="networkPluginMode"> The mode the network plugin should use. </param>
        /// <param name="networkPolicy"> Network policy used for building the Kubernetes network. </param>
        /// <param name="networkMode"> This cannot be specified if networkPlugin is anything other than 'azure'. </param>
        /// <param name="networkDataplane"> Network dataplane used in the Kubernetes cluster. </param>
        /// <param name="podCidr"> A CIDR notation IP range from which to assign pod IPs when kubenet is used. </param>
        /// <param name="serviceCidr"> A CIDR notation IP range from which to assign service cluster IPs. It must not overlap with any Subnet IP ranges. </param>
        /// <param name="dnsServiceIP"> An IP address assigned to the Kubernetes DNS service. It must be within the Kubernetes service address range specified in serviceCidr. </param>
        /// <param name="outboundType"> This can only be set at cluster creation time and cannot be changed later. For more information see [egress outbound type](https://docs.microsoft.com/azure/aks/egress-outboundtype). </param>
        /// <param name="loadBalancerSku"> The default is 'standard'. See [Azure Load Balancer SKUs](https://docs.microsoft.com/azure/load-balancer/skus) for more information about the differences between load balancer SKUs. </param>
        /// <param name="loadBalancerProfile"> Profile of the cluster load balancer. </param>
        /// <param name="natGatewayProfile"> Profile of the cluster NAT gateway. </param>
        /// <param name="podCidrs"> One IPv4 CIDR is expected for single-stack networking. Two CIDRs, one for each IP family (IPv4/IPv6), is expected for dual-stack networking. </param>
        /// <param name="serviceCidrs"> One IPv4 CIDR is expected for single-stack networking. Two CIDRs, one for each IP family (IPv4/IPv6), is expected for dual-stack networking. They must not overlap with any Subnet IP ranges. </param>
        /// <param name="ipFamilies"> IP families are used to determine single-stack or dual-stack clusters. For single-stack, the expected value is IPv4. For dual-stack, the expected values are IPv4 and IPv6. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerServiceNetworkProfile(ContainerServiceNetworkPlugin? networkPlugin, ContainerServiceNetworkPluginMode? networkPluginMode, ContainerServiceNetworkPolicy? networkPolicy, ContainerServiceNetworkMode? networkMode, NetworkDataplane? networkDataplane, string podCidr, string serviceCidr, string dnsServiceIP, ContainerServiceOutboundType? outboundType, ContainerServiceLoadBalancerSku? loadBalancerSku, ManagedClusterLoadBalancerProfile loadBalancerProfile, ManagedClusterNatGatewayProfile natGatewayProfile, IList<string> podCidrs, IList<string> serviceCidrs, IList<IPFamily> ipFamilies, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NetworkPlugin = networkPlugin;
            NetworkPluginMode = networkPluginMode;
            NetworkPolicy = networkPolicy;
            NetworkMode = networkMode;
            NetworkDataplane = networkDataplane;
            PodCidr = podCidr;
            ServiceCidr = serviceCidr;
            DnsServiceIP = dnsServiceIP;
            OutboundType = outboundType;
            LoadBalancerSku = loadBalancerSku;
            LoadBalancerProfile = loadBalancerProfile;
            NatGatewayProfile = natGatewayProfile;
            PodCidrs = podCidrs;
            ServiceCidrs = serviceCidrs;
            IPFamilies = ipFamilies;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Network plugin used for building the Kubernetes network. </summary>
        public ContainerServiceNetworkPlugin? NetworkPlugin { get; set; }
        /// <summary> The mode the network plugin should use. </summary>
        public ContainerServiceNetworkPluginMode? NetworkPluginMode { get; set; }
        /// <summary> Network policy used for building the Kubernetes network. </summary>
        public ContainerServiceNetworkPolicy? NetworkPolicy { get; set; }
        /// <summary> This cannot be specified if networkPlugin is anything other than 'azure'. </summary>
        public ContainerServiceNetworkMode? NetworkMode { get; set; }
        /// <summary> Network dataplane used in the Kubernetes cluster. </summary>
        public NetworkDataplane? NetworkDataplane { get; set; }
        /// <summary> A CIDR notation IP range from which to assign pod IPs when kubenet is used. </summary>
        public string PodCidr { get; set; }
        /// <summary> A CIDR notation IP range from which to assign service cluster IPs. It must not overlap with any Subnet IP ranges. </summary>
        public string ServiceCidr { get; set; }
        /// <summary> An IP address assigned to the Kubernetes DNS service. It must be within the Kubernetes service address range specified in serviceCidr. </summary>
        public string DnsServiceIP { get; set; }
        /// <summary> This can only be set at cluster creation time and cannot be changed later. For more information see [egress outbound type](https://docs.microsoft.com/azure/aks/egress-outboundtype). </summary>
        public ContainerServiceOutboundType? OutboundType { get; set; }
        /// <summary> The default is 'standard'. See [Azure Load Balancer SKUs](https://docs.microsoft.com/azure/load-balancer/skus) for more information about the differences between load balancer SKUs. </summary>
        public ContainerServiceLoadBalancerSku? LoadBalancerSku { get; set; }
        /// <summary> Profile of the cluster load balancer. </summary>
        public ManagedClusterLoadBalancerProfile LoadBalancerProfile { get; set; }
        /// <summary> Profile of the cluster NAT gateway. </summary>
        public ManagedClusterNatGatewayProfile NatGatewayProfile { get; set; }
        /// <summary> One IPv4 CIDR is expected for single-stack networking. Two CIDRs, one for each IP family (IPv4/IPv6), is expected for dual-stack networking. </summary>
        public IList<string> PodCidrs { get; }
        /// <summary> One IPv4 CIDR is expected for single-stack networking. Two CIDRs, one for each IP family (IPv4/IPv6), is expected for dual-stack networking. They must not overlap with any Subnet IP ranges. </summary>
        public IList<string> ServiceCidrs { get; }
        /// <summary> IP families are used to determine single-stack or dual-stack clusters. For single-stack, the expected value is IPv4. For dual-stack, the expected values are IPv4 and IPv6. </summary>
        public IList<IPFamily> IPFamilies { get; }
    }
}
