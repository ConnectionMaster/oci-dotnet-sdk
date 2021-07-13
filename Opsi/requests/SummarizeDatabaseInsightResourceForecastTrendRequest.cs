/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.OpsiService.Models;

namespace Oci.OpsiService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/opsi/SummarizeDatabaseInsightResourceForecastTrend.cs.html">here</a> to see an example of how to use SummarizeDatabaseInsightResourceForecastTrend request.
    /// </example>
    public class SummarizeDatabaseInsightResourceForecastTrendRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Filter by resource metric.
        /// Supported values are CPU , STORAGE, MEMORY and IO.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceMetric is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "resourceMetric")]
        public string ResourceMetric { get; set; }
        
        /// <value>
        /// Specify time period in ISO 8601 format with respect to current time.
        /// Default is last 30 days represented by P30D.
        /// If timeInterval is specified, then timeIntervalStart and timeIntervalEnd will be ignored.
        /// Examples  P90D (last 90 days), P4W (last 4 weeks), P2M (last 2 months), P1Y (last 12 months), . Maximum value allowed is 25 months prior to current time (P25M).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "analysisTimeInterval")]
        public string AnalysisTimeInterval { get; set; }
        
        /// <value>
        /// Analysis start time in UTC in ISO 8601 format(inclusive).
        /// Example 2019-10-30T00:00:00Z (yyyy-MM-ddThh:mm:ssZ).
        /// The minimum allowed value is 2 years prior to the current day.
        /// timeIntervalStart and timeIntervalEnd parameters are used together.
        /// If analysisTimeInterval is specified, this parameter is ignored.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeIntervalStart")]
        public System.Nullable<System.DateTime> TimeIntervalStart { get; set; }
        
        /// <value>
        /// Analysis end time in UTC in ISO 8601 format(exclusive).
        /// Example 2019-10-30T00:00:00Z (yyyy-MM-ddThh:mm:ssZ).
        /// timeIntervalStart and timeIntervalEnd are used together.
        /// If timeIntervalEnd is not specified, current time is used as timeIntervalEnd.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeIntervalEnd")]
        public System.Nullable<System.DateTime> TimeIntervalEnd { get; set; }
        
        ///
        /// <value>
        /// Filter by one or more database type.
        /// Possible values are ADW-S, ATP-S, ADW-D, ATP-D, EXTERNAL-PDB, EXTERNAL-NONCDB.
        /// 
        /// </value>
        ///
        public enum DatabaseTypeEnum {
            [EnumMember(Value = "ADW-S")]
            AdwS,
            [EnumMember(Value = "ATP-S")]
            AtpS,
            [EnumMember(Value = "ADW-D")]
            AdwD,
            [EnumMember(Value = "ATP-D")]
            AtpD,
            [EnumMember(Value = "EXTERNAL-PDB")]
            ExternalPdb,
            [EnumMember(Value = "EXTERNAL-NONCDB")]
            ExternalNoncdb
        };

        /// <value>
        /// Filter by one or more database type.
        /// Possible values are ADW-S, ATP-S, ADW-D, ATP-D, EXTERNAL-PDB, EXTERNAL-NONCDB.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "databaseType", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<DatabaseTypeEnum> DatabaseType { get; set; }
        
        /// <value>
        /// Optional list of database [OCIDs](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the associated DBaaS entity.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "databaseId", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<string> DatabaseId { get; set; }
        
        /// <value>
        /// Optional list of database insight resource [OCIDs](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the database insight resource.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "id", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<string> Id { get; set; }
        
        ///
        /// <value>
        /// Choose the type of statistic metric data to be used for forecasting.
        /// </value>
        ///
        public enum StatisticEnum {
            [EnumMember(Value = "AVG")]
            Avg,
            [EnumMember(Value = "MAX")]
            Max
        };

        /// <value>
        /// Choose the type of statistic metric data to be used for forecasting.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "statistic")]
        public System.Nullable<StatisticEnum> Statistic { get; set; }
        
        /// <value>
        /// Number of days used for utilization forecast analysis.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "forecastDays")]
        public System.Nullable<int> ForecastDays { get; set; }
        
        ///
        /// <value>
        /// Choose algorithm model for the forecasting.
        /// Possible values:
        ///   - LINEAR: Uses linear regression algorithm for forecasting.
        ///   - ML_AUTO: Automatically detects best algorithm to use for forecasting.
        ///   - ML_NO_AUTO: Automatically detects seasonality of the data for forecasting using linear or seasonal algorithm.
        /// 
        /// </value>
        ///
        public enum ForecastModelEnum {
            [EnumMember(Value = "LINEAR")]
            Linear,
            [EnumMember(Value = "ML_AUTO")]
            MlAuto,
            [EnumMember(Value = "ML_NO_AUTO")]
            MlNoAuto
        };

        /// <value>
        /// Choose algorithm model for the forecasting.
        /// Possible values:
        ///   - LINEAR: Uses linear regression algorithm for forecasting.
        ///   - ML_AUTO: Automatically detects best algorithm to use for forecasting.
        ///   - ML_NO_AUTO: Automatically detects seasonality of the data for forecasting using linear or seasonal algorithm.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "forecastModel")]
        public System.Nullable<ForecastModelEnum> ForecastModel { get; set; }
        
        ///
        /// <value>
        /// Filter by utilization level by the following buckets:
        ///   - HIGH_UTILIZATION: DBs with utilization greater or equal than 75.
        ///   - LOW_UTILIZATION: DBs with utilization lower than 25.
        ///   - MEDIUM_HIGH_UTILIZATION: DBs with utilization greater or equal than 50 but lower than 75.
        ///   - MEDIUM_LOW_UTILIZATION: DBs with utilization greater or equal than 25 but lower than 50.
        /// 
        /// </value>
        ///
        public enum UtilizationLevelEnum {
            [EnumMember(Value = "HIGH_UTILIZATION")]
            HighUtilization,
            [EnumMember(Value = "LOW_UTILIZATION")]
            LowUtilization,
            [EnumMember(Value = "MEDIUM_HIGH_UTILIZATION")]
            MediumHighUtilization,
            [EnumMember(Value = "MEDIUM_LOW_UTILIZATION")]
            MediumLowUtilization
        };

        /// <value>
        /// Filter by utilization level by the following buckets:
        ///   - HIGH_UTILIZATION: DBs with utilization greater or equal than 75.
        ///   - LOW_UTILIZATION: DBs with utilization lower than 25.
        ///   - MEDIUM_HIGH_UTILIZATION: DBs with utilization greater or equal than 50 but lower than 75.
        ///   - MEDIUM_LOW_UTILIZATION: DBs with utilization greater or equal than 25 but lower than 50.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "utilizationLevel")]
        public System.Nullable<UtilizationLevelEnum> UtilizationLevel { get; set; }
        
        /// <value>
        /// This parameter is used to change data's confidence level, this data is ingested by the
        /// forecast algorithm.
        /// Confidence is the probability of an interval to contain the expected population parameter.
        /// Manipulation of this value will lead to different results.
        /// If not set, default confidence value is 95%.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "confidence")]
        public System.Nullable<int> Confidence { get; set; }
        
        /// <value>
        /// For list pagination. The value of the `opc-next-page` response header from
        /// the previous \"List\" call. For important details about how pagination works,
        /// see [List Pagination](https://docs.cloud.oracle.com/Content/API/Concepts/usingapi.htm#nine).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        /// <value>
        /// Filter by one or more hostname.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "hostName", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<string> HostName { get; set; }
        
        /// <value>
        /// Tablespace name for a database
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "tablespaceName")]
        public string TablespaceName { get; set; }
        
        /// <value>
        /// Flag to indicate if database instance level metrics should be returned. The flag is ignored when a host name filter is not applied.
        /// When a hostname filter is applied this flag will determine whether to return metrics for the instances located on the specified host or for the
        /// whole database which contains an instance on this host.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "isDatabaseInstanceLevelMetrics")]
        public System.Nullable<bool> IsDatabaseInstanceLevelMetrics { get; set; }
        
        /// <value>
        /// Unique Oracle-assigned identifier for the request. If you need to contact
        /// Oracle about a particular request, please provide the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}
