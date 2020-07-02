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
    
    public class CreateDatabaseFromAnotherDatabaseDetails 
    {
        
        /// <value>
        /// The database [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DatabaseId is required.")]
        [JsonProperty(PropertyName = "databaseId")]
        public string DatabaseId { get; set; }

        /// <value>
        /// The password to open the TDE wallet.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BackupTDEPassword is required.")]
        [JsonProperty(PropertyName = "backupTDEPassword")]
        public string BackupTDEPassword { get; set; }

        /// <value>
        /// A strong password for SYS, SYSTEM, PDB Admin and TDE Wallet. The password must be at least nine characters and contain at least two uppercase, two lowercase, two numbers, and two special characters. The special characters must be _, \\#, or -.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AdminPassword is required.")]
        [JsonProperty(PropertyName = "adminPassword")]
        public string AdminPassword { get; set; }

        /// <value>
        /// The `DB_UNIQUE_NAME` of the Oracle Database being backed up.
        /// </value>
        [JsonProperty(PropertyName = "dbUniqueName")]
        public string DbUniqueName { get; set; }

        /// <value>
        /// The display name of the database to be created from the backup. It must begin with an alphabetic character and can contain a maximum of eight alphanumeric characters. Special characters are not permitted.
        /// </value>
        [JsonProperty(PropertyName = "dbName")]
        public string DbName { get; set; }

        /// <value>
        /// The point in time of the original database from which the new database is created. If not specifed, the latest backup is used to create the database.
        /// </value>
        [JsonProperty(PropertyName = "timeStampForPointInTimeRecovery")]
        public System.Nullable<System.DateTime> TimeStampForPointInTimeRecovery { get; set; }
    }
}
