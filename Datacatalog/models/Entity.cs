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
    /// Data entity details. A representation of data with a set of attributes, normally representing a single
    /// business entity. Synonymous with 'table' or 'view' in a database, or a single logical file structure
    /// that one or many files may match.
    /// 
    /// </summary>
    public class Entity 
    {
        
        /// <value>
        /// Unique data entity key that is immutable.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Key is required.")]
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }

        /// <value>
        /// A user-friendly display name. Does not have to be unique, and it's changeable.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <value>
        /// Detailed description of a data entity.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <value>
        /// The date and time the data entity was created, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// Example: 2019-03-25T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }

        /// <value>
        /// The last time that any change was made to the data entity. An [RFC3339](https://tools.ietf.org/html/rfc3339) formatted datetime string.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }

        /// <value>
        /// OCID of the user who created this object in the data catalog.
        /// </value>
        [JsonProperty(PropertyName = "createdById")]
        public string CreatedById { get; set; }

        /// <value>
        /// OCID of the user who updated this object in the data catalog.
        /// </value>
        [JsonProperty(PropertyName = "updatedById")]
        public string UpdatedById { get; set; }

        /// <value>
        /// The current state of the data entity.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleState> LifecycleState { get; set; }

        /// <value>
        /// Unique external key of this object in the source system.
        /// </value>
        [JsonProperty(PropertyName = "externalKey")]
        public string ExternalKey { get; set; }

        /// <value>
        /// Last modified timestamp of this object in the external system.
        /// </value>
        [JsonProperty(PropertyName = "timeExternal")]
        public System.Nullable<System.DateTime> TimeExternal { get; set; }

        /// <value>
        /// Time that the data entities status was last updated. An [RFC3339](https://tools.ietf.org/html/rfc3339) formatted datetime string.
        /// </value>
        [JsonProperty(PropertyName = "timeStatusUpdated")]
        public System.Nullable<System.DateTime> TimeStatusUpdated { get; set; }

        /// <value>
        /// Property that identifies if the object is a physical object (materialized) or virtual/logical object
        /// defined on other objects.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isLogical")]
        public System.Nullable<bool> IsLogical { get; set; }

        /// <value>
        /// Property that identifies if an object is a sub object of a physical or materialized parent object.
        /// </value>
        [JsonProperty(PropertyName = "isPartition")]
        public System.Nullable<bool> IsPartition { get; set; }

        /// <value>
        /// Unique key of the parent data asset.
        /// </value>
        [JsonProperty(PropertyName = "dataAssetKey")]
        public string DataAssetKey { get; set; }

        /// <value>
        /// Key of the associated folder.
        /// </value>
        [JsonProperty(PropertyName = "folderKey")]
        public string FolderKey { get; set; }

        /// <value>
        /// Full path of the data entity.
        /// </value>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        /// <value>
        /// Status of the object as updated by the harvest process.
        /// </value>
        [JsonProperty(PropertyName = "harvestStatus")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<HarvestStatus> HarvestStatus { get; set; }

        /// <value>
        /// Key of the last harvest process to update this object.
        /// </value>
        [JsonProperty(PropertyName = "lastJobKey")]
        public string LastJobKey { get; set; }

        /// <value>
        /// The type of data entity object. Type key's can be found via the '/types' endpoint.
        /// </value>
        [JsonProperty(PropertyName = "typeKey")]
        public string TypeKey { get; set; }

        /// <value>
        /// URI to the data entity instance in the API.
        /// </value>
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }

        /// <value>
        /// A map of maps that contains the properties which are specific to the entity type. Each entity type
        /// definition defines it's set of required and optional properties. The map keys are category names and the
        /// values are maps of property name to property value. Every property is contained inside of a category. Most
        /// data entities have required properties within the \"default\" category.
        /// Example: {&quot;properties&quot;: { &quot;default&quot;: { &quot;key1&quot;: &quot;value1&quot;}}}
        /// </value>
        [JsonProperty(PropertyName = "properties")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, string>> Properties { get; set; }
    }
}
