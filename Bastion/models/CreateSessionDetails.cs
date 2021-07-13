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


namespace Oci.BastionService.Models
{
    /// <summary>
    /// The configuration details for a new bastion session. A session lets authorized users connect to a target resource for a predetermined amount of time. The Bastion service recognizes two types of sessions, managed SSH sessions and SSH port forwarding sessions. Managed SSH sessions require that the target resource has an OpenSSH server and the Oracle Cloud Agent both running.
    /// </summary>
    public class CreateSessionDetails 
    {
        
        /// <value>
        /// The name of the session.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The unique identifier (OCID) of the bastion on which to create this session.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BastionId is required.")]
        [JsonProperty(PropertyName = "bastionId")]
        public string BastionId { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TargetResourceDetails is required.")]
        [JsonProperty(PropertyName = "targetResourceDetails")]
        public CreateSessionTargetResourceDetails TargetResourceDetails { get; set; }
                ///
        /// <value>
        /// The type of the key used to connect to the session. PUB is a standard public key in OpenSSH format.
        /// </value>
        ///
        public enum KeyTypeEnum {
            [EnumMember(Value = "PUB")]
            Pub
        };

        /// <value>
        /// The type of the key used to connect to the session. PUB is a standard public key in OpenSSH format.
        /// </value>
        [JsonProperty(PropertyName = "keyType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<KeyTypeEnum> KeyType { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "KeyDetails is required.")]
        [JsonProperty(PropertyName = "keyDetails")]
        public PublicKeyDetails KeyDetails { get; set; }
        
        /// <value>
        /// The amount of time the session can remain active.
        /// </value>
        [JsonProperty(PropertyName = "sessionTtlInSeconds")]
        public System.Nullable<int> SessionTtlInSeconds { get; set; }
        
    }
}