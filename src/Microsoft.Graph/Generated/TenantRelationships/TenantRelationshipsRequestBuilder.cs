// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Graph.Models;
using Microsoft.Graph.TenantRelationships.DelegatedAdminCustomers;
using Microsoft.Graph.TenantRelationships.DelegatedAdminRelationships;
using Microsoft.Graph.TenantRelationships.FindTenantInformationByDomainNameWithDomainName;
using Microsoft.Graph.TenantRelationships.FindTenantInformationByTenantIdWithTenantId;
using Microsoft.Graph.TenantRelationships.MultiTenantOrganization;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.TenantRelationships
{
    /// <summary>
    /// Provides operations to manage the tenantRelationship singleton.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class TenantRelationshipsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the delegatedAdminCustomers property of the microsoft.graph.tenantRelationship entity.</summary>
        public global::Microsoft.Graph.TenantRelationships.DelegatedAdminCustomers.DelegatedAdminCustomersRequestBuilder DelegatedAdminCustomers
        {
            get => new global::Microsoft.Graph.TenantRelationships.DelegatedAdminCustomers.DelegatedAdminCustomersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the delegatedAdminRelationships property of the microsoft.graph.tenantRelationship entity.</summary>
        public global::Microsoft.Graph.TenantRelationships.DelegatedAdminRelationships.DelegatedAdminRelationshipsRequestBuilder DelegatedAdminRelationships
        {
            get => new global::Microsoft.Graph.TenantRelationships.DelegatedAdminRelationships.DelegatedAdminRelationshipsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the multiTenantOrganization property of the microsoft.graph.tenantRelationship entity.</summary>
        public global::Microsoft.Graph.TenantRelationships.MultiTenantOrganization.MultiTenantOrganizationRequestBuilder MultiTenantOrganization
        {
            get => new global::Microsoft.Graph.TenantRelationships.MultiTenantOrganization.MultiTenantOrganizationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.TenantRelationships.TenantRelationshipsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TenantRelationshipsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/tenantRelationships{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.TenantRelationships.TenantRelationshipsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TenantRelationshipsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/tenantRelationships{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Provides operations to call the findTenantInformationByDomainName method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.TenantRelationships.FindTenantInformationByDomainNameWithDomainName.FindTenantInformationByDomainNameWithDomainNameRequestBuilder"/></returns>
        /// <param name="domainName">Usage: domainName=&apos;{domainName}&apos;</param>
        public global::Microsoft.Graph.TenantRelationships.FindTenantInformationByDomainNameWithDomainName.FindTenantInformationByDomainNameWithDomainNameRequestBuilder FindTenantInformationByDomainNameWithDomainName(string domainName)
        {
            if(string.IsNullOrEmpty(domainName)) throw new ArgumentNullException(nameof(domainName));
            return new global::Microsoft.Graph.TenantRelationships.FindTenantInformationByDomainNameWithDomainName.FindTenantInformationByDomainNameWithDomainNameRequestBuilder(PathParameters, RequestAdapter, domainName);
        }
        /// <summary>
        /// Provides operations to call the findTenantInformationByTenantId method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.TenantRelationships.FindTenantInformationByTenantIdWithTenantId.FindTenantInformationByTenantIdWithTenantIdRequestBuilder"/></returns>
        /// <param name="tenantId">Usage: tenantId=&apos;{tenantId}&apos;</param>
        public global::Microsoft.Graph.TenantRelationships.FindTenantInformationByTenantIdWithTenantId.FindTenantInformationByTenantIdWithTenantIdRequestBuilder FindTenantInformationByTenantIdWithTenantId(string tenantId)
        {
            if(string.IsNullOrEmpty(tenantId)) throw new ArgumentNullException(nameof(tenantId));
            return new global::Microsoft.Graph.TenantRelationships.FindTenantInformationByTenantIdWithTenantId.FindTenantInformationByTenantIdWithTenantIdRequestBuilder(PathParameters, RequestAdapter, tenantId);
        }
        /// <summary>
        /// Get tenantRelationships
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.TenantRelationship"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.TenantRelationship?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.TenantRelationships.TenantRelationshipsRequestBuilder.TenantRelationshipsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.TenantRelationship> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.TenantRelationships.TenantRelationshipsRequestBuilder.TenantRelationshipsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.TenantRelationship>(requestInfo, global::Microsoft.Graph.Models.TenantRelationship.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update tenantRelationships
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.TenantRelationship"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.TenantRelationship?> PatchAsync(global::Microsoft.Graph.Models.TenantRelationship body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.TenantRelationship> PatchAsync(global::Microsoft.Graph.Models.TenantRelationship body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.TenantRelationship>(requestInfo, global::Microsoft.Graph.Models.TenantRelationship.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get tenantRelationships
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.TenantRelationships.TenantRelationshipsRequestBuilder.TenantRelationshipsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.TenantRelationships.TenantRelationshipsRequestBuilder.TenantRelationshipsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update tenantRelationships
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Models.TenantRelationship body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Models.TenantRelationship body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.TenantRelationships.TenantRelationshipsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.TenantRelationships.TenantRelationshipsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.TenantRelationships.TenantRelationshipsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get tenantRelationships
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class TenantRelationshipsRequestBuilderGetQueryParameters 
        {
            /// <summary>Expand related entities</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24expand")]
            public string[]? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
#endif
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
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class TenantRelationshipsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.TenantRelationships.TenantRelationshipsRequestBuilder.TenantRelationshipsRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class TenantRelationshipsRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
