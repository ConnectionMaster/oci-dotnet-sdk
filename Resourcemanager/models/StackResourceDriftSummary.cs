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


namespace Oci.ResourcemanagerService.Models
{
    /// <summary>
    /// Drift status details for the indicated resource and stack. Includes actual and expected (defined) properties.
    /// 
    /// </summary>
    public class StackResourceDriftSummary 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the stack.
        /// </value>
        [JsonProperty(PropertyName = "stackId")]
        public string StackId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment where the stack is located.
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The name of the resource as defined in the stack.
        /// </value>
        [JsonProperty(PropertyName = "resourceName")]
        public string ResourceName { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the resource provisioned by Terraform.
        /// </value>
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; set; }
        
        /// <value>
        /// The provider resource type.
        /// Must be supported by the [Oracle Cloud Infrastructure provider](https://www.terraform.io/docs/providers/oci/index.html).
        /// Example: oci_core_instance
        /// </value>
        [JsonProperty(PropertyName = "resourceType")]
        public string ResourceType { get; set; }
                ///
        /// <value>
        /// The drift status of the resource.
        /// A drift status value indicates whether or not the actual state of the resource differs from the expected (defined) state for that resource.
        /// 
        /// </value>
        ///
        public enum ResourceDriftStatusEnum {
            [EnumMember(Value = "NOT_CHECKED")]
            NotChecked,
            [EnumMember(Value = "IN_SYNC")]
            InSync,
            [EnumMember(Value = "MODIFIED")]
            Modified,
            [EnumMember(Value = "DELETED")]
            Deleted
        };

        /// <value>
        /// The drift status of the resource.
        /// A drift status value indicates whether or not the actual state of the resource differs from the expected (defined) state for that resource.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "resourceDriftStatus")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ResourceDriftStatusEnum> ResourceDriftStatus { get; set; }
        
        /// <value>
        /// Actual values of properties that the stack defines for the indicated resource.
        /// Each property and value is provided as a key-value pair.
        /// The following example shows actual values for the resource's display name and server type:
        /// `{\"display_name\": \"tf-default-dhcp-options-new\", \"options.0.server_type\": \"VcnLocalPlusInternet\"}`
        /// 
        /// </value>
        [JsonProperty(PropertyName = "actualProperties")]
        public System.Collections.Generic.Dictionary<string, string> ActualProperties { get; set; }
        
        /// <value>
        /// Expected values of properties that the stack defines for the indicated resource.
        /// Each property and value is provided as a key-value pair.
        /// The following example shows expected (defined) values for the resource's display name and server type:
        /// `{\"display_name\": \"tf-default-dhcp-options\", \"options.0.server_type\": \"VcnLocalPlusInternet\"}`
        /// 
        /// </value>
        [JsonProperty(PropertyName = "expectedProperties")]
        public System.Collections.Generic.Dictionary<string, string> ExpectedProperties { get; set; }
        
        /// <value>
        /// The date and time when the drift detection was executed.
        /// Format is defined by RFC3339.
        /// Example: 2020-01-25T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeDriftChecked")]
        public System.Nullable<System.DateTime> TimeDriftChecked { get; set; }
        
    }
}
