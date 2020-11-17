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
    public class ListFieldsRequest : Oci.Common.IOciRequest
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
        /// isMatchAll
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "isMatchAll")]
        public System.Nullable<bool> IsMatchAll { get; set; }
        
        /// <value>
        /// comma delimited list of source ids
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sourceIds")]
        public string SourceIds { get; set; }
        
        /// <value>
        /// comma delimited list of source Names
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sourceNames")]
        public string SourceNames { get; set; }
        
        ///
        /// <value>
        /// parserType
        /// </value>
        ///
        public enum ParserTypeEnum {
            [EnumMember(Value = "ALL")]
            All,
            [EnumMember(Value = "REGEX")]
            Regex,
            [EnumMember(Value = "XML")]
            Xml,
            [EnumMember(Value = "JSON")]
            Json
        };

        /// <value>
        /// parserType
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "parserType")]
        public System.Nullable<ParserTypeEnum> ParserType { get; set; }
        
        /// <value>
        /// comma delimited list of parser ids
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "parserIds")]
        public string ParserIds { get; set; }
        
        /// <value>
        /// comma delimited list of parser names
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "parserNames")]
        public string ParserNames { get; set; }
        
        /// <value>
        /// isIncludeParser
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "isIncludeParser")]
        public System.Nullable<bool> IsIncludeParser { get; set; }
        
        /// <value>
        /// filter
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "filter")]
        public string Filter { get; set; }
        
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
        /// sort by field
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "name")]
            Name,
            [EnumMember(Value = "dataType")]
            DataType
        };

        /// <value>
        /// sort by field
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