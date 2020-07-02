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


namespace Oci.ResourcemanagerService.Models
{
    /// <summary>
    /// A Terraform version supported for use with stacks.
    /// 
    /// </summary>
    public class TerraformVersionSummary 
    {
        
        /// <value>
        /// A supported Terraform version. Example: 0.12.x
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}
