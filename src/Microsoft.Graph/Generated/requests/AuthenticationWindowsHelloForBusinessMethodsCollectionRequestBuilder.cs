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
    /// The type AuthenticationWindowsHelloForBusinessMethodsCollectionRequestBuilder.
    /// </summary>
    public partial class AuthenticationWindowsHelloForBusinessMethodsCollectionRequestBuilder : BaseRequestBuilder, IAuthenticationWindowsHelloForBusinessMethodsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new AuthenticationWindowsHelloForBusinessMethodsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public AuthenticationWindowsHelloForBusinessMethodsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IAuthenticationWindowsHelloForBusinessMethodsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IAuthenticationWindowsHelloForBusinessMethodsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new AuthenticationWindowsHelloForBusinessMethodsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IWindowsHelloForBusinessAuthenticationMethodRequestBuilder"/> for the specified AuthenticationWindowsHelloForBusinessAuthenticationMethod.
        /// </summary>
        /// <param name="id">The ID for the AuthenticationWindowsHelloForBusinessAuthenticationMethod.</param>
        /// <returns>The <see cref="IWindowsHelloForBusinessAuthenticationMethodRequestBuilder"/>.</returns>
        public IWindowsHelloForBusinessAuthenticationMethodRequestBuilder this[string id]
        {
            get
            {
                return new WindowsHelloForBusinessAuthenticationMethodRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}