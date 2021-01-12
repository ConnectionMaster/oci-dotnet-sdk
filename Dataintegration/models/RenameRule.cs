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


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// Lets you rename an attribute.
    /// </summary>
    public class RenameRule : ProjectionRule
    {
        
        /// <value>
        /// Specifies whether to skip remaining rules when a match is found.
        /// </value>
        [JsonProperty(PropertyName = "isSkipRemainingRulesOnMatch")]
        public System.Nullable<bool> IsSkipRemainingRulesOnMatch { get; set; }
        
        /// <value>
        /// The attribute name that needs to be renamed.
        /// </value>
        [JsonProperty(PropertyName = "fromName")]
        public string FromName { get; set; }
        
        /// <value>
        /// The new attribute name.
        /// </value>
        [JsonProperty(PropertyName = "toName")]
        public string ToName { get; set; }
        
        [JsonProperty(PropertyName = "modelType")]
        private readonly string modelType = "RENAME_RULE";
    }
}
