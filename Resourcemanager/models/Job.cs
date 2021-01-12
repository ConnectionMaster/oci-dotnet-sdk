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


namespace Oci.ResourcemanagerService.Models
{
    /// <summary>
    /// The properties that define a job. Jobs perform the actions that are defined in your configuration.
    /// - **Plan job**. A plan job takes your Terraform configuration, parses it, and creates an execution plan.
    /// - **Apply job**. The apply job takes your execution plan, applies it to the associated stack, then executes
    /// the configuration's instructions.
    /// - **Destroy job**. To clean up the infrastructure controlled by the stack, you run a destroy job.
    /// A destroy job does not delete the stack or associated job resources,
    /// but instead releases the resources managed by the stack.
    /// - **Import_TF_State job**. An import Terraform state job takes a Terraform state file and sets it as the current
    /// state of the stack. This is used to migrate local Terraform environments to Resource Manager.
    /// 
    /// </summary>
    public class Job 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the job.
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the stack that is associated with the job.
        /// </value>
        [JsonProperty(PropertyName = "stackId")]
        public string StackId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment in which the job's associated stack resides.
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The job's display name.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
                ///
        /// <value>
        /// The type of job executing.
        /// </value>
        ///
        public enum OperationEnum {
            [EnumMember(Value = "PLAN")]
            Plan,
            [EnumMember(Value = "APPLY")]
            Apply,
            [EnumMember(Value = "DESTROY")]
            Destroy,
            [EnumMember(Value = "IMPORT_TF_STATE")]
            ImportTfState
        };

        /// <value>
        /// The type of job executing.
        /// </value>
        [JsonProperty(PropertyName = "operation")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<OperationEnum> Operation { get; set; }
        
        [JsonProperty(PropertyName = "jobOperationDetails")]
        public JobOperationDetails JobOperationDetails { get; set; }
        
        [JsonProperty(PropertyName = "applyJobPlanResolution")]
        public ApplyJobPlanResolution ApplyJobPlanResolution { get; set; }
        
        /// <value>
        /// Deprecated. Use the property `executionPlanJobId` in `jobOperationDetails` instead.
        /// The plan job [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) that was used (if this was an apply job and was not auto-approved).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "resolvedPlanJobId")]
        public string ResolvedPlanJobId { get; set; }
        
        /// <value>
        /// The date and time when the job was created.
        /// Format is defined by RFC3339.
        /// Example: 2020-01-25T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The date and time when the job stopped running, irrespective of whether the job ran successfully.
        /// Format is defined by RFC3339.
        /// Example: 2020-01-25T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeFinished")]
        public System.Nullable<System.DateTime> TimeFinished { get; set; }
                ///
        /// <value>
        /// Current state of the specified job.
        /// For more information about job lifecycle states in Resource Manager, see
        /// [Key Concepts](https://docs.cloud.oracle.com/iaas/Content/ResourceManager/Concepts/resourcemanager.htm#JobStates).
        /// 
        /// </value>
        ///
        public enum LifecycleStateEnum {
            [EnumMember(Value = "ACCEPTED")]
            Accepted,
            [EnumMember(Value = "IN_PROGRESS")]
            InProgress,
            [EnumMember(Value = "FAILED")]
            Failed,
            [EnumMember(Value = "SUCCEEDED")]
            Succeeded,
            [EnumMember(Value = "CANCELING")]
            Canceling,
            [EnumMember(Value = "CANCELED")]
            Canceled
        };

        /// <value>
        /// Current state of the specified job.
        /// For more information about job lifecycle states in Resource Manager, see
        /// [Key Concepts](https://docs.cloud.oracle.com/iaas/Content/ResourceManager/Concepts/resourcemanager.htm#JobStates).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        [JsonProperty(PropertyName = "failureDetails")]
        public FailureDetails FailureDetails { get; set; }
        
        /// <value>
        /// File path to the directory from which Terraform runs.
        /// If not specified, the root directory is used.
        /// This parameter is ignored for the `configSourceType` value of `COMPARTMENT_CONFIG_SOURCE`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "workingDirectory")]
        public string WorkingDirectory { get; set; }
        
        /// <value>
        /// Terraform variables associated with this resource.
        /// Maximum number of variables supported is 250.
        /// The maximum size of each variable, including both name and value, is 4096 bytes.
        /// Example: {&quot;CompartmentId&quot;: &quot;compartment-id-value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "variables")]
        public System.Collections.Generic.Dictionary<string, string> Variables { get; set; }
        
        [JsonProperty(PropertyName = "configSource")]
        public ConfigSourceRecord ConfigSource { get; set; }
        
        /// <value>
        /// Free-form tags associated with this resource. Each tag is a key-value pair with no predefined name, type, or namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
