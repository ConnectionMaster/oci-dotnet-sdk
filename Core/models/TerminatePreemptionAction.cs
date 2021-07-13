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
    /// <summary>
    /// Terminates the preemptible instance when it is interrupted for eviction.
    /// 
    /// </summary>
    public class TerminatePreemptionAction : PreemptionAction
    {
        
        /// <value>
        /// Whether to preserve the boot volume that was used to launch the preemptible instance when the instance is terminated. Defaults to false if not specified.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "preserveBootVolume")]
        public System.Nullable<bool> PreserveBootVolume { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "TERMINATE";
    }
}
