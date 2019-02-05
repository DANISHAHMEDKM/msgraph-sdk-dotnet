// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type OnenoteNotebooksCollectionRequestBuilder.
    /// </summary>
    public partial class OnenoteNotebooksCollectionRequestBuilder : BaseRequestBuilder, IOnenoteNotebooksCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new OnenoteNotebooksCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public OnenoteNotebooksCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IOnenoteNotebooksCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IOnenoteNotebooksCollectionRequest Request(IEnumerable<Option> options)
        {
            return new OnenoteNotebooksCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="INotebookRequestBuilder"/> for the specified OnenoteNotebook.
        /// </summary>
        /// <param name="id">The ID for the OnenoteNotebook.</param>
        /// <returns>The <see cref="INotebookRequestBuilder"/>.</returns>
        public INotebookRequestBuilder this[string id]
        {
            get
            {
                return new NotebookRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for NotebookGetNotebookFromWebUrl.
        /// </summary>
        /// <returns>The <see cref="INotebookGetNotebookFromWebUrlRequestBuilder"/>.</returns>
        public INotebookGetNotebookFromWebUrlRequestBuilder GetNotebookFromWebUrl(
            string webUrl = null)
        {
            return new NotebookGetNotebookFromWebUrlRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.getNotebookFromWebUrl"),
                this.Client,
                webUrl);
        }

        /// <summary>
        /// Gets the request builder for NotebookGetRecentNotebooks.
        /// </summary>
        /// <returns>The <see cref="INotebookGetRecentNotebooksRequestBuilder"/>.</returns>
        public INotebookGetRecentNotebooksRequestBuilder GetRecentNotebooks(
            bool includePersonalNotebooks)
        {
            return new NotebookGetRecentNotebooksRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.getRecentNotebooks"),
                this.Client,
                includePersonalNotebooks);
        }
    }
}
