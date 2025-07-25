/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Oci.Common;
using Oci.Common.DeveloperToolConfigurations;
using Oci.Common.Model;
using Oci.Common.Auth;
using Oci.Common.Retry;
using Oci.DbmulticloudService.Requests;
using Oci.DbmulticloudService.Responses;

namespace Oci.DbmulticloudService
{
    /// <summary>Service client instance for OracleDbAzureVaultAssociation.</summary>
    public class OracleDbAzureVaultAssociationClient : RegionalClientBase
    {
        private readonly RetryConfiguration retryConfiguration;
        private const string basePathWithoutHost = "/20240501";

        public OracleDbAzureVaultAssociationPaginators Paginators { get; }

        public OracleDbAzureVaultAssociationWaiters Waiters { get; }

        /// <summary>
        /// Creates a new service instance using the given authentication provider and/or client configuration and/or endpoint.
        /// A client configuration can also be provided optionally to adjust REST client behaviors.
        /// </summary>
        /// <param name="authenticationDetailsProvider">The authentication details provider. Required.</param>
        /// <param name="clientConfiguration">The client configuration that contains settings to adjust REST client behaviors. Optional.</param>
        /// <param name="endpoint">The endpoint of the service. If not provided and the client is a regional client, the endpoint will be constructed based on region information. Optional.</param>
        public OracleDbAzureVaultAssociationClient(IBasicAuthenticationDetailsProvider authenticationDetailsProvider, ClientConfiguration clientConfiguration = null, string endpoint = null)
            : base(authenticationDetailsProvider, clientConfiguration)
        {
            if (!DeveloperToolConfiguration.IsServiceEnabled("dbmulticloud"))
            {
                throw new ArgumentException("The DeveloperToolConfiguration disabled this service, this behavior is controlled by DeveloperToolConfiguration.OciEnabledServiceSet variable. Please check if your local DeveloperToolConfiguration file has configured the service you're targeting or contact the cloud provider on the availability of this service");
            }
            service = new Service
            {
                ServiceName = "ORACLEDBAZUREVAULTASSOCIATION",
                ServiceEndpointPrefix = "",
                ServiceEndpointTemplate = "https://dbmulticloud.{region}.oci.{secondLevelDomain}"
            };

            ClientConfiguration clientConfigurationToUse = clientConfiguration ?? new ClientConfiguration();

            if (authenticationDetailsProvider is IRegionProvider)
            {
                // Use region from Authentication details provider.
                SetRegion(((IRegionProvider)authenticationDetailsProvider).Region);
            }

            if (endpoint != null)
            {
                logger.Info($"Using endpoint specified \"{endpoint}\".");
                SetEndpoint(endpoint);
            }

            this.retryConfiguration = clientConfigurationToUse.RetryConfiguration;
            Paginators = new OracleDbAzureVaultAssociationPaginators(this);
            Waiters = new OracleDbAzureVaultAssociationWaiters(this);
        }

        /// <summary>
        /// Delete Oracle DB Azure Vault Association details.
        /// 
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <param name="completionOption">The completion option for this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        /// <example>Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/dbmulticloud/CascadingDeleteOracleDbAzureVaultAssociation.cs.html">here</a> to see an example of how to use CascadingDeleteOracleDbAzureVaultAssociation API.</example>
        public async Task<CascadingDeleteOracleDbAzureVaultAssociationResponse> CascadingDeleteOracleDbAzureVaultAssociation(CascadingDeleteOracleDbAzureVaultAssociationRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead)
        {
            logger.Trace("Called cascadingDeleteOracleDbAzureVaultAssociation");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/oracleDbAzureVaultAssociation/{oracleDbAzureVaultAssociationId}/actions/cascadingDelete".Trim('/')));
            HttpMethod method = new HttpMethod("POST");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, completionOption, cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage, completionOption: completionOption).ConfigureAwait(false);
                }
                stopWatch.Stop();
                ApiDetails apiDetails = new ApiDetails
                {
                    ServiceName = "OracleDbAzureVaultAssociation",
                    OperationName = "CascadingDeleteOracleDbAzureVaultAssociation",
                    RequestEndpoint = $"{method.Method} {requestMessage.RequestUri}",
                    ApiReferenceLink = "https://docs.oracle.com/iaas/api/#/en/database-multicloud-integrations/20240501/OracleDbAzureVaultAssociation/CascadingDeleteOracleDbAzureVaultAssociation",
                    UserAgent = this.GetUserAgent()
                };
                this.restClient.CheckHttpResponseMessage(requestMessage, responseMessage, apiDetails);
                logger.Debug($"Total Latency for this API call is: {stopWatch.ElapsedMilliseconds} ms");
                return Converter.FromHttpResponseMessage<CascadingDeleteOracleDbAzureVaultAssociationResponse>(responseMessage);
            }
            catch (OciException e)
            {
                logger.Error(e);
                throw;
            }
            catch (Exception e)
            {
                logger.Error($"CascadingDeleteOracleDbAzureVaultAssociation failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Moves the Oracle DB Azure Vault Association resource into a different compartment. When provided, &#39;If-Match&#39; is checked against &#39;ETag&#39; values of the resource.
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <param name="completionOption">The completion option for this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        /// <example>Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/dbmulticloud/ChangeOracleDbAzureVaultAssociationCompartment.cs.html">here</a> to see an example of how to use ChangeOracleDbAzureVaultAssociationCompartment API.</example>
        public async Task<ChangeOracleDbAzureVaultAssociationCompartmentResponse> ChangeOracleDbAzureVaultAssociationCompartment(ChangeOracleDbAzureVaultAssociationCompartmentRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead)
        {
            logger.Trace("Called changeOracleDbAzureVaultAssociationCompartment");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/oracleDbAzureVaultAssociation/{oracleDbAzureVaultAssociationId}/actions/changeCompartment".Trim('/')));
            HttpMethod method = new HttpMethod("POST");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, completionOption, cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage, completionOption: completionOption).ConfigureAwait(false);
                }
                stopWatch.Stop();
                ApiDetails apiDetails = new ApiDetails
                {
                    ServiceName = "OracleDbAzureVaultAssociation",
                    OperationName = "ChangeOracleDbAzureVaultAssociationCompartment",
                    RequestEndpoint = $"{method.Method} {requestMessage.RequestUri}",
                    ApiReferenceLink = "https://docs.oracle.com/iaas/api/#/en/database-multicloud-integrations/20240501/OracleDbAzureVaultAssociation/ChangeOracleDbAzureVaultAssociationCompartment",
                    UserAgent = this.GetUserAgent()
                };
                this.restClient.CheckHttpResponseMessage(requestMessage, responseMessage, apiDetails);
                logger.Debug($"Total Latency for this API call is: {stopWatch.ElapsedMilliseconds} ms");
                return Converter.FromHttpResponseMessage<ChangeOracleDbAzureVaultAssociationCompartmentResponse>(responseMessage);
            }
            catch (OciException e)
            {
                logger.Error(e);
                throw;
            }
            catch (Exception e)
            {
                logger.Error($"ChangeOracleDbAzureVaultAssociationCompartment failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Create Oracle DB Azure Vault Association based on the provided information.
        /// 
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <param name="completionOption">The completion option for this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        /// <example>Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/dbmulticloud/CreateOracleDbAzureVaultAssociation.cs.html">here</a> to see an example of how to use CreateOracleDbAzureVaultAssociation API.</example>
        public async Task<CreateOracleDbAzureVaultAssociationResponse> CreateOracleDbAzureVaultAssociation(CreateOracleDbAzureVaultAssociationRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead)
        {
            logger.Trace("Called createOracleDbAzureVaultAssociation");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/oracleDbAzureVaultAssociation".Trim('/')));
            HttpMethod method = new HttpMethod("POST");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, completionOption, cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage, completionOption: completionOption).ConfigureAwait(false);
                }
                stopWatch.Stop();
                ApiDetails apiDetails = new ApiDetails
                {
                    ServiceName = "OracleDbAzureVaultAssociation",
                    OperationName = "CreateOracleDbAzureVaultAssociation",
                    RequestEndpoint = $"{method.Method} {requestMessage.RequestUri}",
                    ApiReferenceLink = "https://docs.oracle.com/iaas/api/#/en/database-multicloud-integrations/20240501/OracleDbAzureVaultAssociation/CreateOracleDbAzureVaultAssociation",
                    UserAgent = this.GetUserAgent()
                };
                this.restClient.CheckHttpResponseMessage(requestMessage, responseMessage, apiDetails);
                logger.Debug($"Total Latency for this API call is: {stopWatch.ElapsedMilliseconds} ms");
                return Converter.FromHttpResponseMessage<CreateOracleDbAzureVaultAssociationResponse>(responseMessage);
            }
            catch (OciException e)
            {
                logger.Error(e);
                throw;
            }
            catch (Exception e)
            {
                logger.Error($"CreateOracleDbAzureVaultAssociation failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Delete Oracle DB Azure Vault Association details.
        /// 
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <param name="completionOption">The completion option for this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        /// <example>Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/dbmulticloud/DeleteOracleDbAzureVaultAssociation.cs.html">here</a> to see an example of how to use DeleteOracleDbAzureVaultAssociation API.</example>
        public async Task<DeleteOracleDbAzureVaultAssociationResponse> DeleteOracleDbAzureVaultAssociation(DeleteOracleDbAzureVaultAssociationRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead)
        {
            logger.Trace("Called deleteOracleDbAzureVaultAssociation");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/oracleDbAzureVaultAssociation/{oracleDbAzureVaultAssociationId}".Trim('/')));
            HttpMethod method = new HttpMethod("DELETE");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, completionOption, cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage, completionOption: completionOption).ConfigureAwait(false);
                }
                stopWatch.Stop();
                ApiDetails apiDetails = new ApiDetails
                {
                    ServiceName = "OracleDbAzureVaultAssociation",
                    OperationName = "DeleteOracleDbAzureVaultAssociation",
                    RequestEndpoint = $"{method.Method} {requestMessage.RequestUri}",
                    ApiReferenceLink = "https://docs.oracle.com/iaas/api/#/en/database-multicloud-integrations/20240501/OracleDbAzureVaultAssociation/DeleteOracleDbAzureVaultAssociation",
                    UserAgent = this.GetUserAgent()
                };
                this.restClient.CheckHttpResponseMessage(requestMessage, responseMessage, apiDetails);
                logger.Debug($"Total Latency for this API call is: {stopWatch.ElapsedMilliseconds} ms");
                return Converter.FromHttpResponseMessage<DeleteOracleDbAzureVaultAssociationResponse>(responseMessage);
            }
            catch (OciException e)
            {
                logger.Error(e);
                throw;
            }
            catch (Exception e)
            {
                logger.Error($"DeleteOracleDbAzureVaultAssociation failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Get Oracle DB Azure Vault Details Association form a particular Container Resource ID.
        /// 
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <param name="completionOption">The completion option for this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        /// <example>Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/dbmulticloud/GetOracleDbAzureVaultAssociation.cs.html">here</a> to see an example of how to use GetOracleDbAzureVaultAssociation API.</example>
        public async Task<GetOracleDbAzureVaultAssociationResponse> GetOracleDbAzureVaultAssociation(GetOracleDbAzureVaultAssociationRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead)
        {
            logger.Trace("Called getOracleDbAzureVaultAssociation");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/oracleDbAzureVaultAssociation/{oracleDbAzureVaultAssociationId}".Trim('/')));
            HttpMethod method = new HttpMethod("GET");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, completionOption, cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage, completionOption: completionOption).ConfigureAwait(false);
                }
                stopWatch.Stop();
                ApiDetails apiDetails = new ApiDetails
                {
                    ServiceName = "OracleDbAzureVaultAssociation",
                    OperationName = "GetOracleDbAzureVaultAssociation",
                    RequestEndpoint = $"{method.Method} {requestMessage.RequestUri}",
                    ApiReferenceLink = "https://docs.oracle.com/iaas/api/#/en/database-multicloud-integrations/20240501/OracleDbAzureVaultAssociation/GetOracleDbAzureVaultAssociation",
                    UserAgent = this.GetUserAgent()
                };
                this.restClient.CheckHttpResponseMessage(requestMessage, responseMessage, apiDetails);
                logger.Debug($"Total Latency for this API call is: {stopWatch.ElapsedMilliseconds} ms");
                return Converter.FromHttpResponseMessage<GetOracleDbAzureVaultAssociationResponse>(responseMessage);
            }
            catch (OciException e)
            {
                logger.Error(e);
                throw;
            }
            catch (Exception e)
            {
                logger.Error($"GetOracleDbAzureVaultAssociation failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Lists the all Oracle DB Azure Associations based on filters.
        /// 
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <param name="completionOption">The completion option for this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        /// <example>Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/dbmulticloud/ListOracleDbAzureVaultAssociations.cs.html">here</a> to see an example of how to use ListOracleDbAzureVaultAssociations API.</example>
        public async Task<ListOracleDbAzureVaultAssociationsResponse> ListOracleDbAzureVaultAssociations(ListOracleDbAzureVaultAssociationsRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead)
        {
            logger.Trace("Called listOracleDbAzureVaultAssociations");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/oracleDbAzureVaultAssociation".Trim('/')));
            HttpMethod method = new HttpMethod("GET");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, completionOption, cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage, completionOption: completionOption).ConfigureAwait(false);
                }
                stopWatch.Stop();
                ApiDetails apiDetails = new ApiDetails
                {
                    ServiceName = "OracleDbAzureVaultAssociation",
                    OperationName = "ListOracleDbAzureVaultAssociations",
                    RequestEndpoint = $"{method.Method} {requestMessage.RequestUri}",
                    ApiReferenceLink = "https://docs.oracle.com/iaas/api/#/en/database-multicloud-integrations/20240501/OracleDbAzureVaultAssociation/ListOracleDbAzureVaultAssociations",
                    UserAgent = this.GetUserAgent()
                };
                this.restClient.CheckHttpResponseMessage(requestMessage, responseMessage, apiDetails);
                logger.Debug($"Total Latency for this API call is: {stopWatch.ElapsedMilliseconds} ms");
                return Converter.FromHttpResponseMessage<ListOracleDbAzureVaultAssociationsResponse>(responseMessage);
            }
            catch (OciException e)
            {
                logger.Error(e);
                throw;
            }
            catch (Exception e)
            {
                logger.Error($"ListOracleDbAzureVaultAssociations failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Modifies the existing Oracle DB Azure Vault Association Details for a given ID.
        /// 
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <param name="completionOption">The completion option for this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        /// <example>Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/dbmulticloud/UpdateOracleDbAzureVaultAssociation.cs.html">here</a> to see an example of how to use UpdateOracleDbAzureVaultAssociation API.</example>
        public async Task<UpdateOracleDbAzureVaultAssociationResponse> UpdateOracleDbAzureVaultAssociation(UpdateOracleDbAzureVaultAssociationRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead)
        {
            logger.Trace("Called updateOracleDbAzureVaultAssociation");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/oracleDbAzureVaultAssociation/{oracleDbAzureVaultAssociationId}".Trim('/')));
            HttpMethod method = new HttpMethod("PUT");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, completionOption, cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage, completionOption: completionOption).ConfigureAwait(false);
                }
                stopWatch.Stop();
                ApiDetails apiDetails = new ApiDetails
                {
                    ServiceName = "OracleDbAzureVaultAssociation",
                    OperationName = "UpdateOracleDbAzureVaultAssociation",
                    RequestEndpoint = $"{method.Method} {requestMessage.RequestUri}",
                    ApiReferenceLink = "https://docs.oracle.com/iaas/api/#/en/database-multicloud-integrations/20240501/OracleDbAzureVaultAssociation/UpdateOracleDbAzureVaultAssociation",
                    UserAgent = this.GetUserAgent()
                };
                this.restClient.CheckHttpResponseMessage(requestMessage, responseMessage, apiDetails);
                logger.Debug($"Total Latency for this API call is: {stopWatch.ElapsedMilliseconds} ms");
                return Converter.FromHttpResponseMessage<UpdateOracleDbAzureVaultAssociationResponse>(responseMessage);
            }
            catch (OciException e)
            {
                logger.Error(e);
                throw;
            }
            catch (Exception e)
            {
                logger.Error($"UpdateOracleDbAzureVaultAssociation failed with error: {e.Message}");
                throw;
            }
        }

    }
}
