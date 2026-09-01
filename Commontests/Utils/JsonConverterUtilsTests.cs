/*
 * Copyright (c) 2020, 2026, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using NLog;
using NLog.Config;
using NLog.Targets;
using Oci.Common.Http;
using Oci.Common.Http.Internal;
using Xunit;

using Newtonsoft.Json.Linq;

namespace Oci.Common.Utils
{
    [ExcludeFromCodeCoverage]
    public class JsonConverterUtilsTests : BaseTest
    {
        private static readonly object LoggerConfigurationLock = new object();

        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        [Theory]
        [InlineData("{\"dateTimeValue\":null}")]
        [InlineData("{\"dateTimeValue\":\"05/07/2020 18:27:08\"}")]
        [InlineData("{\"dateTimeValue\":\"2020-05-07T18:27:08.123Z\"}")]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void DeserializeDateTime(string content)
        {
            ClassWithDateTime result = JsonConvert.DeserializeObject<ClassWithDateTime>(
                content, new JsonSerializerSettings { ContractResolver = new CustomResolver(), NullValueHandling = NullValueHandling.Ignore });

            logger.Info(result.DateTimeValue);
        }

        [Theory]
        [InlineData("11/24/2020 15:05:15Z", "{\"DateTimeValue\":\"2020-11-24T15:05:15.000Z\"}", "en-US")]
        [InlineData("24/11/2020 15:05:15Z", "{\"DateTimeValue\":\"2020-11-24T15:05:15.000Z\"}", "en-IE")]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void SerializeDateTime(string value, string expectedValue, string dateTimeCultureCode)
        {
            var objWithDateTime = new ClassWithDateTime
            {
                DateTimeValue = DateTime.Parse(value, new CultureInfo(dateTimeCultureCode))
            };
            var objJson = JsonConvert.SerializeObject(objWithDateTime, new JsonSerializerSettings { ContractResolver = new CustomResolver(), NullValueHandling = NullValueHandling.Ignore });
            Assert.Equal(expectedValue, objJson);
        }

        [Theory]
        [Trait("Category", "Unit")]
        [InlineData("{\"compartmentId\":\"compartmentId\", \"responseEnum\":\"XYZ\"}", "compartmentId", ResponseEnum.UnknownEnumValue)]
        [InlineData("{\"compartmentId\":\"compartmentId2\", \"responseEnum\":\"Value1\"}", "compartmentId2", ResponseEnum.Value1)]
        [DisplayTestMethodNameAttribute]
        public void TestResonseEnumConverter(string content, string expectedCompartmentId, ResponseEnum responseEnum)
        {
            var resonseEnumSummary = JsonConvert.DeserializeObject<ResonseEnumSummary>(content);
            Assert.Equal(expectedCompartmentId, resonseEnumSummary.CompartmentId);
            Assert.Equal(responseEnum, resonseEnumSummary.responseEnum);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void TestDiscriminatorEnumConverter()
        {
            string content = "{\"attributeName\":\"PATH\", \"attributeValue\":\"XYZ\"}";
            var response = JsonConvert.DeserializeObject<BaseDiscriminatorEnum>(content) as PathMatchCondition;
            Assert.Equal("XYZ", response.AttributeValue);

            string content2 = "{\"attributeName\":\"DOES_NOT_EXIST\", \"attributeValue\":\"XYZ\"}";
            var response2 = JsonConvert.DeserializeObject<BaseDiscriminatorEnum>(content2);
            Assert.Null(response2);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void RedactedStringifierRedactsSensitiveValues()
        {
            const string redactedValue = "<redacted>";
            var passwordCanaries = new[]
            {
                "direct-password-canary",
                "array-password-canary",
                "matrix-password-canary",
                "map-password-canary",
                "enum-password-canary",
                "nested-password-canary",
                "nested-list-password-canary",
                "nested-map-password-canary",
                "inherited-password-canary"
            };
            var plainValues = new[]
            {
                "plain-string-value",
                "plain-array-value",
                "plain-map-value",
                "plain-enum-value",
                "nested-plain-value",
                "email-address-canary",
                "inherited-plain-value"
            };
            var value = new PasswordFormattedValue
            {
                Password = passwordCanaries[0],
                Plain = plainValues[0],
                Passwords = new List<string> { passwordCanaries[1] },
                PlainValues = new List<string> { plainValues[1] },
                PasswordMatrix = new List<List<string>> { new List<string> { passwordCanaries[2] } },
                PasswordMap = new Dictionary<string, string> { { "password", passwordCanaries[3] } },
                PlainMap = new Dictionary<string, string> { { "plain", plainValues[2] } },
                PasswordEnum = PasswordFormatEnum.PasswordValue,
                PlainEnum = PasswordFormatEnum.PlainValue,
                Email = plainValues[5],
                Nested = new PasswordFormattedNestedValue
                {
                    Password = passwordCanaries[5],
                    Plain = plainValues[4]
                },
                NestedValues = new List<PasswordFormattedNestedValue>
                {
                    new PasswordFormattedNestedValue { Password = passwordCanaries[6] }
                },
                NestedMap = new Dictionary<string, PasswordFormattedNestedValue>
                {
                    { "nested", new PasswordFormattedNestedValue { Password = passwordCanaries[7] } }
                },
                Inherited = new InheritedPasswordFormattedValue
                {
                    InheritedPassword = passwordCanaries[8],
                    Plain = plainValues[6]
                }
            };

            var rawValue = JsonConvert.SerializeObject(
                value,
                new JsonSerializerSettings
                {
                    ContractResolver = new CustomResolver(),
                    NullValueHandling = NullValueHandling.Ignore
                });
            var requestValue = SerializeRequest(value);
            var requestDiagnosticValue = CaptureTraceLog(() => SerializeRequest(value));
            var diagnosticValue = RedactedStringifier.ToString(value);
            var diagnosticJson = JObject.Parse(diagnosticValue);

            foreach (var canary in passwordCanaries)
            {
                Assert.Contains(canary, rawValue);
                Assert.Contains(canary, requestValue);
                Assert.DoesNotContain(canary, diagnosticValue);
                Assert.DoesNotContain(canary, requestDiagnosticValue);
            }
            foreach (var plainValue in plainValues)
            {
                Assert.Contains(plainValue, diagnosticValue);
            }
            Assert.DoesNotContain(redactedValue, rawValue);
            Assert.DoesNotContain(redactedValue, requestValue);
            Assert.Contains(redactedValue, requestDiagnosticValue);
            Assert.Contains(plainValues[0], requestDiagnosticValue);

            Assert.Equal(redactedValue, diagnosticJson["Password"].Value<string>());
            Assert.Equal(redactedValue, diagnosticJson["Passwords"].Value<string>());
            Assert.Equal(redactedValue, diagnosticJson["PasswordMatrix"].Value<string>());
            Assert.Equal(redactedValue, diagnosticJson["PasswordMap"].Value<string>());
            Assert.Equal(redactedValue, diagnosticJson["PasswordEnum"].Value<string>());
            Assert.Equal(redactedValue, diagnosticJson["NullPassword"].Value<string>());
            Assert.Equal(redactedValue, diagnosticJson["Nested"]["Password"].Value<string>());
            Assert.Equal(redactedValue, diagnosticJson["NestedValues"][0]["Password"].Value<string>());
            Assert.Equal(redactedValue, diagnosticJson["NestedMap"]["nested"]["Password"].Value<string>());
            Assert.Equal(redactedValue, diagnosticJson["Inherited"]["InheritedPassword"].Value<string>());
            Assert.Equal(plainValues[5], diagnosticJson["Email"].Value<string>());
            Assert.Null(diagnosticJson.Property("PlainNull"));

            var inheritedDiagnosticValue = RedactedStringifier.ToString(value.Inherited);
            Assert.DoesNotContain(passwordCanaries[8], inheritedDiagnosticValue);
            Assert.Contains(redactedValue, inheritedDiagnosticValue);
            Assert.Contains(plainValues[6], inheritedDiagnosticValue);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public async Task SensitiveValuesAreRedactedInEndToEndRequestDiagnostics()
        {
            const string passwordCanary = "end-to-end-password-canary";
            const string plainCanary = "end-to-end-plain-canary";
            var listener = new TcpListener(IPAddress.Loopback, 0);
            listener.Start();

            try
            {
                var port = ((IPEndPoint)listener.LocalEndpoint).Port;
                var receivedBody = ReadRequestBodyAndRespond(listener);
                var diagnostic = CaptureTraceLog(() =>
                {
                    using (var handler = new RestClientHandler(null) { UseCookies = false, UseProxy = false })
                    {
                        var restClient = new RestClient(handler);
                        try
                        {
                            using (var request = Converter.ToHttpRequestMessage(
                                new Uri($"http://127.0.0.1:{port}/"),
                                HttpMethod.Post,
                                new EndToEndSensitiveRequest
                                {
                                    Body = new EndToEndSensitiveModel
                                    {
                                        Password = passwordCanary,
                                        Plain = plainCanary
                                    }
                                }))
                            using (var response = restClient.HttpSend(request).GetAwaiter().GetResult())
                            {
                                restClient.CheckHttpResponseMessage(request, response);
                            }
                        }
                        finally
                        {
                            restClient.Dispose();
                        }
                    }
                });

                var requestBody = await receivedBody;
                Assert.Contains(passwordCanary, requestBody);
                Assert.Contains(plainCanary, requestBody);
                Assert.Contains("<redacted>", diagnostic);
                Assert.Contains(plainCanary, diagnostic);
                Assert.DoesNotContain(passwordCanary, diagnostic);
            }
            finally
            {
                listener.Stop();
            }
        }

        private static string SerializeRequest(object value)
        {
            using var stream = new MemoryStream();
            ContentHelper.SerializeJsonIntoStream(value, stream);
            stream.Seek(0, SeekOrigin.Begin);
            using var reader = new StreamReader(stream, Encoding.UTF8, false, 1024, true);
            return reader.ReadToEnd();
        }

        private static async Task<string> ReadRequestBodyAndRespond(TcpListener listener)
        {
            using (var serverClient = await listener.AcceptTcpClientAsync())
            using (var stream = serverClient.GetStream())
            using (var reader = new StreamReader(stream, Encoding.UTF8, false, 1024, true))
            {
                var contentLength = -1;
                string header;
                while (!string.IsNullOrEmpty(header = await reader.ReadLineAsync()))
                {
                    const string contentLengthHeader = "Content-Length:";
                    if (header.StartsWith(contentLengthHeader, StringComparison.OrdinalIgnoreCase))
                    {
                        contentLength = int.Parse(
                            header.Substring(contentLengthHeader.Length).Trim(),
                            CultureInfo.InvariantCulture);
                    }
                }

                if (contentLength < 0)
                {
                    throw new InvalidOperationException("Expected the request to include a Content-Length header.");
                }

                var body = new char[contentLength];
                var charactersRead = 0;
                while (charactersRead < contentLength)
                {
                    var currentRead = await reader.ReadAsync(body, charactersRead, contentLength - charactersRead);
                    if (currentRead == 0)
                    {
                        break;
                    }
                    charactersRead += currentRead;
                }

                var response = Encoding.ASCII.GetBytes("HTTP/1.1 204 No Content\r\nContent-Length: 0\r\n\r\n");
                await stream.WriteAsync(response, 0, response.Length);
                return new string(body, 0, charactersRead);
            }
        }

        private static string CaptureTraceLog(Action action)
        {
            lock (LoggerConfigurationLock)
            {
                var originalConfiguration = LogManager.Configuration;
                var memoryTarget = new MemoryTarget { Layout = "${message}" };
                var configuration = new LoggingConfiguration();
                configuration.AddRule(LogLevel.Trace, LogLevel.Fatal, memoryTarget);
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
    }

    public class ClassWithDateTime
    {
        public Nullable<DateTime> DateTimeValue { get; set; }
    }

    public class PasswordFormattedValue
    {
        [Sensitive]
        public string Password { get; set; }
        public string Plain { get; set; }
        [Sensitive]
        public List<string> Passwords { get; set; }
        public List<string> PlainValues { get; set; }
        [Sensitive]
        public List<List<string>> PasswordMatrix { get; set; }
        [Sensitive]
        public Dictionary<string, string> PasswordMap { get; set; }
        public Dictionary<string, string> PlainMap { get; set; }
        [Sensitive]
        [JsonConverter(typeof(StringEnumConverter))]
        public PasswordFormatEnum PasswordEnum { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public PasswordFormatEnum PlainEnum { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Sensitive]
        public string NullPassword { get; set; }
        public string PlainNull { get; set; }
        public PasswordFormattedNestedValue Nested { get; set; }
        public List<PasswordFormattedNestedValue> NestedValues { get; set; }
        public Dictionary<string, PasswordFormattedNestedValue> NestedMap { get; set; }
        public InheritedPasswordFormattedValue Inherited { get; set; }
    }

    public class EndToEndSensitiveRequest : IOciRequest
    {
        [HttpConverter(TargetEnum.Body)]
        public EndToEndSensitiveModel Body { get; set; }
    }

    public class EndToEndSensitiveModel
    {
        [Oci.Common.Utils.Sensitive]
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

        [JsonProperty(PropertyName = "plain")]
        public string Plain { get; set; }
    }

    public class PasswordFormattedNestedValue
    {
        [Sensitive]
        public string Password { get; set; }
        public string Plain { get; set; }
    }

    public class PasswordFormattedBaseValue
    {
        [Sensitive]
        public string InheritedPassword { get; set; }
    }

    public class InheritedPasswordFormattedValue : PasswordFormattedBaseValue
    {
        public string Plain { get; set; }
    }

    public enum PasswordFormatEnum
    {
        [EnumMember(Value = "enum-password-canary")]
        PasswordValue,
        [EnumMember(Value = "plain-enum-value")]
        PlainValue
    }

    public enum ResponseEnum
    {
        [EnumMember(Value = null)]
        UnknownEnumValue,
        [EnumMember(Value = "Value1")]
        Value1
    }
    public class ResonseEnumSummary
    {
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }

        [JsonConverter(typeof(ResponseEnumConverter))]
        [JsonProperty(PropertyName = "responseEnum")]
        public System.Nullable<ResponseEnum> responseEnum { get; set; }
    }

    [JsonConverter(typeof(BaseDiscriminatorEnumModelConverter))]
    public class BaseDiscriminatorEnum
    {
        public enum AttributeNameEnum
        {
            [EnumMember(Value = "PATH")]
            Path
        };
    }

    public class BaseDiscriminatorEnumModelConverter : JsonConverter
    {
        private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(BaseDiscriminatorEnum);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(BaseDiscriminatorEnum);
            var discriminator = jsonObject["attributeName"].Value<string>();
            switch (discriminator)
            {
                case "PATH":
                    obj = new PathMatchCondition();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under BaseDiscriminatorEnum! Returning null value.");
            }
            return obj;
        }
    }
    public class PathMatchCondition : BaseDiscriminatorEnum
    {
        [JsonProperty(PropertyName = "attributeValue")]
        public string AttributeValue { get; set; }
        [JsonProperty(PropertyName = "attributeName")]
        private readonly string attributeName = "PATH";
    }
}
