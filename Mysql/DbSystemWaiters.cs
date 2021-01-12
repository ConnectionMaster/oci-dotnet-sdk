/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.MysqlService.Models;
using Oci.MysqlService.Requests;
using Oci.MysqlService.Responses;

namespace Oci.MysqlService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of DbSystem.
    /// </summary>
    public class DbSystemWaiters
    {
        private readonly DbSystemClient client;

        public  DbSystemWaiters(DbSystemClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetAnalyticsClusterRequest, GetAnalyticsClusterResponse> ForAnalyticsCluster(GetAnalyticsClusterRequest request, params AnalyticsCluster.LifecycleStateEnum[] targetStates)
        {
            return this.ForAnalyticsCluster(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetAnalyticsClusterRequest, GetAnalyticsClusterResponse> ForAnalyticsCluster(GetAnalyticsClusterRequest request, WaiterConfiguration config, params AnalyticsCluster.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetAnalyticsClusterRequest, GetAnalyticsClusterResponse>(
                request,
                request => client.GetAnalyticsCluster(request),
                response => targetStates.Contains(response.AnalyticsCluster.LifecycleState.Value),
                targetStates.Contains(AnalyticsCluster.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetAnalyticsClusterRequest, GetAnalyticsClusterResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDbSystemRequest, GetDbSystemResponse> ForDbSystem(GetDbSystemRequest request, params DbSystem.LifecycleStateEnum[] targetStates)
        {
            return this.ForDbSystem(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDbSystemRequest, GetDbSystemResponse> ForDbSystem(GetDbSystemRequest request, WaiterConfiguration config, params DbSystem.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetDbSystemRequest, GetDbSystemResponse>(
                request,
                request => client.GetDbSystem(request),
                response => targetStates.Contains(response.DbSystem.LifecycleState.Value),
                targetStates.Contains(DbSystem.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetDbSystemRequest, GetDbSystemResponse>(config, agent);
        }
    }
}
