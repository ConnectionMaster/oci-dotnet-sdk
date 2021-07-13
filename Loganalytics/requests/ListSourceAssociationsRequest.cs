/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.LoganalyticsService.Models;

namespace Oci.LoganalyticsService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/loganalytics/ListSourceAssociations.cs.html">here</a> to see an example of how to use ListSourceAssociations request.
    /// </example>
    public class ListSourceAssociationsRequest : Oci.Common.IOciRequest
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
        /// The souce name used for filtering associations.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SourceName is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sourceName")]
        public string SourceName { get; set; }
        
        /// <value>
        /// The ID of the compartment in which to list resources.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The entity OCID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "entityId")]
        public string EntityId { get; set; }
        
        ///
        /// <value>
        /// The life cycle state used for filtering.  Only associations with the specified
        /// life cycle state will be returned.
        /// 
        /// </value>
        ///
        public enum LifeCycleStateEnum {
            [EnumMember(Value = "ALL")]
            All,
            [EnumMember(Value = "ACCEPTED")]
            Accepted,
            [EnumMember(Value = "IN_PROGRESS")]
            InProgress,
            [EnumMember(Value = "SUCCEEDED")]
            Succeeded,
            [EnumMember(Value = "FAILED")]
            Failed
        };

        /// <value>
        /// The life cycle state used for filtering.  Only associations with the specified
        /// life cycle state will be returned.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "lifeCycleState")]
        public System.Nullable<LifeCycleStateEnum> LifeCycleState { get; set; }
        
        /// <value>
        /// A flag indicating whether or not to return the total number of items returned.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "isShowTotal")]
        public System.Nullable<bool> IsShowTotal { get; set; }
        
        /// <value>
        /// The client request ID for tracing.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
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
        /// The attribute used to sort the returned associations
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "entityName")]
            EntityName,
            [EnumMember(Value = "timeLastAttempted")]
            TimeLastAttempted,
            [EnumMember(Value = "status")]
            Status
        };

        /// <value>
        /// The attribute used to sort the returned associations
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
    }
}
