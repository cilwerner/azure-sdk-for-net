// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Monitor.Query.Models
{
    /// <summary> The metrics result for a resource. </summary>
    public partial class MetricResultsResponse
    {
        /// <summary> Initializes a new instance of MetricResultsResponse. </summary>
        internal MetricResultsResponse()
        {
            Values = new ChangeTrackingList<MetricResultsResponseValuesItem>();
        }

        /// <summary> Initializes a new instance of MetricResultsResponse. </summary>
        /// <param name="values"> The collection of metric data responses per resource, per metric. </param>
        internal MetricResultsResponse(IReadOnlyList<MetricResultsResponseValuesItem> values)
        {
            Values = values;
        }

        /// <summary> The collection of metric data responses per resource, per metric. </summary>
        public IReadOnlyList<MetricResultsResponseValuesItem> Values { get; }
    }
}
