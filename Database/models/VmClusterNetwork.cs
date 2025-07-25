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


namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// The VM cluster network.
    /// </summary>
    public class VmClusterNetwork 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the VM cluster network.
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Exadata infrastructure.
        /// </value>
        [JsonProperty(PropertyName = "exadataInfrastructureId")]
        public string ExadataInfrastructureId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment.
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the associated VM Cluster.
        /// </value>
        [JsonProperty(PropertyName = "vmClusterId")]
        public string VmClusterId { get; set; }
        
        /// <value>
        /// The user-friendly name for the VM cluster network. The name does not need to be unique.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The SCAN details.
        /// </value>
        [JsonProperty(PropertyName = "scans")]
        public System.Collections.Generic.List<ScanDetails> Scans { get; set; }
        
        /// <value>
        /// The list of DNS server IP addresses. Maximum of 3 allowed.
        /// </value>
        [JsonProperty(PropertyName = "dns")]
        public System.Collections.Generic.List<string> Dns { get; set; }
        
        /// <value>
        /// The list of NTP server IP addresses. Maximum of 3 allowed.
        /// </value>
        [JsonProperty(PropertyName = "ntp")]
        public System.Collections.Generic.List<string> Ntp { get; set; }
        
        /// <value>
        /// Details of the client and backup networks.
        /// </value>
        [JsonProperty(PropertyName = "vmNetworks")]
        public System.Collections.Generic.List<VmNetworkDetails> VmNetworks { get; set; }
        
        /// <value>
        /// The SCAN details for DR network
        /// </value>
        [JsonProperty(PropertyName = "drScans")]
        public System.Collections.Generic.List<DrScanDetails> DrScans { get; set; }
                ///
        /// <value>
        /// The current state of the VM cluster network.
        /// CREATING - The resource is being created
        /// REQUIRES_VALIDATION - The resource is created and may not be usable until it is validated.
        /// VALIDATING - The resource is being validated and not available to use.
        /// VALIDATED - The resource is validated and is available for consumption by VM cluster.
        /// VALIDATION_FAILED - The resource validation has failed and might require user input to be corrected.
        /// UPDATING - The resource is being updated and not available to use.
        /// ALLOCATED - The resource is is currently being used by VM cluster.
        /// TERMINATING - The resource is being deleted and not available to use.
        /// TERMINATED - The resource is deleted and unavailable.
        /// FAILED - The resource is in a failed state due to validation or other errors.
        /// NEEDS_ATTENTION - The resource is in needs attention state as some of it's child nodes are not validated
        ///                   and unusable by VM cluster.
        /// 
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CREATING")]
            Creating,
            [EnumMember(Value = "REQUIRES_VALIDATION")]
            RequiresValidation,
            [EnumMember(Value = "VALIDATING")]
            Validating,
            [EnumMember(Value = "VALIDATED")]
            Validated,
            [EnumMember(Value = "VALIDATION_FAILED")]
            ValidationFailed,
            [EnumMember(Value = "UPDATING")]
            Updating,
            [EnumMember(Value = "ALLOCATED")]
            Allocated,
            [EnumMember(Value = "TERMINATING")]
            Terminating,
            [EnumMember(Value = "TERMINATED")]
            Terminated,
            [EnumMember(Value = "FAILED")]
            Failed,
            [EnumMember(Value = "NEEDS_ATTENTION")]
            NeedsAttention
        };

        /// <value>
        /// The current state of the VM cluster network.
        /// CREATING - The resource is being created
        /// REQUIRES_VALIDATION - The resource is created and may not be usable until it is validated.
        /// VALIDATING - The resource is being validated and not available to use.
        /// VALIDATED - The resource is validated and is available for consumption by VM cluster.
        /// VALIDATION_FAILED - The resource validation has failed and might require user input to be corrected.
        /// UPDATING - The resource is being updated and not available to use.
        /// ALLOCATED - The resource is is currently being used by VM cluster.
        /// TERMINATING - The resource is being deleted and not available to use.
        /// TERMINATED - The resource is deleted and unavailable.
        /// FAILED - The resource is in a failed state due to validation or other errors.
        /// NEEDS_ATTENTION - The resource is in needs attention state as some of it's child nodes are not validated
        ///                   and unusable by VM cluster.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// The date and time when the VM cluster network was created.
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// Additional information about the current lifecycle state.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// System tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
    }
}
