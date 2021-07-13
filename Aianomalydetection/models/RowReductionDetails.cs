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


namespace Oci.AianomalydetectionService.Models
{
    /// <summary>
    /// Information regarding how/what row reduction methods will be applied. If this property is not present or is null, then it means row reduction is not applied.
    /// </summary>
    public class RowReductionDetails 
    {
        
        /// <value>
        /// A boolean value to indicate if row reduction is applied
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsReductionEnabled is required.")]
        [JsonProperty(PropertyName = "isReductionEnabled")]
        public System.Nullable<bool> IsReductionEnabled { get; set; }
        
        /// <value>
        /// A percentage to reduce data size down to on top of original data
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ReductionPercentage is required.")]
        [JsonProperty(PropertyName = "reductionPercentage")]
        public System.Double ReductionPercentage { get; set; }
                ///
        /// <value>
        /// Method for row reduction:
        ///   * DELETE_ROW - delete rows with equal intervals
        ///   * AVERAGE_ROW - average multiple rows to one row
        /// 
        /// </value>
        ///
        public enum ReductionMethodEnum {
            [EnumMember(Value = "DELETE_ROW")]
            DeleteRow,
            [EnumMember(Value = "AVERAGE_ROW")]
            AverageRow
        };

        /// <value>
        /// Method for row reduction:
        ///   * DELETE_ROW - delete rows with equal intervals
        ///   * AVERAGE_ROW - average multiple rows to one row
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ReductionMethod is required.")]
        [JsonProperty(PropertyName = "reductionMethod")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ReductionMethodEnum> ReductionMethod { get; set; }
        
    }
}
