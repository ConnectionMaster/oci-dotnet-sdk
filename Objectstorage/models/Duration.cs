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


namespace Oci.ObjectstorageService.Models
{
    /// <summary>
    /// The amount of time that objects in the bucket should be preserved for and which is calculated in relation to
    /// each object's Last-Modified timestamp. If duration is not present, then there is no time limit and the objects
    /// in the bucket will be preserved indefinitely.
    /// 
    /// </summary>
    public class Duration 
    {
        
        /// <value>
        /// The timeAmount is interpreted in units defined by the timeUnit parameter, and is calculated in relation
        /// to each object's Last-Modified timestamp.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeAmount is required.")]
        [JsonProperty(PropertyName = "timeAmount")]
        public System.Nullable<long> TimeAmount { get; set; }
                ///
        /// <value>
        /// The unit that should be used to interpret timeAmount.
        /// </value>
        ///
        public enum TimeUnitEnum {
            [EnumMember(Value = "YEARS")]
            Years,
            [EnumMember(Value = "DAYS")]
            Days
        };

        /// <value>
        /// The unit that should be used to interpret timeAmount.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeUnit is required.")]
        [JsonProperty(PropertyName = "timeUnit")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<TimeUnitEnum> TimeUnit { get; set; }
        
    }
}
