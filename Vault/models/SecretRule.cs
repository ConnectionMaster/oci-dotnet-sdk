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

namespace Oci.VaultService.Models
{
    /// <summary>
    /// A rule that you can apply to a secret to enforce certain conditions on the secret's usage and management.
    /// </summary>
    [JsonConverter(typeof(SecretRuleModelConverter))]
    public class SecretRule 
    {
                ///
        /// <value>
        /// The type of rule, which either controls when the secret contents expire or whether they can be reused.
        /// </value>
        ///
        public enum RuleTypeEnum {
            [EnumMember(Value = "SECRET_EXPIRY_RULE")]
            SecretExpiryRule,
            [EnumMember(Value = "SECRET_REUSE_RULE")]
            SecretReuseRule
        };

        /// <value>
        /// The type of rule, which either controls when the secret contents expire or whether they can be reused.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RuleType is required.")]
        [JsonProperty(PropertyName = "ruleType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<RuleTypeEnum> RuleType { get; set; }
    }

    public class SecretRuleModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(SecretRule);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(SecretRule);
            var discriminator = jsonObject["ruleType"].Value<string>();
            switch (discriminator)
            {
                case "SECRET_EXPIRY_RULE":
                    obj = new SecretExpiryRule();
                    break;
                case "SECRET_REUSE_RULE":
                    obj = new SecretReuseRule();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
