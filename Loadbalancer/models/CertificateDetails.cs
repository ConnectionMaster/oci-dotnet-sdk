/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.LoadbalancerService.Models
{
    /// <summary>
    /// The configuration details for a certificate bundle.
    /// For more information on SSL certficate configuration, see
    /// [Managing SSL Certificates](https://docs.cloud.oracle.com/Content/Balance/Tasks/managingcertificates.htm).
    /// <br/>
    /// **Warning:** Oracle recommends that you avoid using any confidential information when you supply string values using the API.
    /// 
    /// </summary>
    public class CertificateDetails 
    {
        
        /// <value>
        /// A passphrase for encrypted private keys. This is needed only if you created your certificate with a passphrase.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "passphrase")]
        public string Passphrase { get; set; }
        
        /// <value>
        /// The SSL private key for your certificate, in PEM format.
        /// <br/>
        /// Example:     -----BEGIN RSA PRIVATE KEY-----    jO1O1v2ftXMsawM90tnXwc6xhOAT1gDBC9S8DKeca..JZNUgYYwNS0dP2UK    tmyN+XqVcAKw4HqVmChXy5b5msu8eIq3uc2NqNVtR..2ksSLukP8pxXcHyb    +sEwvM4uf8qbnHAqwnOnP9+KV9vds6BaH1eRA4CHz..n+NVZlzBsTxTlS16    /Umr7wJzVrMqK5sDiSu4WuaaBdqMGfL5hLsTjcBFD..Da2iyQmSKuVD4lIZ    ...    -----END RSA PRIVATE KEY-----
        /// </value>
        [JsonProperty(PropertyName = "privateKey")]
        public string PrivateKey { get; set; }
        
        /// <value>
        /// The public certificate, in PEM format, that you received from your SSL certificate provider.
        /// <br/>
        /// Example:     -----BEGIN CERTIFICATE-----    MIIC2jCCAkMCAg38MA0GCSqGSIb3DQEBBQUAMIGbMQswCQYDVQQGEwJKUDEOMAwG    A1UECBMFVG9reW8xEDAOBgNVBAcTB0NodW8ta3UxETAPBgNVBAoTCEZyYW5rNERE    MRgwFgYDVQQLEw9XZWJDZXJ0IFN1cHBvcnQxGDAWBgNVBAMTD0ZyYW5rNEREIFdl    YiBDQTEjMCEGCSqGSIb3DQEJARYUc3VwcG9ydEBmcmFuazRkZC5jb20wHhcNMTIw    ...    -----END CERTIFICATE-----
        /// </value>
        [JsonProperty(PropertyName = "publicCertificate")]
        public string PublicCertificate { get; set; }
        
        /// <value>
        /// The Certificate Authority certificate, or any interim certificate, that you received from your SSL certificate provider.
        /// <br/>
        /// Example:     -----BEGIN CERTIFICATE-----    MIIEczCCA1ugAwIBAgIBADANBgkqhkiG9w0BAQQFAD..AkGA1UEBhMCR0Ix    EzARBgNVBAgTClNvbWUtU3RhdGUxFDASBgNVBAoTC0..0EgTHRkMTcwNQYD    VQQLEy5DbGFzcyAxIFB1YmxpYyBQcmltYXJ5IENlcn..XRpb24gQXV0aG9y    aXR5MRQwEgYDVQQDEwtCZXN0IENBIEx0ZDAeFw0wMD..TUwMTZaFw0wMTAy    ...    -----END CERTIFICATE-----
        /// </value>
        [JsonProperty(PropertyName = "caCertificate")]
        public string CaCertificate { get; set; }
        
        /// <value>
        /// A friendly name for the certificate bundle. It must be unique and it cannot be changed.
        /// Valid certificate bundle names include only alphanumeric characters, dashes, and underscores.
        /// Certificate bundle names cannot contain spaces. Avoid entering confidential information.
        /// <br/>
        /// Example: example_certificate_bundle
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CertificateName is required.")]
        [JsonProperty(PropertyName = "certificateName")]
        public string CertificateName { get; set; }
        
    }
}
