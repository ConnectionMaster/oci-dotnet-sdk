/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.OsmanagementService.Models
{
    /// <summary>
    /// An object for representing a recurrence time interval
    /// </summary>
    public class Recurrence 
    {
                ///
        /// <value>
        /// the interval period for the recurrence
        /// </value>
        ///
        public enum IntervalTypeEnum {
            [EnumMember(Value = "MINUTES")]
            Minutes,
            [EnumMember(Value = "HOURS")]
            Hours,
            [EnumMember(Value = "DAYS")]
            Days,
            [EnumMember(Value = "WEEKS")]
            Weeks
        };

        /// <value>
        /// the interval period for the recurrence
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IntervalType is required.")]
        [JsonProperty(PropertyName = "intervalType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<IntervalTypeEnum> IntervalType { get; set; }
        
        /// <value>
        /// the value for the interval period for the recurrence
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IntervalValue is required.")]
        [JsonProperty(PropertyName = "intervalValue")]
        public string IntervalValue { get; set; }
        
    }
}
