/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.MarketplacepublisherService.Models
{
    /// <summary>
    /// Guidelines to be displayed to the Customer who intends to generate a lead for a listing.
    /// </summary>
    public class DownloadInfo 
    {
        
        /// <value>
        /// Text shown when capturing lead
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Redirect link provided by publisher
        /// </value>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
        
    }
}
