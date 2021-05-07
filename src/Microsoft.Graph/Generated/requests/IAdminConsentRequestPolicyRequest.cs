// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IAdminConsentRequestPolicyRequest.
    /// </summary>
    public partial interface IAdminConsentRequestPolicyRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AdminConsentRequestPolicy using POST.
        /// </summary>
        /// <param name="adminConsentRequestPolicyToCreate">The AdminConsentRequestPolicy to create.</param>
        /// <returns>The created AdminConsentRequestPolicy.</returns>
        System.Threading.Tasks.Task<AdminConsentRequestPolicy> CreateAsync(AdminConsentRequestPolicy adminConsentRequestPolicyToCreate);        /// <summary>
        /// Creates the specified AdminConsentRequestPolicy using POST.
        /// </summary>
        /// <param name="adminConsentRequestPolicyToCreate">The AdminConsentRequestPolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AdminConsentRequestPolicy.</returns>
        System.Threading.Tasks.Task<AdminConsentRequestPolicy> CreateAsync(AdminConsentRequestPolicy adminConsentRequestPolicyToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified AdminConsentRequestPolicy.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified AdminConsentRequestPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified AdminConsentRequestPolicy.
        /// </summary>
        /// <returns>The AdminConsentRequestPolicy.</returns>
        System.Threading.Tasks.Task<AdminConsentRequestPolicy> GetAsync();

        /// <summary>
        /// Gets the specified AdminConsentRequestPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AdminConsentRequestPolicy.</returns>
        System.Threading.Tasks.Task<AdminConsentRequestPolicy> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified AdminConsentRequestPolicy using PATCH.
        /// </summary>
        /// <param name="adminConsentRequestPolicyToUpdate">The AdminConsentRequestPolicy to update.</param>
        /// <returns>The updated AdminConsentRequestPolicy.</returns>
        System.Threading.Tasks.Task<AdminConsentRequestPolicy> UpdateAsync(AdminConsentRequestPolicy adminConsentRequestPolicyToUpdate);

        /// <summary>
        /// Updates the specified AdminConsentRequestPolicy using PATCH.
        /// </summary>
        /// <param name="adminConsentRequestPolicyToUpdate">The AdminConsentRequestPolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AdminConsentRequestPolicy.</returns>
        System.Threading.Tasks.Task<AdminConsentRequestPolicy> UpdateAsync(AdminConsentRequestPolicy adminConsentRequestPolicyToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAdminConsentRequestPolicyRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAdminConsentRequestPolicyRequest Expand(Expression<Func<AdminConsentRequestPolicy, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAdminConsentRequestPolicyRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAdminConsentRequestPolicyRequest Select(Expression<Func<AdminConsentRequestPolicy, object>> selectExpression);

    }
}