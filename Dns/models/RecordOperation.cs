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


namespace Oci.DnsService.Models
{
    /// <summary>
    /// An extension of the existing record resource, describing either a
    /// precondition, an add, or a remove. Preconditions check all fields,
    /// including read-only data like `recordHash` and `rrsetVersion`.
    /// 
    /// </summary>
    public class RecordOperation 
    {
        
        /// <value>
        /// The fully qualified domain name where the record can be located.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "domain")]
        public string Domain { get; set; }
        
        /// <value>
        /// A unique identifier for the record within its zone.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "recordHash")]
        public string RecordHash { get; set; }
        
        /// <value>
        /// A Boolean flag indicating whether or not parts of the record
        /// are unable to be explicitly managed.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isProtected")]
        public System.Nullable<bool> IsProtected { get; set; }
        
        /// <value>
        /// The record's data, as whitespace-delimited tokens in
        /// type-specific presentation format. All RDATA is normalized and the
        /// returned presentation of your RDATA may differ from its initial input.
        /// For more information about RDATA, see [Supported DNS Resource Record Types](https://docs.cloud.oracle.com/iaas/Content/DNS/Reference/supporteddnsresource.htm)
        /// 
        /// </value>
        [JsonProperty(PropertyName = "rdata")]
        public string Rdata { get; set; }
        
        /// <value>
        /// The latest version of the record's zone in which its RRSet differs
        /// from the preceding version.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "rrsetVersion")]
        public string RrsetVersion { get; set; }
        
        /// <value>
        /// The type of DNS record, such as A or CNAME. For more information, see [Resource Record (RR) TYPEs](https://www.iana.org/assignments/dns-parameters/dns-parameters.xhtml#dns-parameters-4).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "rtype")]
        public string Rtype { get; set; }
        
        /// <value>
        /// The Time To Live for the record, in seconds.
        /// </value>
        [JsonProperty(PropertyName = "ttl")]
        public System.Nullable<int> Ttl { get; set; }
                ///
        /// <value>
        /// A description of how a record relates to a PATCH operation.
        /// <br/>
        /// 
        /// - `REQUIRE` indicates a precondition that record data **must** already exist.
        /// - `PROHIBIT` indicates a precondition that record data **must not** already exist.
        /// - `ADD` indicates that record data **must** exist after successful application.
        /// - `REMOVE` indicates that record data **must not** exist after successful application.
        /// <br/>
        /// 
        ///   **Note:** `ADD` and `REMOVE` operations can succeed even if
        ///   they require no changes when applied, such as when the described
        ///   records are already present or absent.
        /// <br/>
        /// 
        ///   **Note:** `ADD` and `REMOVE` operations can describe changes for
        ///   more than one record.
        /// <br/>
        /// 
        ///   **Example: ** { &quot;domain&quot;: &quot;www.example.com&quot;, &quot;rtype&quot;: &quot;AAAA&quot;, &quot;ttl&quot;: 60 }  specifies a new TTL for every record in the www.example.com AAAA RRSet.
        /// </value>
        ///
        public enum OperationEnum {
            [EnumMember(Value = "REQUIRE")]
            Require,
            [EnumMember(Value = "PROHIBIT")]
            Prohibit,
            [EnumMember(Value = "ADD")]
            Add,
            [EnumMember(Value = "REMOVE")]
            Remove
        };

        /// <value>
        /// A description of how a record relates to a PATCH operation.
        /// <br/>
        /// 
        /// - `REQUIRE` indicates a precondition that record data **must** already exist.
        /// - `PROHIBIT` indicates a precondition that record data **must not** already exist.
        /// - `ADD` indicates that record data **must** exist after successful application.
        /// - `REMOVE` indicates that record data **must not** exist after successful application.
        /// <br/>
        /// 
        ///   **Note:** `ADD` and `REMOVE` operations can succeed even if
        ///   they require no changes when applied, such as when the described
        ///   records are already present or absent.
        /// <br/>
        /// 
        ///   **Note:** `ADD` and `REMOVE` operations can describe changes for
        ///   more than one record.
        /// <br/>
        /// 
        ///   **Example: ** { &quot;domain&quot;: &quot;www.example.com&quot;, &quot;rtype&quot;: &quot;AAAA&quot;, &quot;ttl&quot;: 60 }  specifies a new TTL for every record in the www.example.com AAAA RRSet.
        /// </value>
        [JsonProperty(PropertyName = "operation")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<OperationEnum> Operation { get; set; }
        
    }
}
