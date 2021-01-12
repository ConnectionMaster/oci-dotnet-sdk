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
    /// Label alias mapping view
    /// </summary>
    public class LogAnalyticsLabelAlias 
    {
        
        /// <value>
        /// alias
        /// </value>
        [JsonProperty(PropertyName = "alias")]
        public string Alias { get; set; }
        
        /// <value>
        /// alias display name
        /// </value>
        [JsonProperty(PropertyName = "aliasDisplayName")]
        public string AliasDisplayName { get; set; }
        
        /// <value>
        /// is system flag
        /// </value>
        [JsonProperty(PropertyName = "isSystem")]
        public System.Nullable<bool> IsSystem { get; set; }
        
        /// <value>
        /// label display name
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// label name
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
                ///
        /// <value>
        /// priority
        /// </value>
        ///
        public enum PriorityEnum {
            [EnumMember(Value = "NONE")]
            None,
            [EnumMember(Value = "LOW")]
            Low,
            [EnumMember(Value = "MEDIUM")]
            Medium,
            [EnumMember(Value = "HIGH")]
            High
        };

        /// <value>
        /// priority
        /// </value>
        [JsonProperty(PropertyName = "priority")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<PriorityEnum> Priority { get; set; }
        
    }
}
