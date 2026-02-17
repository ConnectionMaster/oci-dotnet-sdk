/*
 * Copyright (c) 2020, 2026, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using Oci.Common;

namespace Oci.Common.Utils
{
    /// <summary>
    /// Utilities for endpoint template options handling, especially for dualStack.
    /// Mirrors EndpointTemplateForOptionsUtils from Java SDK.
    /// </summary>
    public static class EndpointTemplateForOptionsUtils
    {
        private const string OCI_DUAL_STACK_ENDPOINT_ENABLED_ENV_VAR = "OCI_DUAL_STACK_ENDPOINT_ENABLED";
        public const string DUAL_STACK_OPTION = "dualStack";

        /// <summary>
        /// Determines if dualStack is enabled by default for the client/service.
        /// Checks the OCI_DUAL_STACK_ENDPOINT_ENABLED environment variable first, then service default.
        /// </summary>
        public static bool IsDualStackEnabledForClientDefault(Service service)
        {
            var dualStackEnv = Environment.GetEnvironmentVariable(OCI_DUAL_STACK_ENDPOINT_ENABLED_ENV_VAR);
            if (!string.IsNullOrEmpty(dualStackEnv))
            {
                if (bool.TryParse(dualStackEnv, out bool parsed))
                {
                    return parsed;
                }
            }
            return service != null && service.ServiceUsesDualStackByDefault;
        }
    }
}
