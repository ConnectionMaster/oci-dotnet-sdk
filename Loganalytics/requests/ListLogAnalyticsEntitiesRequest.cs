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
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/loganalytics/ListLogAnalyticsEntities.cs.html">here</a> to see an example of how to use ListLogAnalyticsEntities request.
    /// </example>
    public class ListLogAnalyticsEntitiesRequest : Oci.Common.IOciRequest
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
        /// The ID of the compartment in which to list resources.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// A filter to return only log analytics entities whose name matches the entire name given. The match
        /// is case-insensitive.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "name")]
        public string Name { get; set; }
        
        /// <value>
        /// A filter to return only log analytics entities whose name contains the name given. The match
        /// is case-insensitive.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "nameContains")]
        public string NameContains { get; set; }
        
        /// <value>
        /// A filter to return only log analytics entities whose entityTypeName matches the entire log analytics entity type name of
        /// one of the entityTypeNames given in the list. The match is case-insensitive.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "entityTypeName", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<string> EntityTypeName { get; set; }
        
        /// <value>
        /// A filter to return only log analytics entities whose cloudResourceId matches the cloudResourceId given.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "cloudResourceId")]
        public string CloudResourceId { get; set; }
        
        /// <value>
        /// A filter to return only those log analytics entities with the specified lifecycle state. The state
        /// value is case-insensitive.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "lifecycleState")]
        public System.Nullable<EntityLifecycleStates> LifecycleState { get; set; }
        
        /// <value>
        /// A filter to return only log analytics entities whose lifecycleDetails contains the specified string.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "lifecycleDetailsContains")]
        public string LifecycleDetailsContains { get; set; }
        
        ///
        /// <value>
        /// A filter to return only those log analytics entities whose managementAgentId is null or is not null.
        /// 
        /// </value>
        ///
        public enum IsManagementAgentIdNullEnum {
            [EnumMember(Value = "true")]
            True,
            [EnumMember(Value = "false")]
            False
        };

        /// <value>
        /// A filter to return only those log analytics entities whose managementAgentId is null or is not null.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "isManagementAgentIdNull")]
        public System.Nullable<IsManagementAgentIdNullEnum> IsManagementAgentIdNull { get; set; }
        
        /// <value>
        /// A filter to return only log analytics entities whose hostname matches the entire hostname given.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "hostname")]
        public string Hostname { get; set; }
        
        /// <value>
        /// A filter to return only log analytics entities whose hostname contains the substring given.
        /// The match is case-insensitive.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "hostnameContains")]
        public string HostnameContains { get; set; }
        
        /// <value>
        /// A filter to return only log analytics entities whose sourceId matches the sourceId given.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sourceId")]
        public string SourceId { get; set; }
        
        /// <value>
        /// A filter to return only those log analytics entities with the specified auto-creation source.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "creationSourceType", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<CreationSourceType> CreationSourceType { get; set; }
        
        /// <value>
        /// A filter to return only log analytics entities whose auto-creation source details contains the specified string.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "creationSourceDetails")]
        public string CreationSourceDetails { get; set; }
        
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
        /// The field to sort entities by. Only one sort order may be provided. Default order for timeCreated and timeUpdated
        /// is descending. Default order for entity name is ascending. If no value is specified timeCreated is default.
        /// 
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "timeCreated")]
            TimeCreated,
            [EnumMember(Value = "timeUpdated")]
            TimeUpdated,
            [EnumMember(Value = "name")]
            Name
        };

        /// <value>
        /// The field to sort entities by. Only one sort order may be provided. Default order for timeCreated and timeUpdated
        /// is descending. Default order for entity name is ascending. If no value is specified timeCreated is default.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
        /// <value>
        /// The client request ID for tracing.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}
