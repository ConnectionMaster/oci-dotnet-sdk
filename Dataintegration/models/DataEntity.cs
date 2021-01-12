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
using Newtonsoft.Json.Linq;

namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// The data entity object.
    /// </summary>
    [JsonConverter(typeof(DataEntityModelConverter))]
    public class DataEntity 
    {
                ///
        /// <value>
        /// The data entity type.
        /// </value>
        ///
        public enum ModelTypeEnum {
            [EnumMember(Value = "VIEW_ENTITY")]
            ViewEntity,
            [EnumMember(Value = "TABLE_ENTITY")]
            TableEntity,
            [EnumMember(Value = "FILE_ENTITY")]
            FileEntity
        };

        
        [JsonProperty(PropertyName = "metadata")]
        public ObjectMetadata Metadata { get; set; }
        
    }

    public class DataEntityModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(DataEntity);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(DataEntity);
            var discriminator = jsonObject["modelType"].Value<string>();
            switch (discriminator)
            {
                case "TABLE_ENTITY":
                    obj = new DataEntityFromTable();
                    break;
                case "VIEW_ENTITY":
                    obj = new DataEntityFromView();
                    break;
                case "FILE_ENTITY":
                    obj = new DataEntityFromFile();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
