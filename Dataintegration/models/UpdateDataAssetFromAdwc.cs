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


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// Details for the Autonomous Data Warehouse data asset type.
    /// </summary>
    public class UpdateDataAssetFromAdwc : UpdateDataAssetDetails
    {
        
        /// <value>
        /// The Autonomous Data Warehouse instance service name.
        /// </value>
        [JsonProperty(PropertyName = "serviceName")]
        public string ServiceName { get; set; }
        
        /// <value>
        /// The Autonomous Data Warehouse driver class.
        /// </value>
        [JsonProperty(PropertyName = "driverClass")]
        public string DriverClass { get; set; }
        
        /// <value>
        /// The credential file content from a Autonomous Data Warehouse wallet.
        /// </value>
        [JsonProperty(PropertyName = "credentialFileContent")]
        public string CredentialFileContent { get; set; }
        
        [JsonProperty(PropertyName = "defaultConnection")]
        public UpdateConnectionFromAdwc DefaultConnection { get; set; }
        
        [JsonProperty(PropertyName = "modelType")]
        private readonly string modelType = "ORACLE_ADWC_DATA_ASSET";
    }
}
