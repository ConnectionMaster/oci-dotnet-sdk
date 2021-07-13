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


namespace Oci.UsageapiService.Models
{
    /// <summary>
    /// The usage store result.
    /// </summary>
    public class UsageSummary 
    {
        
        /// <value>
        /// The tenancy OCID.
        /// </value>
        [JsonProperty(PropertyName = "tenantId")]
        public string TenantId { get; set; }
        
        /// <value>
        /// The tenancy name.
        /// </value>
        [JsonProperty(PropertyName = "tenantName")]
        public string TenantName { get; set; }
        
        /// <value>
        /// The compartment OCID.
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The compartment path, starting from root.
        /// </value>
        [JsonProperty(PropertyName = "compartmentPath")]
        public string CompartmentPath { get; set; }
        
        /// <value>
        /// The compartment name.
        /// </value>
        [JsonProperty(PropertyName = "compartmentName")]
        public string CompartmentName { get; set; }
        
        /// <value>
        /// The service name that is incurring the cost.
        /// </value>
        [JsonProperty(PropertyName = "service")]
        public string Service { get; set; }
        
        /// <value>
        /// The resource name that is incurring the cost.
        /// </value>
        [JsonProperty(PropertyName = "resourceName")]
        public string ResourceName { get; set; }
        
        /// <value>
        /// The resource OCID that is incurring the cost.
        /// </value>
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; set; }
        
        /// <value>
        /// The region of the usage.
        /// </value>
        [JsonProperty(PropertyName = "region")]
        public string Region { get; set; }
        
        /// <value>
        /// The availability domain of the usage.
        /// </value>
        [JsonProperty(PropertyName = "ad")]
        public string Ad { get; set; }
        
        /// <value>
        /// The resource size being metered.
        /// </value>
        [JsonProperty(PropertyName = "weight")]
        public System.Nullable<decimal> Weight { get; set; }
        
        /// <value>
        /// The resource shape.
        /// </value>
        [JsonProperty(PropertyName = "shape")]
        public string Shape { get; set; }
        
        /// <value>
        /// The SKU part number.
        /// </value>
        [JsonProperty(PropertyName = "skuPartNumber")]
        public string SkuPartNumber { get; set; }
        
        /// <value>
        /// The SKU friendly name.
        /// </value>
        [JsonProperty(PropertyName = "skuName")]
        public string SkuName { get; set; }
        
        /// <value>
        /// The usage unit.
        /// </value>
        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; set; }
        
        /// <value>
        /// The discretionary discount applied to the SKU.
        /// </value>
        [JsonProperty(PropertyName = "discount")]
        public System.Nullable<decimal> Discount { get; set; }
        
        /// <value>
        /// The SKU list rate (not discount).
        /// </value>
        [JsonProperty(PropertyName = "listRate")]
        public System.Nullable<decimal> ListRate { get; set; }
        
        /// <value>
        /// Platform for the cost.
        /// </value>
        [JsonProperty(PropertyName = "platform")]
        public string Platform { get; set; }
        
        /// <value>
        /// The usage start time.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeUsageStarted is required.")]
        [JsonProperty(PropertyName = "timeUsageStarted")]
        public System.Nullable<System.DateTime> TimeUsageStarted { get; set; }
        
        /// <value>
        /// The usage end time.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeUsageEnded is required.")]
        [JsonProperty(PropertyName = "timeUsageEnded")]
        public System.Nullable<System.DateTime> TimeUsageEnded { get; set; }
        
        /// <value>
        /// The computed cost.
        /// </value>
        [JsonProperty(PropertyName = "computedAmount")]
        public System.Nullable<decimal> ComputedAmount { get; set; }
        
        /// <value>
        /// The usage number.
        /// </value>
        [JsonProperty(PropertyName = "computedQuantity")]
        public System.Nullable<decimal> ComputedQuantity { get; set; }
        
        /// <value>
        /// The SPM OverageFlag.
        /// </value>
        [JsonProperty(PropertyName = "overagesFlag")]
        public string OveragesFlag { get; set; }
        
        /// <value>
        /// The price per unit.
        /// </value>
        [JsonProperty(PropertyName = "unitPrice")]
        public System.Nullable<decimal> UnitPrice { get; set; }
        
        /// <value>
        /// The price currency.
        /// </value>
        [JsonProperty(PropertyName = "currency")]
        public string Currency { get; set; }
        
        /// <value>
        /// The subscription ID.
        /// </value>
        [JsonProperty(PropertyName = "subscriptionId")]
        public string SubscriptionId { get; set; }
        
        /// <value>
        /// The overage usage.
        /// </value>
        [JsonProperty(PropertyName = "overage")]
        public string Overage { get; set; }
        
        /// <value>
        /// The forecasted data.
        /// </value>
        [JsonProperty(PropertyName = "isForecast")]
        public System.Nullable<bool> IsForecast { get; set; }
        
        /// <value>
        /// For grouping, a tag definition. For filtering, a definition and key.
        /// </value>
        [JsonProperty(PropertyName = "tags")]
        public System.Collections.Generic.List<Tag> Tags { get; set; }
        
    }
}
