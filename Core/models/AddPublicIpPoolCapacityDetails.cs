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
    /// <summary>
    /// The information used to add capacity to an IP pool.
    /// </summary>
    public class AddPublicIpPoolCapacityDetails 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the `ByoipRange` resource to which the CIDR block belongs.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ByoipRangeId is required.")]
        [JsonProperty(PropertyName = "byoipRangeId")]
        public string ByoipRangeId { get; set; }
        
        /// <value>
        /// The CIDR block to add to the public IP pool. It could be all of the CIDR block identified in `byoipRangeId`, or a subrange.
        /// Example: 10.0.1.0/24
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CidrBlock is required.")]
        [JsonProperty(PropertyName = "cidrBlock")]
        public string CidrBlock { get; set; }
        
    }
}
