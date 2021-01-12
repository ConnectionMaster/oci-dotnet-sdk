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


namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// Backup destination details
    /// </summary>
    public class BackupDestinationDetails 
    {
                ///
        /// <value>
        /// Type of the database backup destination.
        /// </value>
        ///
        public enum TypeEnum {
            [EnumMember(Value = "NFS")]
            Nfs,
            [EnumMember(Value = "RECOVERY_APPLIANCE")]
            RecoveryAppliance,
            [EnumMember(Value = "OBJECT_STORE")]
            ObjectStore,
            [EnumMember(Value = "LOCAL")]
            Local
        };

        /// <value>
        /// Type of the database backup destination.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Type is required.")]
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<TypeEnum> Type { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the backup destination.
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// For a RECOVERY_APPLIANCE backup destination, the Virtual Private Catalog (VPC) user that is used to access the Recovery Appliance.
        /// </value>
        [JsonProperty(PropertyName = "vpcUser")]
        public string VpcUser { get; set; }
        
        /// <value>
        /// For a RECOVERY_APPLIANCE backup destination, the password for the VPC user that is used to access the Recovery Appliance.
        /// </value>
        [JsonProperty(PropertyName = "vpcPassword")]
        public string VpcPassword { get; set; }
        
        /// <value>
        /// Proxy URL to connect to object store.
        /// </value>
        [JsonProperty(PropertyName = "internetProxy")]
        public string InternetProxy { get; set; }
        
    }
}
