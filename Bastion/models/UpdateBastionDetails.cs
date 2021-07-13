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


namespace Oci.BastionService.Models
{
    /// <summary>
    /// The configuration to update on an existing bastion.
    /// </summary>
    public class UpdateBastionDetails 
    {
        
        /// <value>
        /// The maximum amount of time that any session on the bastion can remain active.
        /// </value>
        [JsonProperty(PropertyName = "maxSessionTtlInSeconds")]
        public System.Nullable<int> MaxSessionTtlInSeconds { get; set; }
        
        /// <value>
        /// A list of IP addresses of the hosts that the bastion has access to. Not applicable to `standard` bastions.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "staticJumpHostIpAddresses")]
        public System.Collections.Generic.List<string> StaticJumpHostIpAddresses { get; set; }
        
        /// <value>
        /// A list of address ranges in CIDR notation that you want to allow to connect to sessions hosted by this bastion.
        /// </value>
        [JsonProperty(PropertyName = "clientCidrBlockAllowList")]
        public System.Collections.Generic.List<string> ClientCidrBlockAllowList { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
