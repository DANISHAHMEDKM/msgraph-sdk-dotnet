// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Graph.Models.Security;
using Microsoft.Graph.Security.ThreatIntelligence.ArticleIndicators;
using Microsoft.Graph.Security.ThreatIntelligence.Articles;
using Microsoft.Graph.Security.ThreatIntelligence.HostComponents;
using Microsoft.Graph.Security.ThreatIntelligence.HostCookies;
using Microsoft.Graph.Security.ThreatIntelligence.HostPairs;
using Microsoft.Graph.Security.ThreatIntelligence.HostPorts;
using Microsoft.Graph.Security.ThreatIntelligence.HostSslCertificates;
using Microsoft.Graph.Security.ThreatIntelligence.HostTrackers;
using Microsoft.Graph.Security.ThreatIntelligence.Hosts;
using Microsoft.Graph.Security.ThreatIntelligence.IntelProfiles;
using Microsoft.Graph.Security.ThreatIntelligence.IntelligenceProfileIndicators;
using Microsoft.Graph.Security.ThreatIntelligence.PassiveDnsRecords;
using Microsoft.Graph.Security.ThreatIntelligence.SslCertificates;
using Microsoft.Graph.Security.ThreatIntelligence.Subdomains;
using Microsoft.Graph.Security.ThreatIntelligence.Vulnerabilities;
using Microsoft.Graph.Security.ThreatIntelligence.WhoisHistoryRecords;
using Microsoft.Graph.Security.ThreatIntelligence.WhoisRecords;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Security.ThreatIntelligence
{
    /// <summary>
    /// Provides operations to manage the threatIntelligence property of the microsoft.graph.security entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class ThreatIntelligenceRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the articleIndicators property of the microsoft.graph.security.threatIntelligence entity.</summary>
        public global::Microsoft.Graph.Security.ThreatIntelligence.ArticleIndicators.ArticleIndicatorsRequestBuilder ArticleIndicators
        {
            get => new global::Microsoft.Graph.Security.ThreatIntelligence.ArticleIndicators.ArticleIndicatorsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the articles property of the microsoft.graph.security.threatIntelligence entity.</summary>
        public global::Microsoft.Graph.Security.ThreatIntelligence.Articles.ArticlesRequestBuilder Articles
        {
            get => new global::Microsoft.Graph.Security.ThreatIntelligence.Articles.ArticlesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the hostComponents property of the microsoft.graph.security.threatIntelligence entity.</summary>
        public global::Microsoft.Graph.Security.ThreatIntelligence.HostComponents.HostComponentsRequestBuilder HostComponents
        {
            get => new global::Microsoft.Graph.Security.ThreatIntelligence.HostComponents.HostComponentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the hostCookies property of the microsoft.graph.security.threatIntelligence entity.</summary>
        public global::Microsoft.Graph.Security.ThreatIntelligence.HostCookies.HostCookiesRequestBuilder HostCookies
        {
            get => new global::Microsoft.Graph.Security.ThreatIntelligence.HostCookies.HostCookiesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the hostPairs property of the microsoft.graph.security.threatIntelligence entity.</summary>
        public global::Microsoft.Graph.Security.ThreatIntelligence.HostPairs.HostPairsRequestBuilder HostPairs
        {
            get => new global::Microsoft.Graph.Security.ThreatIntelligence.HostPairs.HostPairsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the hostPorts property of the microsoft.graph.security.threatIntelligence entity.</summary>
        public global::Microsoft.Graph.Security.ThreatIntelligence.HostPorts.HostPortsRequestBuilder HostPorts
        {
            get => new global::Microsoft.Graph.Security.ThreatIntelligence.HostPorts.HostPortsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the hosts property of the microsoft.graph.security.threatIntelligence entity.</summary>
        public global::Microsoft.Graph.Security.ThreatIntelligence.Hosts.HostsRequestBuilder Hosts
        {
            get => new global::Microsoft.Graph.Security.ThreatIntelligence.Hosts.HostsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the hostSslCertificates property of the microsoft.graph.security.threatIntelligence entity.</summary>
        public global::Microsoft.Graph.Security.ThreatIntelligence.HostSslCertificates.HostSslCertificatesRequestBuilder HostSslCertificates
        {
            get => new global::Microsoft.Graph.Security.ThreatIntelligence.HostSslCertificates.HostSslCertificatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the hostTrackers property of the microsoft.graph.security.threatIntelligence entity.</summary>
        public global::Microsoft.Graph.Security.ThreatIntelligence.HostTrackers.HostTrackersRequestBuilder HostTrackers
        {
            get => new global::Microsoft.Graph.Security.ThreatIntelligence.HostTrackers.HostTrackersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the intelligenceProfileIndicators property of the microsoft.graph.security.threatIntelligence entity.</summary>
        public global::Microsoft.Graph.Security.ThreatIntelligence.IntelligenceProfileIndicators.IntelligenceProfileIndicatorsRequestBuilder IntelligenceProfileIndicators
        {
            get => new global::Microsoft.Graph.Security.ThreatIntelligence.IntelligenceProfileIndicators.IntelligenceProfileIndicatorsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the intelProfiles property of the microsoft.graph.security.threatIntelligence entity.</summary>
        public global::Microsoft.Graph.Security.ThreatIntelligence.IntelProfiles.IntelProfilesRequestBuilder IntelProfiles
        {
            get => new global::Microsoft.Graph.Security.ThreatIntelligence.IntelProfiles.IntelProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the passiveDnsRecords property of the microsoft.graph.security.threatIntelligence entity.</summary>
        public global::Microsoft.Graph.Security.ThreatIntelligence.PassiveDnsRecords.PassiveDnsRecordsRequestBuilder PassiveDnsRecords
        {
            get => new global::Microsoft.Graph.Security.ThreatIntelligence.PassiveDnsRecords.PassiveDnsRecordsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the sslCertificates property of the microsoft.graph.security.threatIntelligence entity.</summary>
        public global::Microsoft.Graph.Security.ThreatIntelligence.SslCertificates.SslCertificatesRequestBuilder SslCertificates
        {
            get => new global::Microsoft.Graph.Security.ThreatIntelligence.SslCertificates.SslCertificatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the subdomains property of the microsoft.graph.security.threatIntelligence entity.</summary>
        public global::Microsoft.Graph.Security.ThreatIntelligence.Subdomains.SubdomainsRequestBuilder Subdomains
        {
            get => new global::Microsoft.Graph.Security.ThreatIntelligence.Subdomains.SubdomainsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the vulnerabilities property of the microsoft.graph.security.threatIntelligence entity.</summary>
        public global::Microsoft.Graph.Security.ThreatIntelligence.Vulnerabilities.VulnerabilitiesRequestBuilder Vulnerabilities
        {
            get => new global::Microsoft.Graph.Security.ThreatIntelligence.Vulnerabilities.VulnerabilitiesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the whoisHistoryRecords property of the microsoft.graph.security.threatIntelligence entity.</summary>
        public global::Microsoft.Graph.Security.ThreatIntelligence.WhoisHistoryRecords.WhoisHistoryRecordsRequestBuilder WhoisHistoryRecords
        {
            get => new global::Microsoft.Graph.Security.ThreatIntelligence.WhoisHistoryRecords.WhoisHistoryRecordsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the whoisRecords property of the microsoft.graph.security.threatIntelligence entity.</summary>
        public global::Microsoft.Graph.Security.ThreatIntelligence.WhoisRecords.WhoisRecordsRequestBuilder WhoisRecords
        {
            get => new global::Microsoft.Graph.Security.ThreatIntelligence.WhoisRecords.WhoisRecordsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Security.ThreatIntelligence.ThreatIntelligenceRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ThreatIntelligenceRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/security/threatIntelligence{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Security.ThreatIntelligence.ThreatIntelligenceRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ThreatIntelligenceRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/security/threatIntelligence{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property threatIntelligence for security
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
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
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get threatIntelligence from security
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Security.ThreatIntelligence"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.Security.ThreatIntelligence?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Security.ThreatIntelligence.ThreatIntelligenceRequestBuilder.ThreatIntelligenceRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.Security.ThreatIntelligence> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Security.ThreatIntelligence.ThreatIntelligenceRequestBuilder.ThreatIntelligenceRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.Security.ThreatIntelligence>(requestInfo, global::Microsoft.Graph.Models.Security.ThreatIntelligence.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the navigation property threatIntelligence in security
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Security.ThreatIntelligence"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.Security.ThreatIntelligence?> PatchAsync(global::Microsoft.Graph.Models.Security.ThreatIntelligence body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.Security.ThreatIntelligence> PatchAsync(global::Microsoft.Graph.Models.Security.ThreatIntelligence body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.Security.ThreatIntelligence>(requestInfo, global::Microsoft.Graph.Models.Security.ThreatIntelligence.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete navigation property threatIntelligence for security
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
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Get threatIntelligence from security
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Security.ThreatIntelligence.ThreatIntelligenceRequestBuilder.ThreatIntelligenceRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Security.ThreatIntelligence.ThreatIntelligenceRequestBuilder.ThreatIntelligenceRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property threatIntelligence in security
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Models.Security.ThreatIntelligence body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Models.Security.ThreatIntelligence body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Security.ThreatIntelligence.ThreatIntelligenceRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Security.ThreatIntelligence.ThreatIntelligenceRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Security.ThreatIntelligence.ThreatIntelligenceRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class ThreatIntelligenceRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Get threatIntelligence from security
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class ThreatIntelligenceRequestBuilderGetQueryParameters 
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
        public partial class ThreatIntelligenceRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Security.ThreatIntelligence.ThreatIntelligenceRequestBuilder.ThreatIntelligenceRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class ThreatIntelligenceRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
