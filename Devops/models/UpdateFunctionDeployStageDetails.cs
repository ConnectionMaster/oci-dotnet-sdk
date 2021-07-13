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


namespace Oci.DevopsService.Models
{
    /// <summary>
    /// Specifies the Function stage.
    /// </summary>
    public class UpdateFunctionDeployStageDetails : UpdateDeployStageDetails
    {
        
        /// <value>
        /// Function environment OCID.
        /// </value>
        [JsonProperty(PropertyName = "functionDeployEnvironmentId")]
        public string FunctionDeployEnvironmentId { get; set; }
        
        /// <value>
        /// A Docker image artifact OCID.
        /// </value>
        [JsonProperty(PropertyName = "dockerImageDeployArtifactId")]
        public string DockerImageDeployArtifactId { get; set; }
        
        /// <value>
        /// User provided key and value pair configuration, which is assigned through constants or parameter.
        /// </value>
        [JsonProperty(PropertyName = "config")]
        public System.Collections.Generic.Dictionary<string, string> Config { get; set; }
        
        /// <value>
        /// Maximum usable memory for the Function (in MB).
        /// </value>
        [JsonProperty(PropertyName = "maxMemoryInMBs")]
        public System.Nullable<long> MaxMemoryInMBs { get; set; }
        
        /// <value>
        /// Timeout for execution of the Function. Value in seconds.
        /// </value>
        [JsonProperty(PropertyName = "functionTimeoutInSeconds")]
        public System.Nullable<int> FunctionTimeoutInSeconds { get; set; }
        
        [JsonProperty(PropertyName = "deployStageType")]
        private readonly string deployStageType = "DEPLOY_FUNCTION";
    }
}
