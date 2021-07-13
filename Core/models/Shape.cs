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


namespace Oci.CoreService.Models
{
    /// <summary>
    /// A compute instance shape that can be used in {@link #launchInstance(LaunchInstanceRequest) launchInstance}.
    /// For more information, see [Overview of the Compute Service](https://docs.cloud.oracle.com/iaas/Content/Compute/Concepts/computeoverview.htm) and
    /// [Compute Shapes](https://docs.cloud.oracle.com/iaas/Content/Compute/References/computeshapes.htm).
    /// 
    /// </summary>
    public class Shape 
    {
                ///
        ///
        public enum BaselineOcpuUtilizationsEnum {
            [EnumMember(Value = "BASELINE_1_8")]
            Baseline18,
            [EnumMember(Value = "BASELINE_1_2")]
            Baseline12,
            [EnumMember(Value = "BASELINE_1_1")]
            Baseline11
        };

        /// <value>
        /// For a subcore burstable VM, the supported baseline OCPU utilization for instances that use this shape.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "baselineOcpuUtilizations", ItemConverterType = typeof(StringEnumConverter))]
        public System.Collections.Generic.List<BaselineOcpuUtilizationsEnum> BaselineOcpuUtilizations { get; set; }
        
        /// <value>
        /// For a subcore burstable VM, the minimum total baseline OCPUs required. The total baseline OCPUs is equal to
        /// baselineOcpuUtilization chosen multiplied by the number of OCPUs chosen.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "minTotalBaselineOcpusRequired")]
        public System.Nullable<decimal> MinTotalBaselineOcpusRequired { get; set; }
        
        /// <value>
        /// The name of the shape. You can enumerate all available shapes by calling
        /// {@link #listShapes(ListShapesRequest) listShapes}.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ShapeProp is required.")]
        [JsonProperty(PropertyName = "shape")]
        public string ShapeProp { get; set; }
        
        /// <value>
        /// A short description of the shape's processor (CPU).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "processorDescription")]
        public string ProcessorDescription { get; set; }
        
        /// <value>
        /// The default number of OCPUs available for this shape.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "ocpus")]
        public System.Nullable<float> Ocpus { get; set; }
        
        /// <value>
        /// The default amount of memory available for this shape, in gigabytes.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "memoryInGBs")]
        public System.Nullable<float> MemoryInGBs { get; set; }
        
        /// <value>
        /// The networking bandwidth available for this shape, in gigabits per second.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "networkingBandwidthInGbps")]
        public System.Nullable<float> NetworkingBandwidthInGbps { get; set; }
        
        /// <value>
        /// The maximum number of VNIC attachments available for this shape.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "maxVnicAttachments")]
        public System.Nullable<int> MaxVnicAttachments { get; set; }
        
        /// <value>
        /// The number of GPUs available for this shape.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "gpus")]
        public System.Nullable<int> Gpus { get; set; }
        
        /// <value>
        /// A short description of the graphics processing unit (GPU) available for this shape.
        /// <br/>
        /// If the shape does not have any GPUs, this field is `null`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "gpuDescription")]
        public string GpuDescription { get; set; }
        
        /// <value>
        /// The number of local disks available for this shape.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "localDisks")]
        public System.Nullable<int> LocalDisks { get; set; }
        
        /// <value>
        /// The aggregate size of the local disks available for this shape, in gigabytes.
        /// <br/>
        /// If the shape does not have any local disks, this field is `null`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "localDisksTotalSizeInGBs")]
        public System.Nullable<float> LocalDisksTotalSizeInGBs { get; set; }
        
        /// <value>
        /// A short description of the local disks available for this shape.
        /// <br/>
        /// If the shape does not have any local disks, this field is `null`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "localDiskDescription")]
        public string LocalDiskDescription { get; set; }
        
        /// <value>
        /// Whether live migration is supported for this shape.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isLiveMigrationSupported")]
        public System.Nullable<bool> IsLiveMigrationSupported { get; set; }
        
        [JsonProperty(PropertyName = "ocpuOptions")]
        public ShapeOcpuOptions OcpuOptions { get; set; }
        
        [JsonProperty(PropertyName = "memoryOptions")]
        public ShapeMemoryOptions MemoryOptions { get; set; }
        
        [JsonProperty(PropertyName = "networkingBandwidthOptions")]
        public ShapeNetworkingBandwidthOptions NetworkingBandwidthOptions { get; set; }
        
        [JsonProperty(PropertyName = "maxVnicAttachmentOptions")]
        public ShapeMaxVnicAttachmentOptions MaxVnicAttachmentOptions { get; set; }
        
    }
}
