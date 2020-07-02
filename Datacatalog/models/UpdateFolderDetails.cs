/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DatacatalogService.Models
{
    /// <summary>
    /// Properties used in folder update operations.
    /// </summary>
    public class UpdateFolderDetails 
    {
        
        /// <value>
        /// A user-friendly display name. Does not have to be unique, and it's changeable.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <value>
        /// Detailed description of a folder.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <value>
        /// The key of the containing folder.
        /// </value>
        [JsonProperty(PropertyName = "parentFolderKey")]
        public string ParentFolderKey { get; set; }

        /// <value>
        /// A map of maps that contains the properties which are specific to the folder type. Each folder type
        /// definition defines it's set of required and optional properties. The map keys are category names and the
        /// values are maps of property name to property value. Every property is contained inside of a category. Most
        /// folders have required properties within the \"default\" category. To determine the set of optional and
        /// required properties for a folder type, a query can be done on '/types?type=folder' that returns a
        /// collection of all folder types. The appropriate folder type, which includes definitions of all of
        /// it's properties, can be identified from this collection.
        /// Example: {&quot;properties&quot;: { &quot;default&quot;: { &quot;key1&quot;: &quot;value1&quot;}}}
        /// </value>
        [JsonProperty(PropertyName = "properties")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, string>> Properties { get; set; }

        /// <value>
        /// Last modified timestamp of this object in the external system.
        /// </value>
        [JsonProperty(PropertyName = "timeExternal")]
        public System.Nullable<System.DateTime> TimeExternal { get; set; }

        /// <value>
        /// Harvest status of the folder.
        /// </value>
        [JsonProperty(PropertyName = "harvestStatus")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<HarvestStatus> HarvestStatus { get; set; }

        /// <value>
        /// The key of the last harvest process to update the metadata of this object.
        /// </value>
        [JsonProperty(PropertyName = "lastJobKey")]
        public string LastJobKey { get; set; }
    }
}
