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


namespace Oci.CloudguardService.Models
{
    /// <summary>
    /// Problem Definition.
    /// </summary>
    public class Problem 
    {
        
        /// <value>
        /// Unique identifier that is immutable on creation
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Compartment Identifier where the resource is created
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Identifier of the rule
        /// </value>
        [JsonProperty(PropertyName = "detectorRuleId")]
        public string DetectorRuleId { get; set; }
        
        /// <value>
        /// DEPRECATED
        /// </value>
        [JsonProperty(PropertyName = "region")]
        public string Region { get; set; }
        
        /// <value>
        /// Regions where the problem is found
        /// </value>
        [JsonProperty(PropertyName = "regions")]
        public System.Collections.Generic.List<string> Regions { get; set; }
        
        /// <value>
        /// The Risk Level
        /// </value>
        [JsonProperty(PropertyName = "riskLevel")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<RiskLevel> RiskLevel { get; set; }
        
        /// <value>
        /// Identifier of the Resource
        /// </value>
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; set; }
        
        /// <value>
        /// DisplayName of the Resource
        /// </value>
        [JsonProperty(PropertyName = "resourceName")]
        public string ResourceName { get; set; }
        
        /// <value>
        /// Type of the Resource
        /// </value>
        [JsonProperty(PropertyName = "resourceType")]
        public string ResourceType { get; set; }
        
        /// <value>
        /// user defined labels on the problem
        /// </value>
        [JsonProperty(PropertyName = "labels")]
        public System.Collections.Generic.List<string> Labels { get; set; }
        
        /// <value>
        /// The date and time the problem was last detected. Format defined by RFC3339.
        /// </value>
        [JsonProperty(PropertyName = "timeLastDetected")]
        public System.Nullable<System.DateTime> TimeLastDetected { get; set; }
        
        /// <value>
        /// The date and time the problem was first detected. Format defined by RFC3339.
        /// </value>
        [JsonProperty(PropertyName = "timeFirstDetected")]
        public System.Nullable<System.DateTime> TimeFirstDetected { get; set; }
        
        /// <value>
        /// The current state of the Problem.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ProblemLifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// The lifecycleDetail will give more detail on the substate of the lifecycleState.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetail")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ProblemLifecycleDetail> LifecycleDetail { get; set; }
        
        /// <value>
        /// Id of the detector associated with the Problem.
        /// </value>
        [JsonProperty(PropertyName = "detectorId")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DetectorEnum> DetectorId { get; set; }
        
        /// <value>
        /// targetId of the problem
        /// </value>
        [JsonProperty(PropertyName = "targetId")]
        public string TargetId { get; set; }
        
        /// <value>
        /// User Comments
        /// </value>
        [JsonProperty(PropertyName = "comment")]
        public string Comment { get; set; }
        
    }
}
