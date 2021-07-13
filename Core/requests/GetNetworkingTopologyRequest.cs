/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.CoreService.Models;

namespace Oci.CoreService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/core/GetNetworkingTopology.cs.html">here</a> to see an example of how to use GetNetworkingTopology request.
    /// </example>
    public class GetNetworkingTopologyRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentId")]
        public string CompartmentId { get; set; }
        
        ///
        /// <value>
        /// Valid values are `ANY` and `ACCESSIBLE`. The default is `ANY`.
        /// Setting this to `ACCESSIBLE` returns only compartments for which a
        /// user has INSPECT permissions, either directly or indirectly (permissions can be on a
        /// resource in a subcompartment). A restricted set of fields is returned for compartments in which a user has
        /// indirect INSPECT permissions.
        /// <br/>
        /// When set to `ANY` permissions are not checked.
        /// 
        /// </value>
        ///
        public enum AccessLevelEnum {
            [EnumMember(Value = "ANY")]
            Any,
            [EnumMember(Value = "ACCESSIBLE")]
            Accessible
        };

        /// <value>
        /// Valid values are `ANY` and `ACCESSIBLE`. The default is `ANY`.
        /// Setting this to `ACCESSIBLE` returns only compartments for which a
        /// user has INSPECT permissions, either directly or indirectly (permissions can be on a
        /// resource in a subcompartment). A restricted set of fields is returned for compartments in which a user has
        /// indirect INSPECT permissions.
        /// <br/>
        /// When set to `ANY` permissions are not checked.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "accessLevel")]
        public System.Nullable<AccessLevelEnum> AccessLevel { get; set; }
        
        /// <value>
        /// When set to true, the hierarchy of compartments is traversed
        /// and the specified compartment and its subcompartments are
        /// inspected depending on the the setting of `accessLevel`.
        /// Default is false.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "queryCompartmentSubtree")]
        public System.Nullable<bool> QueryCompartmentSubtree { get; set; }
        
        /// <value>
        /// Unique identifier for the request.
        /// If you need to contact Oracle about a particular request, please provide the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// For querying if there is a cached value on the server. The If-None-Match HTTP request header 
        /// makes the request conditional. For GET and HEAD methods, the server will send back the requested 
        /// resource, with a 200 status, only if it doesn't have an ETag matching the given ones. 
        /// For other methods, the request will be processed only if the eventually existing resource's 
        /// ETag doesn't match any of the values listed.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "if-none-match")]
        public string IfNoneMatch { get; set; }
        
        /// <value>
        /// The Cache-Control HTTP header holds directives (instructions)
        /// for caching in both requests and responses.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "cache-control")]
        public string CacheControl { get; set; }
    }
}
