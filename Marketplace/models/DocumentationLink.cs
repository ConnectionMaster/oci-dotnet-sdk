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


namespace Oci.MarketplaceService.Models
{
    /// <summary>
    /// A link to a documentation resource on the internet.
    /// </summary>
    public class DocumentationLink 
    {
        
        /// <value>
        /// Text that describes the resource.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <value>
        /// The URL of the resource.
        /// </value>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <value>
        /// The category that the document belongs to.
        /// </value>
        [JsonProperty(PropertyName = "documentCategory")]
        public string DocumentCategory { get; set; }
    }
}
