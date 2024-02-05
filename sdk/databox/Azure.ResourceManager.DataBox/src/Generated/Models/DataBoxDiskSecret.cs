// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Contains all the secrets of a Disk. </summary>
    public partial class DataBoxDiskSecret
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

        /// <summary> Initializes a new instance of <see cref="DataBoxDiskSecret"/>. </summary>
        internal DataBoxDiskSecret()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DataBoxDiskSecret"/>. </summary>
        /// <param name="diskSerialNumber"> Serial number of the assigned disk. </param>
        /// <param name="bitLockerKey"> Bit Locker key of the disk which can be used to unlock the disk to copy data. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataBoxDiskSecret(string diskSerialNumber, string bitLockerKey, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DiskSerialNumber = diskSerialNumber;
            BitLockerKey = bitLockerKey;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Serial number of the assigned disk. </summary>
        public string DiskSerialNumber { get; }
        /// <summary> Bit Locker key of the disk which can be used to unlock the disk to copy data. </summary>
        public string BitLockerKey { get; }
    }
}
