/*
 * Copyright (c) 2020, 2026, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Oci.Common.Http.Internal
{
    /// <summary>Redacts credential-bearing HTTP header values before they are written to diagnostics.</summary>
    internal static class HeaderRedactor
    {
        internal const string RedactedValue = "REDACTED";

        private static readonly HashSet<string> ExactSensitiveHeaderNames = new HashSet<string>(StringComparer.Ordinal)
        {
            "authorization",
            "proxy-authorization",
            "opc-obo-token",
            "x-api-key",
            "cookie",
            "set-cookie",
            "security-context",
            "password",
            "passphrase"
        };

        private static readonly string[] CredentialSuffixes =
        {
            "access-token",
            "refresh-token",
            "id-token",
            "security-token",
            "session-token",
            "delegation-token",
            "client-secret",
            "private-key"
        };

        /// <summary>Normalizes a header name for sensitive-header matching.</summary>
        internal static string NormalizeHeaderName(string headerName)
        {
            if (headerName == null)
            {
                return null;
            }

            var normalizedHeaderName = new StringBuilder(headerName.Length);
            var previousCharacterWasDelimiter = false;
            foreach (var character in headerName)
            {
                if (character == '-' || character == '_')
                {
                    if (!previousCharacterWasDelimiter)
                    {
                        normalizedHeaderName.Append('-');
                        previousCharacterWasDelimiter = true;
                    }
                }
                else
                {
                    normalizedHeaderName.Append(char.ToLowerInvariant(character));
                    previousCharacterWasDelimiter = false;
                }
            }

            return normalizedHeaderName.ToString();
        }

        /// <summary>Returns whether a header name is credential-bearing.</summary>
        internal static bool IsSensitiveHeaderName(string headerName)
        {
            var normalizedHeaderName = NormalizeHeaderName(headerName);
            if (normalizedHeaderName == null)
            {
                return false;
            }

            if (ExactSensitiveHeaderNames.Contains(normalizedHeaderName) || normalizedHeaderName == "x-token" || normalizedHeaderName.StartsWith("x-token-", StringComparison.Ordinal) || normalizedHeaderName == "x-authorization" || normalizedHeaderName.StartsWith("x-authorization-", StringComparison.Ordinal) || normalizedHeaderName.StartsWith("x-key-", StringComparison.Ordinal))
            {
                return true;
            }

            return CredentialSuffixes.Any(suffix => normalizedHeaderName == suffix || normalizedHeaderName.EndsWith("-" + suffix, StringComparison.Ordinal));
        }

        /// <summary>Returns a diagnostic-safe representation of one header value.</summary>
        internal static string RedactHeaderValue(string headerName, string headerValue)
        {
            if (IsSensitiveHeaderName(headerName))
            {
                return RedactedValue;
            }

            return headerValue;
        }

        /// <summary>Redacts sensitive values from line-oriented HTTP diagnostics.</summary>
        internal static string RedactSensitiveHeadersForLogs(string value)
        {
            if (value == null)
            {
                return null;
            }

            var redactedValue = new StringBuilder(value.Length);
            var lineStart = 0;
            while (lineStart < value.Length)
            {
                var lineEnd = value.IndexOf('\n', lineStart);
                if (lineEnd == -1)
                {
                    lineEnd = value.Length;
                }

                var headerLineEnd = lineEnd;
                if (headerLineEnd > lineStart && value[headerLineEnd - 1] == '\r')
                {
                    headerLineEnd--;
                }

                var headerSeparatorIndex = value.IndexOf(':', lineStart, headerLineEnd - lineStart);
                if (headerSeparatorIndex >= 0)
                {
                    var headerNameStart = lineStart;
                    var headerNameEnd = headerSeparatorIndex;
                    while (headerNameStart < headerNameEnd && char.IsWhiteSpace(value[headerNameStart]))
                    {
                        headerNameStart++;
                    }

                    while (headerNameEnd > headerNameStart && char.IsWhiteSpace(value[headerNameEnd - 1]))
                    {
                        headerNameEnd--;
                    }

                    var headerName = value.Substring(headerNameStart, headerNameEnd - headerNameStart);
                    if (IsSensitiveHeaderName(headerName))
                    {
                        var headerValueStart = headerSeparatorIndex + 1;
                        while (headerValueStart < headerLineEnd && char.IsWhiteSpace(value[headerValueStart]))
                        {
                            headerValueStart++;
                        }

                        redactedValue.Append(value, lineStart, headerValueStart - lineStart);
                        redactedValue.Append(RedactedValue);
                        redactedValue.Append(value, headerLineEnd, lineEnd - headerLineEnd);
                    }
                    else
                    {
                        redactedValue.Append(value, lineStart, lineEnd - lineStart);
                    }
                }
                else
                {
                    redactedValue.Append(value, lineStart, lineEnd - lineStart);
                }

                if (lineEnd < value.Length)
                {
                    redactedValue.Append('\n');
                }

                lineStart = lineEnd + 1;
            }

            return redactedValue.ToString();
        }
    }
}
