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
    
    public class UpdateInstanceDetails 
    {
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a
        /// namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// A user-friendly name. Does not have to be unique, and it's changeable.
        /// Avoid entering confidential information.
        /// <br/>
        /// Example: My bare metal instance
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no
        /// predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Instance agent configuration options to choose for updating the instance
        /// 
        /// </value>
        [JsonProperty(PropertyName = "agentConfig")]
        public UpdateInstanceAgentConfigDetails AgentConfig { get; set; }
        
        /// <value>
        /// Custom metadata key/value string pairs that you provide. Any set of key/value pairs
        /// provided here will completely replace the current set of key/value pairs in the `metadata`
        /// field on the instance.
        /// <br/>
        /// The \"user_data\" field and the \"ssh_authorized_keys\" field cannot be changed after an instance
        /// has launched. Any request that updates, removes, or adds either of these fields will be
        /// rejected. You must provide the same values for \"user_data\" and \"ssh_authorized_keys\" that
        /// already exist on the instance.
        /// <br/>
        /// The combined size of the `metadata` and `extendedMetadata` objects can be a maximum of
        /// 32,000 bytes.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "metadata")]
        public System.Collections.Generic.Dictionary<string, string> Metadata { get; set; }
        
        /// <value>
        /// Additional metadata key/value pairs that you provide. They serve the same purpose and
        /// functionality as fields in the `metadata` object.
        /// <br/>
        /// They are distinguished from `metadata` fields in that these can be nested JSON objects
        /// (whereas `metadata` fields are string/string maps only).
        /// <br/>
        /// The \"user_data\" field and the \"ssh_authorized_keys\" field cannot be changed after an instance
        /// has launched. Any request that updates, removes, or adds either of these fields will be
        /// rejected. You must provide the same values for \"user_data\" and \"ssh_authorized_keys\" that
        /// already exist on the instance.
        /// <br/>
        /// The combined size of the `metadata` and `extendedMetadata` objects can be a maximum of
        /// 32,000 bytes.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "extendedMetadata")]
        public System.Collections.Generic.Dictionary<string, System.Object> ExtendedMetadata { get; set; }
        
        /// <value>
        /// The shape of the instance. The shape determines the number of CPUs and the amount of memory
        /// allocated to the instance. For more information about how to change shapes, and a list of
        /// shapes that are supported, see
        /// [Editing an Instance](https://docs.cloud.oracle.com/iaas/Content/Compute/Tasks/resizinginstances.htm).
        /// <br/>
        /// For details about the CPUs, memory, and other properties of each shape, see
        /// [Compute Shapes](https://docs.cloud.oracle.com/iaas/Content/Compute/References/computeshapes.htm).
        /// <br/>
        /// The new shape must be compatible with the image that was used to launch the instance. You
        /// can enumerate all available shapes and determine image compatibility by calling
        /// {@link #listShapes(ListShapesRequest) listShapes}.
        /// <br/>
        /// If the instance is running when you change the shape, the instance is rebooted.
        /// <br/>
        /// Example: VM.Standard2.1
        /// </value>
        [JsonProperty(PropertyName = "shape")]
        public string Shape { get; set; }
        
        [JsonProperty(PropertyName = "shapeConfig")]
        public UpdateInstanceShapeConfigDetails ShapeConfig { get; set; }
        
        [JsonProperty(PropertyName = "instanceOptions")]
        public InstanceOptions InstanceOptions { get; set; }
        
        /// <value>
        /// A fault domain is a grouping of hardware and infrastructure within an availability domain.
        /// Each availability domain contains three fault domains. Fault domains let you distribute your
        /// instances so that they are not on the same physical hardware within a single availability domain.
        /// A hardware failure or Compute hardware maintenance that affects one fault domain does not affect
        /// instances in other fault domains.
        /// <br/>
        /// To get a list of fault domains, use the
        /// {@link #listFaultDomains(ListFaultDomainsRequest) listFaultDomains} operation in the
        /// Identity and Access Management Service API.
        /// <br/>
        /// Example: FAULT-DOMAIN-1
        /// </value>
        [JsonProperty(PropertyName = "faultDomain")]
        public string FaultDomain { get; set; }
        
        /// <value>
        /// Options for tuning the compatibility and performance of VM shapes.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "launchOptions")]
        public UpdateLaunchOptions LaunchOptions { get; set; }
        
        /// <value>
        /// Options for defining the availability of a VM instance after a maintenance event that impacts the underlying hardware.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "availabilityConfig")]
        public UpdateInstanceAvailabilityConfigDetails AvailabilityConfig { get; set; }
        
    }
}
