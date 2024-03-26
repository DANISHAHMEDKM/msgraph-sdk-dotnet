// <auto-generated/>
using Microsoft.Graph.Groups.Item.Threads.Item.Posts;
using Microsoft.Graph.Groups.Item.Threads.Item.Reply;
using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Groups.Item.Threads.Item {
    /// <summary>
    /// Provides operations to manage the threads property of the microsoft.graph.group entity.
    /// </summary>
    public class ConversationThreadItemRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>Provides operations to manage the posts property of the microsoft.graph.conversationThread entity.</summary>
        public PostsRequestBuilder Posts
        {
            get => new PostsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the reply method.</summary>
        public ReplyRequestBuilder Reply
        {
            get => new ReplyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="ConversationThreadItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ConversationThreadItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/groups/{group%2Did}/threads/{conversationThread%2Did}{?%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="ConversationThreadItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ConversationThreadItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/groups/{group%2Did}/threads/{conversationThread%2Did}{?%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete conversationThread.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/group-delete-thread?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"XXX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get a specific thread that belongs to a group. You can specify both the parent conversation and the thread, or, you can specify the thread without referencing the parent conversation. 
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/conversationthread-get?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="ConversationThread"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ConversationThread?> GetAsync(Action<RequestConfiguration<ConversationThreadItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<ConversationThread> GetAsync(Action<RequestConfiguration<ConversationThreadItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"XXX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<ConversationThread>(requestInfo, ConversationThread.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update conversation thread
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/group-update-thread?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="ConversationThread"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ConversationThread?> PatchAsync(ConversationThread body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<ConversationThread> PatchAsync(ConversationThread body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"XXX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<ConversationThread>(requestInfo, ConversationThread.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete conversationThread.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, "{+baseurl}/groups/{group%2Did}/threads/{conversationThread%2Did}", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Get a specific thread that belongs to a group. You can specify both the parent conversation and the thread, or, you can specify the thread without referencing the parent conversation. 
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ConversationThreadItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ConversationThreadItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update conversation thread
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(ConversationThread body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(ConversationThread body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, "{+baseurl}/groups/{group%2Did}/threads/{conversationThread%2Did}", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="ConversationThreadItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ConversationThreadItemRequestBuilder WithUrl(string rawUrl)
        {
            return new ConversationThreadItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class ConversationThreadItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters> 
        {
        }
        /// <summary>
        /// Get a specific thread that belongs to a group. You can specify both the parent conversation and the thread, or, you can specify the thread without referencing the parent conversation. 
        /// </summary>
        public class ConversationThreadItemRequestBuilderGetQueryParameters 
        {
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#nullable restore
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class ConversationThreadItemRequestBuilderGetRequestConfiguration : RequestConfiguration<ConversationThreadItemRequestBuilderGetQueryParameters> 
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class ConversationThreadItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters> 
        {
        }
    }
}
