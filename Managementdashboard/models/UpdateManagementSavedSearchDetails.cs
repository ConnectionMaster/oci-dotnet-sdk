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


namespace Oci.ManagementdashboardService.Models
{
    /// <summary>
    /// Properties of a saved search.  Saved search ID must not be provided.
    /// </summary>
    public class UpdateManagementSavedSearchDetails 
    {
        
        /// <value>
        /// Display name of the saved search.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// ID of the service (for example log-analytics) that owns the saved search. Each service has a unique ID.
        /// </value>
        [JsonProperty(PropertyName = "providerId")]
        public string ProviderId { get; set; }
        
        /// <value>
        /// Version of the service that owns this saved search.
        /// </value>
        [JsonProperty(PropertyName = "providerVersion")]
        public string ProviderVersion { get; set; }
        
        /// <value>
        /// Name of the service (for example, Logging Analytics) that owns the saved search.
        /// </value>
        [JsonProperty(PropertyName = "providerName")]
        public string ProviderName { get; set; }
        
        /// <value>
        /// OCID of the compartment in which the saved search resides.
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Determines whether the saved search is an Out-of-the-Box (OOB) saved search. Note that OOB saved searches are only provided by Oracle and cannot be modified.
        /// </value>
        [JsonProperty(PropertyName = "isOobSavedSearch")]
        public System.Nullable<bool> IsOobSavedSearch { get; set; }
        
        /// <value>
        /// Description of the saved search.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// JSON that contains internationalization options.
        /// </value>
        [JsonProperty(PropertyName = "nls")]
        public System.Object Nls { get; set; }
        
        /// <value>
        /// Determines how the saved search is displayed in a dashboard.
        /// </value>
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<SavedSearchTypes> Type { get; set; }
        
        /// <value>
        /// JSON that contains user interface options.
        /// </value>
        [JsonProperty(PropertyName = "uiConfig")]
        public System.Object UiConfig { get; set; }
        
        /// <value>
        /// Array of JSON that contain data source options.
        /// </value>
        [JsonProperty(PropertyName = "dataConfig")]
        public System.Collections.Generic.List<System.Object> DataConfig { get; set; }
        
        /// <value>
        /// Screen image of the saved search.
        /// </value>
        [JsonProperty(PropertyName = "screenImage")]
        public string ScreenImage { get; set; }
        
        /// <value>
        /// Version of the metadata.
        /// </value>
        [JsonProperty(PropertyName = "metadataVersion")]
        public string MetadataVersion { get; set; }
        
        /// <value>
        /// Reference to the HTML file of the widget.
        /// </value>
        [JsonProperty(PropertyName = "widgetTemplate")]
        public string WidgetTemplate { get; set; }
        
        /// <value>
        /// Reference to the view model of the widget.
        /// </value>
        [JsonProperty(PropertyName = "widgetVM")]
        public string WidgetVM { get; set; }
        
        /// <value>
        /// Defines parameters for the saved search.
        /// </value>
        [JsonProperty(PropertyName = "parametersConfig")]
        public System.Collections.Generic.List<System.Object> ParametersConfig { get; set; }
        
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
        
    }
}
