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


namespace Oci.CoreService.Models
{
    
    public class CreateVirtualCircuitPublicPrefixDetails 
    {
        
        /// <value>
        /// An individual public IP prefix (CIDR) to add to the public virtual circuit.
        /// All prefix sizes are allowed.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CidrBlock is required.")]
        [JsonProperty(PropertyName = "cidrBlock")]
        public string CidrBlock { get; set; }
        
    }
}
