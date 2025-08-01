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


namespace Oci.MarketplacepublisherService.Models
{
    /// <summary>
    /// Additional information about the lead
    /// </summary>
    public class AdditionalInfo 
    {
        
        /// <value>
        /// The company name
        /// </value>
        [JsonProperty(PropertyName = "company")]
        public string Company { get; set; }
        
        /// <value>
        /// The company address
        /// </value>
        [JsonProperty(PropertyName = "companyAddress")]
        public string CompanyAddress { get; set; }
        
        /// <value>
        /// The email address
        /// </value>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }
        
        /// <value>
        /// The first name
        /// </value>
        [JsonProperty(PropertyName = "firstName")]
        public string FirstName { get; set; }
        
        /// <value>
        /// The last name
        /// </value>
        [JsonProperty(PropertyName = "lastName")]
        public string LastName { get; set; }
        
        /// <value>
        /// The phone number
        /// </value>
        [JsonProperty(PropertyName = "phone")]
        public string Phone { get; set; }
        
        /// <value>
        /// Additional notes
        /// </value>
        [JsonProperty(PropertyName = "notes")]
        public string Notes { get; set; }
        
    }
}
