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


namespace Oci.ManagementdashboardService.Models
{
    /// <summary>
    /// Properties of a dashboard, including dashboard ID.
    /// </summary>
    public class ManagementDashboard 
    {
        
        /// <value>
        /// ID of the dashboard.  Same as id.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DashboardId is required.")]
        [JsonProperty(PropertyName = "dashboardId")]
        public string DashboardId { get; set; }
        
        /// <value>
        /// ID of the dashboard.  Same as dashboardId.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// ID of the service (for example, log-analytics) that owns the dashboard. Each service has a unique ID.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ProviderId is required.")]
        [JsonProperty(PropertyName = "providerId")]
        public string ProviderId { get; set; }
        
        /// <value>
        /// Name of the service (for example, Logging Analytics) that owns the dashboard.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ProviderName is required.")]
        [JsonProperty(PropertyName = "providerName")]
        public string ProviderName { get; set; }
        
        /// <value>
        /// Version of the service that owns the dashboard.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ProviderVersion is required.")]
        [JsonProperty(PropertyName = "providerVersion")]
        public string ProviderVersion { get; set; }
        
        /// <value>
        /// Array of dashboard tiles.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Tiles is required.")]
        [JsonProperty(PropertyName = "tiles")]
        public System.Collections.Generic.List<ManagementDashboardTileDetails> Tiles { get; set; }
        
        /// <value>
        /// Display name of the dashboard.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Description of the dashboard.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Description is required.")]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// OCID of the compartment in which the dashboard resides.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Determines whether the dashboard is an Out-of-the-Box (OOB) dashboard. Note that OOB dashboards are only provided by Oracle and cannot be modified.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsOobDashboard is required.")]
        [JsonProperty(PropertyName = "isOobDashboard")]
        public System.Nullable<bool> IsOobDashboard { get; set; }
        
        /// <value>
        /// Determines whether the dashboard will be displayed in Dashboard Home.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsShowInHome is required.")]
        [JsonProperty(PropertyName = "isShowInHome")]
        public System.Nullable<bool> IsShowInHome { get; set; }
        
        /// <value>
        /// User who created the dashboard.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CreatedBy is required.")]
        [JsonProperty(PropertyName = "createdBy")]
        public string CreatedBy { get; set; }
        
        /// <value>
        /// Date and time the dashboard was created.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// User who updated the dashboard.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UpdatedBy is required.")]
        [JsonProperty(PropertyName = "updatedBy")]
        public string UpdatedBy { get; set; }
        
        /// <value>
        /// Date and time the dashboard was updated.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeUpdated is required.")]
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// The version of the metadata defined in the API. This is maintained and enforced by dashboard server. Currently it is 2.0.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MetadataVersion is required.")]
        [JsonProperty(PropertyName = "metadataVersion")]
        public string MetadataVersion { get; set; }
        
        /// <value>
        /// Determines whether the description of the dashboard is displayed.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsShowDescription is required.")]
        [JsonProperty(PropertyName = "isShowDescription")]
        public System.Nullable<bool> IsShowDescription { get; set; }
        
        /// <value>
        /// Screen image of the dashboard.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ScreenImage is required.")]
        [JsonProperty(PropertyName = "screenImage")]
        public string ScreenImage { get; set; }
        
        /// <value>
        /// JSON that contains internationalization options.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Nls is required.")]
        [JsonProperty(PropertyName = "nls")]
        public System.Object Nls { get; set; }
        
        /// <value>
        /// JSON that contains user interface options.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UiConfig is required.")]
        [JsonProperty(PropertyName = "uiConfig")]
        public System.Object UiConfig { get; set; }
        
        /// <value>
        /// Array of JSON that contain data source options.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DataConfig is required.")]
        [JsonProperty(PropertyName = "dataConfig")]
        public System.Collections.Generic.List<System.Object> DataConfig { get; set; }
        
        /// <value>
        /// Type of dashboard. NORMAL denotes a single dashboard and SET denotes a dashboard set.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Type is required.")]
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
        
        /// <value>
        /// Determines whether the dashboard is set as favorite.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsFavorite is required.")]
        [JsonProperty(PropertyName = "isFavorite")]
        public System.Nullable<bool> IsFavorite { get; set; }
        
        /// <value>
        /// Array of saved searches in the dashboard.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SavedSearches is required.")]
        [JsonProperty(PropertyName = "savedSearches")]
        public System.Collections.Generic.List<ManagementSavedSearch> SavedSearches { get; set; }
        
        /// <value>
        /// State of dashboard.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStates> LifecycleState { get; set; }
        
        /// <value>
        /// Defines parameters for the dashboard.
        /// </value>
        [JsonProperty(PropertyName = "parametersConfig")]
        public System.Collections.Generic.List<System.Object> ParametersConfig { get; set; }
        
        /// <value>
        /// Drill-down configuration to define the destination of a drill-down action.
        /// </value>
        [JsonProperty(PropertyName = "drilldownConfig")]
        public System.Collections.Generic.List<System.Object> DrilldownConfig { get; set; }
        
        /// <value>
        /// Contains configuration for enabling features.
        /// </value>
        [JsonProperty(PropertyName = "featuresConfig")]
        public System.Object FeaturesConfig { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// Usage of system tag keys. These predefined keys are scoped to namespaces.
        /// Example: {&quot;orcl-cloud&quot;: {&quot;free-tier-retained&quot;: &quot;true&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
    }
}
