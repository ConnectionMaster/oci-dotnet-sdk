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
    /// Violation
    /// </summary>
    public class Violation 
    {
        
        /// <value>
        /// indexes
        /// </value>
        [JsonProperty(PropertyName = "indexes")]
        public System.Collections.Generic.List<Indexes> Indexes { get; set; }
        
        /// <value>
        /// ruleDescription
        /// </value>
        [JsonProperty(PropertyName = "ruleDescription")]
        public string RuleDescription { get; set; }
        
        /// <value>
        /// ruleName
        /// </value>
        [JsonProperty(PropertyName = "ruleName")]
        public string RuleName { get; set; }
        
        /// <value>
        /// ruleRemediation
        /// </value>
        [JsonProperty(PropertyName = "ruleRemediation")]
        public string RuleRemediation { get; set; }
                ///
        /// <value>
        /// ruleType
        /// </value>
        ///
        public enum RuleTypeEnum {
            [EnumMember(Value = "WARN")]
            Warn,
            [EnumMember(Value = "ERROR")]
            Error
        };

        /// <value>
        /// ruleType
        /// </value>
        [JsonProperty(PropertyName = "ruleType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<RuleTypeEnum> RuleType { get; set; }
        
    }
}
