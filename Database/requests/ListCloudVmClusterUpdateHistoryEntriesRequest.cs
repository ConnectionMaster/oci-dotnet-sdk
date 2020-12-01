/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.DatabaseService.Models;

namespace Oci.DatabaseService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/8.0.0/database/ListCloudVmClusterUpdateHistoryEntries.cs.html">here</a> to see an example of how to use ListCloudVmClusterUpdateHistoryEntries request.
    /// </example>
    public class ListCloudVmClusterUpdateHistoryEntriesRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The cloud VM cluster [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CloudVmClusterId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "cloudVmClusterId")]
        public string CloudVmClusterId { get; set; }
        
        ///
        /// <value>
        /// A filter to return only resources that match the given update type exactly.
        /// </value>
        ///
        public enum UpdateTypeEnum {
            [EnumMember(Value = "GI_UPGRADE")]
            GiUpgrade,
            [EnumMember(Value = "GI_PATCH")]
            GiPatch
        };

        /// <value>
        /// A filter to return only resources that match the given update type exactly.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "updateType")]
        public System.Nullable<UpdateTypeEnum> UpdateType { get; set; }
        
        /// <value>
        /// The maximum number of items to return per page.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        /// <value>
        /// The pagination token to continue listing from.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        /// <value>
        /// Unique identifier for the request.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}
