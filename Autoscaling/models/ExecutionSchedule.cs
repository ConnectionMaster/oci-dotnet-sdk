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
using Newtonsoft.Json.Linq;

namespace Oci.AutoscalingService.Models
{
    /// <summary>
    /// Specifies the execution schedule for a policy.
    /// 
    /// </summary>
    [JsonConverter(typeof(ExecutionScheduleModelConverter))]
    public class ExecutionSchedule 
    {
        
                ///
        /// <value>
        /// Specifies the time zone the schedule is in.
        /// </value>
        ///
        public enum TimezoneEnum {
            [EnumMember(Value = "UTC")]
            Utc
        };

        /// <value>
        /// Specifies the time zone the schedule is in.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Timezone is required.")]
        [JsonProperty(PropertyName = "timezone")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<TimezoneEnum> Timezone { get; set; }
        
    }

    public class ExecutionScheduleModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(ExecutionSchedule);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(ExecutionSchedule);
            var discriminator = jsonObject["type"].Value<string>();
            switch (discriminator)
            {
                case "cron":
                    obj = new CronExecutionSchedule();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
