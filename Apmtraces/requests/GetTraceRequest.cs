/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.ApmtracesService.Models;

namespace Oci.ApmtracesService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/apmtraces/GetTrace.cs.html">here</a> to see an example of how to use GetTrace request.
    /// </example>
    public class GetTraceRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The APM Domain ID for the intended request.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ApmDomainId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "apmDomainId")]
        public string ApmDomainId { get; set; }
        
        /// <value>
        /// Unique Application Performance Monitoring trace identifier (traceId).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TraceKey is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "traceKey")]
        public string TraceKey { get; set; }
        
        /// <value>
        /// Unique Oracle-assigned identifier for the request.  If you need to contact Oracle about a
        /// particular request, please provide the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// Include traces that have a minTraceStartTime equal to or greater than this value.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeTraceStartedGreaterThanOrEqualTo")]
        public System.Nullable<System.DateTime> TimeTraceStartedGreaterThanOrEqualTo { get; set; }
        
        /// <value>
        /// Include traces that have a minTraceStartTime less than this value.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeTraceStartedLessThan")]
        public System.Nullable<System.DateTime> TimeTraceStartedLessThan { get; set; }
        
        ///
        /// <value>
        /// Name space from which the trace details need to be retrieved.
        /// 
        /// </value>
        ///
        public enum TraceNamespaceEnum {
            [EnumMember(Value = "TRACES")]
            Traces,
            [EnumMember(Value = "SYNTHETIC")]
            Synthetic
        };

        /// <value>
        /// Name space from which the trace details need to be retrieved.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "traceNamespace")]
        public System.Nullable<TraceNamespaceEnum> TraceNamespace { get; set; }
    }
}
