/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.IdentityService.Models
{
    /// <summary>
    /// The resource entity.
    /// 
    /// </summary>
    public class WorkRequestResource 
    {
        
        /// <value>
        /// The resource identifier the work request affects.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Identifier is required.")]
        [JsonProperty(PropertyName = "identifier")]
        public string Identifier { get; set; }
        
        /// <value>
        /// The resource type the work request is affects.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "EntityType is required.")]
        [JsonProperty(PropertyName = "entityType")]
        public string EntityType { get; set; }
                ///
        /// <value>
        /// The way in which this resource was affected by the work tracked by the work request.
        /// </value>
        ///
        public enum ActionTypeEnum {
            [EnumMember(Value = "CREATED")]
            Created,
            [EnumMember(Value = "UPDATED")]
            Updated,
            [EnumMember(Value = "DELETED")]
            Deleted,
            [EnumMember(Value = "RELATED")]
            Related,
            [EnumMember(Value = "IN_PROGRESS")]
            InProgress,
            [EnumMember(Value = "FAILED")]
            Failed
        };

        /// <value>
        /// The way in which this resource was affected by the work tracked by the work request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ActionType is required.")]
        [JsonProperty(PropertyName = "actionType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ActionTypeEnum> ActionType { get; set; }
        
        /// <value>
        /// The URI path that the user can do a GET on to access the resource metadata.
        /// </value>
        [JsonProperty(PropertyName = "entityUri")]
        public string EntityUri { get; set; }
        
    }
}
