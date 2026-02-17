/*
 * Copyright (c) 2020, 2026, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.IO;
using System.Threading.Tasks;
using Oci.Common;
using Oci.Common.Auth;
using Oci.ObjectstorageService;
using Oci.ObjectstorageService.Models;
using Oci.ObjectstorageService.Requests;
using Oci.ObjectstorageService.Responses;

namespace Oci.Examples
{
    public class EnableDualStackEndpointsExample
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public static async Task MainEnableDualStackEndpointsExample()
        {
            var provider = new ConfigFileAuthenticationDetailsProvider("DEFAULT");
            var osClient = new ObjectStorageClient(provider, new ClientConfiguration());
            osClient.EnableDualStackEndpoints(true);
            // env variable to enable dual stack OCI_DUAL_STACK_ENDPOINT_ENABLED=true
            try
            {
                // Get current namespace
                var namespaceResponse = await osClient.GetNamespace(new GetNamespaceRequest { });
                var namespaceName = namespaceResponse.Value;
                logger.Info($"Using namespace:{namespaceName}");

                // list all buckets
                var listBucketsRequest = new ListBucketsRequest
                {
                    NamespaceName = namespaceName,
                    CompartmentId = provider.TenantId,
                };

                string nextToken = null;
                do
                {
                    listBucketsRequest.Page = nextToken;
                    var listBucketsResponse = await osClient.ListBuckets(listBucketsRequest);
                    foreach (var bucketSummary in listBucketsResponse.Items)
                    {
                       logger.Info($"Found bucket: {bucketSummary.Name} in the list of buckets");
                    }
                    nextToken = listBucketsResponse.OpcNextPage;
                } while (nextToken != null);

            }
            catch (Exception e)
            {
                logger.Error($"Failed EnableDualStackEndpointsExample: {e.Message}");
            }
            finally
            {
                osClient.Dispose();
            }
        }
    }
}
