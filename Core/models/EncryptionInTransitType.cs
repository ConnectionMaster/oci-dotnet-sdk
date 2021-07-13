/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.CoreService.Models
{
  /// <summary>
  /// The attachment type of a BM volume.
    /// If the attachment is in-transit encryption, the field is BM_ENCRYPTION_IN_TRANSIT.
    /// Otherwise, the field is None.
    /// 
  /// </summary>
  public enum EncryptionInTransitType {
      [EnumMember(Value = "NONE")]
      None,
      [EnumMember(Value = "BM_ENCRYPTION_IN_TRANSIT")]
      BmEncryptionInTransit
  }
}
