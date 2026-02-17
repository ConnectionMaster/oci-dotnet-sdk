/*
 * Copyright (c) 2020, 2026, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

using Oci.Common.Utils;

namespace Oci.Common.Internal
{
    /// <summary>
    /// EndpointBuilder provides a wrapper to construct the appropriate
    /// endpoint for a service.  The service may override the endpoint template, but
    /// if not, a default template will be used.
    /// </summary>
    public class EndpointBuilder
    {
        protected static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        private static readonly int SERVICE_NAME_GROUP_INDEX = 2;
        private static readonly string SERVICE_ENDPOINT_PREFIX_TEMPLATE = "{serviceEndpointPrefix}";
        private static readonly string SERVICE_TEMPLATE = "{service}";
        private static readonly string REGION_ID_TEMPLATE = "{region}";
        private static readonly string SECOND_LEVEL_DOMAIN_TEMPLATE = "{secondLevelDomain}";
        public static readonly string DEFAULT_ENDPOINT_TEMPLATE = $"https://{SERVICE_ENDPOINT_PREFIX_TEMPLATE}.{REGION_ID_TEMPLATE}.{SECOND_LEVEL_DOMAIN_TEMPLATE}";
        public static readonly string DOTTED_REGION_ENDPOINT_TEMPLATE = $"https://{SERVICE_TEMPLATE}.{REGION_ID_TEMPLATE}";

        private static readonly Regex PLACEHOLDER_PATTERN = new Regex(@"\{(.*?)\}", RegexOptions.Compiled);
        /// <summary>
        /// Regex to detect options defined in the endpoint template. It checks for the following pattern:
        /// <list type="bullet">
        ///   <item>Starts with an opening curly brace ({)</item>
        ///   <item>Followed by 1 or more word characters</item>
        ///   <item>Followed by a question mark (?)</item>
        ///   <item>Followed by any one of the following:
        ///     <list type="bullet">
        ///         <item>one or more word characters, followed by a period:one or more word characters, followed by a period</item>
        ///         <item>one or more word characters, followed by a period:zero or more whitespace characters</item>
        ///         <item>zero or more whitespace characters:one or more word characters, followed by a period</item>
        ///     </list>
        ///   </item>
        ///   <item>Ends with a closing curly brace (})</item>
        /// </list>
        /// <para>Example: {option?v1.:v2.}, {option?:v2.}, {option?v1.:} are valid patterns</para>
        /// <para>Example: {option?v1:v2+}, {option?:v2}, {option?v1?:} {option?:} are invalid pattern</para>
        /// </summary>
        public static readonly string OPTIONS_REGEX = @"\{(\w+)\?(((\w+\.)+\:(\w+\.)+)|((\w+\.)+:\s*)|(\s*:(\w+\.)+))\}+";
        public static readonly Regex OPTIONS_PATTERN = new Regex(OPTIONS_REGEX, RegexOptions.Compiled);

        private static readonly Dictionary<string, string> OVERRIDE_REGION_IDS = new Dictionary<string, string>();

        /// <summary>Creates the service endpoint</summary>
        /// <param name="service">The service.</param>
        /// <param name="regionId">The region id.</param>
        /// <param name="Realm">The realm to use.</param>
        /// <returns>The endpoint (protocol + FQDN) for this service.</returns>
        [MethodImpl(MethodImplOptions.Synchronized)]
        public static string CreateEndpoint(Service service, string regionId, Realm realm)
        {
            if (service == null || String.IsNullOrWhiteSpace(regionId) || realm == null)
            {
                throw new ArgumentNullException();
            }
            string regionIdToUse;
            lock (OVERRIDE_REGION_IDS)
            {
                regionIdToUse = OVERRIDE_REGION_IDS.TryGetValue(regionId, out var val) ? val : regionId;
            }
            // If the region is dotted, return endpoint using the "{service}.{region}" template.
            if (regionIdToUse.Contains("."))
            {
                return BuildEndpoint(DOTTED_REGION_ENDPOINT_TEMPLATE, service, regionIdToUse);
            }
            bool isRealmSpecificEndpointTemplateEnabledByDefault = RealmSpecificEndpointTemplateUtils.IsRealmSpecificEndpointTemplateEnabledByDefault();
            if (isRealmSpecificEndpointTemplateEnabledByDefault)
            {
                bool isRealSpecificTemplateDefined = service?.GetServiceEndpointTemplateForRealmDictionary()?.ContainsKey(realm.RealmId.ToLower()) ?? false;
                if (isRealSpecificTemplateDefined)
                {
                    return GetRealmSpecificEndpointTemplate(service, regionIdToUse, realm);
                }
                else
                {
                    logger.Debug($"Realm Specific Endpoint template not defined for realm {realm.RealmId}, using non-realm-specific endpoint template instead.");
                }
            }
            return GetServiceEndpointTemplateToUse(service, regionIdToUse, realm);
        }

        /// <summary>Creates the service endpoint from region.</summary>
        /// <param name="service">The service.</param>
        /// <param name="region">The region id.</param>
        /// <returns>The endpoint (protocol + FQDN) for this service.</returns>
        public static string CreateEndpoint(Service service, Region region)
        {
            if (service == null || region == null)
            {
                throw new ArgumentNullException();
            }
            return CreateEndpoint(service, region.RegionId, region.Realm);
        }

        /// <summary>Builds the service endpoint</summary>
        /// <param name="template">The endpoint template.</param>
        /// <param name="regionId">The region id.</param>
        /// <param name="endpointPrefix">The endpoint prefix.</param>
        /// <param name="realm">The Realm to use.</param>
        /// <returns>The endpoint (protocol + FQDN) for this service.</returns>
        public static string BuildEndpoint(string template, string regionId, string endpointPrefix, Realm realm)
        {
            logger.Trace("Called BuildEndpoint");
            if (template == null || regionId == null || endpointPrefix == null || realm == null)
            {
                throw new ArgumentNullException();
            }

            string endpoint = template.Replace(SERVICE_ENDPOINT_PREFIX_TEMPLATE, endpointPrefix)
                .Replace(REGION_ID_TEMPLATE, regionId)
                .Replace(SECOND_LEVEL_DOMAIN_TEMPLATE, realm.SecondLevelDomain);
            logger.Debug($"Built endpoint: '{endpoint}'");

            return endpoint;
        }

        /// <summary>
        /// Builds the service endpoint using `EndpointServiceName` if available,
        /// otherwise extrapolating the service name from the `ServiceEndpointTemplate`.
        /// </summary>
        /// <param name="template">The endpoint template, i.e https://{service}.{region}</param>
        /// <param name="service">The service object with `EndpointServiceName` or `ServiceEndpointTemplate` fields.</param>
        /// <param name="region">The region with a dot.</param>
        /// <returns>The endpoint for this service.</returns>
        public static string BuildEndpoint(string template, Service service, string region)
        {
            logger.Trace("Called BuildEndpoint - custom region detected");
            if (template == null || service == null || region == null)
            {
                throw new ArgumentNullException();
            }

            string serviceName;

            if (!string.IsNullOrEmpty(service.EndpointServiceName))
            {
                // If x-obmcs-endpoint-service-name is set in the spec, use that for the {service} portion of this template.
                serviceName = service.EndpointServiceName;
            }
            else
            {
                // If x-obmcs-endpoint-service-name is not set in the spec, extract the service name from the x-obmcs-endpoint-template.
                // The service name is found in the {service} portion of the x-obmcs-endpoint-template: https://{service}.{region}.oci.{secondLevelDomain}
                Regex regex = new Regex(@"(https:\/\/|http:\/\/)(\w+)(\..*)");
                Match match = regex.Match(service.ServiceEndpointTemplate);
                serviceName = match.Groups[SERVICE_NAME_GROUP_INDEX].Value;
                if (string.IsNullOrEmpty(serviceName))
                {
                    throw new Oci.Common.Model.OciException($"The ServiceEndpointTemplate: \"{service.ServiceEndpointTemplate}\" is formatted incorrectly", new UriFormatException());
                }
            }

            // Build the endpoint using the template with replaced {service} and {region} portions.
            string endpoint = template.Replace(SERVICE_TEMPLATE, serviceName)
                .Replace(REGION_ID_TEMPLATE, region);

            logger.Debug($"Built endpoint: '{endpoint}'");
            return endpoint;
        }

        public static string GetServiceEndpointTemplateToUse(Service service, string regionId, Realm realm)
        {
            string endpointTemplateToUse;
            if (!string.IsNullOrEmpty(service.ServiceEndpointTemplate))
            {
                endpointTemplateToUse = service.ServiceEndpointTemplate;
            }
            else
            {
                endpointTemplateToUse = DEFAULT_ENDPOINT_TEMPLATE;
            }
            return BuildEndpoint(endpointTemplateToUse, regionId, service.ServiceEndpointPrefix, realm);
        }

        public static string GetRealmSpecificEndpointTemplate(Service service, string regionId, Realm realm)
        {
            Dictionary<string, string> serviceEndpointTemplateForRealmDictionary = service.GetServiceEndpointTemplateForRealmDictionary();
            string endpointTemplateToUse;
            if (serviceEndpointTemplateForRealmDictionary.ContainsKey(realm.RealmId.ToLower()))
            {
                endpointTemplateToUse = serviceEndpointTemplateForRealmDictionary[realm.RealmId.ToLower()];
            }
            else
            {
                logger.Debug($"Endpoint template not defined for {realm.RealmId} realm, using non-realm-specific endpoint template instead");
                endpointTemplateToUse = GetServiceEndpointTemplateToUse(service, regionId, realm);
            }
            logger.Debug($"Setting endpoint template to: {endpointTemplateToUse}");
            return BuildEndpoint(endpointTemplateToUse, regionId, service.ServiceEndpointPrefix, realm);
        }

        /// <summary>
        /// Populate the parameters and handle option blocks in the endpoint template.
        /// </summary>
        /// <param name="baseUriString">The template endpoint with placeholders.</param>
        /// <param name="requiredParametersDictionary">Dictionary of request parameters to populate.</param>
        /// <param name="optionsMap">Options map for enabled/disabled flags (e.g. dualStack).</param>
        /// <returns>Processed endpoint string with parameters and options.</returns>
        public static string GetEndpointWithPopulatedServiceParams(
            string baseUriString,
            Dictionary<string, object> requiredParametersDictionary,
            Dictionary<string, bool> optionsMap)
        {
            string endpoint = baseUriString;
            logger.Trace($"getEndpointWithPopulateServiceParameters: baseUriString='{endpoint}'");
            if (!IsEndpointParameterized(endpoint))
            {
                logger.Trace($"baseUriString not parameterized; endpoint='{endpoint}'");
                return endpoint;
            }

            var updatedEndpointBuilder = new System.Text.StringBuilder();
            int afterLastMatch = 0;
            var matcher = PLACEHOLDER_PATTERN.Matches(endpoint);

            foreach (Match match in matcher)
            {
                // Append part between last match and this match
                updatedEndpointBuilder.Append(endpoint.Substring(afterLastMatch, match.Index - afterLastMatch));
                afterLastMatch = match.Index + match.Length;

                string group = match.Value;
                // Option block
                if (OPTIONS_PATTERN.IsMatch(group))
                {
                    var optionMatch = OPTIONS_PATTERN.Match(group);
                    if (optionMatch.Success)
                    {
                        string optionName = optionMatch.Groups[1].Value;
                        if (!optionsMap.ContainsKey(optionName))
                        {
                            logger.Debug($"The option {optionName} cannot be populated since its value was not provided, removing {group} from endpoint entirely");
                            continue;
                        }
                        bool optionValue = optionsMap[optionName];
                        // Parse choices
                        var qMark = group.IndexOf("?");
                        var colon = group.IndexOf(":", qMark);
                        var close = group.IndexOf("}", colon);
                        string onChoice = group.Substring(qMark + 1, colon - qMark - 1);
                        string offChoice = group.Substring(colon + 1, close - colon - 1);
                        string replacement = optionValue ? onChoice : offChoice;
                        updatedEndpointBuilder.Append(replacement);
                    }
                }
                else
                {
                    // Generic parameter
                    string parameter = match.Value; // e.g. "{param}", or "{param+Dot}"
                    bool appendDot = false;
                    string paramName;
                    if (parameter.EndsWith("+Dot}"))
                    {
                        appendDot = true;
                        paramName = parameter.Substring(1, parameter.IndexOf("+")-1);
                    }
                    else
                    {
                        paramName = parameter.Substring(1, parameter.Length - 2);
                    }
                    if (requiredParametersDictionary.ContainsKey(paramName))
                    {
                        if (!(requiredParametersDictionary[paramName] is string paramValue))
                        {
                            logger.Debug($"The parameter for {paramName} cannot be populated since the value is not of type string");
                            continue;
                        }
                        updatedEndpointBuilder.Append(paramValue);
                        if (appendDot)
                            updatedEndpointBuilder.Append('.');
                    }
                    else
                    {
                        logger.Trace($"GetEndpointWithPopulatedServiceParams: parameter '{paramName}' not found in requiredParameters dictionary");
                    }
                }
            }
            // Append rest
            updatedEndpointBuilder.Append(endpoint.Substring(afterLastMatch));
            string updatedEndpoint = updatedEndpointBuilder.ToString();
            logger.Trace($"Processed all parameters, endpoint='{updatedEndpoint}'");
            return updatedEndpoint;
        }

        /// <summary>
        /// Checks if the given endpoint string contains any placeholders.
        /// </summary>
        public static bool IsEndpointParameterized(string endpoint)
        {
            return endpoint.Contains("{");
        }

    }
}
