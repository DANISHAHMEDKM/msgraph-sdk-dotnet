// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityWithReferenceRequestBuilder.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type EdiscoveryReviewTagWithReferenceRequestBuilder.
    /// </summary>
    public partial class EdiscoveryReviewTagWithReferenceRequestBuilder : Microsoft.Graph.BaseRequestBuilder, IEdiscoveryReviewTagWithReferenceRequestBuilder
    {

        /// <summary>
        /// Constructs a new EdiscoveryReviewTagWithReferenceRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        public EdiscoveryReviewTagWithReferenceRequestBuilder(
            string requestUrl,
            Microsoft.Graph.IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IEdiscoveryReviewTagWithReferenceRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IEdiscoveryReviewTagWithReferenceRequest Request(IEnumerable<Microsoft.Graph.Option> options)
        {
            return new EdiscoveryReviewTagWithReferenceRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets the request builder for the reference of the ediscoveryReviewTag.
        /// </summary>
        /// <returns>The <see cref="IEdiscoveryReviewTagReferenceRequestBuilder"/>.</returns>
        public IEdiscoveryReviewTagReferenceRequestBuilder Reference
        {
            get
            {
                return new EdiscoveryReviewTagReferenceRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}