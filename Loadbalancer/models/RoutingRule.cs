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


namespace Oci.LoadbalancerService.Models
{
    /// <summary>
    /// A routing rule examines an incoming request, routing matching requests to the specified backend set.
    /// Routing rules apply only to HTTP and HTTPS requests. They have no effect on TCP requests.
    /// 
    /// </summary>
    public class RoutingRule 
    {
        
        /// <value>
        /// A unique name for the routing policy rule. Avoid entering confidential information.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// A routing rule to evaluate defined conditions against the incoming HTTP request and perform an action.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Condition is required.")]
        [JsonProperty(PropertyName = "condition")]
        public string Condition { get; set; }
        
        /// <value>
        /// A list of actions to be applied when conditions of the routing rule are met.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Actions is required.")]
        [JsonProperty(PropertyName = "actions")]
        public System.Collections.Generic.List<Action> Actions { get; set; }
        
    }
}
