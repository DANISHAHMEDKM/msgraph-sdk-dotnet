// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface INotebookSectionsCollectionRequest.
    /// </summary>
    public partial interface INotebookSectionsCollectionRequest : IBaseRequest
    {
        
        /// <summary>
        /// Adds the specified OnenoteSection to the collection via POST.
        /// </summary>
        /// <param name="onenoteSection">The OnenoteSection to add.</param>
        /// <returns>The created OnenoteSection.</returns>
        System.Threading.Tasks.Task<OnenoteSection> AddAsync(OnenoteSection onenoteSection);

        /// <summary>
        /// Adds the specified OnenoteSection to the collection via POST.
        /// </summary>
        /// <param name="onenoteSection">The OnenoteSection to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created OnenoteSection.</returns>
        System.Threading.Tasks.Task<OnenoteSection> AddAsync(OnenoteSection onenoteSection, CancellationToken cancellationToken);
        
        /// <summary>
        /// Adds the specified OnenoteSection to the collection via POST and returns a <see cref="GraphResponse{OnenoteSection}"/> object of the request.
        /// </summary>
        /// <param name="onenoteSection">The OnenoteSection to add.</param>
        /// <returns>The <see cref="GraphResponse{OnenoteSection}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<OnenoteSection>> AddResponseAsync(OnenoteSection onenoteSection);

        /// <summary>
        /// Adds the specified OnenoteSection to the collection via POST and returns a <see cref="GraphResponse{OnenoteSection}"/> object of the request.
        /// </summary>
        /// <param name="onenoteSection">The OnenoteSection to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{OnenoteSection}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<OnenoteSection>> AddResponseAsync(OnenoteSection onenoteSection, CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<INotebookSectionsCollectionPage> GetAsync();

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<INotebookSectionsCollectionPage> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{NotebookSectionsCollectionResponse}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{NotebookSectionsCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<NotebookSectionsCollectionResponse>> GetResponseAsync();

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{NotebookSectionsCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{NotebookSectionsCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<NotebookSectionsCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        INotebookSectionsCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        INotebookSectionsCollectionRequest Expand(Expression<Func<OnenoteSection, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        INotebookSectionsCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        INotebookSectionsCollectionRequest Select(Expression<Func<OnenoteSection, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        INotebookSectionsCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        INotebookSectionsCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        INotebookSectionsCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        INotebookSectionsCollectionRequest OrderBy(string value);
    }
}
