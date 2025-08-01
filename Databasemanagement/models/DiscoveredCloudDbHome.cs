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


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// The details of an Oracle DB home discovered in a cloud DB system discovery run.
    /// </summary>
    public class DiscoveredCloudDbHome : DiscoveredCloudDbSystemComponent
    {
        
        /// <value>
        /// The location of the DB home.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "HomeDirectory is required.")]
        [JsonProperty(PropertyName = "homeDirectory")]
        public string HomeDirectory { get; set; }
        
        [JsonProperty(PropertyName = "componentType")]
        private readonly string componentType = "DATABASE_HOME";
    }
}
