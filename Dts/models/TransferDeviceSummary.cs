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


namespace Oci.DtsService.Models
{
    
    public class TransferDeviceSummary 
    {
        
        [JsonProperty(PropertyName = "serialNumber")]
        public string SerialNumber { get; set; }
        
        [JsonProperty(PropertyName = "iscsiIQN")]
        public string IscsiIQN { get; set; }
        
        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }
                ///
        ///
        public enum LifecycleStateEnum {
            [EnumMember(Value = "PREPARING")]
            Preparing,
            [EnumMember(Value = "READY")]
            Ready,
            [EnumMember(Value = "PACKAGED")]
            Packaged,
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "PROCESSING")]
            Processing,
            [EnumMember(Value = "COMPLETE")]
            Complete,
            [EnumMember(Value = "MISSING")]
            Missing,
            [EnumMember(Value = "ERROR")]
            Error,
            [EnumMember(Value = "DELETED")]
            Deleted,
            [EnumMember(Value = "CANCELLED")]
            Cancelled
        };

        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        [JsonProperty(PropertyName = "attachedTransferPackageLabel")]
        public string AttachedTransferPackageLabel { get; set; }
        
        [JsonProperty(PropertyName = "creationTime")]
        public System.Nullable<System.DateTime> CreationTime { get; set; }
        
        [JsonProperty(PropertyName = "uploadStatusLogUri")]
        public string UploadStatusLogUri { get; set; }
        
    }
}
