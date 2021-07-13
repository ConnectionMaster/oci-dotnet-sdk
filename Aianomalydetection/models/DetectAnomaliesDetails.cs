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

namespace Oci.AianomalydetectionService.Models
{
    /// <summary>
    /// Base class for the DetectAnomalies call. It contains the identifier that will
    /// be used for deciding what type of request this is.
    /// 
    /// </summary>
    [JsonConverter(typeof(DetectAnomaliesDetailsModelConverter))]
    public class DetectAnomaliesDetails 
    {
        
        /// <value>
        /// The OCID of the trained model\u3002
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ModelId is required.")]
        [JsonProperty(PropertyName = "modelId")]
        public string ModelId { get; set; }
                ///
        /// <value>
        /// Type of request. This parameter will be filled autmatically by classes generated
        /// by the SDK. For raw curl request, user will have to provide this field.
        /// 
        /// </value>
        ///
        public enum RequestTypeEnum {
            [EnumMember(Value = "INLINE")]
            Inline,
            [EnumMember(Value = "BASE64_ENCODED")]
            Base64Encoded
        };

        
    }

    public class DetectAnomaliesDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(DetectAnomaliesDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(DetectAnomaliesDetails);
            var discriminator = jsonObject["requestType"].Value<string>();
            switch (discriminator)
            {
                case "INLINE":
                    obj = new InlineDetectAnomaliesRequest();
                    break;
                case "BASE64_ENCODED":
                    obj = new EmbeddedDetectAnomaliesRequest();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
