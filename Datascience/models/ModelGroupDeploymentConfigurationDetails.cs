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


namespace Oci.DatascienceService.Models
{
    /// <summary>
    /// The model group type deployment.
    /// </summary>
    public class ModelGroupDeploymentConfigurationDetails : ModelDeploymentConfigurationDetails
    {
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ModelGroupConfigurationDetails is required.")]
        [JsonProperty(PropertyName = "modelGroupConfigurationDetails")]
        public ModelGroupConfigurationDetails ModelGroupConfigurationDetails { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "InfrastructureConfigurationDetails is required.")]
        [JsonProperty(PropertyName = "infrastructureConfigurationDetails")]
        public InfrastructureConfigurationDetails InfrastructureConfigurationDetails { get; set; }
        
        [JsonProperty(PropertyName = "environmentConfigurationDetails")]
        public ModelDeploymentEnvironmentConfigurationDetails EnvironmentConfigurationDetails { get; set; }
        
        [JsonProperty(PropertyName = "deploymentType")]
        private readonly string deploymentType = "MODEL_GROUP";
    }
}
