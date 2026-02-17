/*
 * Copyright (c) 2020, 2026, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Oci.Common.Internal;
using Org.BouncyCastle.Math;
using Xunit;

namespace Oci.Common
{
    [ExcludeFromCodeCoverage]
    public class EndpointBuilderTest : BaseTest
    {
        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void TestCreateEndpointWithRealmSpecificEndpointTemplateInUse()
        {
            Environment.SetEnvironmentVariable("OCI_REALM_SPECIFIC_SERVICE_ENDPOINT_TEMPLATE_ENABLED", "true");
            Service testService = new Service
            {
                ServiceName = "EndpointBuilderTest1",
                ServiceEndpointPrefix = "foobar",
                ServiceEndpointTemplate = "http://{serviceEndpointPrefix}.{region}.{secondLevelDomain}",
                EndpointServiceName = "endpointbuildertest"
            };
            testService.AddServiceEndpointTemplateForRealm("oc1", "http://{fooParameter+Dot}{serviceEndpointPrefix}.{region}.{secondLevelDomain}");
            testService.AddServiceEndpointTemplateForRealm("oc3", "http://{barParameter+Dot}{serviceEndpointPrefix}.{region}.{secondLevelDomain}");
            Assert.Equal("http://{fooParameter+Dot}foobar.us-phoenix-1.oraclecloud.com", EndpointBuilder.CreateEndpoint(testService, Region.US_PHOENIX_1));
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void TestCreateEndpointWithRealmSpecificEndpointWithTemplateMissing()
        {
            Environment.SetEnvironmentVariable("OCI_REALM_SPECIFIC_SERVICE_ENDPOINT_TEMPLATE_ENABLED", "true");
            Service testService = new Service
            {
                ServiceName = "EndpointBuilderTest2",
                ServiceEndpointPrefix = "foobar",
                ServiceEndpointTemplate = "http://{serviceEndpointPrefix}.{region}.{secondLevelDomain}",
                EndpointServiceName = "endpointbuildertest"
            };
            Assert.Equal("http://foobar.us-phoenix-1.oraclecloud.com", EndpointBuilder.CreateEndpoint(testService, Region.US_PHOENIX_1));
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void TestCreateEndpointWithRealmSpecificEndpointDisabledWithTemplateInUse()
        {
            Environment.SetEnvironmentVariable("OCI_REALM_SPECIFIC_SERVICE_ENDPOINT_TEMPLATE_ENABLED", "");
            Service testService = new Service
            {
                ServiceName = "EndpointBuilderTest2",
                ServiceEndpointPrefix = "foobar",
                ServiceEndpointTemplate = "http://{serviceEndpointPrefix}.{region}.{secondLevelDomain}",
                EndpointServiceName = "endpointbuildertest"
            };
            testService.AddServiceEndpointTemplateForRealm("oc1", "http://{fooParameter+Dot}{serviceEndpointPrefix}.{region}.{secondLevelDomain}");
            Assert.Equal("http://foobar.us-phoenix-1.oraclecloud.com", EndpointBuilder.CreateEndpoint(testService, Region.US_PHOENIX_1));
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void TestUpdateEndpointTemplateWhenOCIEndpointHasMultipleDualStackValidOption()
        {
            Environment.SetEnvironmentVariable("OCI_REALM_SPECIFIC_SERVICE_ENDPOINT_TEMPLATE_ENABLED", "true");

            Service testService = new Service
            {
                ServiceName = "EndpointBuilderTest2",
                ServiceEndpointPrefix = "foobar",
                ServiceEndpointTemplate = "http://{serviceEndpointPrefix}.{region}.{secondLevelDomain}",
                EndpointServiceName = "endpointbuildertest"
            };

            testService.AddServiceEndpointTemplateForRealm("oc1",
                "http://{dualStack?ds.oci.:}{serviceEndpointPrefix}.{region}.{dualStack?oci.:}{secondLevelDomain}");
            Assert.Equal("http://{dualStack?ds.oci.:}foobar.us-phoenix-1.{dualStack?oci.:}oraclecloud.com",
                EndpointBuilder.CreateEndpoint(testService, Region.US_PHOENIX_1));

            Dictionary<string, bool> optionsMap = new Dictionary<string, bool>();
            optionsMap["dualStack"] = true;
            String endpoint = EndpointBuilder.GetEndpointWithPopulatedServiceParams(EndpointBuilder.CreateEndpoint(testService, Region.US_PHOENIX_1), new Dictionary<string, object>(), optionsMap);
            Assert.Equal("http://ds.oci.foobar.us-phoenix-1.oci.oraclecloud.com", endpoint);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void TestUpdateEndpointTemplateWhenOCIEndpointHasMultipleValuesValidOption()
        {
            Environment.SetEnvironmentVariable("OCI_REALM_SPECIFIC_SERVICE_ENDPOINT_TEMPLATE_ENABLED", "true");

            Service testService = new Service
            {
                ServiceName = "EndpointBuilderTest2",
                ServiceEndpointPrefix = "foobar",
                ServiceEndpointTemplate = "http://{serviceEndpointPrefix}.{region}.{secondLevelDomain}",
                EndpointServiceName = "endpointbuildertest"
            };

            testService.AddServiceEndpointTemplateForRealm("oc1",
                "http://{dualStack?ds.oci.:}{serviceEndpointPrefix}.{region}.{secondLevelDomain}");
            Assert.Equal("http://{dualStack?ds.oci.:}foobar.us-phoenix-1.oraclecloud.com",
                EndpointBuilder.CreateEndpoint(testService, Region.US_PHOENIX_1));

            Dictionary<string, bool> optionsMap = new Dictionary<string, bool>();
            optionsMap["dualStack"] = true;
            String endpoint = EndpointBuilder.GetEndpointWithPopulatedServiceParams(EndpointBuilder.CreateEndpoint(testService, Region.US_PHOENIX_1), new Dictionary<string, object>(), optionsMap);
            Assert.Equal("http://ds.oci.foobar.us-phoenix-1.oraclecloud.com", endpoint);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void TestUpdateEndpointTemplateWhenEndpointHasValidOption()
        {
            Environment.SetEnvironmentVariable("OCI_REALM_SPECIFIC_SERVICE_ENDPOINT_TEMPLATE_ENABLED", "true");

            Service testService = new Service
            {
                ServiceName = "EndpointBuilderTest2",
                ServiceEndpointPrefix = "foobar",
                ServiceEndpointTemplate = "http://{serviceEndpointPrefix}.{region}.{secondLevelDomain}",
                EndpointServiceName = "endpointbuildertest"
            };

            testService.AddServiceEndpointTemplateForRealm("oc1",
                "http://{fooParameter+Dot}{dualStack?ds.:}{serviceEndpointPrefix}.{region}.{secondLevelDomain}");
            Assert.Equal("http://{fooParameter+Dot}{dualStack?ds.:}foobar.us-phoenix-1.oraclecloud.com",
                EndpointBuilder.CreateEndpoint(testService, Region.US_PHOENIX_1));

            Dictionary<string, bool> optionsMap = new Dictionary<string, bool>();
            optionsMap["dualStack"] = true;
            String endpoint = EndpointBuilder.GetEndpointWithPopulatedServiceParams(EndpointBuilder.CreateEndpoint(testService, Region.US_PHOENIX_1), new Dictionary<string, object>(), optionsMap);
            Assert.Equal("http://ds.foobar.us-phoenix-1.oraclecloud.com", endpoint);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void TestUpdateEndpointTemplateWhenEndpointHasInvalidOption()
        {
            Environment.SetEnvironmentVariable("OCI_REALM_SPECIFIC_SERVICE_ENDPOINT_TEMPLATE_ENABLED", "true");

            Service testService = new Service
            {
                ServiceName = "EndpointBuilderTest2",
                ServiceEndpointPrefix = "foobar",
                ServiceEndpointTemplate = "http://{serviceEndpointPrefix}.{region}.{secondLevelDomain}",
                EndpointServiceName = "endpointbuildertest"
            };

            testService.AddServiceEndpointTemplateForRealm("oc1",
                "http://{fooParameter+Dot}{singleStack?ss.:}{serviceEndpointPrefix}.{region}.{secondLevelDomain}");
            Assert.Equal("http://{fooParameter+Dot}{singleStack?ss.:}foobar.us-phoenix-1.oraclecloud.com",
                EndpointBuilder.CreateEndpoint(testService, Region.US_PHOENIX_1));

            Dictionary<string, bool> optionsMap = new Dictionary<string, bool>();
            optionsMap["dualStack"] = true;
            String endpoint = EndpointBuilder.GetEndpointWithPopulatedServiceParams(EndpointBuilder.CreateEndpoint(testService, Region.US_PHOENIX_1), new Dictionary<string, object>(), optionsMap);
            Assert.Equal("http://foobar.us-phoenix-1.oraclecloud.com", endpoint);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void TestUpdateEndpointTemplateForOptionsWhenDualStackOptionFalse()
        {
            Environment.SetEnvironmentVariable("OCI_REALM_SPECIFIC_SERVICE_ENDPOINT_TEMPLATE_ENABLED", "true");

            Service testService = new Service
            {
                ServiceName = "EndpointBuilderTest2",
                ServiceEndpointPrefix = "foobar",
                ServiceEndpointTemplate = "http://{serviceEndpointPrefix}.{region}.{secondLevelDomain}",
                EndpointServiceName = "endpointbuildertest"
            };

            testService.AddServiceEndpointTemplateForRealm("oc1",
                "http://{fooParameter+Dot}{dualStack?ds.:}{serviceEndpointPrefix}.{region}.{secondLevelDomain}");
            Assert.Equal("http://{fooParameter+Dot}{dualStack?ds.:}foobar.us-phoenix-1.oraclecloud.com",
                EndpointBuilder.CreateEndpoint(testService, Region.US_PHOENIX_1));

            Dictionary<string, bool> optionsMap = new Dictionary<string, bool>();
            optionsMap["dualStack"] = false;
            String endpoint = EndpointBuilder.GetEndpointWithPopulatedServiceParams(EndpointBuilder.CreateEndpoint(testService, Region.US_PHOENIX_1), new Dictionary<string, object>(), optionsMap);
            Assert.Equal("http://foobar.us-phoenix-1.oraclecloud.com", endpoint);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void TestUpdateEndpointTemplateForOptionsWhenDualStackOptionDefaultTemplate()
        {
            Environment.SetEnvironmentVariable("OCI_REALM_SPECIFIC_SERVICE_ENDPOINT_TEMPLATE_ENABLED", "true");

            Service testService = new Service
            {
                ServiceName = "EndpointBuilderTest2",
                ServiceEndpointPrefix = "foobar",
                ServiceEndpointTemplate = "http://{fooParameter+Dot}{dualStack?ds.:}{serviceEndpointPrefix}.{region}.{secondLevelDomain}",
                EndpointServiceName = "endpointbuildertest"
            };

            Assert.Equal("http://{fooParameter+Dot}{dualStack?ds.:}foobar.us-phoenix-1.oraclecloud.com",
                EndpointBuilder.CreateEndpoint(testService, Region.US_PHOENIX_1));

            Dictionary<string, bool> optionsMap = new Dictionary<string, bool>();
            optionsMap["dualStack"] = true;
            String endpoint = EndpointBuilder.GetEndpointWithPopulatedServiceParams(EndpointBuilder.CreateEndpoint(testService, Region.US_PHOENIX_1), new Dictionary<string, object>(), optionsMap);
            Assert.Equal("http://ds.foobar.us-phoenix-1.oraclecloud.com", endpoint);
        }
    }
}
