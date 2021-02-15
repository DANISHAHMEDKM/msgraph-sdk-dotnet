// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type GraphServiceTeamsTemplatesCollectionRequest.
    /// </summary>
    public partial class GraphServiceTeamsTemplatesCollectionRequest : BaseRequest, IGraphServiceTeamsTemplatesCollectionRequest
    {
        /// <summary>
        /// Constructs a new GraphServiceTeamsTemplatesCollectionRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public GraphServiceTeamsTemplatesCollectionRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }
        
        /// <summary>
        /// Adds the specified TeamsTemplate to the collection via POST.
        /// </summary>
        /// <param name="teamsTemplate">The TeamsTemplate to add.</param>
        /// <returns>The created TeamsTemplate.</returns>
        public System.Threading.Tasks.Task<TeamsTemplate> AddAsync(TeamsTemplate teamsTemplate)
        {
            return this.AddAsync(teamsTemplate, CancellationToken.None);
        }

        /// <summary>
        /// Adds the specified TeamsTemplate to the collection via POST.
        /// </summary>
        /// <param name="teamsTemplate">The TeamsTemplate to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created TeamsTemplate.</returns>
        public System.Threading.Tasks.Task<TeamsTemplate> AddAsync(TeamsTemplate teamsTemplate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return this.SendAsync<TeamsTemplate>(teamsTemplate, cancellationToken);
        }

        
        /// <summary>
        /// Adds the specified TeamsTemplate to the collection via POST and returns a <see cref="GraphResponse{TeamsTemplate}"/> object of the request.
        /// </summary>
        /// <param name="teamsTemplate">The TeamsTemplate to add.</param>
        /// <returns>The <see cref="GraphResponse{TeamsTemplate}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<TeamsTemplate>> AddResponseAsync(TeamsTemplate teamsTemplate)
        {
            return this.AddResponseAsync(teamsTemplate, CancellationToken.None);
        }

        /// <summary>
        /// Adds the specified TeamsTemplate to the collection via POST and returns a <see cref="GraphResponse{TeamsTemplate}"/> object of the request.
        /// </summary>
        /// <param name="teamsTemplate">The TeamsTemplate to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TeamsTemplate}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<TeamsTemplate>> AddResponseAsync(TeamsTemplate teamsTemplate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<TeamsTemplate>(teamsTemplate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <returns>The collection page.</returns>
        public System.Threading.Tasks.Task<IGraphServiceTeamsTemplatesCollectionPage> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        public async System.Threading.Tasks.Task<IGraphServiceTeamsTemplatesCollectionPage> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var response = await this.SendAsync<GraphServiceTeamsTemplatesCollectionResponse>(null, cancellationToken).ConfigureAwait(false);
            if (response != null && response.Value != null && response.Value.CurrentPage != null)
            {
                if (response.AdditionalData != null)
                {
                    object nextPageLink;
                    response.AdditionalData.TryGetValue("@odata.nextLink", out nextPageLink);

                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        response.Value.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }

                    // Copy the additional data collection to the page itself so that information is not lost
                    response.Value.AdditionalData = response.AdditionalData;
                }

                return response.Value;
            }

            return null;
        }

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{GraphServiceTeamsTemplatesCollectionResponse}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{GraphServiceTeamsTemplatesCollectionResponse}"/> object.</returns>
        public System.Threading.Tasks.Task<GraphResponse<GraphServiceTeamsTemplatesCollectionResponse>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{GraphServiceTeamsTemplatesCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{GraphServiceTeamsTemplatesCollectionResponse}"/> object.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<GraphServiceTeamsTemplatesCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<GraphServiceTeamsTemplatesCollectionResponse>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IGraphServiceTeamsTemplatesCollectionRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IGraphServiceTeamsTemplatesCollectionRequest Expand(Expression<Func<TeamsTemplate, object>> expandExpression)
        {
            if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IGraphServiceTeamsTemplatesCollectionRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IGraphServiceTeamsTemplatesCollectionRequest Select(Expression<Func<TeamsTemplate, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        public IGraphServiceTeamsTemplatesCollectionRequest Top(int value)
        {
            this.QueryOptions.Add(new QueryOption("$top", value.ToString()));
            return this;
        }

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        public IGraphServiceTeamsTemplatesCollectionRequest Filter(string value)
        {
            this.QueryOptions.Add(new QueryOption("$filter", value));
            return this;
        }

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        public IGraphServiceTeamsTemplatesCollectionRequest Skip(int value)
        {
            this.QueryOptions.Add(new QueryOption("$skip", value.ToString()));
            return this;
        }

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        public IGraphServiceTeamsTemplatesCollectionRequest OrderBy(string value)
        {
            this.QueryOptions.Add(new QueryOption("$orderby", value));
            return this;
        }
    }
}
