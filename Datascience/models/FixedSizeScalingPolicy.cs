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


namespace Oci.DatascienceService.Models
{
    /// <summary>
    /// The fixed size scaling policy.
    /// </summary>
    public class FixedSizeScalingPolicy : ScalingPolicy
    {
        
        /// <value>
        /// The number of instances for the model deployment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "InstanceCount is required.")]
        [JsonProperty(PropertyName = "instanceCount")]
        public System.Nullable<int> InstanceCount { get; set; }
        
        [JsonProperty(PropertyName = "policyType")]
        private readonly string policyType = "FIXED_SIZE";
    }
}
