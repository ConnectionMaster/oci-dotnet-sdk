/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.KeymanagementService.Models;

namespace Oci.KeymanagementService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/keymanagement/RestoreVaultFromFile.cs.html">here</a> to see an example of how to use RestoreVaultFromFile request.
    /// </example>
    public class RestoreVaultFromFileRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The OCID of the compartment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The content length of the body.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "content-length")]
        public System.Nullable<long> ContentLength { get; set; }
        
        /// <value>
        /// The encrypted backup file to upload to restore the vault.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RestoreVaultFromFileDetails is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Body)]
        public System.IO.Stream RestoreVaultFromFileDetails { get; set; }
        
        /// <value>
        /// For optimistic concurrency control. In the PUT or DELETE call for a
        /// resource, set the `if-match` parameter to the value of the etag from a
        /// previous GET or POST response for that resource. The resource will be
        /// updated or deleted only if the etag you provide matches the resource's
        /// current etag value.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "if-match")]
        public string IfMatch { get; set; }
        
        /// <value>
        /// The base64-encoded MD5 hash value of the body, as described in [RFC 2616](https://tools.ietf.org/rfc/rfc2616), section 14.15.
        /// If the Content-MD5 header is present, Key Management performs an integrity check on the body of the HTTP request by computing the MD5
        /// hash for the body and comparing it to the MD5 hash supplied in the header. If the two hashes don't match, the object is rejected and
        /// a response with 400 Unmatched Content MD5 error is returned, along with the message: \"The computed MD5 of the request body (ACTUAL_MD5) 
        /// does not match the Content-MD5 header (HEADER_MD5).\"
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "content-md5")]
        public string ContentMd5 { get; set; }
        
        /// <value>
        /// Unique identifier for the request. If provided, the returned request ID
        /// will include this value. Otherwise, a random request ID will be
        /// generated by the service.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// A token that uniquely identifies a request so it can be retried in case
        /// of a timeout or server error without risk of executing that same action
        /// again. Retry tokens expire after 24 hours, but can be invalidated
        /// before then due to conflicting operations (e.g., if a resource has been
        /// deleted and purged from the system, then a retry of the original
        /// creation request may be rejected).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-retry-token")]
        public string OpcRetryToken { get; set; }
    }
}
