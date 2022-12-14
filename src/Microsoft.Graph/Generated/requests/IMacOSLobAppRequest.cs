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
    /// The interface IMacOSLobAppRequest.
    /// </summary>
    public partial interface IMacOSLobAppRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified MacOSLobApp using POST.
        /// </summary>
        /// <param name="macOSLobAppToCreate">The MacOSLobApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MacOSLobApp.</returns>
        System.Threading.Tasks.Task<MacOSLobApp> CreateAsync(MacOSLobApp macOSLobAppToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified MacOSLobApp using POST and returns a <see cref="GraphResponse{MacOSLobApp}"/> object.
        /// </summary>
        /// <param name="macOSLobAppToCreate">The MacOSLobApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MacOSLobApp}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MacOSLobApp>> CreateResponseAsync(MacOSLobApp macOSLobAppToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified MacOSLobApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified MacOSLobApp and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified MacOSLobApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MacOSLobApp.</returns>
        System.Threading.Tasks.Task<MacOSLobApp> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified MacOSLobApp and returns a <see cref="GraphResponse{MacOSLobApp}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MacOSLobApp}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MacOSLobApp>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified MacOSLobApp using PATCH.
        /// </summary>
        /// <param name="macOSLobAppToUpdate">The MacOSLobApp to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MacOSLobApp.</returns>
        System.Threading.Tasks.Task<MacOSLobApp> UpdateAsync(MacOSLobApp macOSLobAppToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified MacOSLobApp using PATCH and returns a <see cref="GraphResponse{MacOSLobApp}"/> object.
        /// </summary>
        /// <param name="macOSLobAppToUpdate">The MacOSLobApp to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{MacOSLobApp}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MacOSLobApp>> UpdateResponseAsync(MacOSLobApp macOSLobAppToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified MacOSLobApp using PUT.
        /// </summary>
        /// <param name="macOSLobAppToUpdate">The MacOSLobApp object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<MacOSLobApp> PutAsync(MacOSLobApp macOSLobAppToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified MacOSLobApp using PUT and returns a <see cref="GraphResponse{MacOSLobApp}"/> object.
        /// </summary>
        /// <param name="macOSLobAppToUpdate">The MacOSLobApp object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{MacOSLobApp}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<MacOSLobApp>> PutResponseAsync(MacOSLobApp macOSLobAppToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSLobAppRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSLobAppRequest Expand(Expression<Func<MacOSLobApp, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSLobAppRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSLobAppRequest Select(Expression<Func<MacOSLobApp, object>> selectExpression);

    }
}