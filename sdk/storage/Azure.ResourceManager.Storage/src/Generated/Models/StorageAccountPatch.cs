// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> The parameters that can be provided when updating the storage account properties. </summary>
    public partial class StorageAccountPatch
    {
        /// <summary> Initializes a new instance of <see cref="StorageAccountPatch"/>. </summary>
        public StorageAccountPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="StorageAccountPatch"/>. </summary>
        /// <param name="sku"> Gets or sets the SKU name. Note that the SKU name cannot be updated to Standard_ZRS, Premium_LRS or Premium_ZRS, nor can accounts of those SKU names be updated to any other value. </param>
        /// <param name="tags"> Gets or sets a list of key value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key no greater in length than 128 characters and a value no greater in length than 256 characters. </param>
        /// <param name="identity"> The identity of the resource. </param>
        /// <param name="kind"> Optional. Indicates the type of storage account. Currently only StorageV2 value supported by server. </param>
        /// <param name="customDomain"> Custom domain assigned to the storage account by the user. Name is the CNAME source. Only one custom domain is supported per storage account at this time. To clear the existing custom domain, use an empty string for the custom domain name property. </param>
        /// <param name="encryption"> Not applicable. Azure Storage encryption at rest is enabled by default for all storage accounts and cannot be disabled. </param>
        /// <param name="sasPolicy"> SasPolicy assigned to the storage account. </param>
        /// <param name="keyPolicy"> KeyPolicy assigned to the storage account. </param>
        /// <param name="accessTier"> Required for storage accounts where kind = BlobStorage. The access tier is used for billing. The 'Premium' access tier is the default value for premium block blobs storage account type and it cannot be changed for the premium block blobs storage account type. </param>
        /// <param name="azureFilesIdentityBasedAuthentication"> Provides the identity based authentication settings for Azure Files. </param>
        /// <param name="enableHttpsTrafficOnly"> Allows https traffic only to storage service if sets to true. </param>
        /// <param name="isSftpEnabled"> Enables Secure File Transfer Protocol, if set to true. </param>
        /// <param name="isLocalUserEnabled"> Enables local users feature, if set to true. </param>
        /// <param name="networkRuleSet"> Network rule set. </param>
        /// <param name="largeFileSharesState"> Allow large file shares if sets to Enabled. It cannot be disabled once it is enabled. </param>
        /// <param name="routingPreference"> Maintains information about the network routing choice opted by the user for data transfer. </param>
        /// <param name="allowBlobPublicAccess"> Allow or disallow public access to all blobs or containers in the storage account. The default interpretation is true for this property. </param>
        /// <param name="minimumTlsVersion"> Set the minimum TLS version to be permitted on requests to storage. The default interpretation is TLS 1.0 for this property. </param>
        /// <param name="allowSharedKeyAccess"> Indicates whether the storage account permits requests to be authorized with the account access key via Shared Key. If false, then all requests, including shared access signatures, must be authorized with Azure Active Directory (Azure AD). The default value is null, which is equivalent to true. </param>
        /// <param name="allowCrossTenantReplication"> Allow or disallow cross AAD tenant object replication. The default interpretation is true for this property. </param>
        /// <param name="isDefaultToOAuthAuthentication"> A boolean flag which indicates whether the default authentication is OAuth or not. The default interpretation is false for this property. </param>
        /// <param name="publicNetworkAccess"> Allow or disallow public network access to Storage Account. Value is optional but if passed in, must be 'Enabled' or 'Disabled'. </param>
        /// <param name="immutableStorageWithVersioning"> The property is immutable and can only be set to true at the account creation time. When set to true, it enables object level immutability for all the containers in the account by default. </param>
        /// <param name="allowedCopyScope"> Restrict copy to and from Storage Accounts within an AAD tenant or with Private Links to the same VNet. </param>
        /// <param name="dnsEndpointType"> Allows you to specify the type of endpoint. Set this to AzureDNSZone to create a large number of accounts in a single subscription, which creates accounts in an Azure DNS Zone and the endpoint URL will have an alphanumeric DNS Zone identifier. </param>
        internal StorageAccountPatch(StorageSku sku, IDictionary<string, string> tags, ManagedServiceIdentity identity, StorageKind? kind, StorageCustomDomain customDomain, StorageAccountEncryption encryption, StorageAccountSasPolicy sasPolicy, StorageAccountKeyPolicy keyPolicy, StorageAccountAccessTier? accessTier, FilesIdentityBasedAuthentication azureFilesIdentityBasedAuthentication, bool? enableHttpsTrafficOnly, bool? isSftpEnabled, bool? isLocalUserEnabled, StorageAccountNetworkRuleSet networkRuleSet, LargeFileSharesState? largeFileSharesState, StorageRoutingPreference routingPreference, bool? allowBlobPublicAccess, StorageMinimumTlsVersion? minimumTlsVersion, bool? allowSharedKeyAccess, bool? allowCrossTenantReplication, bool? isDefaultToOAuthAuthentication, StoragePublicNetworkAccess? publicNetworkAccess, ImmutableStorageAccount immutableStorageWithVersioning, AllowedCopyScope? allowedCopyScope, StorageDnsEndpointType? dnsEndpointType)
        {
            Sku = sku;
            Tags = tags;
            Identity = identity;
            Kind = kind;
            CustomDomain = customDomain;
            Encryption = encryption;
            SasPolicy = sasPolicy;
            KeyPolicy = keyPolicy;
            AccessTier = accessTier;
            AzureFilesIdentityBasedAuthentication = azureFilesIdentityBasedAuthentication;
            EnableHttpsTrafficOnly = enableHttpsTrafficOnly;
            IsSftpEnabled = isSftpEnabled;
            IsLocalUserEnabled = isLocalUserEnabled;
            NetworkRuleSet = networkRuleSet;
            LargeFileSharesState = largeFileSharesState;
            RoutingPreference = routingPreference;
            AllowBlobPublicAccess = allowBlobPublicAccess;
            MinimumTlsVersion = minimumTlsVersion;
            AllowSharedKeyAccess = allowSharedKeyAccess;
            AllowCrossTenantReplication = allowCrossTenantReplication;
            IsDefaultToOAuthAuthentication = isDefaultToOAuthAuthentication;
            PublicNetworkAccess = publicNetworkAccess;
            ImmutableStorageWithVersioning = immutableStorageWithVersioning;
            AllowedCopyScope = allowedCopyScope;
            DnsEndpointType = dnsEndpointType;
        }

        /// <summary> Gets or sets the SKU name. Note that the SKU name cannot be updated to Standard_ZRS, Premium_LRS or Premium_ZRS, nor can accounts of those SKU names be updated to any other value. </summary>
        public StorageSku Sku { get; set; }
        /// <summary> Gets or sets a list of key value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key no greater in length than 128 characters and a value no greater in length than 256 characters. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The identity of the resource. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Optional. Indicates the type of storage account. Currently only StorageV2 value supported by server. </summary>
        public StorageKind? Kind { get; set; }
        /// <summary> Custom domain assigned to the storage account by the user. Name is the CNAME source. Only one custom domain is supported per storage account at this time. To clear the existing custom domain, use an empty string for the custom domain name property. </summary>
        public StorageCustomDomain CustomDomain { get; set; }
        /// <summary> Not applicable. Azure Storage encryption at rest is enabled by default for all storage accounts and cannot be disabled. </summary>
        public StorageAccountEncryption Encryption { get; set; }
        /// <summary> SasPolicy assigned to the storage account. </summary>
        public StorageAccountSasPolicy SasPolicy { get; set; }
        /// <summary> KeyPolicy assigned to the storage account. </summary>
        internal StorageAccountKeyPolicy KeyPolicy { get; set; }
        /// <summary> The key expiration period in days. </summary>
        public int? KeyExpirationPeriodInDays
        {
            get => KeyPolicy is null ? default(int?) : KeyPolicy.KeyExpirationPeriodInDays;
            set
            {
                KeyPolicy = value.HasValue ? new StorageAccountKeyPolicy(value.Value) : null;
            }
        }

        /// <summary> Required for storage accounts where kind = BlobStorage. The access tier is used for billing. The 'Premium' access tier is the default value for premium block blobs storage account type and it cannot be changed for the premium block blobs storage account type. </summary>
        public StorageAccountAccessTier? AccessTier { get; set; }
        /// <summary> Provides the identity based authentication settings for Azure Files. </summary>
        public FilesIdentityBasedAuthentication AzureFilesIdentityBasedAuthentication { get; set; }
        /// <summary> Allows https traffic only to storage service if sets to true. </summary>
        public bool? EnableHttpsTrafficOnly { get; set; }
        /// <summary> Enables Secure File Transfer Protocol, if set to true. </summary>
        public bool? IsSftpEnabled { get; set; }
        /// <summary> Enables local users feature, if set to true. </summary>
        public bool? IsLocalUserEnabled { get; set; }
        /// <summary> Network rule set. </summary>
        public StorageAccountNetworkRuleSet NetworkRuleSet { get; set; }
        /// <summary> Allow large file shares if sets to Enabled. It cannot be disabled once it is enabled. </summary>
        public LargeFileSharesState? LargeFileSharesState { get; set; }
        /// <summary> Maintains information about the network routing choice opted by the user for data transfer. </summary>
        public StorageRoutingPreference RoutingPreference { get; set; }
        /// <summary> Allow or disallow public access to all blobs or containers in the storage account. The default interpretation is true for this property. </summary>
        public bool? AllowBlobPublicAccess { get; set; }
        /// <summary> Set the minimum TLS version to be permitted on requests to storage. The default interpretation is TLS 1.0 for this property. </summary>
        public StorageMinimumTlsVersion? MinimumTlsVersion { get; set; }
        /// <summary> Indicates whether the storage account permits requests to be authorized with the account access key via Shared Key. If false, then all requests, including shared access signatures, must be authorized with Azure Active Directory (Azure AD). The default value is null, which is equivalent to true. </summary>
        public bool? AllowSharedKeyAccess { get; set; }
        /// <summary> Allow or disallow cross AAD tenant object replication. The default interpretation is true for this property. </summary>
        public bool? AllowCrossTenantReplication { get; set; }
        /// <summary> A boolean flag which indicates whether the default authentication is OAuth or not. The default interpretation is false for this property. </summary>
        public bool? IsDefaultToOAuthAuthentication { get; set; }
        /// <summary> Allow or disallow public network access to Storage Account. Value is optional but if passed in, must be 'Enabled' or 'Disabled'. </summary>
        public StoragePublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary> The property is immutable and can only be set to true at the account creation time. When set to true, it enables object level immutability for all the containers in the account by default. </summary>
        public ImmutableStorageAccount ImmutableStorageWithVersioning { get; set; }
        /// <summary> Restrict copy to and from Storage Accounts within an AAD tenant or with Private Links to the same VNet. </summary>
        public AllowedCopyScope? AllowedCopyScope { get; set; }
        /// <summary> Allows you to specify the type of endpoint. Set this to AzureDNSZone to create a large number of accounts in a single subscription, which creates accounts in an Azure DNS Zone and the endpoint URL will have an alphanumeric DNS Zone identifier. </summary>
        public StorageDnsEndpointType? DnsEndpointType { get; set; }
    }
}
