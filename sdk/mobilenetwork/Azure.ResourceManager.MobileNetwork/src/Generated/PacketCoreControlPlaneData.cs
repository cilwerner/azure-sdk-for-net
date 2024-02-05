// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.MobileNetwork.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.MobileNetwork
{
    /// <summary>
    /// A class representing the PacketCoreControlPlane data model.
    /// Packet core control plane resource.
    /// </summary>
    public partial class PacketCoreControlPlaneData : TrackedResourceData
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

        /// <summary> Initializes a new instance of <see cref="PacketCoreControlPlaneData"/>. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="sites"> Site(s) under which this packet core control plane should be deployed. The sites must be in the same location as the packet core control plane. </param>
        /// <param name="platform"> The platform where the packet core is deployed. </param>
        /// <param name="controlPlaneAccessInterface"> The control plane interface on the access network. For 5G networks, this is the N2 interface. For 4G networks, this is the S1-MME interface. </param>
        /// <param name="sku"> The SKU defining the throughput and SIM allowances for this packet core control plane deployment. </param>
        /// <param name="localDiagnosticsAccess"> The kubernetes ingress configuration to control access to packet core diagnostics over local APIs. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sites"/>, <paramref name="platform"/>, <paramref name="controlPlaneAccessInterface"/> or <paramref name="localDiagnosticsAccess"/> is null. </exception>
        public PacketCoreControlPlaneData(AzureLocation location, IEnumerable<WritableSubResource> sites, MobileNetworkPlatformConfiguration platform, MobileNetworkInterfaceProperties controlPlaneAccessInterface, MobileNetworkBillingSku sku, MobileNetworkLocalDiagnosticsAccessConfiguration localDiagnosticsAccess) : base(location)
        {
            Argument.AssertNotNull(sites, nameof(sites));
            Argument.AssertNotNull(platform, nameof(platform));
            Argument.AssertNotNull(controlPlaneAccessInterface, nameof(controlPlaneAccessInterface));
            Argument.AssertNotNull(localDiagnosticsAccess, nameof(localDiagnosticsAccess));

            Sites = sites.ToList();
            Platform = platform;
            ControlPlaneAccessInterface = controlPlaneAccessInterface;
            ControlPlaneAccessVirtualIPv4Addresses = new ChangeTrackingList<string>();
            Sku = sku;
            LocalDiagnosticsAccess = localDiagnosticsAccess;
        }

        /// <summary> Initializes a new instance of <see cref="PacketCoreControlPlaneData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="userAssignedIdentity"> The identity used to retrieve the ingress certificate from Azure key vault. </param>
        /// <param name="provisioningState"> The provisioning state of the packet core control plane resource. </param>
        /// <param name="installation"> The installation state of the packet core control plane resource. </param>
        /// <param name="sites"> Site(s) under which this packet core control plane should be deployed. The sites must be in the same location as the packet core control plane. </param>
        /// <param name="platform"> The platform where the packet core is deployed. </param>
        /// <param name="coreNetworkTechnology"> The core network technology generation (5G core or EPC / 4G core). </param>
        /// <param name="version"> The desired version of the packet core software. </param>
        /// <param name="installedVersion"> The currently installed version of the packet core software. </param>
        /// <param name="rollbackVersion"> The previous version of the packet core software that was deployed. Used when performing the rollback action. </param>
        /// <param name="controlPlaneAccessInterface"> The control plane interface on the access network. For 5G networks, this is the N2 interface. For 4G networks, this is the S1-MME interface. </param>
        /// <param name="controlPlaneAccessVirtualIPv4Addresses"> The virtual IP address(es) for the control plane on the access network in a High Availability (HA) system. In an HA deployment the access network router should be configured to anycast traffic for this address to the control plane access interfaces on the active and standby nodes. In non-HA system this list should be omitted or empty. </param>
        /// <param name="sku"> The SKU defining the throughput and SIM allowances for this packet core control plane deployment. </param>
        /// <param name="ueMtu"> The MTU (in bytes) signaled to the UE. The same MTU is set on the user plane data links for all data networks. The MTU set on the user plane access link is calculated to be 60 bytes greater than this value to allow for GTP encapsulation. </param>
        /// <param name="localDiagnosticsAccess"> The kubernetes ingress configuration to control access to packet core diagnostics over local APIs. </param>
        /// <param name="diagnosticsUpload"> Configuration for uploading packet core diagnostics. </param>
        /// <param name="eventHub"> Configuration for sending packet core events to an Azure Event Hub. </param>
        /// <param name="signaling"> Signaling configuration for the packet core. </param>
        /// <param name="interopSettings"> Settings to allow interoperability with third party components e.g. RANs and UEs. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PacketCoreControlPlaneData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, MobileNetworkManagedServiceIdentity userAssignedIdentity, MobileNetworkProvisioningState? provisioningState, MobileNetworkInstallation installation, IList<WritableSubResource> sites, MobileNetworkPlatformConfiguration platform, MobileNetworkCoreNetworkType? coreNetworkTechnology, string version, string installedVersion, string rollbackVersion, MobileNetworkInterfaceProperties controlPlaneAccessInterface, IList<string> controlPlaneAccessVirtualIPv4Addresses, MobileNetworkBillingSku sku, int? ueMtu, MobileNetworkLocalDiagnosticsAccessConfiguration localDiagnosticsAccess, DiagnosticsUploadConfiguration diagnosticsUpload, MobileNetworkEventHubConfiguration eventHub, SignalingConfiguration signaling, BinaryData interopSettings, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            UserAssignedIdentity = userAssignedIdentity;
            ProvisioningState = provisioningState;
            Installation = installation;
            Sites = sites;
            Platform = platform;
            CoreNetworkTechnology = coreNetworkTechnology;
            Version = version;
            InstalledVersion = installedVersion;
            RollbackVersion = rollbackVersion;
            ControlPlaneAccessInterface = controlPlaneAccessInterface;
            ControlPlaneAccessVirtualIPv4Addresses = controlPlaneAccessVirtualIPv4Addresses;
            Sku = sku;
            UeMtu = ueMtu;
            LocalDiagnosticsAccess = localDiagnosticsAccess;
            DiagnosticsUpload = diagnosticsUpload;
            EventHub = eventHub;
            Signaling = signaling;
            InteropSettings = interopSettings;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="PacketCoreControlPlaneData"/> for deserialization. </summary>
        internal PacketCoreControlPlaneData()
        {
        }

        /// <summary> The identity used to retrieve the ingress certificate from Azure key vault. </summary>
        public MobileNetworkManagedServiceIdentity UserAssignedIdentity { get; set; }
        /// <summary> The provisioning state of the packet core control plane resource. </summary>
        public MobileNetworkProvisioningState? ProvisioningState { get; }
        /// <summary> The installation state of the packet core control plane resource. </summary>
        public MobileNetworkInstallation Installation { get; set; }
        /// <summary> Site(s) under which this packet core control plane should be deployed. The sites must be in the same location as the packet core control plane. </summary>
        public IList<WritableSubResource> Sites { get; }
        /// <summary> The platform where the packet core is deployed. </summary>
        public MobileNetworkPlatformConfiguration Platform { get; set; }
        /// <summary> The core network technology generation (5G core or EPC / 4G core). </summary>
        public MobileNetworkCoreNetworkType? CoreNetworkTechnology { get; set; }
        /// <summary> The desired version of the packet core software. </summary>
        public string Version { get; set; }
        /// <summary> The currently installed version of the packet core software. </summary>
        public string InstalledVersion { get; }
        /// <summary> The previous version of the packet core software that was deployed. Used when performing the rollback action. </summary>
        public string RollbackVersion { get; }
        /// <summary> The control plane interface on the access network. For 5G networks, this is the N2 interface. For 4G networks, this is the S1-MME interface. </summary>
        public MobileNetworkInterfaceProperties ControlPlaneAccessInterface { get; set; }
        /// <summary> The virtual IP address(es) for the control plane on the access network in a High Availability (HA) system. In an HA deployment the access network router should be configured to anycast traffic for this address to the control plane access interfaces on the active and standby nodes. In non-HA system this list should be omitted or empty. </summary>
        public IList<string> ControlPlaneAccessVirtualIPv4Addresses { get; }
        /// <summary> The SKU defining the throughput and SIM allowances for this packet core control plane deployment. </summary>
        public MobileNetworkBillingSku Sku { get; set; }
        /// <summary> The MTU (in bytes) signaled to the UE. The same MTU is set on the user plane data links for all data networks. The MTU set on the user plane access link is calculated to be 60 bytes greater than this value to allow for GTP encapsulation. </summary>
        public int? UeMtu { get; set; }
        /// <summary> The kubernetes ingress configuration to control access to packet core diagnostics over local APIs. </summary>
        public MobileNetworkLocalDiagnosticsAccessConfiguration LocalDiagnosticsAccess { get; set; }
        /// <summary> Configuration for uploading packet core diagnostics. </summary>
        internal DiagnosticsUploadConfiguration DiagnosticsUpload { get; set; }
        /// <summary> The Storage Account Container URL to upload diagnostics to. </summary>
        public Uri DiagnosticsUploadStorageAccountContainerUri
        {
            get => DiagnosticsUpload is null ? default : DiagnosticsUpload.StorageAccountContainerUri;
            set => DiagnosticsUpload = new DiagnosticsUploadConfiguration(value);
        }

        /// <summary> Configuration for sending packet core events to an Azure Event Hub. </summary>
        public MobileNetworkEventHubConfiguration EventHub { get; set; }
        /// <summary> Signaling configuration for the packet core. </summary>
        internal SignalingConfiguration Signaling { get; set; }
        /// <summary> The macro network's MME group ID. This is where unknown UEs are sent to via NAS reroute. </summary>
        public int? NasRerouteMacroMmeGroupId
        {
            get => Signaling is null ? default : Signaling.NasRerouteMacroMmeGroupId;
            set
            {
                if (value.HasValue)
                {
                    if (Signaling is null)
                        Signaling = new SignalingConfiguration();
                    Signaling.NasRerouteMacroMmeGroupId = value.Value;
                }
                else
                {
                    Signaling = null;
                }
            }
        }

        /// <summary>
        /// Settings to allow interoperability with third party components e.g. RANs and UEs.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public BinaryData InteropSettings { get; set; }
    }
}
