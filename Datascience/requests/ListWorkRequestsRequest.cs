/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.DatascienceService.Models;

namespace Oci.DatascienceService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/datascience/ListWorkRequests.cs.html">here</a> to see an example of how to use ListWorkRequests request.
    /// </example>
    public class ListWorkRequestsRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// <b>Filter</b> results by the [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// <b>Filter</b> results by [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm). Must be an OCID of the correct type for the resource type.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "id")]
        public string Id { get; set; }
        
        ///
        /// <value>
        /// <b>Filter</b> results by the type of the operation associated with the work request.
        /// </value>
        ///
        public enum OperationTypeEnum {
            [EnumMember(Value = "NOTEBOOK_SESSION_CREATE")]
            NotebookSessionCreate,
            [EnumMember(Value = "NOTEBOOK_SESSION_DELETE")]
            NotebookSessionDelete,
            [EnumMember(Value = "NOTEBOOK_SESSION_ACTIVATE")]
            NotebookSessionActivate,
            [EnumMember(Value = "NOTEBOOK_SESSION_DEACTIVATE")]
            NotebookSessionDeactivate,
            [EnumMember(Value = "MODEL_DEPLOYMENT_CREATE")]
            ModelDeploymentCreate,
            [EnumMember(Value = "MODEL_DEPLOYMENT_DELETE")]
            ModelDeploymentDelete,
            [EnumMember(Value = "MODEL_DEPLOYMENT_ACTIVATE")]
            ModelDeploymentActivate,
            [EnumMember(Value = "MODEL_DEPLOYMENT_DEACTIVATE")]
            ModelDeploymentDeactivate,
            [EnumMember(Value = "MODEL_DEPLOYMENT_UPDATE")]
            ModelDeploymentUpdate,
            [EnumMember(Value = "PROJECT_DELETE")]
            ProjectDelete,
            [EnumMember(Value = "WORKREQUEST_CANCEL")]
            WorkrequestCancel
        };

        /// <value>
        /// <b>Filter</b> results by the type of the operation associated with the work request.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "operationType")]
        public System.Nullable<OperationTypeEnum> OperationType { get; set; }
        
        ///
        /// <value>
        /// <b>Filter</b> results by work request status.
        /// </value>
        ///
        public enum StatusEnum {
            [EnumMember(Value = "ACCEPTED")]
            Accepted,
            [EnumMember(Value = "IN_PROGRESS")]
            InProgress,
            [EnumMember(Value = "FAILED")]
            Failed,
            [EnumMember(Value = "SUCCEEDED")]
            Succeeded,
            [EnumMember(Value = "CANCELING")]
            Canceling,
            [EnumMember(Value = "CANCELED")]
            Canceled
        };

        /// <value>
        /// <b>Filter</b> results by work request status.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "status")]
        public System.Nullable<StatusEnum> Status { get; set; }
        
        /// <value>
        /// For list pagination. The maximum number of results per page,
        /// or items to return in a paginated \"List\" call.
        /// 1 is the minimum, 1000 is the maximum.
        /// See [List Pagination](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/usingapi.htm#nine).
        /// <br/>
        /// Example: 500
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        /// <value>
        /// For list pagination. The value of the `opc-next-page` response
        /// header from the previous \"List\" call.
        /// <br/>
        /// See [List Pagination](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/usingapi.htm#nine).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        ///
        /// <value>
        /// Specifies sort order to use, either `ASC` (ascending) or `DESC` (descending).
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
        /// Specifies sort order to use, either `ASC` (ascending) or `DESC` (descending).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrderEnum> SortOrder { get; set; }
        
        ///
        /// <value>
        /// Specifies the field to sort by. Accepts only one field. By default, when you sort by time fields, the results are shown in descending order. All other fields default to ascending order.
        /// 
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "operationType")]
            OperationType,
            [EnumMember(Value = "status")]
            Status,
            [EnumMember(Value = "timeAccepted")]
            TimeAccepted
        };

        /// <value>
        /// Specifies the field to sort by. Accepts only one field. By default, when you sort by time fields, the results are shown in descending order. All other fields default to ascending order.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
        /// <value>
        /// Unique Oracle assigned identifier for the request. If you need to contact Oracle about a particular request, then provide the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}
