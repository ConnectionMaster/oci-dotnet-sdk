/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.Runtime.Serialization;
using Oci.ObjectstorageService.Models;

namespace Oci.ObjectstorageService.Responses
{
    public class CommitMultipartUploadResponse : Oci.Common.IOciResponse
    {

        /// <value>
        /// Echoes back the value passed in the opc-client-request-id header, for use by clients when debugging.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-client-request-id")]
        public string OpcClientRequestId { get; set; }


        /// <value>
        /// Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular
        /// request, provide this request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }


        /// <value>
        /// Base-64 representation of the multipart object hash.
        /// The multipart object hash is calculated by taking the MD5 hashes of the parts passed to this call,
        /// concatenating the binary representation of those hashes in order of their part numbers,
        /// and then calculating the MD5 hash of the concatenated values. The multipart object hash is followed
        /// by a hyphen and the total number of parts (for example, '-6').
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-multipart-md5")]
        public string OpcMultipartMd5 { get; set; }


        /// <value>
        /// The entity tag (ETag) for the object.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "ETag")]
        public string ETag { get; set; }


        /// <value>
        /// The time the object was last modified, as described in [RFC 2616](https://tools.ietf.org/html/rfc2616#section-14.29).
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "last-modified")]
        public System.Nullable<System.DateTime> LastModified { get; set; }


        /// <value>
        /// VersionId of the newly created object
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "version-id")]
        public string VersionId { get; set; }



    }
}
