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


namespace Oci.ContainerengineService.Models
{
    /// <summary>
    /// The properties that define a request to create a cluster kubeconfig.
    /// </summary>
    public class CreateClusterKubeconfigContentDetails 
    {
        
        /// <value>
        /// The version of the kubeconfig token. Supported value 2.0.0
        /// 
        /// </value>
        [JsonProperty(PropertyName = "tokenVersion")]
        public string TokenVersion { get; set; }
        
        /// <value>
        /// Deprecated. This field is no longer used.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "expiration")]
        public System.Nullable<int> Expiration { get; set; }
        
    }
}
