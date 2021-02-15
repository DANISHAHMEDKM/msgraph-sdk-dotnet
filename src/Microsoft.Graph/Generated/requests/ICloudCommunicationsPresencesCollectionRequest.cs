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
    /// The interface ICloudCommunicationsPresencesCollectionRequest.
    /// </summary>
    public partial interface ICloudCommunicationsPresencesCollectionRequest : IBaseRequest
    {
        
        /// <summary>
        /// Adds the specified Presence to the collection via POST.
        /// </summary>
        /// <param name="presence">The Presence to add.</param>
        /// <returns>The created Presence.</returns>
        System.Threading.Tasks.Task<Presence> AddAsync(Presence presence);

        /// <summary>
        /// Adds the specified Presence to the collection via POST.
        /// </summary>
        /// <param name="presence">The Presence to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Presence.</returns>
        System.Threading.Tasks.Task<Presence> AddAsync(Presence presence, CancellationToken cancellationToken);
        
        /// <summary>
        /// Adds the specified Presence to the collection via POST and returns a <see cref="GraphResponse{Presence}"/> object of the request.
        /// </summary>
        /// <param name="presence">The Presence to add.</param>
        /// <returns>The <see cref="GraphResponse{Presence}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Presence>> AddResponseAsync(Presence presence);

        /// <summary>
        /// Adds the specified Presence to the collection via POST and returns a <see cref="GraphResponse{Presence}"/> object of the request.
        /// </summary>
        /// <param name="presence">The Presence to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Presence}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Presence>> AddResponseAsync(Presence presence, CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<ICloudCommunicationsPresencesCollectionPage> GetAsync();

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<ICloudCommunicationsPresencesCollectionPage> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{CloudCommunicationsPresencesCollectionResponse}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{CloudCommunicationsPresencesCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<CloudCommunicationsPresencesCollectionResponse>> GetResponseAsync();

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{CloudCommunicationsPresencesCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CloudCommunicationsPresencesCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<CloudCommunicationsPresencesCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ICloudCommunicationsPresencesCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ICloudCommunicationsPresencesCollectionRequest Expand(Expression<Func<Presence, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ICloudCommunicationsPresencesCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ICloudCommunicationsPresencesCollectionRequest Select(Expression<Func<Presence, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        ICloudCommunicationsPresencesCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        ICloudCommunicationsPresencesCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        ICloudCommunicationsPresencesCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        ICloudCommunicationsPresencesCollectionRequest OrderBy(string value);
    }
}
