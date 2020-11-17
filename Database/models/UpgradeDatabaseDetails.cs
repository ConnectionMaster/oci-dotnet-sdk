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


namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// Details for upgrading a database to a specific db version.
    /// **Warning:** Oracle recommends that you avoid using any confidential information when you supply string values using the API.
    /// 
    /// </summary>
    public class UpgradeDatabaseDetails 
    {
                ///
        /// <value>
        /// action for upgrading database.
        /// </value>
        ///
        public enum ActionEnum {
            [EnumMember(Value = "PRECHECK")]
            Precheck,
            [EnumMember(Value = "UPGRADE")]
            Upgrade,
            [EnumMember(Value = "ROLLBACK")]
            Rollback
        };

        /// <value>
        /// action for upgrading database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Action is required.")]
        [JsonProperty(PropertyName = "action")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ActionEnum> Action { get; set; }
        
        [JsonProperty(PropertyName = "databaseUpgradeSourceDetails")]
        public DatabaseUpgradeSourceBase DatabaseUpgradeSourceDetails { get; set; }
        
    }
}
