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
    /// Backup Options
    /// To use any of the API operations, you must be authorized in an IAM policy. If you're not authorized, talk to an administrator. If you're an administrator who needs to write policies to give users access, see [Getting Started with Policies](https://docs.cloud.oracle.com/Content/Identity/Concepts/policygetstarted.htm).
    /// 
    /// </summary>
    public class DbBackupConfig 
    {
        
        /// <value>
        /// If set to true, configures automatic backups. If you previously used RMAN or dbcli to configure backups and then you switch to using the Console or the API for backups, a new backup configuration is created and associated with your database. This means that you can no longer rely on your previously configured unmanaged backups to work.
        /// </value>
        [JsonProperty(PropertyName = "autoBackupEnabled")]
        public System.Nullable<bool> AutoBackupEnabled { get; set; }

        /// <value>
        /// Number of days between the current and the earliest point of recoverability covered by automatic backups.
        /// This value applies to automatic backups only. After a new automatic backup has been created, Oracle removes old automatic backups that are created before the window.
        /// When the value is updated, it is applied to all existing automatic backups.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "recoveryWindowInDays")]
        public System.Nullable<int> RecoveryWindowInDays { get; set; }
        ///
        /// <value>
        /// Time window selected for initiating automatic backup for the database system. There are twelve available two-hour time windows. If no option is selected, a start time between 12:00 AM to 7:00 AM in the region of the database is automatically chosen. For example, if the user selects SLOT_TWO from the enum list, the automatic backup job will start in between 2:00 AM (inclusive) to 4:00 AM (exclusive).
        /// <br/>
        /// Example: SLOT_TWO
        /// </value>
        ///
        public enum AutoBackupWindowEnum {
            [EnumMember(Value = "SLOT_ONE")]
            SlotOne,
            [EnumMember(Value = "SLOT_TWO")]
            SlotTwo,
            [EnumMember(Value = "SLOT_THREE")]
            SlotThree,
            [EnumMember(Value = "SLOT_FOUR")]
            SlotFour,
            [EnumMember(Value = "SLOT_FIVE")]
            SlotFive,
            [EnumMember(Value = "SLOT_SIX")]
            SlotSix,
            [EnumMember(Value = "SLOT_SEVEN")]
            SlotSeven,
            [EnumMember(Value = "SLOT_EIGHT")]
            SlotEight,
            [EnumMember(Value = "SLOT_NINE")]
            SlotNine,
            [EnumMember(Value = "SLOT_TEN")]
            SlotTen,
            [EnumMember(Value = "SLOT_ELEVEN")]
            SlotEleven,
            [EnumMember(Value = "SLOT_TWELVE")]
            SlotTwelve
        };

        /// <value>
        /// Time window selected for initiating automatic backup for the database system. There are twelve available two-hour time windows. If no option is selected, a start time between 12:00 AM to 7:00 AM in the region of the database is automatically chosen. For example, if the user selects SLOT_TWO from the enum list, the automatic backup job will start in between 2:00 AM (inclusive) to 4:00 AM (exclusive).
        /// <br/>
        /// Example: SLOT_TWO
        /// </value>
        [JsonProperty(PropertyName = "autoBackupWindow")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<AutoBackupWindowEnum> AutoBackupWindow { get; set; }

        /// <value>
        /// Backup destination details.
        /// </value>
        [JsonProperty(PropertyName = "backupDestinationDetails")]
        public System.Collections.Generic.List<BackupDestinationDetails> BackupDestinationDetails { get; set; }
    }
}
