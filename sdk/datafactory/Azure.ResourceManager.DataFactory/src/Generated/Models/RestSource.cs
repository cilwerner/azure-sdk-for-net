// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> A copy activity Rest service source. </summary>
    public partial class RestSource : CopyActivitySource
    {
        /// <summary> Initializes a new instance of <see cref="RestSource"/>. </summary>
        public RestSource()
        {
            CopySourceType = "RestSource";
        }

        /// <summary> Initializes a new instance of <see cref="RestSource"/>. </summary>
        /// <param name="copySourceType"> Copy source type. </param>
        /// <param name="sourceRetryCount"> Source retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sourceRetryWait"> Source retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="disableMetricsCollection"> If true, disable data store metrics collection. Default is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="requestMethod"> The HTTP method used to call the RESTful API. The default is GET. Type: string (or Expression with resultType string). </param>
        /// <param name="requestBody"> The HTTP request body to the RESTful API if requestMethod is POST. Type: string (or Expression with resultType string). </param>
        /// <param name="additionalHeaders"> The additional HTTP headers in the request to the RESTful API. Type: string (or Expression with resultType string). </param>
        /// <param name="paginationRules"> The pagination rules to compose next page requests. Type: string (or Expression with resultType string). </param>
        /// <param name="httpRequestTimeout"> The timeout (TimeSpan) to get an HTTP response. It is the timeout to get a response, not the timeout to read response data. Default value: 00:01:40. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="requestInterval"> The time to await before sending next page request. </param>
        /// <param name="additionalColumns"> Specifies the additional columns to be added to source data. Type: key value pairs (value should be string type). </param>
        internal RestSource(string copySourceType, DataFactoryElement<int> sourceRetryCount, DataFactoryElement<string> sourceRetryWait, DataFactoryElement<int> maxConcurrentConnections, DataFactoryElement<bool> disableMetricsCollection, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> requestMethod, DataFactoryElement<string> requestBody, DataFactoryElement<string> additionalHeaders, DataFactoryElement<string> paginationRules, DataFactoryElement<string> httpRequestTimeout, BinaryData requestInterval, DataFactoryElement<IDictionary<string, string>> additionalColumns) : base(copySourceType, sourceRetryCount, sourceRetryWait, maxConcurrentConnections, disableMetricsCollection, additionalProperties)
        {
            RequestMethod = requestMethod;
            RequestBody = requestBody;
            AdditionalHeaders = additionalHeaders;
            PaginationRules = paginationRules;
            HttpRequestTimeout = httpRequestTimeout;
            RequestInterval = requestInterval;
            AdditionalColumns = additionalColumns;
            CopySourceType = copySourceType ?? "RestSource";
        }

        /// <summary> The HTTP method used to call the RESTful API. The default is GET. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> RequestMethod { get; set; }
        /// <summary> The HTTP request body to the RESTful API if requestMethod is POST. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> RequestBody { get; set; }
        /// <summary> The additional HTTP headers in the request to the RESTful API. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> AdditionalHeaders { get; set; }
        /// <summary> The pagination rules to compose next page requests. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> PaginationRules { get; set; }
        /// <summary> The timeout (TimeSpan) to get an HTTP response. It is the timeout to get a response, not the timeout to read response data. Default value: 00:01:40. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </summary>
        public DataFactoryElement<string> HttpRequestTimeout { get; set; }
        /// <summary>
        /// The time to await before sending next page request.
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
        public BinaryData RequestInterval { get; set; }
        /// <summary> Specifies the additional columns to be added to source data. Type: key value pairs (value should be string type). </summary>
        public DataFactoryElement<IDictionary<string, string>> AdditionalColumns { get; set; }
    }
}
