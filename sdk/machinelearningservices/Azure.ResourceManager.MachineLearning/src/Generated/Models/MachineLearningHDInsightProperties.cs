// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> HDInsight compute properties. </summary>
    public partial class MachineLearningHDInsightProperties
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

        /// <summary> Initializes a new instance of <see cref="MachineLearningHDInsightProperties"/>. </summary>
        public MachineLearningHDInsightProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningHDInsightProperties"/>. </summary>
        /// <param name="sshPort"> Port open for ssh connections on the master node of the cluster. </param>
        /// <param name="address"> Public IP address of the master node of the cluster. </param>
        /// <param name="administratorAccount"> Admin credentials for master node of the cluster. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningHDInsightProperties(int? sshPort, IPAddress address, MachineLearningVmSshCredentials administratorAccount, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SshPort = sshPort;
            Address = address;
            AdministratorAccount = administratorAccount;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Port open for ssh connections on the master node of the cluster. </summary>
        public int? SshPort { get; set; }
        /// <summary> Public IP address of the master node of the cluster. </summary>
        public IPAddress Address { get; set; }
        /// <summary> Admin credentials for master node of the cluster. </summary>
        public MachineLearningVmSshCredentials AdministratorAccount { get; set; }
    }
}
