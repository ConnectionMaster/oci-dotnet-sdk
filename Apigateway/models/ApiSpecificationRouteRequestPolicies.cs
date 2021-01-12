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


namespace Oci.ApigatewayService.Models
{
    /// <summary>
    /// Behavior applied to any requests received by the API on this route.
    /// 
    /// </summary>
    public class ApiSpecificationRouteRequestPolicies 
    {
        
        [JsonProperty(PropertyName = "authorization")]
        public RouteAuthorizationPolicy Authorization { get; set; }
        
        [JsonProperty(PropertyName = "cors")]
        public CorsPolicy Cors { get; set; }
        
        [JsonProperty(PropertyName = "headerTransformations")]
        public HeaderTransformationPolicy HeaderTransformations { get; set; }
        
        [JsonProperty(PropertyName = "queryParameterTransformations")]
        public QueryParameterTransformationPolicy QueryParameterTransformations { get; set; }
        
    }
}
