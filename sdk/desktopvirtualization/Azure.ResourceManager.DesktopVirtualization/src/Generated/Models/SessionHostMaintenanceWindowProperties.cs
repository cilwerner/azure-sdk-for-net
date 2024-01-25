// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> Maintenance window starting hour and day of week. </summary>
    public partial class SessionHostMaintenanceWindowProperties
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

        /// <summary> Initializes a new instance of <see cref="SessionHostMaintenanceWindowProperties"/>. </summary>
        public SessionHostMaintenanceWindowProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SessionHostMaintenanceWindowProperties"/>. </summary>
        /// <param name="hour"> The update start hour of the day. (0 - 23). </param>
        /// <param name="dayOfWeek"> Day of the week. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SessionHostMaintenanceWindowProperties(int? hour, DesktopVirtualizationDayOfWeek? dayOfWeek, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Hour = hour;
            DayOfWeek = dayOfWeek;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The update start hour of the day. (0 - 23). </summary>
        public int? Hour { get; set; }
        /// <summary> Day of the week. </summary>
        public DesktopVirtualizationDayOfWeek? DayOfWeek { get; set; }
    }
}
