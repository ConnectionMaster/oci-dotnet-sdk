/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.WlmsService.Models;

namespace Oci.WlmsService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/wlms/UpdateWlsDomainCredential.cs.html">here</a> to see an example of how to use UpdateWlsDomainCredential request.
    /// </example>
    public class UpdateWlsDomainCredentialRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the WebLogic domain.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "WlsDomainId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "wlsDomainId")]
        public string WlsDomainId { get; set; }
        
        ///
        /// <value>
        /// The type of the credentials.
        /// </value>
        ///
        public enum CredentialTypeEnum {
            [EnumMember(Value = "weblogicAdminUser")]
            WeblogicAdminUser,
            [EnumMember(Value = "nodemanagerUser")]
            NodemanagerUser
        };

        /// <value>
        /// The type of the credentials.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CredentialType is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "credentialType")]
        public System.Nullable<CredentialTypeEnum> CredentialType { get; set; }
        
        /// <value>
        /// The WebLogic domain credentials.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UpdateWlsDomainCredentialDetails is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Body)]
        public UpdateWlsDomainCredentialDetails UpdateWlsDomainCredentialDetails { get; set; }
        
        /// <value>
        /// For optimistic concurrency control. In the PUT or DELETE call
        /// for a resource, set the `if-match` parameter to the value of the
        /// ETag from a previous GET or POST response for that resource.
        /// The resource will be updated or deleted only if the ETag you
        /// provide matches the resource's current ETag value.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "if-match")]
        public string IfMatch { get; set; }
        
        /// <value>
        /// The client request ID for tracing.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}
