/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.VaultService.Models;
using Oci.VaultService.Requests;
using Oci.VaultService.Responses;

namespace Oci.VaultService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of Vaults.
    /// </summary>
    public class VaultsWaiters
    {
        private readonly VaultsClient client;

        public  VaultsWaiters(VaultsClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetSecretRequest, GetSecretResponse> ForSecret(GetSecretRequest request, params Secret.LifecycleStateEnum[] targetStates)
        {
            return this.ForSecret(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetSecretRequest, GetSecretResponse> ForSecret(GetSecretRequest request, WaiterConfiguration config, params Secret.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetSecretRequest, GetSecretResponse>(
                request,
                request => client.GetSecret(request),
                response => targetStates.Contains(response.Secret.LifecycleState.Value),
                targetStates.Contains(Secret.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetSecretRequest, GetSecretResponse>(config, agent);
        }
    }
}
