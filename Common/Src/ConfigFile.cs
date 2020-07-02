/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System.Collections.Generic;
using System.IO;

namespace Oci.Common
{
    public class ConfigFile
    {
        private readonly ConfigAccumulator accumulator;
        private string profile;
        private static readonly string DEFAULT_PROFILE_NAME = "DEFAULT";

        public ConfigFile(ConfigAccumulator accumulator, string profile)
        {
            this.accumulator = accumulator;
            this.profile = profile;
        }

        public string GetValue(string key)
        {
            if (profile != null && (accumulator.configurationByProfile.ContainsKey(profile)) && accumulator.configurationByProfile[profile].ContainsKey(key))
            {
                return accumulator.configurationByProfile[profile][key];
            }
            string value = null;
            if (accumulator.foundDefaultProfile)
            {
                accumulator.configurationByProfile[DEFAULT_PROFILE_NAME].TryGetValue(key, out value);
            }
            return value;
        }

        public class ConfigAccumulator
        {
            public Dictionary<string, Dictionary<string, string>> configurationByProfile = new Dictionary<string, Dictionary<string, string>>();

            public string currentProfile = null;
            public bool foundDefaultProfile = false;

            public void Accept(string line)
            {
                string trimmedLine = line.Trim();
                // empty
                if (string.IsNullOrEmpty(trimmedLine))
                {
                    return;
                }
                // comment
                if (trimmedLine.StartsWith("#"))
                {
                    return;
                }
                // [profile_name]
                if (trimmedLine.StartsWith("[") && trimmedLine.EndsWith("]"))
                {
                    currentProfile = trimmedLine.Substring(1, trimmedLine.Length - 2).Trim();
                    if (string.IsNullOrEmpty(currentProfile))
                    {
                        throw new InvalidDataException($"Cannot have empty profile name: {line}");
                    }
                    if (currentProfile.Equals(DEFAULT_PROFILE_NAME))
                    {
                        foundDefaultProfile = true;
                    }
                    if (!configurationByProfile.ContainsKey(currentProfile))
                    {
                        configurationByProfile.Add(currentProfile, new Dictionary<string, string>());
                    }
                    return;
                }
                var splitIndex = trimmedLine.IndexOf("=");
                if (splitIndex == -1)
                {
                    throw new InvalidDataException($"Found line with no key-value pair: {line}");
                }

                var key = trimmedLine.Substring(0, splitIndex).Trim();
                var value = trimmedLine.Substring(splitIndex + 1).Trim();
                if (string.IsNullOrEmpty(key))
                {
                    throw new InvalidDataException($"Found line with no key: {line}");
                }
                configurationByProfile[currentProfile].Add(key, value);
            }
        }
    }
}
