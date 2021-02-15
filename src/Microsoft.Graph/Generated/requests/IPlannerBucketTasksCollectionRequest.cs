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
    /// The interface IPlannerBucketTasksCollectionRequest.
    /// </summary>
    public partial interface IPlannerBucketTasksCollectionRequest : IBaseRequest
    {
        
        /// <summary>
        /// Adds the specified PlannerTask to the collection via POST.
        /// </summary>
        /// <param name="plannerTask">The PlannerTask to add.</param>
        /// <returns>The created PlannerTask.</returns>
        System.Threading.Tasks.Task<PlannerTask> AddAsync(PlannerTask plannerTask);

        /// <summary>
        /// Adds the specified PlannerTask to the collection via POST.
        /// </summary>
        /// <param name="plannerTask">The PlannerTask to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PlannerTask.</returns>
        System.Threading.Tasks.Task<PlannerTask> AddAsync(PlannerTask plannerTask, CancellationToken cancellationToken);
        
        /// <summary>
        /// Adds the specified PlannerTask to the collection via POST and returns a <see cref="GraphResponse{PlannerTask}"/> object of the request.
        /// </summary>
        /// <param name="plannerTask">The PlannerTask to add.</param>
        /// <returns>The <see cref="GraphResponse{PlannerTask}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PlannerTask>> AddResponseAsync(PlannerTask plannerTask);

        /// <summary>
        /// Adds the specified PlannerTask to the collection via POST and returns a <see cref="GraphResponse{PlannerTask}"/> object of the request.
        /// </summary>
        /// <param name="plannerTask">The PlannerTask to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PlannerTask}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PlannerTask>> AddResponseAsync(PlannerTask plannerTask, CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IPlannerBucketTasksCollectionPage> GetAsync();

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IPlannerBucketTasksCollectionPage> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{PlannerBucketTasksCollectionResponse}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{PlannerBucketTasksCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<PlannerBucketTasksCollectionResponse>> GetResponseAsync();

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{PlannerBucketTasksCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PlannerBucketTasksCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<PlannerBucketTasksCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IPlannerBucketTasksCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IPlannerBucketTasksCollectionRequest Expand(Expression<Func<PlannerTask, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IPlannerBucketTasksCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IPlannerBucketTasksCollectionRequest Select(Expression<Func<PlannerTask, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IPlannerBucketTasksCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IPlannerBucketTasksCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IPlannerBucketTasksCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IPlannerBucketTasksCollectionRequest OrderBy(string value);
    }
}
