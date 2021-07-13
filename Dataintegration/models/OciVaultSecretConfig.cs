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
    /// Properties used for specifying OCI vault configuration
    /// </summary>
    public class OciVaultSecretConfig : SecretConfig
    {
        
        /// <value>
        /// OCID of the OCI vault secret
        /// </value>
        [JsonProperty(PropertyName = "secretId")]
        public string SecretId { get; set; }
        
        [JsonProperty(PropertyName = "modelType")]
        private readonly string modelType = "OCI_VAULT_SECRET_CONFIG";
    }
}
