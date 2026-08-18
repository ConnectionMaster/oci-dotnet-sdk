/*
 * Copyright (c) 2020, 2026, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/upl. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using NLog;
using NLog.Config;
using NLog.Targets;
using Oci.Common.Http;
using Xunit;

namespace Oci.Common
{
    [ExcludeFromCodeCoverage]
    public class HeaderRedactorTests : BaseTest
    {
        private const string SensitiveValue = "secret-value";
        private static readonly object LoggerConfigurationLock = new object();

        [Theory]
        [InlineData("authorization")]
        [InlineData("proxy-authorization")]
        [InlineData("opc-obo-token")]
        [InlineData("x-api-key")]
        [InlineData("cookie")]
        [InlineData("set-cookie")]
        [InlineData("security-context")]
        [InlineData("password")]
        [InlineData("passphrase")]
        [InlineData("x-token")]
        [InlineData("x-token-custom")]
        [InlineData("x-authorization")]
        [InlineData("x-authorization-token")]
        [InlineData("x-key-secret")]
        [InlineData("access-token")]
        [InlineData("refresh-token")]
        [InlineData("id-token")]
        [InlineData("security-token")]
        [InlineData("session-token")]
        [InlineData("delegation-token")]
        [InlineData("private-key")]
        [InlineData("idcs-access-token")]
        [InlineData("Client_Secret")]
        [InlineData("service__private-key")]
        [InlineData("OPC_DELEGATION_TOKEN")]
        [InlineData("opc_delegation_token")]
        [InlineData("service_private_key")]
        [InlineData("client_secret")]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void ResponseDiagnosticsRedactSensitiveHeaders(string headerName)
        {
            var diagnostic = CaptureResponseDiagnostic(response => Assert.True(response.Headers.TryAddWithoutValidation(headerName, SensitiveValue)));

            Assert.Contains("REDACTED", diagnostic);
            Assert.DoesNotContain(SensitiveValue, diagnostic);
        }

        [Theory]
        [InlineData("x-key")]
        [InlineData("x-keyring-name")]
        [InlineData("x-tokenization")]
        [InlineData("tokenization-status")]
        [InlineData("private-key-id")]
        [InlineData("client-secret-version")]
        [InlineData("opc-request-id")]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void ResponseDiagnosticsRetainNonSensitiveHeaders(string headerName)
        {
            const string visibleValue = "visible-value";
            var diagnostic = CaptureResponseDiagnostic(response => Assert.True(response.Headers.TryAddWithoutValidation(headerName, visibleValue)));

            Assert.Contains(visibleValue, diagnostic);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void ResponseDiagnosticsRedactMultiValueAndContentHeaders()
        {
            const string firstSecret = "first-secret";
            const string secondSecret = "second-secret";
            const string contentSecret = "content-secret";
            const string responseBody = "response-body-is-not-logged";
            var diagnostic = CaptureResponseDiagnostic(response =>
            {
                Assert.True(response.Headers.TryAddWithoutValidation("Set-Cookie", new[] { firstSecret, secondSecret }));
                response.Content = new StringContent(responseBody);
                Assert.True(response.Content.Headers.TryAddWithoutValidation("Client_Secret", contentSecret));
            });

            Assert.Equal(2, Regex.Matches(diagnostic, "Set-Cookie: REDACTED").Count);
            Assert.Contains("Client_Secret: REDACTED", diagnostic);
            Assert.DoesNotContain(firstSecret, diagnostic);
            Assert.DoesNotContain(secondSecret, diagnostic);
            Assert.DoesNotContain(contentSecret, diagnostic);
            Assert.DoesNotContain(responseBody, diagnostic);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public async Task RequestDiagnosticsRedactSensitiveAndContentHeaders()
        {
            const string requestSecret = "request-secret";
            const string contentSecret = "content-secret";
            const string requestBody = "request-body-is-not-logged";
            var listener = new TcpListener(IPAddress.Loopback, 0);
            listener.Start();

            try
            {
                var port = ((IPEndPoint)listener.LocalEndpoint).Port;
                var serverTask = Task.Run(async () =>
                {
                    using (var serverClient = await listener.AcceptTcpClientAsync())
                    {
                        var response = Encoding.ASCII.GetBytes("HTTP/1.1 204 No Content\r\nContent-Length: 0\r\n\r\n");
                        await serverClient.GetStream().WriteAsync(response, 0, response.Length);
                    }
                });

                using (var handler = new RestClientHandler(null) { UseCookies = false, UseProxy = false })
                using (var client = new HttpClient(handler))
                using (var request = new HttpRequestMessage(HttpMethod.Post, $"http://127.0.0.1:{port}/"))
                {
                    Assert.True(request.Headers.TryAddWithoutValidation("Authorization", requestSecret));
                    request.Content = new StringContent(requestBody);
                    Assert.True(request.Content.Headers.TryAddWithoutValidation("Client_Secret", contentSecret));

                    var diagnostic = CaptureDebugLog(() =>
                    {
                        using (var response = client.SendAsync(request).GetAwaiter().GetResult()) { }
                    });

                    Assert.Contains("Authorization: REDACTED", diagnostic);
                    Assert.Contains("Client_Secret: REDACTED", diagnostic);
                    Assert.DoesNotContain(requestSecret, diagnostic);
                    Assert.DoesNotContain(contentSecret, diagnostic);
                    Assert.DoesNotContain(requestBody, diagnostic);
                }

                await serverTask;
            }
            finally
            {
                listener.Stop();
            }
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void ConverterHeaderLogRedactsSensitiveValues()
        {
            var diagnostic = CaptureDebugLog(() => Converter.ToHttpRequestMessage(new Uri("https://example.com/"), HttpMethod.Get, new SensitiveHeaderRequest { ClientSecret = SensitiveValue }).Dispose());

            Assert.Contains("Adding header client_secret: REDACTED", diagnostic);
            Assert.DoesNotContain(SensitiveValue, diagnostic);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void ConverterListHeaderLogRedactsEachValue()
        {
            const string firstSecret = "first-secret";
            const string secondSecret = "second-secret";
            var request = new SensitiveHeaderRequest { SetCookies = new List<string> { firstSecret, secondSecret } };
            var diagnostic = CaptureDebugLog(() => Converter.ToHttpRequestMessage(new Uri("https://example.com/"), HttpMethod.Get, request).Dispose());

            Assert.Contains("Adding header set_cookie: REDACTED,REDACTED", diagnostic);
            Assert.DoesNotContain(firstSecret, diagnostic);
            Assert.DoesNotContain(secondSecret, diagnostic);
        }

        private static string CaptureResponseDiagnostic(Action<HttpResponseMessage> configureResponse)
        {
            using (var request = new HttpRequestMessage(HttpMethod.Get, "https://example.com/"))
            using (var response = new HttpResponseMessage(HttpStatusCode.OK))
            {
                var restClient = new RestClient();
                try
                {
                    configureResponse(response);
                    return CaptureDebugLog(() => restClient.CheckHttpResponseMessage(request, response));
                }
                finally
                {
                    restClient.Dispose();
                }
            }
        }

        private static string CaptureDebugLog(Action action)
        {
            lock (LoggerConfigurationLock)
            {
                var originalConfiguration = LogManager.Configuration;
                var memoryTarget = new MemoryTarget { Layout = "${message}" };
                var configuration = new LoggingConfiguration();
                configuration.AddRule(LogLevel.Debug, LogLevel.Fatal, memoryTarget);
                LogManager.Configuration = configuration;
                LogManager.ReconfigExistingLoggers();

                try
                {
                    action();
                    LogManager.Flush();
                    return string.Join(Environment.NewLine, memoryTarget.Logs);
                }
                finally
                {
                    LogManager.Configuration = originalConfiguration;
                    LogManager.ReconfigExistingLoggers();
                }
            }
        }

        private class SensitiveHeaderRequest : IOciRequest
        {
            [HttpConverter(TargetEnum.Header, "client_secret")]
            public string ClientSecret { get; set; }

            [HttpConverter(TargetEnum.Header, "set_cookie")]
            public List<string> SetCookies { get; set; }
        }
    }
}
