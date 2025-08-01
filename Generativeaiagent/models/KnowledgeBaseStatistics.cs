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


namespace Oci.GenerativeaiagentService.Models
{
    /// <summary>
    /// Statistics for Default Knowledge Base.
    /// </summary>
    public class KnowledgeBaseStatistics 
    {
        
        /// <value>
        /// Knowledge Base size in bytes.
        /// </value>
        [JsonProperty(PropertyName = "sizeInBytes")]
        public System.Nullable<long> SizeInBytes { get; set; }
        
        /// <value>
        /// Total number of ingested files in Knowledge Base.
        /// </value>
        [JsonProperty(PropertyName = "totalIngestedFiles")]
        public System.Nullable<long> TotalIngestedFiles { get; set; }
        
    }
}
