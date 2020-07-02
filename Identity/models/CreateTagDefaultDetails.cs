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


namespace Oci.IdentityService.Models
{
    
    public class CreateTagDefaultDetails 
    {
        
        /// <value>
        /// The OCID of the compartment. The tag default will be applied to all new resources created in this compartment.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }

        /// <value>
        /// The OCID of the tag definition. The tag default will always assign a default value for this tag definition.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TagDefinitionId is required.")]
        [JsonProperty(PropertyName = "tagDefinitionId")]
        public string TagDefinitionId { get; set; }

        /// <value>
        /// The default value for the tag definition. This will be applied to all new resources created in the compartment.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Value is required.")]
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <value>
        /// If you specify that a value is required, a value is set during resource creation (either by 
        /// the user creating the resource or another tag defualt). If no value is set, resource 
        /// creation is blocked.
        /// <br/>
        /// * If the `isRequired` flag is set to \"true\", the value is set during resource creation.
        /// * If the `isRequired` flag is set to \"false\", the value you enter is set during resource creation.
        /// <br/>
        /// Example: false
        /// </value>
        [JsonProperty(PropertyName = "isRequired")]
        public System.Nullable<bool> IsRequired { get; set; }
    }
}
