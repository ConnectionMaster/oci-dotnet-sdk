/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.OsmanagementService.Models
{
  /// <summary>
  /// Possible CPU architecture types
  /// </summary>
  public enum ArchTypes {
      [EnumMember(Value = "IA_32")]
      Ia32,
      [EnumMember(Value = "X86_64")]
      X8664,
      [EnumMember(Value = "AARCH64")]
      Aarch64,
      [EnumMember(Value = "SPARC")]
      Sparc,
      [EnumMember(Value = "AMD64_DEBIAN")]
      Amd64Debian
  }
}
