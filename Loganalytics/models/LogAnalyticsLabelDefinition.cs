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
    /// LogAnalyticsLabelDefinition
    /// </summary>
    public class LogAnalyticsLabelDefinition 
    {
        
        /// <value>
        /// edit version
        /// </value>
        [JsonProperty(PropertyName = "editVersion")]
        public System.Nullable<long> EditVersion { get; set; }
        
        /// <value>
        /// is system flag
        /// </value>
        [JsonProperty(PropertyName = "isSystem")]
        public System.Nullable<bool> IsSystem { get; set; }
        
        /// <value>
        /// source Id
        /// </value>
        [JsonProperty(PropertyName = "sourceId")]
        public System.Nullable<long> SourceId { get; set; }
        
        /// <value>
        /// label name
        /// </value>
        [JsonProperty(PropertyName = "labelName")]
        public string LabelName { get; set; }
        
    }
}
