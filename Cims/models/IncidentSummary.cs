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


namespace Oci.CimsService.Models
{
    /// <summary>
    /// Details about the support ticket.
    /// </summary>
    public class IncidentSummary 
    {
        
        /// <value>
        /// Unique identifier of the incident.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Key is required.")]
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <value>
        /// The OCID of the tenancy.
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        [JsonProperty(PropertyName = "contactList")]
        public ContactList ContactList { get; set; }
        
        [JsonProperty(PropertyName = "tenancyInformation")]
        public TenancyInformation TenancyInformation { get; set; }
        
        [JsonProperty(PropertyName = "ticket")]
        public Ticket Ticket { get; set; }
        
        [JsonProperty(PropertyName = "incidentType")]
        public IncidentResourceType IncidentType { get; set; }
        
        /// <value>
        /// The kind of support ticket, such as a technical support request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ProblemType is required.")]
        [JsonProperty(PropertyName = "problemType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ProblemType> ProblemType { get; set; }
        
    }
}
