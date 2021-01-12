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
    /// Log analytics entity type definition to be updated.
    /// </summary>
    public class UpdateLogAnalyticsEntityTypeDetails 
    {
        
        /// <value>
        /// Log analytics entity type category. Category will be used for grouping and filtering.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }
        
        /// <value>
        /// A single log analytics entity type property definition.
        /// </value>
        [JsonProperty(PropertyName = "properties")]
        public System.Collections.Generic.List<EntityTypeProperty> Properties { get; set; }
        
    }
}
