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


namespace Oci.JmsService.Models
{
    /// <summary>
    /// Parameters for filtering Java Runtime Usages.
    /// </summary>
    public class RequestSummarizedJreUsageDetails 
    {
        
        /// <value>
        /// The start of the time period during which resources are searched (formatted according to RFC3339). Defaults to current time minus seven days.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeStart")]
        public System.Nullable<System.DateTime> TimeStart { get; set; }
        
        /// <value>
        /// The end of the time period during which resources are searched (formatted according to RFC3339). Defaults to current time.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeEnd")]
        public System.Nullable<System.DateTime> TimeEnd { get; set; }
        
        /// <value>
        /// The vendor of the Java Runtime.
        /// </value>
        [JsonProperty(PropertyName = "jreVendor")]
        public string JreVendor { get; set; }
        
        /// <value>
        /// The distribution of the Java Runtime.
        /// </value>
        [JsonProperty(PropertyName = "jreDistribution")]
        public string JreDistribution { get; set; }
        
        /// <value>
        /// The version of the Java Runtime.
        /// </value>
        [JsonProperty(PropertyName = "jreVersion")]
        public string JreVersion { get; set; }
        
        /// <value>
        /// The ID of the related application.
        /// </value>
        [JsonProperty(PropertyName = "applicationId")]
        public string ApplicationId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the related managed instance.
        /// </value>
        [JsonProperty(PropertyName = "managedInstanceId")]
        public string ManagedInstanceId { get; set; }
        
        /// <value>
        /// The sort order to use, either 'asc' or 'desc'.
        /// </value>
        [JsonProperty(PropertyName = "sortOrder")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<SortOrder> SortOrder { get; set; }
        
        /// <value>
        /// The field to sort Java Runtime views. Only one sort order may be provided.
        /// Default order for _timeFirstSeen_, _timeLastSeen_, _version_, _approximateInstallationCount_,
        /// _approximateApplicationCount_ and _approximateManagedInstanceCount_  is **descending**.
        /// Default order for _distribution_ and _vendor_ is **ascending**. If no value is specified _timeLastSeen_ is default.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sortBy")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<JreSortBy> SortBy { get; set; }
        
        /// <value>
        /// Additional fields to include into the returned model on top of the required ones.
        /// This parameter can also include 'approximateApplicationCount', 'approximateInstallationCount' and 'approximateManagedInstanceCount'.
        /// For example 'approximateApplicationCount,approximateManagedInstanceCount'.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "fields")]
        public System.Collections.Generic.List<SummarizeJreUsageFields> Fields { get; set; }
        
    }
}
