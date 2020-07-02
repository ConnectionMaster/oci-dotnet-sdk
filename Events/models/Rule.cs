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


namespace Oci.EventsService.Models
{
    /// <summary>
    /// The configuration details of an Events rule. For more information, see
    /// [Managing Rules for Events](https://docs.cloud.oracle.com/iaas/Content/Events/Task/managingrules.htm).
    /// 
    /// </summary>
    public class Rule 
    {
        
        /// <value>
        /// A string that describes the rule. It does not have to be unique, and you can change it. Avoid entering
        /// confidential information.
        /// <br/>
        /// Example: &quot;This rule sends a notification upon completion of DbaaS backup.&quot;
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <value>
        /// A string that describes the details of the rule. It does not have to be unique, and you can change it. Avoid entering
        /// confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        ///
        /// <value>
        /// The current state of the rule.
        /// 
        /// </value>
        ///
        public enum LifecycleStateEnum {
            [EnumMember(Value = "CREATING")]
            Creating,
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "INACTIVE")]
            Inactive,
            [EnumMember(Value = "UPDATING")]
            Updating,
            [EnumMember(Value = "DELETING")]
            Deleting,
            [EnumMember(Value = "DELETED")]
            Deleted,
            [EnumMember(Value = "FAILED")]
            Failed
        };

        /// <value>
        /// The current state of the rule.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }

        /// <value>
        /// A filter that specifies the event that will trigger actions associated with this rule. A few 
        /// important things to remember about filters:
        /// <br/>
        /// * Fields not mentioned in the condition are ignored. You can create a valid filter that matches
        /// all events with two curly brackets: `{}` 
        /// <br/>
        ///   For more examples, see 
        /// [Matching Events with Filters](https://docs.cloud.oracle.com/iaas/Content/Events/Concepts/filterevents.htm).       
        /// * For a condition with fields to match an event, the event must contain all the field names 
        /// listed in the condition. Field names must appear in the condition with the same nesting 
        /// structure used in the event. 
        /// <br/>
        ///   For a list of reference events, see 
        /// [Services that Produce Events](https://docs.cloud.oracle.com/iaas/Content/Events/Reference/eventsproducers.htm).       
        /// * Rules apply to events in the compartment in which you create them and any child compartments. 
        /// This means that a condition specified by a rule only matches events emitted from resources in 
        /// the compartment or any of its child compartments. 
        /// * Wildcard matching is supported with the asterisk (*) character. 
        /// <br/>
        ///   For examples of wildcard matching, see 
        /// [Matching Events with Filters](https://docs.cloud.oracle.com/iaas/Content/Events/Concepts/filterevents.htm)
        /// <br/>
        /// Example: \\&quot;eventType\\&quot;: \\&quot;com.oraclecloud.databaseservice.autonomous.database.backup.end\\&quot;
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Condition is required.")]
        [JsonProperty(PropertyName = "condition")]
        public string Condition { get; set; }

        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment to which this rule belongs.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }

        /// <value>
        /// Whether or not this rule is currently enabled.
        /// <br/>
        /// Example: true
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsEnabled is required.")]
        [JsonProperty(PropertyName = "isEnabled")]
        public System.Nullable<bool> IsEnabled { get; set; }

        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace. Exists for cross-compatibility only.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }

        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }

        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Actions is required.")]
        [JsonProperty(PropertyName = "actions")]
        public ActionList Actions { get; set; }

        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of this rule.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <value>
        /// The time this rule was created, expressed in [RFC 3339](https://tools.ietf.org/html/rfc3339)
        /// timestamp format.
        /// <br/>
        /// Example: 2018-09-12T22:47:12.613Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }

        /// <value>
        /// A message generated by the Events service about the current state of this rule.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "lifecycleMessage")]
        public string LifecycleMessage { get; set; }
    }
}
