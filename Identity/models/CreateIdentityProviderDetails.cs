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

namespace Oci.IdentityService.Models
{
    
    [JsonConverter(typeof(CreateIdentityProviderDetailsModelConverter))]
    public class CreateIdentityProviderDetails 
    {
        
        /// <value>
        /// The OCID of your tenancy.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }

        /// <value>
        /// The name you assign to the `IdentityProvider` during creation.
        /// The name must be unique across all `IdentityProvider` objects in the
        /// tenancy and cannot be changed.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <value>
        /// The description you assign to the `IdentityProvider` during creation.
        /// Does not have to be unique, and it's changeable.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Description is required.")]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        ///
        /// <value>
        /// The identity provider service or product.
        /// Supported identity providers are Oracle Identity Cloud Service (IDCS) and Microsoft
        /// Active Directory Federation Services (ADFS).
        /// <br/>
        /// Example: IDCS
        /// </value>
        ///
        public enum ProductTypeEnum {
            [EnumMember(Value = "IDCS")]
            Idcs,
            [EnumMember(Value = "ADFS")]
            Adfs
        };

        /// <value>
        /// The identity provider service or product.
        /// Supported identity providers are Oracle Identity Cloud Service (IDCS) and Microsoft
        /// Active Directory Federation Services (ADFS).
        /// <br/>
        /// Example: IDCS
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ProductType is required.")]
        [JsonProperty(PropertyName = "productType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ProductTypeEnum> ProductType { get; set; }
        ///
        /// <value>
        /// The protocol used for federation.
        /// <br/>
        /// Example: SAML2
        /// </value>
        ///
        public enum ProtocolEnum {
            [EnumMember(Value = "SAML2")]
            Saml2,
            [EnumMember(Value = "ADFS")]
            Adfs
        };

        /// <value>
        /// The protocol used for federation.
        /// <br/>
        /// Example: SAML2
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Protocol is required.")]
        [JsonProperty(PropertyName = "protocol")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ProtocolEnum> Protocol { get; set; }

        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }

        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
    }

    public class CreateIdentityProviderDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(CreateIdentityProviderDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(CreateIdentityProviderDetails);
            var discriminator = jsonObject["protocol"].Value<string>();
            switch (discriminator)
            {
                case "SAML2":
                    obj = new CreateSaml2IdentityProviderDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
