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
    /// The information about a task run.
    /// </summary>
    public class TaskRun 
    {
        
        /// <value>
        /// The key of the object.
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
        /// Free form text without any restriction on permitted characters. Name can have letters, numbers, and special characters. The value is editable and is restricted to 1000 characters.
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
        
        [JsonProperty(PropertyName = "configProvider")]
        public ConfigProvider ConfigProvider { get; set; }
                ///
        /// <value>
        /// The status of the task run.
        /// </value>
        ///
        public enum StatusEnum {
            [EnumMember(Value = "NOT_STARTED")]
            NotStarted,
            [EnumMember(Value = "QUEUED")]
            Queued,
            [EnumMember(Value = "RUNNING")]
            Running,
            [EnumMember(Value = "TERMINATING")]
            Terminating,
            [EnumMember(Value = "TERMINATED")]
            Terminated,
            [EnumMember(Value = "SUCCESS")]
            Success,
            [EnumMember(Value = "ERROR")]
            Error
        };

        /// <value>
        /// The status of the task run.
        /// </value>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<StatusEnum> Status { get; set; }
        
        /// <value>
        /// The start time.
        /// </value>
        [JsonProperty(PropertyName = "startTimeMillis")]
        public System.Nullable<long> StartTimeMillis { get; set; }
        
        /// <value>
        /// The end time.
        /// </value>
        [JsonProperty(PropertyName = "endTimeMillis")]
        public System.Nullable<long> EndTimeMillis { get; set; }
        
        /// <value>
        /// The date and time the object was last updated.
        /// </value>
        [JsonProperty(PropertyName = "lastUpdated")]
        public System.Nullable<long> LastUpdated { get; set; }
        
        /// <value>
        /// The number of records processed in the task run.
        /// </value>
        [JsonProperty(PropertyName = "recordsWritten")]
        public System.Nullable<long> RecordsWritten { get; set; }
        
        /// <value>
        /// The number of bytes processed in the task run.
        /// </value>
        [JsonProperty(PropertyName = "bytesProcessed")]
        public System.Nullable<long> BytesProcessed { get; set; }
        
        /// <value>
        /// Contains an error message if status is `ERROR`.
        /// </value>
        [JsonProperty(PropertyName = "errorMessage")]
        public string ErrorMessage { get; set; }
        
        /// <value>
        /// The OPC request ID of execution of the task run.
        /// </value>
        [JsonProperty(PropertyName = "opcRequestId")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// The status of an object that can be set to value 1 for shallow references across objects, other values reserved.
        /// </value>
        [JsonProperty(PropertyName = "objectStatus")]
        public System.Nullable<int> ObjectStatus { get; set; }
                ///
        /// <value>
        /// The type of task run.
        /// </value>
        ///
        public enum TaskTypeEnum {
            [EnumMember(Value = "INTEGRATION_TASK")]
            IntegrationTask,
            [EnumMember(Value = "DATA_LOADER_TASK")]
            DataLoaderTask
        };

        /// <value>
        /// The type of task run.
        /// </value>
        [JsonProperty(PropertyName = "taskType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<TaskTypeEnum> TaskType { get; set; }
        
        /// <value>
        /// Value can only contain upper case letters, underscore and numbers. It should begin with upper case letter or underscore. The value can be modified.
        /// </value>
        [JsonProperty(PropertyName = "identifier")]
        public string Identifier { get; set; }
        
        [JsonProperty(PropertyName = "metadata")]
        public ObjectMetadata Metadata { get; set; }
        
        /// <value>
        /// A key map. If provided, key is replaced with generated key. This structure provides mapping between user provided key and generated key.
        /// </value>
        [JsonProperty(PropertyName = "keyMap")]
        public System.Collections.Generic.Dictionary<string, string> KeyMap { get; set; }
        
    }
}
