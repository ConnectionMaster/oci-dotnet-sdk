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


namespace Oci.CoreService.Models
{
    /// <summary>
    /// A mapping between a destination IP address range and a virtual device to route matching
    /// packets to (a target).
    /// 
    /// </summary>
    public class RouteRule 
    {
        
        /// <value>
        /// Deprecated. Instead use `destination` and `destinationType`. Requests that include both
        /// `cidrBlock` and `destination` will be rejected.
        /// <br/>
        /// A destination IP address range in CIDR notation. Matching packets will
        /// be routed to the indicated network entity (the target).
        /// <br/>
        /// Cannot be an IPv6 CIDR.
        /// <br/>
        /// Example: 0.0.0.0/0
        /// </value>
        [JsonProperty(PropertyName = "cidrBlock")]
        public string CidrBlock { get; set; }

        /// <value>
        /// Conceptually, this is the range of IP addresses used for matching when routing
        /// traffic. Required if you provide a `destinationType`.
        /// <br/>
        /// Allowed values:
        /// <br/>
        ///   * IP address range in CIDR notation. Can be an IPv4 or IPv6 CIDR. For Example: 192.168.1.0/24  or 2001:0db8:0123:45::/56. If you set this to an IPv6 CIDR, the route rule's target  can only be a DRG or internet gateway. Note that IPv6 addressing is currently supported  only in certain regions. See [IPv6 Addresses](https://docs.cloud.oracle.com/Content/Network/Concepts/ipv6.htm).  * The cidrBlock value for a {@link Service}, if you're    setting up a route rule for traffic destined for a particular Service through    a service gateway. For
        /// </value>
        [JsonProperty(PropertyName = "destination")]
        public string Destination { get; set; }
        ///
        /// <value>
        /// Type of destination for the rule. Required if you provide a `destination`.
        /// <br/>
        ///   * `CIDR_BLOCK`: If the rule's `destination` is an IP address range in CIDR notation.
        /// <br/>
        ///   * `SERVICE_CIDR_BLOCK`: If the rule's `destination` is the `cidrBlock` value for a
        ///     {@link Service} (the rule is for traffic destined for a
        ///     particular `Service` through a service gateway).
        /// 
        /// </value>
        ///
        public enum DestinationTypeEnum {
            [EnumMember(Value = "CIDR_BLOCK")]
            CidrBlock,
            [EnumMember(Value = "SERVICE_CIDR_BLOCK")]
            ServiceCidrBlock
        };

        /// <value>
        /// Type of destination for the rule. Required if you provide a `destination`.
        /// <br/>
        ///   * `CIDR_BLOCK`: If the rule's `destination` is an IP address range in CIDR notation.
        /// <br/>
        ///   * `SERVICE_CIDR_BLOCK`: If the rule's `destination` is the `cidrBlock` value for a
        ///     {@link Service} (the rule is for traffic destined for a
        ///     particular `Service` through a service gateway).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "destinationType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DestinationTypeEnum> DestinationType { get; set; }

        /// <value>
        /// The OCID for the route rule's target. For information about the type of
        /// targets you can specify, see
        /// [Route Tables](https://docs.cloud.oracle.com/Content/Network/Tasks/managingroutetables.htm).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NetworkEntityId is required.")]
        [JsonProperty(PropertyName = "networkEntityId")]
        public string NetworkEntityId { get; set; }

        /// <value>
        /// An optional description of your choice for the rule.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }
}
