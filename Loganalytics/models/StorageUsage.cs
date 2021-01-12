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
    /// This is the storage usage information of a tenancy in Logan Analytics application
    /// </summary>
    public class StorageUsage 
    {
        
        /// <value>
        /// This is the number of bytes of active data (non-archived)
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ActiveDataSizeInBytes is required.")]
        [JsonProperty(PropertyName = "activeDataSizeInBytes")]
        public System.Nullable<long> ActiveDataSizeInBytes { get; set; }
        
        /// <value>
        /// This is the number of bytes of archived data in object storage
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ArchivedDataSizeInBytes is required.")]
        [JsonProperty(PropertyName = "archivedDataSizeInBytes")]
        public System.Nullable<long> ArchivedDataSizeInBytes { get; set; }
        
        /// <value>
        /// This is the number of bytes of recalled data from archived in object store
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RecalledArchivedDataSizeInBytes is required.")]
        [JsonProperty(PropertyName = "recalledArchivedDataSizeInBytes")]
        public System.Nullable<long> RecalledArchivedDataSizeInBytes { get; set; }
        
    }
}
