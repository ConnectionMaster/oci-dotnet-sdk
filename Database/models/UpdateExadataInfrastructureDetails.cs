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
    /// Updates the Exadata infrastructure.
    /// 
    /// </summary>
    public class UpdateExadataInfrastructureDetails 
    {
        
        /// <value>
        /// The IP address for the first control plane server.
        /// </value>
        [JsonProperty(PropertyName = "cloudControlPlaneServer1")]
        public string CloudControlPlaneServer1 { get; set; }

        /// <value>
        /// The IP address for the second control plane server.
        /// </value>
        [JsonProperty(PropertyName = "cloudControlPlaneServer2")]
        public string CloudControlPlaneServer2 { get; set; }

        /// <value>
        /// The netmask for the control plane network.
        /// </value>
        [JsonProperty(PropertyName = "netmask")]
        public string Netmask { get; set; }

        /// <value>
        /// The gateway for the control plane network.
        /// </value>
        [JsonProperty(PropertyName = "gateway")]
        public string Gateway { get; set; }

        /// <value>
        /// The CIDR block for the Exadata administration network.
        /// </value>
        [JsonProperty(PropertyName = "adminNetworkCIDR")]
        public string AdminNetworkCIDR { get; set; }

        /// <value>
        /// The CIDR block for the Exadata InfiniBand interconnect.
        /// </value>
        [JsonProperty(PropertyName = "infiniBandNetworkCIDR")]
        public string InfiniBandNetworkCIDR { get; set; }

        /// <value>
        /// The corporate network proxy for access to the control plane network.
        /// </value>
        [JsonProperty(PropertyName = "corporateProxy")]
        public string CorporateProxy { get; set; }

        /// <value>
        /// The list of DNS server IP addresses. Maximum of 3 allowed.
        /// </value>
        [JsonProperty(PropertyName = "dnsServer")]
        public System.Collections.Generic.List<string> DnsServer { get; set; }

        /// <value>
        /// The list of NTP server IP addresses. Maximum of 3 allowed.
        /// </value>
        [JsonProperty(PropertyName = "ntpServer")]
        public System.Collections.Generic.List<string> NtpServer { get; set; }

        /// <value>
        /// The time zone of the Exadata infrastructure. For details, see [Exadata Infrastructure Time Zones](https://docs.cloud.oracle.com/Content/Database/References/timezones.htm).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeZone")]
        public string TimeZone { get; set; }

        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }

        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
    }
}
