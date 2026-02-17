/*
 * Copyright (c) 2020, 2026, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using Oci.Common.Utils;
using Xunit;
using System;

namespace Oci.Common.Src.Utils;

public class EndpointTemplateForOptionsUtilsTest
{

    [Fact]
    public void TestIsDualStackEnabledEnvVarTrue()
    {
        Environment.SetEnvironmentVariable("OCI_DUAL_STACK_ENDPOINT_ENABLED", "true");
        var service = new Oci.Common.Service { ServiceUsesDualStackByDefault = false };
        Assert.True(EndpointTemplateForOptionsUtils.IsDualStackEnabledForClientDefault(service));
        Environment.SetEnvironmentVariable("OCI_DUAL_STACK_ENDPOINT_ENABLED", null);
    }

    [Fact]
    public void TestIsDualStackEnabledEnvVarFalse()
    {
        Environment.SetEnvironmentVariable("OCI_DUAL_STACK_ENDPOINT_ENABLED", "false");
        var service = new Oci.Common.Service { ServiceUsesDualStackByDefault = true };
        Assert.False(EndpointTemplateForOptionsUtils.IsDualStackEnabledForClientDefault(service));
        Environment.SetEnvironmentVariable("OCI_DUAL_STACK_ENDPOINT_ENABLED", null);
    }

    [Fact]
    public void TestIsDualStackEnabledEnvVarNotSetServiceDefaultTrue()
    {
        var service = new Oci.Common.Service { ServiceUsesDualStackByDefault = true };
        Assert.True(EndpointTemplateForOptionsUtils.IsDualStackEnabledForClientDefault(service));
    }

    [Fact]
    public void TestIsDualStackEnabledEnvVarNotSetServiceDefaultFalse()
    {
        var service = new Oci.Common.Service { ServiceUsesDualStackByDefault = false };
        Assert.False(EndpointTemplateForOptionsUtils.IsDualStackEnabledForClientDefault(service));
    }
}
