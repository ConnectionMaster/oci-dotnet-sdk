/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.ApmtracesService.Models
{
    /// <summary>
    /// Object that contains the details about a single attribute in the bulk request for which properties are to be updated.
    /// 
    /// </summary>
    public class BulkUpdateAttributeDetail 
    {
        
        /// <value>
        /// Name of the attribute for which notes are to be updated.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AttributeName is required.")]
        [JsonProperty(PropertyName = "attributeName")]
        public string AttributeName { get; set; }
                ///
        /// <value>
        /// Unit of the attribute to be updated.  If unit is not specified, it defaults to NONE.
        /// 
        /// </value>
        ///
        public enum UnitEnum {
            [EnumMember(Value = "NONE")]
            None,
            [EnumMember(Value = "EPOCH_TIME_MS")]
            EpochTimeMs,
            [EnumMember(Value = "BYTES")]
            Bytes,
            [EnumMember(Value = "COUNT")]
            Count,
            [EnumMember(Value = "DURATION_MS")]
            DurationMs,
            [EnumMember(Value = "TRACE_STATUS")]
            TraceStatus,
            [EnumMember(Value = "PERCENTAGE")]
            Percentage
        };

        /// <value>
        /// Unit of the attribute to be updated.  If unit is not specified, it defaults to NONE.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "unit")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<UnitEnum> Unit { get; set; }
                ///
        /// <value>
        /// Namespace of the attribute for which the properties are to be updated.
        /// 
        /// </value>
        ///
        public enum AttributeNameSpaceEnum {
            [EnumMember(Value = "TRACES")]
            Traces,
            [EnumMember(Value = "SYNTHETIC")]
            Synthetic,
            [EnumMember(Value = "LOGS")]
            Logs
        };

        /// <value>
        /// Namespace of the attribute for which the properties are to be updated.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "attributeNameSpace")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<AttributeNameSpaceEnum> AttributeNameSpace { get; set; }
        
    }
}
