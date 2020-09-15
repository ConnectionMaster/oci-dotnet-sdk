/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
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
    /// MatchInfo
    /// </summary>
    public class MatchInfo 
    {
        
        /// <value>
        /// matchingLogEntryEndIndex
        /// </value>
        [JsonProperty(PropertyName = "matchingLogEntryEndIndex")]
        public System.Nullable<int> MatchingLogEntryEndIndex { get; set; }

        /// <value>
        /// regexScore
        /// </value>
        [JsonProperty(PropertyName = "regexScore")]
        public System.Nullable<int> RegexScore { get; set; }

        /// <value>
        /// stepCount
        /// </value>
        [JsonProperty(PropertyName = "stepCount")]
        public System.Nullable<int> StepCount { get; set; }
    }
}