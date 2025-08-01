/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.ApiaccesscontrolService.Models
{
    /// <summary>
    /// It contains appprovers details such as who approved it, when he approved and any details the approver would have entered as a part of approval process.
    /// </summary>
    public class ApproverDetail 
    {
        
        /// <value>
        /// The userId of the approver.
        /// </value>
        [JsonProperty(PropertyName = "approverId")]
        public string ApproverId { get; set; }
        
        /// <value>
        /// The action done by the approver.
        /// </value>
        [JsonProperty(PropertyName = "approvalAction")]
        public string ApprovalAction { get; set; }
        
        /// <value>
        /// Comment specified by the approver of the request.
        /// </value>
        [JsonProperty(PropertyName = "approvalComment")]
        public string ApprovalComment { get; set; }
        
        /// <value>
        /// Time when the privilegedApi request was authorized by the customer in [RFC 3339](https://tools.ietf.org/html/rfc3339) timestamp format.Example: '2020-05-22T21:10:29.600Z'
        /// </value>
        [JsonProperty(PropertyName = "timeOfAuthorization")]
        public System.Nullable<System.DateTime> TimeOfAuthorization { get; set; }
        
        /// <value>
        /// Time for when the privilegedApi request should start that is authorized by the customer in [RFC 3339](https://tools.ietf.org/html/rfc3339) timestamp format.Example: '2020-05-22T21:10:29.600Z'
        /// </value>
        [JsonProperty(PropertyName = "timeApprovedForAccess")]
        public System.Nullable<System.DateTime> TimeApprovedForAccess { get; set; }
        
    }
}
