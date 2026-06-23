/*
 * Copyright (c) 2020, 2026, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

namespace Oci.Common.Auth
{
    /// <summary>
    /// An Authentication details provider to generate service tokens
    /// used for actual signing.
    /// </summary>
    public class InstancePrincipalsAuthenticationDetailsProvider : AbstractRequestingAuthenticationDetailsProvider
    {
        public InstancePrincipalsAuthenticationDetailsProvider() : base()
        { }

        /// <summary>
        /// Creates an instance principals authentication provider using a custom auth service federation endpoint.
        /// The endpoint should be the base auth service endpoint; the SDK appends /v1/x509 when requesting the security token.
        /// </summary>
        /// <param name="federationEndpoint">The base auth service federation endpoint.</param>
        public InstancePrincipalsAuthenticationDetailsProvider(string federationEndpoint) : base(federationEndpoint)
        { }
    }
}
