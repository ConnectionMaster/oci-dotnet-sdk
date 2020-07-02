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


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// The information about the target operator. The target operator lets you specify the data entity to store the transformed data.
    /// </summary>
    public class Target : Operator
    {
        
        [JsonProperty(PropertyName = "entity")]
        public DataEntity Entity { get; set; }

        /// <value>
        /// Specifies the read access.
        /// </value>
        [JsonProperty(PropertyName = "isReadAccess")]
        public System.Nullable<bool> IsReadAccess { get; set; }

        /// <value>
        /// Specifies the copy fields.
        /// </value>
        [JsonProperty(PropertyName = "isCopyFields")]
        public System.Nullable<bool> IsCopyFields { get; set; }

        /// <value>
        /// Specifies if this uses a predefined shape.
        /// </value>
        [JsonProperty(PropertyName = "isPredefinedShape")]
        public System.Nullable<bool> IsPredefinedShape { get; set; }
        ///
        /// <value>
        /// Specifies the data property.
        /// </value>
        ///
        public enum DataPropertyEnum {
            [EnumMember(Value = "TRUNCATE")]
            Truncate,
            [EnumMember(Value = "MERGE")]
            Merge,
            [EnumMember(Value = "BACKUP")]
            Backup,
            [EnumMember(Value = "OVERWRITE")]
            Overwrite,
            [EnumMember(Value = "APPEND")]
            Append,
            [EnumMember(Value = "IGNORE")]
            Ignore
        };

        /// <value>
        /// Specifies the data property.
        /// </value>
        [JsonProperty(PropertyName = "dataProperty")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DataPropertyEnum> DataProperty { get; set; }

        [JsonProperty(PropertyName = "writeOperationConfig")]
        public WriteOperationConfig WriteOperationConfig { get; set; }
    }
}
