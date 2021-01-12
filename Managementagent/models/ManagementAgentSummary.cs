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


namespace Oci.ManagementagentService.Models
{
    /// <summary>
    /// The summary of the Management Agent inventory including the associated plugins.
    /// </summary>
    public class ManagementAgentSummary 
    {
        
        /// <value>
        /// agent identifier
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// agent install key identifier
        /// </value>
        [JsonProperty(PropertyName = "installKeyId")]
        public string InstallKeyId { get; set; }
        
        /// <value>
        /// Management Agent Name
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Platform Type
        /// </value>
        [JsonProperty(PropertyName = "platformType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<PlatformTypes> PlatformType { get; set; }
        
        /// <value>
        /// Platform Name
        /// </value>
        [JsonProperty(PropertyName = "platformName")]
        public string PlatformName { get; set; }
        
        /// <value>
        /// Platform Version
        /// </value>
        [JsonProperty(PropertyName = "platformVersion")]
        public string PlatformVersion { get; set; }
        
        /// <value>
        /// Management Agent Version
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Version is required.")]
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }
        
        /// <value>
        /// true if the agent can be upgraded automatically; false if it must be upgraded manually. true is currently unsupported.
        /// </value>
        [JsonProperty(PropertyName = "isAgentAutoUpgradable")]
        public System.Nullable<bool> IsAgentAutoUpgradable { get; set; }
        
        /// <value>
        /// The time the Management Agent was created. An RFC3339 formatted datetime string
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// Management Agent host machine name
        /// </value>
        [JsonProperty(PropertyName = "host")]
        public string Host { get; set; }
        
        /// <value>
        /// list of managementAgentPlugins associated with the agent
        /// </value>
        [JsonProperty(PropertyName = "pluginList")]
        public System.Collections.Generic.List<ManagementAgentPluginDetails> PluginList { get; set; }
        
        /// <value>
        /// Compartment Identifier
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The time the Management Agent has last recorded its heartbeat. An RFC3339 formatted datetime string
        /// </value>
        [JsonProperty(PropertyName = "timeLastHeartbeat")]
        public System.Nullable<System.DateTime> TimeLastHeartbeat { get; set; }
        
        /// <value>
        /// The current availability status of managementAgent
        /// </value>
        [JsonProperty(PropertyName = "availabilityStatus")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<AvailabilityStatus> AvailabilityStatus { get; set; }
        
        /// <value>
        /// The current state of managementAgent
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleStates> LifecycleState { get; set; }
        
        /// <value>
        /// A message describing the current state in more detail. For example, can be used to provide actionable information for a resource in Failed state.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
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
