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
    /// The information about task validation
    /// </summary>
    public class TaskValidation 
    {
        
        /// <value>
        /// Total number of validation messages
        /// </value>
        [JsonProperty(PropertyName = "totalMessageCount")]
        public System.Nullable<int> TotalMessageCount { get; set; }

        /// <value>
        /// Total number of validation error messages
        /// </value>
        [JsonProperty(PropertyName = "errorMessageCount")]
        public System.Nullable<int> ErrorMessageCount { get; set; }

        /// <value>
        /// Total number of validation warning messages
        /// </value>
        [JsonProperty(PropertyName = "warnMessageCount")]
        public System.Nullable<int> WarnMessageCount { get; set; }

        /// <value>
        /// Total number of validation information messages
        /// </value>
        [JsonProperty(PropertyName = "infoMessageCount")]
        public System.Nullable<int> InfoMessageCount { get; set; }

        /// <value>
        /// Detailed information of the DataFlow object validation.
        /// </value>
        [JsonProperty(PropertyName = "validationMessages")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<ValidationMessage>> ValidationMessages { get; set; }

        /// <value>
        /// Objects will use a 36 character key as unique ID. It is system generated and cannot be edited by user
        /// </value>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }

        /// <value>
        /// The type of the object.
        /// </value>
        [JsonProperty(PropertyName = "modelType")]
        public string ModelType { get; set; }

        /// <value>
        /// The model version of an object.
        /// </value>
        [JsonProperty(PropertyName = "modelVersion")]
        public string ModelVersion { get; set; }

        [JsonProperty(PropertyName = "parentRef")]
        public ParentReference ParentRef { get; set; }

        /// <value>
        /// Free form text without any restriction on permitted characters. Name can have letters, numbers, and special characters. The value can be edited by the user and it is restricted to 1000 characters
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <value>
        /// Detailed description for the object.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <value>
        /// The version of the object that is used to track changes in the object instance.
        /// </value>
        [JsonProperty(PropertyName = "objectVersion")]
        public System.Nullable<int> ObjectVersion { get; set; }

        /// <value>
        /// The status of an object that can be set to value 1 for shallow references across objects, other values reserved.
        /// </value>
        [JsonProperty(PropertyName = "objectStatus")]
        public System.Nullable<int> ObjectStatus { get; set; }

        /// <value>
        /// Value can only contain upper case letters, underscore and numbers. It should begin with upper case letter or underscore. The value can be edited by the user.
        /// </value>
        [JsonProperty(PropertyName = "identifier")]
        public string Identifier { get; set; }

        [JsonProperty(PropertyName = "metadata")]
        public ObjectMetadata Metadata { get; set; }
    }
}
