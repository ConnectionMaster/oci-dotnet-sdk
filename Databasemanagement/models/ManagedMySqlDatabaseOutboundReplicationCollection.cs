/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// The collection of outbound replication records of a MySQL server.
    /// </summary>
    public class ManagedMySqlDatabaseOutboundReplicationCollection 
    {
        
        /// <value>
        /// The number of outbound replications from the MySQL server.
        /// </value>
        [JsonProperty(PropertyName = "outboundReplicationsCount")]
        public System.Nullable<int> OutboundReplicationsCount { get; set; }
        
        /// <value>
        /// The list of ManagedMySqlDatabaseOutboundReplicationSummary records.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Items is required.")]
        [JsonProperty(PropertyName = "items")]
        public System.Collections.Generic.List<ManagedMySqlDatabaseOutboundReplicationSummary> Items { get; set; }
        
    }
}
