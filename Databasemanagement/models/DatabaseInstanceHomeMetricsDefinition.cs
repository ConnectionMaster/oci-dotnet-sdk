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


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// The response containing the CPU, Wait, DB Time, and Memory metrics
    /// for a specific Oracle Real Application Clusters (Oracle RAC) database
    /// instance.
    /// 
    /// </summary>
    public class DatabaseInstanceHomeMetricsDefinition 
    {
        
        /// <value>
        /// The name of the Oracle Real Application Clusters (Oracle RAC)
        /// database instance to which the corresponding metrics belong.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "InstanceName is required.")]
        [JsonProperty(PropertyName = "instanceName")]
        public string InstanceName { get; set; }
        
        /// <value>
        /// The number of Oracle Real Application Clusters (Oracle RAC)
        /// database instance to which the corresponding metrics belong.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "InstanceNumber is required.")]
        [JsonProperty(PropertyName = "instanceNumber")]
        public System.Nullable<int> InstanceNumber { get; set; }
        
        /// <value>
        /// A list of the active session metrics for CPU and Wait time for
        /// a specific Oracle Real Application Clusters (Oracle RAC)
        /// database instance.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ActivityTimeSeriesMetrics is required.")]
        [JsonProperty(PropertyName = "activityTimeSeriesMetrics")]
        public System.Collections.Generic.List<ActivityTimeSeriesMetrics> ActivityTimeSeriesMetrics { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DbTimeAggregateMetrics is required.")]
        [JsonProperty(PropertyName = "dbTimeAggregateMetrics")]
        public DatabaseTimeAggregateMetrics DbTimeAggregateMetrics { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IoAggregateMetrics is required.")]
        [JsonProperty(PropertyName = "ioAggregateMetrics")]
        public DatabaseIOAggregateMetrics IoAggregateMetrics { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MemoryAggregateMetrics is required.")]
        [JsonProperty(PropertyName = "memoryAggregateMetrics")]
        public MemoryAggregateMetrics MemoryAggregateMetrics { get; set; }
        
    }
}