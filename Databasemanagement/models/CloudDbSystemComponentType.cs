/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.DatabasemanagementService.Models
{
  /// <summary>
  /// The cloud DB system component type.
  /// </summary>
  public enum CloudDbSystemComponentType {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "ASM")]
      Asm,
      [EnumMember(Value = "ASM_INSTANCE")]
      AsmInstance,
      [EnumMember(Value = "CLUSTER")]
      Cluster,
      [EnumMember(Value = "CLUSTER_INSTANCE")]
      ClusterInstance,
      [EnumMember(Value = "DATABASE")]
      Database,
      [EnumMember(Value = "DATABASE_INSTANCE")]
      DatabaseInstance,
      [EnumMember(Value = "DATABASE_HOME")]
      DatabaseHome,
      [EnumMember(Value = "DATABASE_NODE")]
      DatabaseNode,
      [EnumMember(Value = "DBSYSTEM")]
      Dbsystem,
      [EnumMember(Value = "LISTENER")]
      Listener,
      [EnumMember(Value = "PLUGGABLE_DATABASE")]
      PluggableDatabase
  }
}
