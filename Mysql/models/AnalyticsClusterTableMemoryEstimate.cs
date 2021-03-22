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


namespace Oci.MysqlService.Models
{
    /// <summary>
    /// DEPRECATED -- please use HeatWave API instead.
    /// Estimated memory footprint for a MySQL user table
    /// when loaded to the Analytics Cluster memory.
    /// 
    /// </summary>
    public class AnalyticsClusterTableMemoryEstimate 
    {
        
        /// <value>
        /// The table name.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TableName is required.")]
        [JsonProperty(PropertyName = "tableName")]
        public string TableName { get; set; }
        
        /// <value>
        /// The number of columns to be loaded to Analytics Cluster memory.
        /// These columns contribute to the analytical memory footprint.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ToLoadColumnCount is required.")]
        [JsonProperty(PropertyName = "toLoadColumnCount")]
        public System.Nullable<int> ToLoadColumnCount { get; set; }
        
        /// <value>
        /// The number of variable-length columns to be loaded to Analytics Cluster memory.
        /// These columns contribute to the analytical memory footprint.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VarlenColumnCount is required.")]
        [JsonProperty(PropertyName = "varlenColumnCount")]
        public System.Nullable<int> VarlenColumnCount { get; set; }
        
        /// <value>
        /// The estimated number of rows in the table. This number was used to
        /// derive the analytical memory footprint.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "EstimatedRowCount is required.")]
        [JsonProperty(PropertyName = "estimatedRowCount")]
        public System.Nullable<long> EstimatedRowCount { get; set; }
        
        /// <value>
        /// The estimated memory footprint of the table in MBs when loaded to
        /// Analytics Cluster memory (null if the table cannot be loaded to the
        /// Analytics Cluster).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AnalyticalFootprintInMbs is required.")]
        [JsonProperty(PropertyName = "analyticalFootprintInMbs")]
        public System.Nullable<long> AnalyticalFootprintInMbs { get; set; }
        
        /// <value>
        /// Error comment (empty string if no errors occured).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ErrorComment is required.")]
        [JsonProperty(PropertyName = "errorComment")]
        public string ErrorComment { get; set; }
        
    }
}
