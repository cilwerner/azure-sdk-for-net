// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Using the Text Analytics API, extracts entities of different types from text. </summary>
    internal partial class EntityRecognitionSkillV3 : SearchIndexerSkill
    {
        /// <summary> Initializes a new instance of <see cref="EntityRecognitionSkillV3"/>. </summary>
        /// <param name="inputs"> Inputs of the skills could be a column in the source data set, or the output of an upstream skill. </param>
        /// <param name="outputs"> The output of a skill is either a field in a search index, or a value that can be consumed as an input by another skill. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="inputs"/> or <paramref name="outputs"/> is null. </exception>
        public EntityRecognitionSkillV3(IEnumerable<InputFieldMappingEntry> inputs, IEnumerable<OutputFieldMappingEntry> outputs) : base(inputs, outputs)
        {
            Argument.AssertNotNull(inputs, nameof(inputs));
            Argument.AssertNotNull(outputs, nameof(outputs));

            Categories = new ChangeTrackingList<string>();
            ODataType = "#Microsoft.Skills.Text.V3.EntityRecognitionSkill";
        }

        /// <summary> Initializes a new instance of <see cref="EntityRecognitionSkillV3"/>. </summary>
        /// <param name="oDataType"> Identifies the concrete type of the skill. </param>
        /// <param name="name"> The name of the skill which uniquely identifies it within the skillset. A skill with no name defined will be given a default name of its 1-based index in the skills array, prefixed with the character '#'. </param>
        /// <param name="description"> The description of the skill which describes the inputs, outputs, and usage of the skill. </param>
        /// <param name="context"> Represents the level at which operations take place, such as the document root or document content (for example, /document or /document/content). The default is /document. </param>
        /// <param name="inputs"> Inputs of the skills could be a column in the source data set, or the output of an upstream skill. </param>
        /// <param name="outputs"> The output of a skill is either a field in a search index, or a value that can be consumed as an input by another skill. </param>
        /// <param name="categories"> A list of entity categories that should be extracted. </param>
        /// <param name="defaultLanguageCode"> A value indicating which language code to use. Default is en. </param>
        /// <param name="minimumPrecision"> A value between 0 and 1 that be used to only include entities whose confidence score is greater than the value specified. If not set (default), or if explicitly set to null, all entities will be included. </param>
        /// <param name="modelVersion"> The version of the model to use when calling the Text Analytics service. It will default to the latest available when not specified. We recommend you do not specify this value unless absolutely necessary. </param>
        internal EntityRecognitionSkillV3(string oDataType, string name, string description, string context, IList<InputFieldMappingEntry> inputs, IList<OutputFieldMappingEntry> outputs, IList<string> categories, string defaultLanguageCode, double? minimumPrecision, string modelVersion) : base(oDataType, name, description, context, inputs, outputs)
        {
            Categories = categories;
            DefaultLanguageCode = defaultLanguageCode;
            MinimumPrecision = minimumPrecision;
            ModelVersion = modelVersion;
            ODataType = oDataType ?? "#Microsoft.Skills.Text.V3.EntityRecognitionSkill";
        }

        /// <summary> A list of entity categories that should be extracted. </summary>
        public IList<string> Categories { get; }
        /// <summary> A value indicating which language code to use. Default is en. </summary>
        public string DefaultLanguageCode { get; set; }
        /// <summary> A value between 0 and 1 that be used to only include entities whose confidence score is greater than the value specified. If not set (default), or if explicitly set to null, all entities will be included. </summary>
        public double? MinimumPrecision { get; set; }
        /// <summary> The version of the model to use when calling the Text Analytics service. It will default to the latest available when not specified. We recommend you do not specify this value unless absolutely necessary. </summary>
        public string ModelVersion { get; set; }
    }
}
