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
using Newtonsoft.Json.Linq;

namespace Oci.FleetsoftwareupdateService.Models
{
    /// <summary>
    /// Exadata Fleet Update Cycle resource creation details.
    /// 
    /// </summary>
    [JsonConverter(typeof(CreateFsuCycleDetailsModelConverter))]
    public class CreateFsuCycleDetails 
    {
        
        /// <value>
        /// Exadata Fleet Update Cycle display name.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Compartment Identifier.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        
        /// <value>
        /// OCID identifier for the Collection ID the Exadata Fleet Update Cycle will be assigned to.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FsuCollectionId is required.")]
        [JsonProperty(PropertyName = "fsuCollectionId")]
        public string FsuCollectionId { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "GoalVersionDetails is required.")]
        [JsonProperty(PropertyName = "goalVersionDetails")]
        public FsuGoalVersionDetails GoalVersionDetails { get; set; }
        
        [JsonProperty(PropertyName = "batchingStrategy")]
        public CreateBatchingStrategyDetails BatchingStrategy { get; set; }
        
        [JsonProperty(PropertyName = "stageActionSchedule")]
        public CreateScheduleDetails StageActionSchedule { get; set; }
        
        [JsonProperty(PropertyName = "applyActionSchedule")]
        public CreateScheduleDetails ApplyActionSchedule { get; set; }
        
        [JsonProperty(PropertyName = "diagnosticsCollection")]
        public DiagnosticsCollectionDetails DiagnosticsCollection { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }

    public class CreateFsuCycleDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(CreateFsuCycleDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(CreateFsuCycleDetails);
            var discriminator = jsonObject["type"].Value<string>();
            switch (discriminator)
            {
                case "PATCH":
                    obj = new CreatePatchFsuCycle();
                    break;
                case "UPGRADE":
                    obj = new CreateUpgradeFsuCycle();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
