// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> The metastore specification for Spark cluster. </summary>
    public partial class SparkMetastoreSpec
    {
        /// <summary> Initializes a new instance of SparkMetastoreSpec. </summary>
        /// <param name="dbServerHost"> The database server host. </param>
        /// <param name="dbName"> The database name. </param>
        /// <param name="dbUserName"> The database user name. </param>
        /// <param name="dbPasswordSecretName"> The secret name which contains the database user password. </param>
        /// <param name="keyVaultId"> The key vault resource id. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dbServerHost"/>, <paramref name="dbName"/>, <paramref name="dbUserName"/>, <paramref name="dbPasswordSecretName"/> or <paramref name="keyVaultId"/> is null. </exception>
        public SparkMetastoreSpec(string dbServerHost, string dbName, string dbUserName, string dbPasswordSecretName, string keyVaultId)
        {
            Argument.AssertNotNull(dbServerHost, nameof(dbServerHost));
            Argument.AssertNotNull(dbName, nameof(dbName));
            Argument.AssertNotNull(dbUserName, nameof(dbUserName));
            Argument.AssertNotNull(dbPasswordSecretName, nameof(dbPasswordSecretName));
            Argument.AssertNotNull(keyVaultId, nameof(keyVaultId));

            DbServerHost = dbServerHost;
            DbName = dbName;
            DbUserName = dbUserName;
            DbPasswordSecretName = dbPasswordSecretName;
            KeyVaultId = keyVaultId;
        }

        /// <summary> Initializes a new instance of SparkMetastoreSpec. </summary>
        /// <param name="dbServerHost"> The database server host. </param>
        /// <param name="dbName"> The database name. </param>
        /// <param name="dbUserName"> The database user name. </param>
        /// <param name="dbPasswordSecretName"> The secret name which contains the database user password. </param>
        /// <param name="keyVaultId"> The key vault resource id. </param>
        /// <param name="thriftUri"> The thrift url. </param>
        internal SparkMetastoreSpec(string dbServerHost, string dbName, string dbUserName, string dbPasswordSecretName, string keyVaultId, string thriftUri)
        {
            DbServerHost = dbServerHost;
            DbName = dbName;
            DbUserName = dbUserName;
            DbPasswordSecretName = dbPasswordSecretName;
            KeyVaultId = keyVaultId;
            ThriftUri = thriftUri;
        }

        /// <summary> The database server host. </summary>
        public string DbServerHost { get; set; }
        /// <summary> The database name. </summary>
        public string DbName { get; set; }
        /// <summary> The database user name. </summary>
        public string DbUserName { get; set; }
        /// <summary> The secret name which contains the database user password. </summary>
        public string DbPasswordSecretName { get; set; }
        /// <summary> The key vault resource id. </summary>
        public string KeyVaultId { get; set; }
        /// <summary> The thrift url. </summary>
        public string ThriftUri { get; set; }
    }
}
