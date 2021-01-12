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
    /// LogAnalyticsParserField
    /// </summary>
    public class LogAnalyticsParserField 
    {
        
        [JsonProperty(PropertyName = "field")]
        public LogAnalyticsField Field { get; set; }
        
        /// <value>
        /// parser field map Id
        /// </value>
        [JsonProperty(PropertyName = "parserFieldId")]
        public System.Nullable<long> ParserFieldId { get; set; }
        
        /// <value>
        /// field expression
        /// </value>
        [JsonProperty(PropertyName = "parserFieldExpression")]
        public string ParserFieldExpression { get; set; }
        
        /// <value>
        /// field internal name
        /// </value>
        [JsonProperty(PropertyName = "parserFieldName")]
        public string ParserFieldName { get; set; }
        
        /// <value>
        /// internal name
        /// </value>
        [JsonProperty(PropertyName = "storageFieldName")]
        public string StorageFieldName { get; set; }
        
        /// <value>
        /// integrator name
        /// </value>
        [JsonProperty(PropertyName = "parserFieldIntegratorName")]
        public string ParserFieldIntegratorName { get; set; }
        
        /// <value>
        /// parser internal name
        /// </value>
        [JsonProperty(PropertyName = "parserName")]
        public string ParserName { get; set; }
        
        /// <value>
        /// sequence
        /// </value>
        [JsonProperty(PropertyName = "parserFieldSequence")]
        public System.Nullable<long> ParserFieldSequence { get; set; }
        
        [JsonProperty(PropertyName = "parser")]
        public LogAnalyticsParser Parser { get; set; }
        
        /// <value>
        /// structured column information
        /// </value>
        [JsonProperty(PropertyName = "structuredColumnInfo")]
        public string StructuredColumnInfo { get; set; }
        
    }
}
