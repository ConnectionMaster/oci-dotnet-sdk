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


namespace Oci.NosqlService.Models
{
    /// <summary>
    /// Throughput and storage limits configuration of a table.
    /// </summary>
    public class TableLimits 
    {
        
        /// <value>
        /// Maximum sustained read throughput limit for the table.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MaxReadUnits is required.")]
        [JsonProperty(PropertyName = "maxReadUnits")]
        public System.Nullable<int> MaxReadUnits { get; set; }

        /// <value>
        /// Maximum sustained write throughput limit for the table.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MaxWriteUnits is required.")]
        [JsonProperty(PropertyName = "maxWriteUnits")]
        public System.Nullable<int> MaxWriteUnits { get; set; }

        /// <value>
        /// Maximum size of storage used by the table.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MaxStorageInGBs is required.")]
        [JsonProperty(PropertyName = "maxStorageInGBs")]
        public System.Nullable<int> MaxStorageInGBs { get; set; }
    }
}
