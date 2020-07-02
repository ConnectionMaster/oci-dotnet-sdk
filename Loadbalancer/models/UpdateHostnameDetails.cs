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


namespace Oci.LoadbalancerService.Models
{
    /// <summary>
    /// The configuration details for updating a virtual hostname.
    /// For more information on virtual hostnames, see
    /// [Managing Request Routing](https://docs.cloud.oracle.com/Content/Balance/Tasks/managingrequest.htm).
    /// 
    /// </summary>
    public class UpdateHostnameDetails 
    {
        
        /// <value>
        /// The virtual hostname to update. For more information about virtual hostname string construction, see
        /// [Managing Request Routing](https://docs.cloud.oracle.com/Content/Balance/Tasks/managingrequest.htm#routing).
        /// <br/>
        /// Example: app.example.com
        /// </value>
        [JsonProperty(PropertyName = "hostname")]
        public string Hostname { get; set; }
    }
}
