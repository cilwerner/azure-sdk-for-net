// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure;

namespace Azure.Health.Insights.CancerProfiling
{
    /// <summary> Model factory for models. </summary>
    public static partial class HealthInsightsCancerProfilingModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="CancerProfiling.OncoPhenotypeResults"/>. </summary>
        /// <param name="patients"> Results for the patients given in the request. </param>
        /// <param name="modelVersion"> The version of the model used for inference, expressed as the model date. </param>
        /// <returns> A new <see cref="CancerProfiling.OncoPhenotypeResults"/> instance for mocking. </returns>
        public static OncoPhenotypeResults OncoPhenotypeResults(IEnumerable<OncoPhenotypePatientResult> patients = null, string modelVersion = null)
        {
            patients ??= new List<OncoPhenotypePatientResult>();

            return new OncoPhenotypeResults(patients?.ToList(), modelVersion);
        }

        /// <summary> Initializes a new instance of <see cref="CancerProfiling.OncoPhenotypePatientResult"/>. </summary>
        /// <param name="id"> The identifier given for the patient in the request. </param>
        /// <param name="inferences"> The model's inferences for the given patient. </param>
        /// <returns> A new <see cref="CancerProfiling.OncoPhenotypePatientResult"/> instance for mocking. </returns>
        public static OncoPhenotypePatientResult OncoPhenotypePatientResult(string id = null, IEnumerable<OncoPhenotypeInference> inferences = null)
        {
            inferences ??= new List<OncoPhenotypeInference>();

            return new OncoPhenotypePatientResult(id, inferences?.ToList());
        }

        /// <summary> Initializes a new instance of <see cref="CancerProfiling.OncoPhenotypeInference"/>. </summary>
        /// <param name="type"> The type of the Onco Phenotype inference. </param>
        /// <param name="value"> The value of the inference, as relevant for the given inference type. </param>
        /// <param name="description"> The description corresponding to the inference value. </param>
        /// <param name="confidenceScore"> Confidence score for this inference. </param>
        /// <param name="evidence"> The evidence corresponding to the inference value. </param>
        /// <param name="caseId"> An identifier for a clinical case, if there are multiple clinical cases regarding the same patient. </param>
        /// <returns> A new <see cref="CancerProfiling.OncoPhenotypeInference"/> instance for mocking. </returns>
        public static OncoPhenotypeInference OncoPhenotypeInference(OncoPhenotypeInferenceType type = default, string value = null, string description = null, float? confidenceScore = null, IEnumerable<InferenceEvidence> evidence = null, string caseId = null)
        {
            evidence ??= new List<InferenceEvidence>();

            return new OncoPhenotypeInference(type, value, description, confidenceScore, evidence?.ToList(), caseId);
        }

        /// <summary> Initializes a new instance of <see cref="CancerProfiling.InferenceEvidence"/>. </summary>
        /// <param name="patientDataEvidence"> A piece of evidence from a clinical note (text document). </param>
        /// <param name="patientInfoEvidence">
        /// A piece of clinical information, expressed as a code in a clinical coding
        /// system.
        /// </param>
        /// <param name="importance"> A value indicating how important this piece of evidence is for the inference. </param>
        /// <returns> A new <see cref="CancerProfiling.InferenceEvidence"/> instance for mocking. </returns>
        public static InferenceEvidence InferenceEvidence(ClinicalNoteEvidence patientDataEvidence = null, ClinicalCodedElement patientInfoEvidence = null, float? importance = null)
        {
            return new InferenceEvidence(patientDataEvidence, patientInfoEvidence, importance);
        }

        /// <summary> Initializes a new instance of <see cref="CancerProfiling.ClinicalNoteEvidence"/>. </summary>
        /// <param name="id"> The identifier of the document containing the evidence. </param>
        /// <param name="text"> The actual text span which is evidence for the inference. </param>
        /// <param name="offset"> The start index of the evidence text span in the document (0 based). </param>
        /// <param name="length"> The length of the evidence text span. </param>
        /// <returns> A new <see cref="CancerProfiling.ClinicalNoteEvidence"/> instance for mocking. </returns>
        public static ClinicalNoteEvidence ClinicalNoteEvidence(string id = null, string text = null, int offset = default, int length = default)
        {
            return new ClinicalNoteEvidence(id, text, offset, length);
        }
    }
}
