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
    /// An object that represents the action of removing a header from a response. This rule applies only to HTTP listeners.
    /// <br/>
    /// If the same header appears more than once in the response, the load balancer removes all occurances of the specified header.
    /// <br/>
    /// **Note:** The system does not distinquish between underscore and dash characters in headers. That is, it treats
    /// `example_header_name` and `example-header-name` as identical. Oracle recommends that you do not rely on underscore
    /// or dash characters to uniquely distinguish header names.
    /// 
    /// </summary>
    public class RemoveHttpResponseHeaderRule : Rule
    {
        
        /// <value>
        /// A header name that conforms to RFC 7230.
        /// <br/>
        /// Example: example_header_name
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Header is required.")]
        [JsonProperty(PropertyName = "header")]
        public string Header { get; set; }
    }
}
