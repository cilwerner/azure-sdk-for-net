// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Represents an output file produced. </summary>
    public partial class MediaOutputFile
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

        /// <summary> Initializes a new instance of <see cref="MediaOutputFile"/>. </summary>
        /// <param name="labels"> The list of labels that describe how the encoder should multiplex video and audio into an output file. For example, if the encoder is producing two video layers with labels v1 and v2, and one audio layer with label a1, then an array like '[v1, a1]' tells the encoder to produce an output file with the video track represented by v1 and the audio track represented by a1. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="labels"/> is null. </exception>
        public MediaOutputFile(IEnumerable<string> labels)
        {
            Argument.AssertNotNull(labels, nameof(labels));

            Labels = labels.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="MediaOutputFile"/>. </summary>
        /// <param name="labels"> The list of labels that describe how the encoder should multiplex video and audio into an output file. For example, if the encoder is producing two video layers with labels v1 and v2, and one audio layer with label a1, then an array like '[v1, a1]' tells the encoder to produce an output file with the video track represented by v1 and the audio track represented by a1. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MediaOutputFile(IList<string> labels, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Labels = labels;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MediaOutputFile"/> for deserialization. </summary>
        internal MediaOutputFile()
        {
        }

        /// <summary> The list of labels that describe how the encoder should multiplex video and audio into an output file. For example, if the encoder is producing two video layers with labels v1 and v2, and one audio layer with label a1, then an array like '[v1, a1]' tells the encoder to produce an output file with the video track represented by v1 and the audio track represented by a1. </summary>
        public IList<string> Labels { get; }
    }
}
