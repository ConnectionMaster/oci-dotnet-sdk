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


namespace Oci.AilanguageService.Models
{
    /// <summary>
    /// Aspect object.
    /// </summary>
    public class SentimentAspect 
    {
        
        /// <value>
        /// The number of Unicode code points preceding this entity in the submitted text.
        /// </value>
        [JsonProperty(PropertyName = "offset")]
        public System.Nullable<int> Offset { get; set; }
        
        /// <value>
        /// Length of text.
        /// </value>
        [JsonProperty(PropertyName = "length")]
        public System.Nullable<int> Length { get; set; }
        
        /// <value>
        /// Aspect text.
        /// </value>
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }
        
        /// <value>
        /// The highest-score sentiment for the aspect text.
        /// </value>
        [JsonProperty(PropertyName = "sentiment")]
        public string Sentiment { get; set; }
        
        /// <value>
        /// Scores for each sentiment.
        /// Example: &quot;{\\&quot;positive\\&quot;: 1.0, \\&quot;negative\\&quot;: 0.0}&quot;
        /// </value>
        [JsonProperty(PropertyName = "scores")]
        public System.Collections.Generic.Dictionary<string, System.Double> Scores { get; set; }
        
    }
}
