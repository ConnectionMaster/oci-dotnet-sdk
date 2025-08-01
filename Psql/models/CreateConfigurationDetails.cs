/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.PsqlService.Models
{
    /// <summary>
    /// The information to create a new configuration.
    /// </summary>
    public class CreateConfigurationDetails 
    {
        
        /// <value>
        /// A user-friendly display name for the configuration. Avoid entering confidential information.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment that contains the configuration.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Details about the configuration set.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Version of the PostgreSQL database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DbVersion is required.")]
        [JsonProperty(PropertyName = "dbVersion")]
        public string DbVersion { get; set; }
        
        /// <value>
        /// The name of the shape for the configuration. 
        /// <br/>
        /// For multi-shape enabled configurations, it is set to PostgreSQL.X86 or similar. Please use compatibleShapes property to set the list of supported shapes.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "shape")]
        public string Shape { get; set; }
        
        /// <value>
        /// Whether the configuration supports flexible shapes.
        /// </value>
        [JsonProperty(PropertyName = "isFlexible")]
        public System.Nullable<bool> IsFlexible { get; set; }
        
        /// <value>
        /// CPU core count.
        /// <br/>
        /// Skip or set it's value to 0 if configuration is for a flexible shape.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "instanceOcpuCount")]
        public System.Nullable<int> InstanceOcpuCount { get; set; }
        
        /// <value>
        /// Memory size in gigabytes with 1GB increment.
        /// <br/>
        /// Skip or set it's value to 0 if configuration is for a flexible shape.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "instanceMemorySizeInGBs")]
        public System.Nullable<int> InstanceMemorySizeInGBs { get; set; }
        
        /// <value>
        /// Indicates the collection of compatible shapes for this configuration.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "compatibleShapes")]
        public System.Collections.Generic.List<string> CompatibleShapes { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DbConfigurationOverrides is required.")]
        [JsonProperty(PropertyName = "dbConfigurationOverrides")]
        public DbConfigurationOverrideCollection DbConfigurationOverrides { get; set; }
        
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
        
        /// <value>
        /// System tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;orcl-cloud&quot;: {&quot;free-tier-retained&quot;: &quot;true&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
    }
}
