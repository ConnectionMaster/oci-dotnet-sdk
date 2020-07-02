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


namespace Oci.ObjectstorageService.Models
{
    /// <summary>
    /// The collection of lifecycle policy rules that together form the object lifecycle policy of a given bucket.
    /// 
    /// </summary>
    public class ObjectLifecyclePolicy 
    {
        
        /// <value>
        /// The date and time the object lifecycle policy was created, as described in
        /// [RFC 3339](https://tools.ietf.org/html/rfc3339).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }

        /// <value>
        /// The live lifecycle policy on the bucket.
        /// <br/>
        /// For an example of this value, see the
        /// [PutObjectLifecyclePolicy API documentation](https://docs.cloud.oracle.com/iaas/api/#/en/objectstorage/20160918/ObjectLifecyclePolicy/PutObjectLifecyclePolicy).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "items")]
        public System.Collections.Generic.List<ObjectLifecycleRule> Items { get; set; }
    }
}
