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


namespace Oci.ObjectstorageService.Models
{
    /// <summary>
    /// The details to create a replication policy.
    /// </summary>
    public class CreateReplicationPolicyDetails 
    {
        
        /// <value>
        /// The name of the policy. Avoid entering confidential information.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The destination region to replicate to, for example \"us-ashburn-1\".
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DestinationRegionName is required.")]
        [JsonProperty(PropertyName = "destinationRegionName")]
        public string DestinationRegionName { get; set; }
        
        /// <value>
        /// The bucket to replicate to in the destination region. Replication policy creation does not automatically
        /// create a destination bucket. Create the destination bucket before creating the policy.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DestinationBucketName is required.")]
        [JsonProperty(PropertyName = "destinationBucketName")]
        public string DestinationBucketName { get; set; }
        
    }
}
