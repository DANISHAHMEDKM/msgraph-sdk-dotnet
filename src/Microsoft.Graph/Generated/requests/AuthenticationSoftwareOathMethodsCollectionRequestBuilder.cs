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
    /// The type AuthenticationSoftwareOathMethodsCollectionRequestBuilder.
    /// </summary>
    public partial class AuthenticationSoftwareOathMethodsCollectionRequestBuilder : BaseRequestBuilder, IAuthenticationSoftwareOathMethodsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new AuthenticationSoftwareOathMethodsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public AuthenticationSoftwareOathMethodsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IAuthenticationSoftwareOathMethodsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IAuthenticationSoftwareOathMethodsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new AuthenticationSoftwareOathMethodsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ISoftwareOathAuthenticationMethodRequestBuilder"/> for the specified AuthenticationSoftwareOathAuthenticationMethod.
        /// </summary>
        /// <param name="id">The ID for the AuthenticationSoftwareOathAuthenticationMethod.</param>
        /// <returns>The <see cref="ISoftwareOathAuthenticationMethodRequestBuilder"/>.</returns>
        public ISoftwareOathAuthenticationMethodRequestBuilder this[string id]
        {
            get
            {
                return new SoftwareOathAuthenticationMethodRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}