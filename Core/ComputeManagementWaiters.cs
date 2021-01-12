/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.CoreService.Models;
using Oci.CoreService.Requests;
using Oci.CoreService.Responses;

namespace Oci.CoreService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of ComputeManagement.
    /// </summary>
    public class ComputeManagementWaiters
    {
        private readonly ComputeManagementClient client;
        private readonly Oci.WorkrequestsService.WorkRequestClient workRequestClient;

        public  ComputeManagementWaiters(ComputeManagementClient client, Oci.WorkrequestsService.WorkRequestClient workRequestClient)
        {
            this.client = client;
            this.workRequestClient = workRequestClient;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="statuses">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<CreateClusterNetworkRequest, CreateClusterNetworkResponse> ForCreateClusterNetwork(CreateClusterNetworkRequest request, params WorkrequestsService.Models.WorkRequest.StatusEnum[] targetStates)
        {
            return this.ForCreateClusterNetwork(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<CreateClusterNetworkRequest, CreateClusterNetworkResponse> ForCreateClusterNetwork(CreateClusterNetworkRequest request, WaiterConfiguration config, params WorkrequestsService.Models.WorkRequest.StatusEnum[] targetStates)
        {
            return new Waiter<CreateClusterNetworkRequest, CreateClusterNetworkResponse>(() =>
            {
                var response = client.CreateClusterNetwork(request).Result;
                var getWorkRequestRequest = new Oci.WorkrequestsService.Requests.GetWorkRequestRequest
                {
                    WorkRequestId = response.OpcWorkRequestId
                };
                workRequestClient.Waiters.ForWorkRequest(getWorkRequestRequest, config, targetStates).Execute();
                return response;
            });
        }
        
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetClusterNetworkRequest, GetClusterNetworkResponse> ForClusterNetwork(GetClusterNetworkRequest request, params ClusterNetwork.LifecycleStateEnum[] targetStates)
        {
            return this.ForClusterNetwork(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetClusterNetworkRequest, GetClusterNetworkResponse> ForClusterNetwork(GetClusterNetworkRequest request, WaiterConfiguration config, params ClusterNetwork.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetClusterNetworkRequest, GetClusterNetworkResponse>(
                request,
                request => client.GetClusterNetwork(request),
                response => targetStates.Contains(response.ClusterNetwork.LifecycleState.Value),
                targetStates.Contains(ClusterNetwork.LifecycleStateEnum.Terminated)
            );
            return new Waiter<GetClusterNetworkRequest, GetClusterNetworkResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetInstancePoolRequest, GetInstancePoolResponse> ForInstancePool(GetInstancePoolRequest request, params InstancePool.LifecycleStateEnum[] targetStates)
        {
            return this.ForInstancePool(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetInstancePoolRequest, GetInstancePoolResponse> ForInstancePool(GetInstancePoolRequest request, WaiterConfiguration config, params InstancePool.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetInstancePoolRequest, GetInstancePoolResponse>(
                request,
                request => client.GetInstancePool(request),
                response => targetStates.Contains(response.InstancePool.LifecycleState.Value),
                targetStates.Contains(InstancePool.LifecycleStateEnum.Terminated)
            );
            return new Waiter<GetInstancePoolRequest, GetInstancePoolResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetInstancePoolLoadBalancerAttachmentRequest, GetInstancePoolLoadBalancerAttachmentResponse> ForInstancePoolLoadBalancerAttachment(GetInstancePoolLoadBalancerAttachmentRequest request, params InstancePoolLoadBalancerAttachment.LifecycleStateEnum[] targetStates)
        {
            return this.ForInstancePoolLoadBalancerAttachment(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetInstancePoolLoadBalancerAttachmentRequest, GetInstancePoolLoadBalancerAttachmentResponse> ForInstancePoolLoadBalancerAttachment(GetInstancePoolLoadBalancerAttachmentRequest request, WaiterConfiguration config, params InstancePoolLoadBalancerAttachment.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetInstancePoolLoadBalancerAttachmentRequest, GetInstancePoolLoadBalancerAttachmentResponse>(
                request,
                request => client.GetInstancePoolLoadBalancerAttachment(request),
                response => targetStates.Contains(response.InstancePoolLoadBalancerAttachment.LifecycleState.Value)
            );
            return new Waiter<GetInstancePoolLoadBalancerAttachmentRequest, GetInstancePoolLoadBalancerAttachmentResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="statuses">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<LaunchInstanceConfigurationRequest, LaunchInstanceConfigurationResponse> ForLaunchInstanceConfiguration(LaunchInstanceConfigurationRequest request, params WorkrequestsService.Models.WorkRequest.StatusEnum[] targetStates)
        {
            return this.ForLaunchInstanceConfiguration(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<LaunchInstanceConfigurationRequest, LaunchInstanceConfigurationResponse> ForLaunchInstanceConfiguration(LaunchInstanceConfigurationRequest request, WaiterConfiguration config, params WorkrequestsService.Models.WorkRequest.StatusEnum[] targetStates)
        {
            return new Waiter<LaunchInstanceConfigurationRequest, LaunchInstanceConfigurationResponse>(() =>
            {
                var response = client.LaunchInstanceConfiguration(request).Result;
                var getWorkRequestRequest = new Oci.WorkrequestsService.Requests.GetWorkRequestRequest
                {
                    WorkRequestId = response.OpcWorkRequestId
                };
                workRequestClient.Waiters.ForWorkRequest(getWorkRequestRequest, config, targetStates).Execute();
                return response;
            });
        }
        
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="statuses">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<TerminateClusterNetworkRequest, TerminateClusterNetworkResponse> ForTerminateClusterNetwork(TerminateClusterNetworkRequest request, params WorkrequestsService.Models.WorkRequest.StatusEnum[] targetStates)
        {
            return this.ForTerminateClusterNetwork(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<TerminateClusterNetworkRequest, TerminateClusterNetworkResponse> ForTerminateClusterNetwork(TerminateClusterNetworkRequest request, WaiterConfiguration config, params WorkrequestsService.Models.WorkRequest.StatusEnum[] targetStates)
        {
            return new Waiter<TerminateClusterNetworkRequest, TerminateClusterNetworkResponse>(() =>
            {
                var response = client.TerminateClusterNetwork(request).Result;
                var getWorkRequestRequest = new Oci.WorkrequestsService.Requests.GetWorkRequestRequest
                {
                    WorkRequestId = response.OpcWorkRequestId
                };
                workRequestClient.Waiters.ForWorkRequest(getWorkRequestRequest, config, targetStates).Execute();
                return response;
            });
        }
        
    }
}
