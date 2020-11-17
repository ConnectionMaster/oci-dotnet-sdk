/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.LoganalyticsService.Models;

namespace Oci.LoganalyticsService.Requests
{
    public class ListUploadFilesRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The Logging Analytics namespace used for the request.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NamespaceName is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "namespaceName")]
        public string NamespaceName { get; set; }
        
        /// <value>
        /// Unique internal identifier to refer to upload container
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UploadReference is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "uploadReference")]
        public string UploadReference { get; set; }
        
        /// <value>
        /// The maximum number of items to return.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        /// <value>
        /// The page token representing the page at which to start retrieving results. This is usually retrieved from a previous list call.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        ///
        /// <value>
        /// The sort order to use, either ascending (`ASC`) or descending (`DESC`).
        /// 
        /// </value>
        ///
        public enum SortOrderEnum {
            [EnumMember(Value = "ASC")]
            Asc,
            [EnumMember(Value = "DESC")]
            Desc
        };

        /// <value>
        /// The sort order to use, either ascending (`ASC`) or descending (`DESC`).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrderEnum> SortOrder { get; set; }
        
        ///
        /// <value>
        /// The field to sort by. Only one sort order may be provided. Default order for timeCreated is descending.
        /// 
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "timeCreated")]
            TimeCreated,
            [EnumMember(Value = "fileName")]
            FileName,
            [EnumMember(Value = "logGroup")]
            LogGroup,
            [EnumMember(Value = "sourceName")]
            SourceName,
            [EnumMember(Value = "status")]
            Status
        };

        /// <value>
        /// The field to sort by. Only one sort order may be provided. Default order for timeCreated is descending.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
        /// <value>
        /// Search string used to filtering uploads based on file name, log group name and log source name.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "searchStr")]
        public string SearchStr { get; set; }
        
        ///
        /// <value>
        /// Upload Status.
        /// </value>
        ///
        public enum StatusEnum {
            [EnumMember(Value = "IN_PROGRESS")]
            InProgress,
            [EnumMember(Value = "SUCCESSFUL")]
            Successful,
            [EnumMember(Value = "FAILED")]
            Failed
        };

        /// <value>
        /// Upload Status.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "status")]
        public System.Collections.Generic.List<StatusEnum> Status { get; set; }
        
        /// <value>
        /// The client request ID for tracing.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}