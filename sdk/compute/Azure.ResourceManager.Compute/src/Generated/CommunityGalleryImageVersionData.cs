// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Compute.Models;

namespace Azure.ResourceManager.Compute
{
    /// <summary>
    /// A class representing the CommunityGalleryImageVersion data model.
    /// Specifies information about the gallery image version that you want to create or update.
    /// </summary>
    public partial class CommunityGalleryImageVersionData : PirCommunityGalleryResourceData
    {
        /// <summary> Initializes a new instance of <see cref="CommunityGalleryImageVersionData"/>. </summary>
        internal CommunityGalleryImageVersionData()
        {
            ArtifactTags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="CommunityGalleryImageVersionData"/>. </summary>
        /// <param name="name"> Resource name. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="uniqueId"> The unique id of this community gallery. </param>
        /// <param name="publishedOn"> The published date of the gallery image version Definition. This property can be used for decommissioning purposes. This property is updatable. </param>
        /// <param name="endOfLifeOn"> The end of life date of the gallery image version Definition. This property can be used for decommissioning purposes. This property is updatable. </param>
        /// <param name="isExcludedFromLatest"> If set to true, Virtual Machines deployed from the latest version of the Image Definition won't use this Image Version. </param>
        /// <param name="storageProfile"> Describes the storage profile of the image version. </param>
        /// <param name="disclaimer"> The disclaimer for a community gallery resource. </param>
        /// <param name="artifactTags"> The artifact tags of a community gallery resource. </param>
        internal CommunityGalleryImageVersionData(string name, AzureLocation? location, ResourceType? resourceType, string uniqueId, DateTimeOffset? publishedOn, DateTimeOffset? endOfLifeOn, bool? isExcludedFromLatest, SharedGalleryImageVersionStorageProfile storageProfile, string disclaimer, IReadOnlyDictionary<string, string> artifactTags) : base(name, location, resourceType, uniqueId)
        {
            PublishedOn = publishedOn;
            EndOfLifeOn = endOfLifeOn;
            IsExcludedFromLatest = isExcludedFromLatest;
            StorageProfile = storageProfile;
            Disclaimer = disclaimer;
            ArtifactTags = artifactTags;
        }

        /// <summary> The published date of the gallery image version Definition. This property can be used for decommissioning purposes. This property is updatable. </summary>
        public DateTimeOffset? PublishedOn { get; }
        /// <summary> The end of life date of the gallery image version Definition. This property can be used for decommissioning purposes. This property is updatable. </summary>
        public DateTimeOffset? EndOfLifeOn { get; }
        /// <summary> If set to true, Virtual Machines deployed from the latest version of the Image Definition won't use this Image Version. </summary>
        public bool? IsExcludedFromLatest { get; }
        /// <summary> Describes the storage profile of the image version. </summary>
        public SharedGalleryImageVersionStorageProfile StorageProfile { get; }
        /// <summary> The disclaimer for a community gallery resource. </summary>
        public string Disclaimer { get; }
        /// <summary> The artifact tags of a community gallery resource. </summary>
        public IReadOnlyDictionary<string, string> ArtifactTags { get; }
        /// <summary> The resource identifier. </summary>
        public ResourceIdentifier Id { get; internal set; }
    }
}
