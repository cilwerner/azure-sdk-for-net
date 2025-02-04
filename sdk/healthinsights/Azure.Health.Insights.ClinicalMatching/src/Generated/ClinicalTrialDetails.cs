// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Health.Insights.ClinicalMatching
{
    /// <summary> A description of a clinical trial. </summary>
    public partial class ClinicalTrialDetails
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

        /// <summary> Initializes a new instance of <see cref="ClinicalTrialDetails"/>. </summary>
        /// <param name="id"> A given identifier for the clinical trial. Has to be unique within a list of clinical trials. </param>
        /// <param name="metadata"> Trial data which is of interest to the potential participant. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="metadata"/> is null. </exception>
        public ClinicalTrialDetails(string id, ClinicalTrialMetadata metadata)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(metadata, nameof(metadata));

            Id = id;
            Metadata = metadata;
        }

        /// <summary> Initializes a new instance of <see cref="ClinicalTrialDetails"/>. </summary>
        /// <param name="id"> A given identifier for the clinical trial. Has to be unique within a list of clinical trials. </param>
        /// <param name="eligibilityCriteriaText"> The eligibility criteria of the clinical trial (inclusion and exclusion), given as text. </param>
        /// <param name="demographics"> Demographic criteria for a clinical trial. </param>
        /// <param name="metadata"> Trial data which is of interest to the potential participant. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ClinicalTrialDetails(string id, string eligibilityCriteriaText, ClinicalTrialDemographics demographics, ClinicalTrialMetadata metadata, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            EligibilityCriteriaText = eligibilityCriteriaText;
            Demographics = demographics;
            Metadata = metadata;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ClinicalTrialDetails"/> for deserialization. </summary>
        internal ClinicalTrialDetails()
        {
        }

        /// <summary> A given identifier for the clinical trial. Has to be unique within a list of clinical trials. </summary>
        public string Id { get; }
        /// <summary> The eligibility criteria of the clinical trial (inclusion and exclusion), given as text. </summary>
        public string EligibilityCriteriaText { get; set; }
        /// <summary> Demographic criteria for a clinical trial. </summary>
        public ClinicalTrialDemographics Demographics { get; set; }
        /// <summary> Trial data which is of interest to the potential participant. </summary>
        public ClinicalTrialMetadata Metadata { get; }
    }
}
