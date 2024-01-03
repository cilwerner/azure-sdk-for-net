// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Sphere.Models
{
    /// <summary> Device insight report. </summary>
    public partial class SphereDeviceInsight
    {
        /// <summary> Initializes a new instance of <see cref="SphereDeviceInsight"/>. </summary>
        /// <param name="deviceId"> Device ID. </param>
        /// <param name="description"> Event description. </param>
        /// <param name="startTimestampUtc"> Event start timestamp. </param>
        /// <param name="endTimestampUtc"> Event end timestamp. </param>
        /// <param name="eventCategory"> Event category. </param>
        /// <param name="eventClass"> Event class. </param>
        /// <param name="eventType"> Event type. </param>
        /// <param name="eventCount"> Event count. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deviceId"/>, <paramref name="description"/>, <paramref name="eventCategory"/>, <paramref name="eventClass"/> or <paramref name="eventType"/> is null. </exception>
        internal SphereDeviceInsight(string deviceId, string description, DateTimeOffset startTimestampUtc, DateTimeOffset endTimestampUtc, string eventCategory, string eventClass, string eventType, int eventCount)
        {
            Argument.AssertNotNull(deviceId, nameof(deviceId));
            Argument.AssertNotNull(description, nameof(description));
            Argument.AssertNotNull(eventCategory, nameof(eventCategory));
            Argument.AssertNotNull(eventClass, nameof(eventClass));
            Argument.AssertNotNull(eventType, nameof(eventType));

            DeviceId = deviceId;
            Description = description;
            StartTimestampUtc = startTimestampUtc;
            EndTimestampUtc = endTimestampUtc;
            EventCategory = eventCategory;
            EventClass = eventClass;
            EventType = eventType;
            EventCount = eventCount;
        }

        /// <summary> Device ID. </summary>
        public string DeviceId { get; }
        /// <summary> Event description. </summary>
        public string Description { get; }
        /// <summary> Event start timestamp. </summary>
        public DateTimeOffset StartTimestampUtc { get; }
        /// <summary> Event end timestamp. </summary>
        public DateTimeOffset EndTimestampUtc { get; }
        /// <summary> Event category. </summary>
        public string EventCategory { get; }
        /// <summary> Event class. </summary>
        public string EventClass { get; }
        /// <summary> Event type. </summary>
        public string EventType { get; }
        /// <summary> Event count. </summary>
        public int EventCount { get; }
    }
}
