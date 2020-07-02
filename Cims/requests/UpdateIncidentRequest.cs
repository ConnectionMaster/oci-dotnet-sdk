/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.CimsService.Models;

namespace Oci.CimsService.Requests
{
    public class UpdateIncidentRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// Unique ID that identifies an incident
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IncidentKey is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "incidentKey")]
        public string IncidentKey { get; set; }
        
        /// <value>
        /// Customer Support Identifier of the support account
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Csi is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "csi")]
        public string Csi { get; set; }
        
        /// <value>
        /// Details of Resource to be updated
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UpdateIncidentDetails is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Body)]
        public UpdateIncident UpdateIncidentDetails { get; set; }
        
        /// <value>
        /// User OCID for IDCS users that have a shadow in OCI
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Ocid is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "ocid")]
        public string Ocid { get; set; }
        
        /// <value>
        /// Retry token
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-retry-token")]
        public string OpcRetryToken { get; set; }
        
        /// <value>
        /// Unique Header for request id
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// if-match check
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "if-match")]
        public string IfMatch { get; set; }
    }
}