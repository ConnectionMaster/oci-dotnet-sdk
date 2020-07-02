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
using Newtonsoft.Json.Linq;

namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// The configuration details for creating a Data Guard association between databases.
    /// <br/>
    /// **Warning:** Oracle recommends that you avoid using any confidential information when you supply string values using the API.
    /// 
    /// </summary>
    [JsonConverter(typeof(CreateDataGuardAssociationDetailsModelConverter))]
    public class CreateDataGuardAssociationDetails 
    {
        
        /// <value>
        /// A strong password for the `SYS`, `SYSTEM`, and `PDB Admin` users to apply during standby creation.
        /// <br/>
        /// The password must contain no fewer than nine characters and include:
        /// <br/>
        /// * At least two uppercase characters.
        /// <br/>
        /// * At least two lowercase characters.
        /// <br/>
        /// * At least two numeric characters.
        /// <br/>
        /// * At least two special characters. Valid special characters include \"_\", \"#\", and \"-\" only.
        /// <br/>
        /// **The password MUST be the same as the primary admin password.**
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DatabaseAdminPassword is required.")]
        [JsonProperty(PropertyName = "databaseAdminPassword")]
        public string DatabaseAdminPassword { get; set; }
        ///
        /// <value>
        /// The protection mode to set up between the primary and standby databases. For more information, see
        /// [Oracle Data Guard Protection Modes](http://docs.oracle.com/database/122/SBYDB/oracle-data-guard-protection-modes.htm#SBYDB02000)
        /// in the Oracle Data Guard documentation.
        /// <br/>
        /// **IMPORTANT** - The only protection mode currently supported by the Database service is MAXIMUM_PERFORMANCE.
        /// 
        /// </value>
        ///
        public enum ProtectionModeEnum {
            [EnumMember(Value = "MAXIMUM_AVAILABILITY")]
            MaximumAvailability,
            [EnumMember(Value = "MAXIMUM_PERFORMANCE")]
            MaximumPerformance,
            [EnumMember(Value = "MAXIMUM_PROTECTION")]
            MaximumProtection
        };

        /// <value>
        /// The protection mode to set up between the primary and standby databases. For more information, see
        /// [Oracle Data Guard Protection Modes](http://docs.oracle.com/database/122/SBYDB/oracle-data-guard-protection-modes.htm#SBYDB02000)
        /// in the Oracle Data Guard documentation.
        /// <br/>
        /// **IMPORTANT** - The only protection mode currently supported by the Database service is MAXIMUM_PERFORMANCE.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ProtectionMode is required.")]
        [JsonProperty(PropertyName = "protectionMode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ProtectionModeEnum> ProtectionMode { get; set; }
        ///
        /// <value>
        /// The redo transport type to use for this Data Guard association.  Valid values depend on the specified `protectionMode`:
        /// <br/>
        /// * MAXIMUM_AVAILABILITY - SYNC or FASTSYNC
        /// * MAXIMUM_PERFORMANCE - ASYNC
        /// * MAXIMUM_PROTECTION - SYNC
        /// <br/>
        /// For more information, see
        /// [Redo Transport Services](http://docs.oracle.com/database/122/SBYDB/oracle-data-guard-redo-transport-services.htm#SBYDB00400)
        /// in the Oracle Data Guard documentation.
        /// <br/>
        /// **IMPORTANT** - The only transport type currently supported by the Database service is ASYNC.
        /// 
        /// </value>
        ///
        public enum TransportTypeEnum {
            [EnumMember(Value = "SYNC")]
            Sync,
            [EnumMember(Value = "ASYNC")]
            Async,
            [EnumMember(Value = "FASTSYNC")]
            Fastsync
        };

        /// <value>
        /// The redo transport type to use for this Data Guard association.  Valid values depend on the specified `protectionMode`:
        /// <br/>
        /// * MAXIMUM_AVAILABILITY - SYNC or FASTSYNC
        /// * MAXIMUM_PERFORMANCE - ASYNC
        /// * MAXIMUM_PROTECTION - SYNC
        /// <br/>
        /// For more information, see
        /// [Redo Transport Services](http://docs.oracle.com/database/122/SBYDB/oracle-data-guard-redo-transport-services.htm#SBYDB00400)
        /// in the Oracle Data Guard documentation.
        /// <br/>
        /// **IMPORTANT** - The only transport type currently supported by the Database service is ASYNC.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TransportType is required.")]
        [JsonProperty(PropertyName = "transportType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<TransportTypeEnum> TransportType { get; set; }

        /// <value>
        /// Specifies whether to create the peer database in an existing DB system or in a new DB system.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CreationType is required.")]
        [JsonProperty(PropertyName = "creationType")]
        public string CreationType { get; set; }
    }

    public class CreateDataGuardAssociationDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(CreateDataGuardAssociationDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(CreateDataGuardAssociationDetails);
            var discriminator = jsonObject["creationType"].Value<string>();
            switch (discriminator)
            {
                case "NewDbSystem":
                    obj = new CreateDataGuardAssociationWithNewDbSystemDetails();
                    break;
                case "ExistingDbSystem":
                    obj = new CreateDataGuardAssociationToExistingDbSystemDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
