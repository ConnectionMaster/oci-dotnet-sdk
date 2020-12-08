/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
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
    /// Details of the cloud VM cluster. Applies to Exadata Cloud Service instances only.
    /// 
    /// </summary>
    public class CloudVmClusterSummary 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the cloud VM cluster.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The name of the availability domain that the cloud Exadata infrastructure resource is located in.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AvailabilityDomain is required.")]
        [JsonProperty(PropertyName = "availabilityDomain")]
        public string AvailabilityDomain { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the subnet associated with the cloud VM cluster.
        /// <br/>
        /// **Subnet Restrictions:**
        /// - For Exadata and virtual machine 2-node RAC systems, do not use a subnet that overlaps with 192.168.128.0/20.
        /// <br/>
        /// These subnets are used by the Oracle Clusterware private interconnect on the database instance.
        /// Specifying an overlapping subnet will cause the private interconnect to malfunction.
        /// This restriction applies to both the client subnet and backup subnet.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SubnetId is required.")]
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the backup network subnet associated with the cloud VM cluster.
        /// <br/>
        /// **Subnet Restriction:** See the subnet restrictions information for **subnetId**.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "backupSubnetId")]
        public string BackupSubnetId { get; set; }
        
        /// <value>
        /// A list of the [OCIDs](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the network security groups (NSGs) that this resource belongs to. Setting this to an empty array after the list is created removes the resource from all NSGs. For more information about NSGs, see [Security Rules](https://docs.cloud.oracle.com/Content/Network/Concepts/securityrules.htm).
        /// **NsgIds restrictions:**
        /// - Autonomous Databases with private access require at least 1 Network Security Group (NSG). The nsgIds array cannot be empty.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "nsgIds")]
        public System.Collections.Generic.List<string> NsgIds { get; set; }
        
        /// <value>
        /// A list of the [OCIDs](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the network security groups (NSGs) that the backup network of this DB system belongs to. Setting this to an empty array after the list is created removes the resource from all NSGs. For more information about NSGs, see [Security Rules](https://docs.cloud.oracle.com/Content/Network/Concepts/securityrules.htm). Applicable only to Exadata systems.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "backupNetworkNsgIds")]
        public System.Collections.Generic.List<string> BackupNetworkNsgIds { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the last maintenance update history entry. This value is updated when a maintenance update starts.
        /// </value>
        [JsonProperty(PropertyName = "lastUpdateHistoryEntryId")]
        public string LastUpdateHistoryEntryId { get; set; }
        
        /// <value>
        /// The model name of the Exadata hardware running the cloud VM cluster.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Shape is required.")]
        [JsonProperty(PropertyName = "shape")]
        public string Shape { get; set; }
        
        /// <value>
        /// The port number configured for the listener on the cloud VM cluster.
        /// </value>
        [JsonProperty(PropertyName = "listenerPort")]
        public System.Nullable<long> ListenerPort { get; set; }
                ///
        /// <value>
        /// The current state of the cloud VM cluster.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            [EnumMember(Value = "PROVISIONING")]
            Provisioning,
            [EnumMember(Value = "AVAILABLE")]
            Available,
            [EnumMember(Value = "UPDATING")]
            Updating,
            [EnumMember(Value = "TERMINATING")]
            Terminating,
            [EnumMember(Value = "TERMINATED")]
            Terminated,
            [EnumMember(Value = "FAILED")]
            Failed,
            [EnumMember(Value = "MAINTENANCE_IN_PROGRESS")]
            MaintenanceInProgress
        };

        /// <value>
        /// The current state of the cloud VM cluster.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// The number of nodes in the cloud VM cluster.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "nodeCount")]
        public System.Nullable<int> NodeCount { get; set; }
        
        /// <value>
        /// The storage allocation for the disk group, in gigabytes (GB).
        /// </value>
        [JsonProperty(PropertyName = "storageSizeInGBs")]
        public System.Nullable<int> StorageSizeInGBs { get; set; }
        
        /// <value>
        /// The user-friendly name for the cloud VM cluster. The name does not need to be unique.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The date and time that the cloud VM cluster was created.
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// Additional information about the current lifecycle state.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        /// <value>
        /// The time zone of the cloud VM cluster. For details, see [Exadata Infrastructure Time Zones](https://docs.cloud.oracle.com/Content/Database/References/timezones.htm).
        /// </value>
        [JsonProperty(PropertyName = "timeZone")]
        public string TimeZone { get; set; }
        
        /// <value>
        /// The hostname for the cloud VM cluster.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Hostname is required.")]
        [JsonProperty(PropertyName = "hostname")]
        public string Hostname { get; set; }
        
        /// <value>
        /// The domain name for the cloud VM cluster.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Domain is required.")]
        [JsonProperty(PropertyName = "domain")]
        public string Domain { get; set; }
        
        /// <value>
        /// The number of CPU cores enabled on the cloud VM cluster.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CpuCoreCount is required.")]
        [JsonProperty(PropertyName = "cpuCoreCount")]
        public System.Nullable<int> CpuCoreCount { get; set; }
        
        /// <value>
        /// The cluster name for cloud VM cluster. The cluster name must begin with an alphabetic character, and may contain hyphens (-). Underscores (_) are not permitted. The cluster name can be no longer than 11 characters and is not case sensitive.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "clusterName")]
        public string ClusterName { get; set; }
        
        /// <value>
        /// The percentage assigned to DATA storage (user data and database files).
        /// The remaining percentage is assigned to RECO storage (database redo logs, archive logs, and recovery manager backups). Accepted values are 35, 40, 60 and 80. The default is 80 percent assigned to DATA storage. See [Storage Configuration](https://docs.cloud.oracle.com/Content/Database/Concepts/exaoverview.htm#Exadata) in the Exadata documentation for details on the impact of the configuration settings on storage.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "dataStoragePercentage")]
        public System.Nullable<int> DataStoragePercentage { get; set; }
        
        /// <value>
        /// If true, database backup on local Exadata storage is configured for the cloud VM cluster. If false, database backup on local Exadata storage is not available in the cloud VM cluster.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isLocalBackupEnabled")]
        public System.Nullable<bool> IsLocalBackupEnabled { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the cloud Exadata infrastructure.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CloudExadataInfrastructureId is required.")]
        [JsonProperty(PropertyName = "cloudExadataInfrastructureId")]
        public string CloudExadataInfrastructureId { get; set; }
        
        /// <value>
        /// If true, sparse disk group is configured for the cloud VM cluster. If false, sparse disk group is not created.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isSparseDiskgroupEnabled")]
        public System.Nullable<bool> IsSparseDiskgroupEnabled { get; set; }
        
        /// <value>
        /// A valid Oracle Grid Infrastructure (GI) software version.
        /// </value>
        [JsonProperty(PropertyName = "giVersion")]
        public string GiVersion { get; set; }
        
        /// <value>
        /// Operating system version of the image.
        /// </value>
        [JsonProperty(PropertyName = "systemVersion")]
        public string SystemVersion { get; set; }
        
        /// <value>
        /// The public key portion of one or more key pairs used for SSH access to the cloud VM cluster.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SshPublicKeys is required.")]
        [JsonProperty(PropertyName = "sshPublicKeys")]
        public System.Collections.Generic.List<string> SshPublicKeys { get; set; }
                ///
        /// <value>
        /// The Oracle license model that applies to the cloud VM cluster. The default is LICENSE_INCLUDED.
        /// 
        /// </value>
        ///
        public enum LicenseModelEnum {
            [EnumMember(Value = "LICENSE_INCLUDED")]
            LicenseIncluded,
            [EnumMember(Value = "BRING_YOUR_OWN_LICENSE")]
            BringYourOwnLicense
        };

        /// <value>
        /// The Oracle license model that applies to the cloud VM cluster. The default is LICENSE_INCLUDED.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "licenseModel")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LicenseModelEnum> LicenseModel { get; set; }
                ///
        /// <value>
        /// The type of redundancy configured for the cloud Vm cluster.
        /// NORMAL is 2-way redundancy.
        /// HIGH is 3-way redundancy.
        /// 
        /// </value>
        ///
        public enum DiskRedundancyEnum {
            [EnumMember(Value = "HIGH")]
            High,
            [EnumMember(Value = "NORMAL")]
            Normal
        };

        /// <value>
        /// The type of redundancy configured for the cloud Vm cluster.
        /// NORMAL is 2-way redundancy.
        /// HIGH is 3-way redundancy.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "diskRedundancy")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DiskRedundancyEnum> DiskRedundancy { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Single Client Access Name (SCAN) IP addresses associated with the cloud VM cluster.
        /// SCAN IP addresses are typically used for load balancing and are not assigned to any interface.
        /// Oracle Clusterware directs the requests to the appropriate nodes in the cluster.
        /// <br/>
        /// **Note:** For a single-node DB system, this list is empty.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "scanIpIds")]
        public System.Collections.Generic.List<string> ScanIpIds { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the virtual IP (VIP) addresses associated with the cloud VM cluster.
        /// The Cluster Ready Services (CRS) creates and maintains one VIP address for each node in the Exadata Cloud Service instance to
        /// enable failover. If one node fails, the VIP is reassigned to another active node in the cluster.
        /// <br/>
        /// **Note:** For a single-node DB system, this list is empty.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "vipIds")]
        public System.Collections.Generic.List<string> VipIds { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the DNS record for the SCAN IP addresses that are associated with the cloud VM cluster.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "scanDnsRecordId")]
        public string ScanDnsRecordId { get; set; }
        
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
        
    }
}
