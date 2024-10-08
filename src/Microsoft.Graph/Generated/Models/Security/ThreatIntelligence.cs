// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models.Security
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class ThreatIntelligence : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Refers to indicators of threat or compromise highlighted in an article.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.Security.ArticleIndicator>? ArticleIndicators
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.ArticleIndicator>?>("articleIndicators"); }
            set { BackingStore?.Set("articleIndicators", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.Security.ArticleIndicator> ArticleIndicators
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.ArticleIndicator>>("articleIndicators"); }
            set { BackingStore?.Set("articleIndicators", value); }
        }
#endif
        /// <summary>A list of article objects.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.Security.Article>? Articles
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.Article>?>("articles"); }
            set { BackingStore?.Set("articles", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.Security.Article> Articles
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.Article>>("articles"); }
            set { BackingStore?.Set("articles", value); }
        }
#endif
        /// <summary>Retrieve details about hostComponent objects.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.Security.HostComponent>? HostComponents
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.HostComponent>?>("hostComponents"); }
            set { BackingStore?.Set("hostComponents", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.Security.HostComponent> HostComponents
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.HostComponent>>("hostComponents"); }
            set { BackingStore?.Set("hostComponents", value); }
        }
#endif
        /// <summary>Retrieve details about hostCookie objects.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.Security.HostCookie>? HostCookies
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.HostCookie>?>("hostCookies"); }
            set { BackingStore?.Set("hostCookies", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.Security.HostCookie> HostCookies
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.HostCookie>>("hostCookies"); }
            set { BackingStore?.Set("hostCookies", value); }
        }
#endif
        /// <summary>Retrieve details about hostTracker objects.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.Security.HostPair>? HostPairs
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.HostPair>?>("hostPairs"); }
            set { BackingStore?.Set("hostPairs", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.Security.HostPair> HostPairs
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.HostPair>>("hostPairs"); }
            set { BackingStore?.Set("hostPairs", value); }
        }
#endif
        /// <summary>Retrieve details about hostPort objects.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.Security.HostPort>? HostPorts
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.HostPort>?>("hostPorts"); }
            set { BackingStore?.Set("hostPorts", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.Security.HostPort> HostPorts
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.HostPort>>("hostPorts"); }
            set { BackingStore?.Set("hostPorts", value); }
        }
#endif
        /// <summary>Refers to host objects that Microsoft Threat Intelligence has observed.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.Security.Host>? Hosts
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.Host>?>("hosts"); }
            set { BackingStore?.Set("hosts", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.Security.Host> Hosts
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.Host>>("hosts"); }
            set { BackingStore?.Set("hosts", value); }
        }
#endif
        /// <summary>Retrieve details about hostSslCertificate objects.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.Security.HostSslCertificate>? HostSslCertificates
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.HostSslCertificate>?>("hostSslCertificates"); }
            set { BackingStore?.Set("hostSslCertificates", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.Security.HostSslCertificate> HostSslCertificates
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.HostSslCertificate>>("hostSslCertificates"); }
            set { BackingStore?.Set("hostSslCertificates", value); }
        }
#endif
        /// <summary>Retrieve details about hostTracker objects.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.Security.HostTracker>? HostTrackers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.HostTracker>?>("hostTrackers"); }
            set { BackingStore?.Set("hostTrackers", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.Security.HostTracker> HostTrackers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.HostTracker>>("hostTrackers"); }
            set { BackingStore?.Set("hostTrackers", value); }
        }
#endif
        /// <summary>The intelligenceProfileIndicators property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.Security.IntelligenceProfileIndicator>? IntelligenceProfileIndicators
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.IntelligenceProfileIndicator>?>("intelligenceProfileIndicators"); }
            set { BackingStore?.Set("intelligenceProfileIndicators", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.Security.IntelligenceProfileIndicator> IntelligenceProfileIndicators
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.IntelligenceProfileIndicator>>("intelligenceProfileIndicators"); }
            set { BackingStore?.Set("intelligenceProfileIndicators", value); }
        }
#endif
        /// <summary>A list of intelligenceProfile objects.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.Security.IntelligenceProfile>? IntelProfiles
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.IntelligenceProfile>?>("intelProfiles"); }
            set { BackingStore?.Set("intelProfiles", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.Security.IntelligenceProfile> IntelProfiles
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.IntelligenceProfile>>("intelProfiles"); }
            set { BackingStore?.Set("intelProfiles", value); }
        }
#endif
        /// <summary>Retrieve details about passiveDnsRecord objects.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.Security.PassiveDnsRecord>? PassiveDnsRecords
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.PassiveDnsRecord>?>("passiveDnsRecords"); }
            set { BackingStore?.Set("passiveDnsRecords", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.Security.PassiveDnsRecord> PassiveDnsRecords
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.PassiveDnsRecord>>("passiveDnsRecords"); }
            set { BackingStore?.Set("passiveDnsRecords", value); }
        }
#endif
        /// <summary>Retrieve details about sslCertificate objects.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.Security.SslCertificate>? SslCertificates
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.SslCertificate>?>("sslCertificates"); }
            set { BackingStore?.Set("sslCertificates", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.Security.SslCertificate> SslCertificates
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.SslCertificate>>("sslCertificates"); }
            set { BackingStore?.Set("sslCertificates", value); }
        }
#endif
        /// <summary>Retrieve details about the subdomain.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.Security.Subdomain>? Subdomains
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.Subdomain>?>("subdomains"); }
            set { BackingStore?.Set("subdomains", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.Security.Subdomain> Subdomains
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.Subdomain>>("subdomains"); }
            set { BackingStore?.Set("subdomains", value); }
        }
#endif
        /// <summary>Retrieve details about vulnerabilities.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.Security.Vulnerability>? Vulnerabilities
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.Vulnerability>?>("vulnerabilities"); }
            set { BackingStore?.Set("vulnerabilities", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.Security.Vulnerability> Vulnerabilities
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.Vulnerability>>("vulnerabilities"); }
            set { BackingStore?.Set("vulnerabilities", value); }
        }
#endif
        /// <summary>Retrieve details about whoisHistoryRecord objects.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.Security.WhoisHistoryRecord>? WhoisHistoryRecords
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.WhoisHistoryRecord>?>("whoisHistoryRecords"); }
            set { BackingStore?.Set("whoisHistoryRecords", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.Security.WhoisHistoryRecord> WhoisHistoryRecords
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.WhoisHistoryRecord>>("whoisHistoryRecords"); }
            set { BackingStore?.Set("whoisHistoryRecords", value); }
        }
#endif
        /// <summary>A list of whoisRecord objects.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.Security.WhoisRecord>? WhoisRecords
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.WhoisRecord>?>("whoisRecords"); }
            set { BackingStore?.Set("whoisRecords", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.Security.WhoisRecord> WhoisRecords
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.WhoisRecord>>("whoisRecords"); }
            set { BackingStore?.Set("whoisRecords", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Security.ThreatIntelligence"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.Security.ThreatIntelligence CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.Security.ThreatIntelligence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "articleIndicators", n => { ArticleIndicators = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.ArticleIndicator>(global::Microsoft.Graph.Models.Security.ArticleIndicator.CreateFromDiscriminatorValue)?.AsList(); } },
                { "articles", n => { Articles = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.Article>(global::Microsoft.Graph.Models.Security.Article.CreateFromDiscriminatorValue)?.AsList(); } },
                { "hostComponents", n => { HostComponents = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.HostComponent>(global::Microsoft.Graph.Models.Security.HostComponent.CreateFromDiscriminatorValue)?.AsList(); } },
                { "hostCookies", n => { HostCookies = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.HostCookie>(global::Microsoft.Graph.Models.Security.HostCookie.CreateFromDiscriminatorValue)?.AsList(); } },
                { "hostPairs", n => { HostPairs = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.HostPair>(global::Microsoft.Graph.Models.Security.HostPair.CreateFromDiscriminatorValue)?.AsList(); } },
                { "hostPorts", n => { HostPorts = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.HostPort>(global::Microsoft.Graph.Models.Security.HostPort.CreateFromDiscriminatorValue)?.AsList(); } },
                { "hostSslCertificates", n => { HostSslCertificates = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.HostSslCertificate>(global::Microsoft.Graph.Models.Security.HostSslCertificate.CreateFromDiscriminatorValue)?.AsList(); } },
                { "hostTrackers", n => { HostTrackers = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.HostTracker>(global::Microsoft.Graph.Models.Security.HostTracker.CreateFromDiscriminatorValue)?.AsList(); } },
                { "hosts", n => { Hosts = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.Host>(global::Microsoft.Graph.Models.Security.Host.CreateFromDiscriminatorValue)?.AsList(); } },
                { "intelProfiles", n => { IntelProfiles = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.IntelligenceProfile>(global::Microsoft.Graph.Models.Security.IntelligenceProfile.CreateFromDiscriminatorValue)?.AsList(); } },
                { "intelligenceProfileIndicators", n => { IntelligenceProfileIndicators = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.IntelligenceProfileIndicator>(global::Microsoft.Graph.Models.Security.IntelligenceProfileIndicator.CreateFromDiscriminatorValue)?.AsList(); } },
                { "passiveDnsRecords", n => { PassiveDnsRecords = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.PassiveDnsRecord>(global::Microsoft.Graph.Models.Security.PassiveDnsRecord.CreateFromDiscriminatorValue)?.AsList(); } },
                { "sslCertificates", n => { SslCertificates = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.SslCertificate>(global::Microsoft.Graph.Models.Security.SslCertificate.CreateFromDiscriminatorValue)?.AsList(); } },
                { "subdomains", n => { Subdomains = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.Subdomain>(global::Microsoft.Graph.Models.Security.Subdomain.CreateFromDiscriminatorValue)?.AsList(); } },
                { "vulnerabilities", n => { Vulnerabilities = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.Vulnerability>(global::Microsoft.Graph.Models.Security.Vulnerability.CreateFromDiscriminatorValue)?.AsList(); } },
                { "whoisHistoryRecords", n => { WhoisHistoryRecords = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.WhoisHistoryRecord>(global::Microsoft.Graph.Models.Security.WhoisHistoryRecord.CreateFromDiscriminatorValue)?.AsList(); } },
                { "whoisRecords", n => { WhoisRecords = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.WhoisRecord>(global::Microsoft.Graph.Models.Security.WhoisRecord.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.ArticleIndicator>("articleIndicators", ArticleIndicators);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.Article>("articles", Articles);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.HostComponent>("hostComponents", HostComponents);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.HostCookie>("hostCookies", HostCookies);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.HostPair>("hostPairs", HostPairs);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.HostPort>("hostPorts", HostPorts);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.Host>("hosts", Hosts);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.HostSslCertificate>("hostSslCertificates", HostSslCertificates);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.HostTracker>("hostTrackers", HostTrackers);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.IntelligenceProfileIndicator>("intelligenceProfileIndicators", IntelligenceProfileIndicators);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.IntelligenceProfile>("intelProfiles", IntelProfiles);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.PassiveDnsRecord>("passiveDnsRecords", PassiveDnsRecords);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.SslCertificate>("sslCertificates", SslCertificates);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.Subdomain>("subdomains", Subdomains);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.Vulnerability>("vulnerabilities", Vulnerabilities);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.WhoisHistoryRecord>("whoisHistoryRecords", WhoisHistoryRecords);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.WhoisRecord>("whoisRecords", WhoisRecords);
        }
    }
}
#pragma warning restore CS0618
