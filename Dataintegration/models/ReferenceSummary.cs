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


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// This is the reference summary information.
    /// </summary>
    public class ReferenceSummary 
    {
        
        /// <value>
        /// The reference's key, key of the object that is being used by a published object or its dependents.
        /// </value>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <value>
        /// The name of reference object.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The identifier of reference object.
        /// </value>
        [JsonProperty(PropertyName = "identifier")]
        public string Identifier { get; set; }
        
        /// <value>
        /// The identifier path of reference object.
        /// </value>
        [JsonProperty(PropertyName = "identifierPath")]
        public string IdentifierPath { get; set; }
        
        /// <value>
        /// The description of reference object.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
                ///
        /// <value>
        /// The type of reference object.
        /// </value>
        ///
        public enum TypeEnum {
            [EnumMember(Value = "ORACLE_DATA_ASSET")]
            OracleDataAsset,
            [EnumMember(Value = "ORACLE_OBJECT_STORAGE_DATA_ASSET")]
            OracleObjectStorageDataAsset,
            [EnumMember(Value = "ORACLE_ATP_DATA_ASSET")]
            OracleAtpDataAsset,
            [EnumMember(Value = "ORACLE_ADWC_DATA_ASSET")]
            OracleAdwcDataAsset,
            [EnumMember(Value = "MYSQL_DATA_ASSET")]
            MysqlDataAsset,
            [EnumMember(Value = "GENERIC_JDBC_DATA_ASSET")]
            GenericJdbcDataAsset
        };

        /// <value>
        /// The type of reference object.
        /// </value>
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<TypeEnum> Type { get; set; }
        
        /// <value>
        /// The target object referenced. References are made to data assets and child references are made to connections. The type defining this reference is mentioned in the property type.
        /// </value>
        [JsonProperty(PropertyName = "targetObject")]
        public System.Object TargetObject { get; set; }
        
        /// <value>
        /// The aggregator of reference object.
        /// </value>
        [JsonProperty(PropertyName = "aggregatorKey")]
        public string AggregatorKey { get; set; }
        
        /// <value>
        /// List of published objects where this is used.
        /// </value>
        [JsonProperty(PropertyName = "usedBy")]
        public System.Collections.Generic.List<ReferenceUsedBy> UsedBy { get; set; }
        
        /// <value>
        /// List of references that are dependent on this reference.
        /// </value>
        [JsonProperty(PropertyName = "childReferences")]
        public System.Collections.Generic.List<ChildReference> ChildReferences { get; set; }
        
    }
}
