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
    
    public class InstanceSourceViaImageDetails : InstanceSourceDetails
    {
        
        /// <value>
        /// The size of the boot volume in GBs. Minimum value is 50 GB and maximum value is 16384 GB (16TB).
        /// </value>
        [JsonProperty(PropertyName = "bootVolumeSizeInGBs")]
        public System.Nullable<long> BootVolumeSizeInGBs { get; set; }
        
        /// <value>
        /// The OCID of the image used to boot the instance.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ImageId is required.")]
        [JsonProperty(PropertyName = "imageId")]
        public string ImageId { get; set; }
        
        /// <value>
        /// The OCID of the Key Management key to assign as the master encryption key for the boot volume.
        /// </value>
        [JsonProperty(PropertyName = "kmsKeyId")]
        public string KmsKeyId { get; set; }
        
        [JsonProperty(PropertyName = "sourceType")]
        private readonly string sourceType = "image";
    }
}
