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


namespace Oci.CoreService.Models
{
    
    public class CreateVcnDetails 
    {
        
        /// <value>
        /// Deprecated. Instead use 'cidrBlocks'. It is an error to set both cidrBlock and
        /// cidrBlocks.
        /// Example: 10.0.0.0/16
        /// </value>
        [JsonProperty(PropertyName = "cidrBlock")]
        public string CidrBlock { get; set; }
        
        /// <value>
        /// List of IPv4 CIDR blocks associated with the VCN. The CIDRs must maintain the following
        /// rules -
        /// <br/>
        /// a. The list of CIDRs provided are valid
        /// b. There is no overlap between different CIDRs
        /// c. The number of CIDRs should not exceed the max limit of CIDRs per VCN
        /// d. It is an error to set both cidrBlock and cidrBlocks.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "cidrBlocks")]
        public System.Collections.Generic.List<string> CidrBlocks { get; set; }
        
        /// <value>
        /// The OCID of the compartment to contain the VCN.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// If you enable IPv6 for the VCN (see `isIpv6Enabled`), you may optionally provide an IPv6
        /// /48 CIDR block from the supported ranges (see [IPv6 Addresses](https://docs.cloud.oracle.com/Content/Network/Concepts/ipv6.htm).
        /// The addresses in this block will be considered private and cannot be accessed
        /// from the internet. The documentation refers to this as a *custom CIDR* for the VCN.
        /// <br/>
        /// If you don't provide a custom CIDR for the VCN, Oracle assigns the VCN's IPv6 /48 CIDR block.
        /// <br/>
        /// Regardless of whether you or Oracle assigns the `ipv6CidrBlock`,
        /// Oracle *also* assigns the VCN an IPv6 CIDR block for the VCN's public IP address space
        /// (see the `ipv6PublicCidrBlock` of the {@link Vcn} object). If you do
        /// not assign a custom CIDR, Oracle uses the *same* Oracle-assigned CIDR for both the private
        /// IP address space (`ipv6CidrBlock` in the `Vcn` object) and the public IP addreses space
        /// (`ipv6PublicCidrBlock` in the `Vcn` object). This means that a given VNIC might use the same
        /// IPv6 IP address for both private and public (internet) communication. You control whether
        /// an IPv6 address can be used for internet communication by using the `isInternetAccessAllowed`
        /// attribute in the {@link Ipv6} object.
        /// <br/>
        /// For important details about IPv6 addressing in a VCN, see [IPv6 Addresses](https://docs.cloud.oracle.com/Content/Network/Concepts/ipv6.htm).
        /// <br/>
        /// Example: 2001:0db8:0123::/48
        /// </value>
        [JsonProperty(PropertyName = "ipv6CidrBlock")]
        public string Ipv6CidrBlock { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a
        /// namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// A user-friendly name. Does not have to be unique, and it's changeable. Avoid entering confidential information.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// A DNS label for the VCN, used in conjunction with the VNIC's hostname and
        /// subnet's DNS label to form a fully qualified domain name (FQDN) for each VNIC
        /// within this subnet (for example, `bminstance-1.subnet123.vcn1.oraclevcn.com`).
        /// Not required to be unique, but it's a best practice to set unique DNS labels
        /// for VCNs in your tenancy. Must be an alphanumeric string that begins with a letter.
        /// The value cannot be changed.
        /// <br/>
        /// You must set this value if you want instances to be able to use hostnames to
        /// resolve other instances in the VCN. Otherwise the Internet and VCN Resolver
        /// will not work.
        /// <br/>
        /// For more information, see
        /// [DNS in Your Virtual Cloud Network](https://docs.cloud.oracle.com/Content/Network/Concepts/dns.htm).
        /// <br/>
        /// Example: vcn1
        /// </value>
        [JsonProperty(PropertyName = "dnsLabel")]
        public string DnsLabel { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no
        /// predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Whether IPv6 is enabled for the VCN. Default is `false`. You cannot change this later.
        /// For important details about IPv6 addressing in a VCN, see [IPv6 Addresses](https://docs.cloud.oracle.com/Content/Network/Concepts/ipv6.htm).
        /// <br/>
        /// Example: true
        /// </value>
        [JsonProperty(PropertyName = "isIpv6Enabled")]
        public System.Nullable<bool> IsIpv6Enabled { get; set; }
        
    }
}
