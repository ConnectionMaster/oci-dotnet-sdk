/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DatasafeService.Models
{
    /// <summary>
    /// Summary of a work request.
    /// </summary>
    public class WorkRequestSummary 
    {
                ///
        /// <value>
        /// The asynchronous operation tracked by this work request.
        /// </value>
        ///
        public enum OperationTypeEnum {
            [EnumMember(Value = "ENABLE_DATA_SAFE_CONFIGURATION")]
            EnableDataSafeConfiguration,
            [EnumMember(Value = "CREATE_PRIVATE_ENDPOINT")]
            CreatePrivateEndpoint,
            [EnumMember(Value = "UPDATE_PRIVATE_ENDPOINT")]
            UpdatePrivateEndpoint,
            [EnumMember(Value = "DELETE_PRIVATE_ENDPOINT")]
            DeletePrivateEndpoint,
            [EnumMember(Value = "CHANGE_PRIVATE_ENDPOINT_COMPARTMENT")]
            ChangePrivateEndpointCompartment,
            [EnumMember(Value = "CREATE_ONPREM_CONNECTOR")]
            CreateOnpremConnector,
            [EnumMember(Value = "UPDATE_ONPREM_CONNECTOR")]
            UpdateOnpremConnector,
            [EnumMember(Value = "DELETE_ONPREM_CONNECTOR")]
            DeleteOnpremConnector,
            [EnumMember(Value = "UPDATE_ONPREM_CONNECTOR_WALLET")]
            UpdateOnpremConnectorWallet,
            [EnumMember(Value = "CHANGE_ONPREM_CONNECTOR_COMPARTMENT")]
            ChangeOnpremConnectorCompartment,
            [EnumMember(Value = "CREATE_TARGET_DATABASE")]
            CreateTargetDatabase,
            [EnumMember(Value = "UPDATE_TARGET_DATABASE")]
            UpdateTargetDatabase,
            [EnumMember(Value = "ACTIVATE_TARGET_DATABASE")]
            ActivateTargetDatabase,
            [EnumMember(Value = "DEACTIVATE_TARGET_DATABASE")]
            DeactivateTargetDatabase,
            [EnumMember(Value = "DELETE_TARGET_DATABASE")]
            DeleteTargetDatabase,
            [EnumMember(Value = "CHANGE_TARGET_DATABASE_COMPARTMENT")]
            ChangeTargetDatabaseCompartment
        };

        /// <value>
        /// The asynchronous operation tracked by this work request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OperationType is required.")]
        [JsonProperty(PropertyName = "operationType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<OperationTypeEnum> OperationType { get; set; }
                ///
        /// <value>
        /// The current status of the work request.
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
            Succeeded
        };

        /// <value>
        /// The current status of the work request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Status is required.")]
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<StatusEnum> Status { get; set; }
        
        /// <value>
        /// The OCID of the work request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The OCID of the compartment that contains the work request.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The resources that are affected by the work request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Resources is required.")]
        [JsonProperty(PropertyName = "resources")]
        public System.Collections.Generic.List<WorkRequestResource> Resources { get; set; }
        
        /// <value>
        /// Progress of the work request in percentage.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PercentComplete is required.")]
        [JsonProperty(PropertyName = "percentComplete")]
        public System.Nullable<float> PercentComplete { get; set; }
        
        /// <value>
        /// The date and time the work request was accepted, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeAccepted is required.")]
        [JsonProperty(PropertyName = "timeAccepted")]
        public System.Nullable<System.DateTime> TimeAccepted { get; set; }
        
        /// <value>
        /// The date and time the work request transitioned from ACCEPTED to IN_PROGRESS, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeStarted")]
        public System.Nullable<System.DateTime> TimeStarted { get; set; }
        
        /// <value>
        /// The date and time the work request reached a terminal state, either FAILED or SUCCEEDED, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeFinished")]
        public System.Nullable<System.DateTime> TimeFinished { get; set; }
        
    }
}
