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


namespace Oci.LoganalyticsService.Models
{
    /// <summary>
    /// Command descriptor for querylanguage LINK command.
    /// 
    /// </summary>
    public class LinkCommandDescriptor : AbstractCommandDescriptor
    {
        
        /// <value>
        /// Option to return groups with a null value if specified.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "shouldIncludeNulls")]
        public System.Nullable<bool> ShouldIncludeNulls { get; set; }
        
        /// <value>
        /// Option to calculate trends of each group if specified.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "shouldIncludeTrends")]
        public System.Nullable<bool> ShouldIncludeTrends { get; set; }
        
        /// <value>
        /// Option to control the size of buckets in the histogram e.g 8hrs  - each bar other than first and last should represent 8hr time span. Will be adjusted to a larger span if time range is very large.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "span")]
        public string Span { get; set; }
        
        [JsonProperty(PropertyName = "name")]
        private readonly string name = "LINK";
    }
}
