/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.CoreService.Models;

namespace Oci.CoreService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/8.1.0/core/ListVirtualCircuitPublicPrefixes.cs.html">here</a> to see an example of how to use ListVirtualCircuitPublicPrefixes request.
    /// </example>
    public class ListVirtualCircuitPublicPrefixesRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The OCID of the virtual circuit.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VirtualCircuitId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "virtualCircuitId")]
        public string VirtualCircuitId { get; set; }
        
        /// <value>
        /// A filter to only return resources that match the given verification state.
        /// The state value is case-insensitive.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "verificationState")]
        public System.Nullable<VirtualCircuitPublicPrefix.VerificationStateEnum> VerificationState { get; set; }
    }
}
