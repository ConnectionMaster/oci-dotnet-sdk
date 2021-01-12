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


namespace Oci.BlockchainService.Models
{
    /// <summary>
    /// Blockchain Platform Instance Description Preview after Scaling.
    /// </summary>
    public class ScaledBlockchainPlatformPreview 
    {
        
        /// <value>
        /// unique identifier that is immutable on creation
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Platform Instance Display name, can be renamed
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
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
        /// Platform Instance Description
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Compute shape - STANDARD or ENTERPRISE_SMALL or ENTERPRISE_MEDIUM or ENTERPRISE_LARGE or ENTERPRISE_EXTRA_LARGE or ENTERPRISE_CUSTOM
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ComputeShape is required.")]
        [JsonProperty(PropertyName = "computeShape")]
        public string ComputeShape { get; set; }
        
        /// <value>
        /// Storage size in TBs
        /// </value>
        [JsonProperty(PropertyName = "storageSizeInTBs")]
        public System.Double StorageSizeInTBs { get; set; }
        
        /// <value>
        /// Storage size in TBs post scaling
        /// </value>
        [JsonProperty(PropertyName = "storageSizeInTBsPostScaling")]
        public System.Double StorageSizeInTBsPostScaling { get; set; }
        
        [JsonProperty(PropertyName = "componentDetails")]
        public BlockchainPlatformComponentDetails ComponentDetails { get; set; }
        
        [JsonProperty(PropertyName = "replicas")]
        public ReplicaDetails Replicas { get; set; }
        
        [JsonProperty(PropertyName = "componentDetailsPostScaling")]
        public BlockchainPlatformComponentDetails ComponentDetailsPostScaling { get; set; }
        
        [JsonProperty(PropertyName = "replicasPostScaling")]
        public ReplicaDetails ReplicasPostScaling { get; set; }
        
        /// <value>
        /// List of OcpuUtilization for all hosts
        /// </value>
        [JsonProperty(PropertyName = "hostOcpuUtilizationInfo")]
        public System.Collections.Generic.List<OcpuUtilizationInfo> HostOcpuUtilizationInfo { get; set; }
        
        /// <value>
        /// List of OcpuUtilization for all hosts after scaling
        /// </value>
        [JsonProperty(PropertyName = "hostOcpuUtilizationInfoPostScaling")]
        public System.Collections.Generic.List<OcpuUtilizationInfo> HostOcpuUtilizationInfoPostScaling { get; set; }
        
        /// <value>
        /// Number of new VMs that would be created
        /// </value>
        [JsonProperty(PropertyName = "newVmCount")]
        public System.Nullable<int> NewVmCount { get; set; }
        
        [JsonProperty(PropertyName = "meteringPreview")]
        public ScaledPlatformMeteringPreview MeteringPreview { get; set; }
        
        [JsonProperty(PropertyName = "scalePayload")]
        public ScaleBlockchainPlatformDetails ScalePayload { get; set; }
        
    }
}
