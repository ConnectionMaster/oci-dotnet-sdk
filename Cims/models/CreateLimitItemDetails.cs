/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.CimsService.Models
{
    /// <summary>
    /// Details of Limit Item
    /// </summary>
    public class CreateLimitItemDetails : CreateItemDetails
    {
        
        /// <value>
        /// Current available limit of the resource
        /// </value>
        [JsonProperty(PropertyName = "currentLimit")]
        public System.Nullable<int> CurrentLimit { get; set; }

        /// <value>
        /// Current used limit of the resource
        /// </value>
        [JsonProperty(PropertyName = "currentUsage")]
        public System.Nullable<int> CurrentUsage { get; set; }

        /// <value>
        /// Requested limit for the resource
        /// </value>
        [JsonProperty(PropertyName = "requestedLimit")]
        public System.Nullable<int> RequestedLimit { get; set; }
        ///
        /// <value>
        /// Status of the Limit
        /// </value>
        ///
        public enum LimitStatusEnum {
            [EnumMember(Value = "APPROVED")]
            Approved,
            [EnumMember(Value = "PARTIALLY_APPROVED")]
            PartiallyApproved,
            [EnumMember(Value = "NOT_APPROVED")]
            NotApproved
        };

        /// <value>
        /// Status of the Limit
        /// </value>
        [JsonProperty(PropertyName = "limitStatus")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LimitStatusEnum> LimitStatus { get; set; }
    }
}
