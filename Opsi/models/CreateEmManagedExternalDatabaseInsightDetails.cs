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


namespace Oci.OpsiService.Models
{
    /// <summary>
    /// The information about database to be analyzed.
    /// </summary>
    public class CreateEmManagedExternalDatabaseInsightDetails : CreateDatabaseInsightDetails
    {
        
        /// <value>
        /// Enterprise Manager Unique Identifier
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "EnterpriseManagerIdentifier is required.")]
        [JsonProperty(PropertyName = "enterpriseManagerIdentifier")]
        public string EnterpriseManagerIdentifier { get; set; }
        
        /// <value>
        /// OPSI Enterprise Manager Bridge OCID
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "EnterpriseManagerBridgeId is required.")]
        [JsonProperty(PropertyName = "enterpriseManagerBridgeId")]
        public string EnterpriseManagerBridgeId { get; set; }
        
        /// <value>
        /// Enterprise Manager Entity Unique Identifier
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "EnterpriseManagerEntityIdentifier is required.")]
        [JsonProperty(PropertyName = "enterpriseManagerEntityIdentifier")]
        public string EnterpriseManagerEntityIdentifier { get; set; }
        
        [JsonProperty(PropertyName = "entitySource")]
        private readonly string entitySource = "EM_MANAGED_EXTERNAL_DATABASE";
    }
}