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


namespace Oci.WlmsService.Models
{
    /// <summary>
    /// Information of the backup to be used to restore a server in a domain.
    /// 
    /// </summary>
    public class BackupToRestore 
    {
        
        /// <value>
        /// The unique identifier of the backup to be used to restore.
        /// <br/>
        /// **Note:** Not [OCIDs](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The type of content of the backup.
        /// </value>
        [JsonProperty(PropertyName = "contentType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<BackupContentType> ContentType { get; set; }
        
    }
}
