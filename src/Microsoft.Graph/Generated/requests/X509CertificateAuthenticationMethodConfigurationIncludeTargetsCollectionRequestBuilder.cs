// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type X509CertificateAuthenticationMethodConfigurationIncludeTargetsCollectionRequestBuilder.
    /// </summary>
    public partial class X509CertificateAuthenticationMethodConfigurationIncludeTargetsCollectionRequestBuilder : BaseRequestBuilder, IX509CertificateAuthenticationMethodConfigurationIncludeTargetsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new X509CertificateAuthenticationMethodConfigurationIncludeTargetsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public X509CertificateAuthenticationMethodConfigurationIncludeTargetsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IX509CertificateAuthenticationMethodConfigurationIncludeTargetsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IX509CertificateAuthenticationMethodConfigurationIncludeTargetsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new X509CertificateAuthenticationMethodConfigurationIncludeTargetsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IAuthenticationMethodTargetRequestBuilder"/> for the specified X509CertificateAuthenticationMethodConfigurationAuthenticationMethodTarget.
        /// </summary>
        /// <param name="id">The ID for the X509CertificateAuthenticationMethodConfigurationAuthenticationMethodTarget.</param>
        /// <returns>The <see cref="IAuthenticationMethodTargetRequestBuilder"/>.</returns>
        public IAuthenticationMethodTargetRequestBuilder this[string id]
        {
            get
            {
                return new AuthenticationMethodTargetRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}