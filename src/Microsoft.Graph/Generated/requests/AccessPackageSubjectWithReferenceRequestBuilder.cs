// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityWithReferenceRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type AccessPackageSubjectWithReferenceRequestBuilder.
    /// </summary>
    public partial class AccessPackageSubjectWithReferenceRequestBuilder : BaseRequestBuilder, IAccessPackageSubjectWithReferenceRequestBuilder
    {

        /// <summary>
        /// Constructs a new AccessPackageSubjectWithReferenceRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public AccessPackageSubjectWithReferenceRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IAccessPackageSubjectWithReferenceRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IAccessPackageSubjectWithReferenceRequest Request(IEnumerable<Option> options)
        {
            return new AccessPackageSubjectWithReferenceRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets the request builder for the reference of the accessPackageSubject.
        /// </summary>
        /// <returns>The <see cref="IAccessPackageSubjectReferenceRequestBuilder"/>.</returns>
        public IAccessPackageSubjectReferenceRequestBuilder Reference
        {
            get
            {
                return new AccessPackageSubjectReferenceRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}