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
    /// The interface IServicePrincipalAppRoleAssignedToCollectionRequest.
    /// </summary>
    public partial interface IServicePrincipalAppRoleAssignedToCollectionRequest : IBaseRequest
    {
        
        /// <summary>
        /// Adds the specified AppRoleAssignment to the collection via POST.
        /// </summary>
        /// <param name="appRoleAssignment">The AppRoleAssignment to add.</param>
        /// <returns>The created AppRoleAssignment.</returns>
        System.Threading.Tasks.Task<AppRoleAssignment> AddAsync(AppRoleAssignment appRoleAssignment);

        /// <summary>
        /// Adds the specified AppRoleAssignment to the collection via POST.
        /// </summary>
        /// <param name="appRoleAssignment">The AppRoleAssignment to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AppRoleAssignment.</returns>
        System.Threading.Tasks.Task<AppRoleAssignment> AddAsync(AppRoleAssignment appRoleAssignment, CancellationToken cancellationToken);
        
        /// <summary>
        /// Adds the specified AppRoleAssignment to the collection via POST and returns a <see cref="GraphResponse{AppRoleAssignment}"/> object of the request.
        /// </summary>
        /// <param name="appRoleAssignment">The AppRoleAssignment to add.</param>
        /// <returns>The <see cref="GraphResponse{AppRoleAssignment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AppRoleAssignment>> AddResponseAsync(AppRoleAssignment appRoleAssignment);

        /// <summary>
        /// Adds the specified AppRoleAssignment to the collection via POST and returns a <see cref="GraphResponse{AppRoleAssignment}"/> object of the request.
        /// </summary>
        /// <param name="appRoleAssignment">The AppRoleAssignment to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AppRoleAssignment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AppRoleAssignment>> AddResponseAsync(AppRoleAssignment appRoleAssignment, CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IServicePrincipalAppRoleAssignedToCollectionPage> GetAsync();

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IServicePrincipalAppRoleAssignedToCollectionPage> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{ServicePrincipalAppRoleAssignedToCollectionResponse}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{ServicePrincipalAppRoleAssignedToCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<ServicePrincipalAppRoleAssignedToCollectionResponse>> GetResponseAsync();

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{ServicePrincipalAppRoleAssignedToCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ServicePrincipalAppRoleAssignedToCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<ServicePrincipalAppRoleAssignedToCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IServicePrincipalAppRoleAssignedToCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IServicePrincipalAppRoleAssignedToCollectionRequest Expand(Expression<Func<AppRoleAssignment, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IServicePrincipalAppRoleAssignedToCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IServicePrincipalAppRoleAssignedToCollectionRequest Select(Expression<Func<AppRoleAssignment, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IServicePrincipalAppRoleAssignedToCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IServicePrincipalAppRoleAssignedToCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IServicePrincipalAppRoleAssignedToCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IServicePrincipalAppRoleAssignedToCollectionRequest OrderBy(string value);
    }
}
