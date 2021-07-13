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

namespace Oci.DatasafeService.Models
{
    /// <summary>
    /// Details of the database for the registration in Data Safe.
    /// To choose applicable database type and infrastructure type refer to 
    /// https://confluence.oci.oraclecorp.com/display/DATASAFE/Target+V2+Design
    /// 
    /// </summary>
    [JsonConverter(typeof(DatabaseDetailsModelConverter))]
    public class DatabaseDetails 
    {
        
        
        /// <value>
        /// The infrastructure type the database is running on.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "InfrastructureType is required.")]
        [JsonProperty(PropertyName = "infrastructureType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<InfrastructureType> InfrastructureType { get; set; }
        
    }

    public class DatabaseDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(DatabaseDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(DatabaseDetails);
            var discriminator = jsonObject["databaseType"].Value<string>();
            switch (discriminator)
            {
                case "INSTALLED_DATABASE":
                    obj = new InstalledDatabaseDetails();
                    break;
                case "AUTONOMOUS_DATABASE":
                    obj = new AutonomousDatabaseDetails();
                    break;
                case "DATABASE_CLOUD_SERVICE":
                    obj = new DatabaseCloudServiceDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}