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


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// The details of a cloud cluster instance discovered in a cloud DB system discovery run.
    /// </summary>
    public class DiscoveredCloudClusterInstance : DiscoveredCloudDbSystemComponent
    {
        
        /// <value>
        /// The name of the host on which the cluster instance is running.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "HostName is required.")]
        [JsonProperty(PropertyName = "hostName")]
        public string HostName { get; set; }
        
        /// <value>
        /// The unique identifier of the Oracle cluster.
        /// </value>
        [JsonProperty(PropertyName = "clusterId")]
        public string ClusterId { get; set; }
                ///
        /// <value>
        /// The role of the cluster node.
        /// </value>
        ///
        public enum NodeRoleEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "HUB")]
            Hub,
            [EnumMember(Value = "LEAF")]
            Leaf
        };

        /// <value>
        /// The role of the cluster node.
        /// </value>
        [JsonProperty(PropertyName = "nodeRole")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<NodeRoleEnum> NodeRole { get; set; }
        
        /// <value>
        /// The Oracle base location of Cluster Ready Services (CRS).
        /// </value>
        [JsonProperty(PropertyName = "crsBaseDirectory")]
        public string CrsBaseDirectory { get; set; }
        
        /// <value>
        /// The Automatic Diagnostic Repository (ADR) home directory for the cluster instance.
        /// </value>
        [JsonProperty(PropertyName = "adrHomeDirectory")]
        public string AdrHomeDirectory { get; set; }
        
        [JsonProperty(PropertyName = "connector")]
        public CloudDbSystemDiscoveryConnector Connector { get; set; }
        
        [JsonProperty(PropertyName = "componentType")]
        private readonly string componentType = "CLUSTER_INSTANCE";
    }
}
