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


namespace Oci.LoggingsearchService.Models
{
    /// <summary>
    /// Search response object.
    /// </summary>
    public class SearchResponse 
    {
        
        /// <value>
        /// List of search results
        /// </value>
        [JsonProperty(PropertyName = "results")]
        public System.Collections.Generic.List<SearchResult> Results { get; set; }
        
        /// <value>
        /// List of log field schema information.
        /// </value>
        [JsonProperty(PropertyName = "fields")]
        public System.Collections.Generic.List<FieldInfo> Fields { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Summary is required.")]
        [JsonProperty(PropertyName = "summary")]
        public SearchResultSummary Summary { get; set; }
        
    }
}
