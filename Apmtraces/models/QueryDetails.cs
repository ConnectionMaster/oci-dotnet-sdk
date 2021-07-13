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


namespace Oci.ApmtracesService.Models
{
    /// <summary>
    /// Request object containing the query to be run against our repository.
    /// 
    /// </summary>
    public class QueryDetails 
    {
        
        /// <value>
        /// APM defined query string to run against our repository and return results for.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "queryText")]
        public string QueryText { get; set; }
        
    }
}
