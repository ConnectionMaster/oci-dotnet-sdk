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

namespace Oci.OpsiService.Models
{
    /// <summary>
    /// User credential details to connect to the database.
    /// 
    /// </summary>
    [JsonConverter(typeof(CredentialDetailsModelConverter))]
    public class CredentialDetails 
    {
        
        /// <value>
        /// Credential source name that had been added in Management Agent wallet. This value is only required when Credential set by CREDENTIALS_BY_SOURCE and is optional properties for ther others.
        /// </value>
        [JsonProperty(PropertyName = "credentialSourceName")]
        public string CredentialSourceName { get; set; }
                ///
        /// <value>
        /// CREDENTIALS_BY_SOURCE is supplied via the External Database Service. CREDENTIALS_BY_VAULT is supplied by secret service to connection PE_COMANAGED_DATABASE and ADB as well. CREDENTIALS_BY_IAM is used db-token to connect only for Autonomous Database.
        /// 
        /// </value>
        ///
        public enum CredentialTypeEnum {
            [EnumMember(Value = "CREDENTIALS_BY_SOURCE")]
            CredentialsBySource,
            [EnumMember(Value = "CREDENTIALS_BY_VAULT")]
            CredentialsByVault,
            [EnumMember(Value = "CREDENTIALS_BY_IAM")]
            CredentialsByIam,
            [EnumMember(Value = "CREDENTIALS_BY_NAMED_CREDS")]
            CredentialsByNamedCreds
        };

        
    }

    public class CredentialDetailsModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(CredentialDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(CredentialDetails);
            var discriminator = jsonObject["credentialType"].Value<string>();
            switch (discriminator)
            {
                case "CREDENTIALS_BY_NAMED_CREDS":
                    obj = new CredentialByNamedCredentials();
                    break;
                case "CREDENTIALS_BY_SOURCE":
                    obj = new CredentialsBySource();
                    break;
                case "CREDENTIALS_BY_VAULT":
                    obj = new CredentialByVault();
                    break;
                case "CREDENTIALS_BY_IAM":
                    obj = new CredentialByIam();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under CredentialDetails! Returning null value.");
            }
            return obj;
        }
    }
}
