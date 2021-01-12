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

namespace Oci.MysqlService.Models
{
    /// <summary>
    /// The CA certificate of the server used for VERIFY_IDENTITY and VERIFY_CA ssl modes.
    /// </summary>
    [JsonConverter(typeof(CaCertificateModelConverter))]
    public class CaCertificate 
    {
                ///
        /// <value>
        /// The type of CA certificate.
        /// </value>
        ///
        public enum CertificateTypeEnum {
            [EnumMember(Value = "PEM")]
            Pem
        };

        
    }

    public class CaCertificateModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(CaCertificate);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(CaCertificate);
            var discriminator = jsonObject["certificateType"].Value<string>();
            switch (discriminator)
            {
                case "PEM":
                    obj = new PemCaCertificate();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
