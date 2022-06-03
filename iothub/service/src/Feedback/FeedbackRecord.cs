﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Azure.Devices
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// Contains properties of an individual feedback record.
    /// Feedback messages are delivery acknowledgments for messages sent to a device from IoT hub.
    /// </summary>
    public class FeedbackRecord
    {
        /// <summary>
        /// The Id of the cloud-to-device message to which this feedback message relates.
        /// Feedback messages are delivery acknowledgments for messages sent to a device from IoT hub.
        /// </summary>
        [JsonProperty(PropertyName = "originalMessageId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string OriginalMessageId { get; set; }

        /// <summary>
        /// The device generation Id of the target device of the cloud-to-device message to which this piece of feedback relates.
        /// DeviceGenerationId is an IoT hub generated, case-sensitive string. This value is used to distinguish devices with the
        /// same device Id when they have been deleted and re-created.
        /// </summary>
        [JsonProperty(PropertyName = "deviceGenerationId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string DeviceGenerationId { get; set; }

        /// <summary>
        /// The Id of the target device of the cloud-to-device message to which this piece of feedback relates.
        /// </summary>
        [JsonProperty(PropertyName = "deviceId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string DeviceId { get; set; }

        /// <summary>
        /// Date and time that indicates when the outcome of the message happened in UTC (for example, the hub received the feedback message or the original message expired).
        /// </summary>
        [JsonProperty(PropertyName = "enqueuedTimeUtc", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime EnqueuedTimeUtc { get; set; }

        /// <summary>
        /// The status of feedback messages that are generated by the IoT hub.
        /// </summary>
        /// <remarks>
        /// Possible values are:
        /// <list type="bullet">
        /// <item>
        /// <description>Success</description>
        /// </item>
        /// <item>
        /// <description>Expired</description>
        /// </item>
        /// <item>
        /// <description>DeliveryCountExceeded</description>
        /// </item>
        /// <item>
        /// <description>Rejected</description>
        /// </item>
        /// <item>
        /// <description>Purged</description>
        /// </item>
        /// </list>
        /// </remarks>
        [JsonProperty(PropertyName = "statusCode", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public FeedbackStatusCode StatusCode { get; set; }

        /// <summary>
        /// Description for <see cref="StatusCode"/>.
        /// </summary>
        [JsonProperty(PropertyName = "description", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }
    }
}