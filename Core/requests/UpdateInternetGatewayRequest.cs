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
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/8.1.0/core/UpdateInternetGateway.cs.html">here</a> to see an example of how to use UpdateInternetGateway request.
    /// </example>
    public class UpdateInternetGatewayRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The OCID of the internet gateway.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IgId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "igId")]
        public string IgId { get; set; }
        
        /// <value>
        /// Details for updating the internet gateway.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UpdateInternetGatewayDetails is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Body)]
        public UpdateInternetGatewayDetails UpdateInternetGatewayDetails { get; set; }
        
        /// <value>
        /// For optimistic concurrency control. In the PUT or DELETE call for a resource, set the `if-match`
        /// parameter to the value of the etag from a previous GET or POST response for that resource.  The resource
        /// will be updated or deleted only if the etag you provide matches the resource's current etag value.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "if-match")]
        public string IfMatch { get; set; }
    }
}
