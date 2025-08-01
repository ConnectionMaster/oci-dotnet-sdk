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


namespace Oci.ManagementagentService.Models
{
    /// <summary>
    /// Property item in name/value pair
    /// </summary>
    public class NamedCredentialProperty 
    {
        
        /// <value>
        /// Name of the property
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Value of the property
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Value is required.")]
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
        
        /// <value>
        /// The category of the Named credential property value.
        /// CLEAR_TEXT indicates the value field contains a clear text value.
        /// SECRET_IDENTIFIER indicates the value field contains a vault secret ocid identifier.
        /// ADB_IDENTIFIER indicates the value field contains an Autonomous database ocid identifier.
        /// ALLOWED_VALUE indicates the value should be selected from the options in the allowedValues field.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ValueCategory is required.")]
        [JsonProperty(PropertyName = "valueCategory")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ValueCategoryType> ValueCategory { get; set; }
        
    }
}
