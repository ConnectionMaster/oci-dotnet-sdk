/*
 * Copyright (c) 2020, 2026, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using Xunit;

namespace Oci.Common.Auth
{
    [ExcludeFromCodeCoverage]
    public class InstancePrincipalsAuthenticationDetailsProviderTests : BaseTest
    {
        private const string MetadataBaseUrlEnvVar = "OCI_METADATA_BASE_URL";

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void MetadataServiceBaseUrlDefaultsToImdsV2Endpoint()
        {
            WithMetadataBaseUrl(null, () =>
            {
                Assert.Equal("http://169.254.169.254/opc/v2/", GetMetadataServiceBaseUrl());
            });
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void MetadataServiceBaseUrlIgnoresWhitespaceOverride()
        {
            WithMetadataBaseUrl("   ", () =>
            {
                Assert.Equal("http://169.254.169.254/opc/v2/", GetMetadataServiceBaseUrl());
            });
        }

        [Theory]
        [InlineData("http://custom-metadata/opc/v2", "http://custom-metadata/opc/v2/")]
        [InlineData("  http://custom-metadata/opc/v2/  ", "http://custom-metadata/opc/v2/")]
        [InlineData("http://[fd00:c1::a9fe:a9fe]/opc/v2", "http://[fd00:c1::a9fe:a9fe]/opc/v2/")]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void MetadataServiceBaseUrlHonorsEnvironmentOverride(string envValue, string expected)
        {
            WithMetadataBaseUrl(envValue, () =>
            {
                Assert.Equal(expected, GetMetadataServiceBaseUrl());
            });
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void InstancePrincipalsProviderExposesFederationEndpointConstructor()
        {
            Assert.NotNull(typeof(InstancePrincipalsAuthenticationDetailsProvider).GetConstructor(new[] { typeof(string) }));
        }

        [Theory]
        [InlineData(null, null)]
        [InlineData("", null)]
        [InlineData("   ", null)]
        [InlineData("https://auth.us-ashburn-1.oraclecloud.com", "https://auth.us-ashburn-1.oraclecloud.com")]
        [InlineData(" https://auth.us-ashburn-1.oraclecloud.com/ ", "https://auth.us-ashburn-1.oraclecloud.com")]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void FederationEndpointOverrideIsNormalized(string endpoint, string expected)
        {
            Assert.Equal(expected, NormalizeFederationEndpoint(endpoint));
        }

        private static string GetMetadataServiceBaseUrl()
        {
            var method = typeof(AbstractRequestingAuthenticationDetailsProvider).GetMethod(
                "GetMetadataServiceBaseUrl",
                BindingFlags.NonPublic | BindingFlags.Static);
            return (string)method.Invoke(null, null);
        }

        private static string NormalizeFederationEndpoint(string endpoint)
        {
            var method = typeof(AbstractRequestingAuthenticationDetailsProvider).GetMethod(
                "NormalizeFederationEndpoint",
                BindingFlags.NonPublic | BindingFlags.Static);
            return (string)method.Invoke(null, new object[] { endpoint });
        }

        private static void WithMetadataBaseUrl(string value, Action action)
        {
            var originalValue = Environment.GetEnvironmentVariable(MetadataBaseUrlEnvVar);
            try
            {
                Environment.SetEnvironmentVariable(MetadataBaseUrlEnvVar, value);
                action();
            }
            finally
            {
                Environment.SetEnvironmentVariable(MetadataBaseUrlEnvVar, originalValue);
            }
        }
    }
}
