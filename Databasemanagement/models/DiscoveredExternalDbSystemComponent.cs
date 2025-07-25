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
using Newtonsoft.Json.Linq;

namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// The details of an external DB system component.
    /// </summary>
    [JsonConverter(typeof(DiscoveredExternalDbSystemComponentModelConverter))]
    public class DiscoveredExternalDbSystemComponent 
    {
        
        /// <value>
        /// The identifier of the discovered DB system component.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ComponentId is required.")]
        [JsonProperty(PropertyName = "componentId")]
        public string ComponentId { get; set; }
        
        /// <value>
        /// The user-friendly name for the discovered DB system component. The name does not have to be unique.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The name of the discovered DB system component.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ComponentName is required.")]
        [JsonProperty(PropertyName = "componentName")]
        public string ComponentName { get; set; }
        
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the existing OCI resource matching the discovered DB system component.
        /// </value>
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; set; }
        
        /// <value>
        /// Indicates whether the DB system component should be provisioned as an OCI resource or not.
        /// </value>
        [JsonProperty(PropertyName = "isSelectedForMonitoring")]
        public System.Nullable<bool> IsSelectedForMonitoring { get; set; }
                ///
        /// <value>
        /// The state of the discovered DB system component.
        /// </value>
        ///
        public enum StatusEnum {
            [EnumMember(Value = "NEW")]
            New,
            [EnumMember(Value = "EXISTING")]
            Existing,
            [EnumMember(Value = "MARKED_FOR_DELETION")]
            MarkedForDeletion,
            [EnumMember(Value = "UNKNOWN")]
            Unknown
        };

        /// <value>
        /// The state of the discovered DB system component.
        /// </value>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<StatusEnum> Status { get; set; }
        
        /// <value>
        /// The list of associated components.
        /// </value>
        [JsonProperty(PropertyName = "associatedComponents")]
        public System.Collections.Generic.List<AssociatedComponent> AssociatedComponents { get; set; }
        
    }

    public class DiscoveredExternalDbSystemComponentModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(DiscoveredExternalDbSystemComponent);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(DiscoveredExternalDbSystemComponent);
            var discriminator = jsonObject["componentType"].Value<string>();
            switch (discriminator)
            {
                case "CLUSTER":
                    obj = new DiscoveredExternalCluster();
                    break;
                case "DATABASE_HOME":
                    obj = new DiscoveredExternalDbHome();
                    break;
                case "DATABASE":
                    obj = new DiscoveredExternalDatabase();
                    break;
                case "PLUGGABLE_DATABASE":
                    obj = new DiscoveredExternalPluggableDatabase();
                    break;
                case "CLUSTER_INSTANCE":
                    obj = new DiscoveredExternalClusterInstance();
                    break;
                case "LISTENER":
                    obj = new DiscoveredExternalListener();
                    break;
                case "DATABASE_NODE":
                    obj = new DiscoveredExternalDbNode();
                    break;
                case "DATABASE_INSTANCE":
                    obj = new DiscoveredExternalDbInstance();
                    break;
                case "ASM":
                    obj = new DiscoveredExternalAsm();
                    break;
                case "ASM_INSTANCE":
                    obj = new DiscoveredExternalAsmInstance();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under DiscoveredExternalDbSystemComponent! Returning null value.");
            }
            return obj;
        }
    }
}
