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
    public partial class WhoisBaseRecord : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The contact information for the abuse contact.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.Security.WhoisContact? Abuse
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.WhoisContact?>("abuse"); }
            set { BackingStore?.Set("abuse", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.Security.WhoisContact Abuse
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.WhoisContact>("abuse"); }
            set { BackingStore?.Set("abuse", value); }
        }
#endif
        /// <summary>The contact information for the admin contact.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.Security.WhoisContact? Admin
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.WhoisContact?>("admin"); }
            set { BackingStore?.Set("admin", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.Security.WhoisContact Admin
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.WhoisContact>("admin"); }
            set { BackingStore?.Set("admin", value); }
        }
#endif
        /// <summary>The contact information for the billing contact.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.Security.WhoisContact? Billing
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.WhoisContact?>("billing"); }
            set { BackingStore?.Set("billing", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.Security.WhoisContact Billing
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.WhoisContact>("billing"); }
            set { BackingStore?.Set("billing", value); }
        }
#endif
        /// <summary>The domain status for this WHOIS object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DomainStatus
        {
            get { return BackingStore?.Get<string?>("domainStatus"); }
            set { BackingStore?.Set("domainStatus", value); }
        }
#nullable restore
#else
        public string DomainStatus
        {
            get { return BackingStore?.Get<string>("domainStatus"); }
            set { BackingStore?.Set("domainStatus", value); }
        }
#endif
        /// <summary>The date and time when this WHOIS record expires with the registrar. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? ExpirationDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("expirationDateTime"); }
            set { BackingStore?.Set("expirationDateTime", value); }
        }
        /// <summary>The first seen date and time of this WHOIS record. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? FirstSeenDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("firstSeenDateTime"); }
            set { BackingStore?.Set("firstSeenDateTime", value); }
        }
        /// <summary>The host property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.Security.Host? Host
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.Host?>("host"); }
            set { BackingStore?.Set("host", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.Security.Host Host
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.Host>("host"); }
            set { BackingStore?.Set("host", value); }
        }
#endif
        /// <summary>The last seen date and time of this WHOIS record. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LastSeenDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastSeenDateTime"); }
            set { BackingStore?.Set("lastSeenDateTime", value); }
        }
        /// <summary>The date and time when this WHOIS record was last modified. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LastUpdateDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastUpdateDateTime"); }
            set { BackingStore?.Set("lastUpdateDateTime", value); }
        }
        /// <summary>The nameservers for this WHOIS object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.Security.WhoisNameserver>? Nameservers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.WhoisNameserver>?>("nameservers"); }
            set { BackingStore?.Set("nameservers", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.Security.WhoisNameserver> Nameservers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.WhoisNameserver>>("nameservers"); }
            set { BackingStore?.Set("nameservers", value); }
        }
#endif
        /// <summary>The contact information for the noc contact.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.Security.WhoisContact? Noc
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.WhoisContact?>("noc"); }
            set { BackingStore?.Set("noc", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.Security.WhoisContact Noc
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.WhoisContact>("noc"); }
            set { BackingStore?.Set("noc", value); }
        }
#endif
        /// <summary>The raw WHOIS details for this WHOIS object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RawWhoisText
        {
            get { return BackingStore?.Get<string?>("rawWhoisText"); }
            set { BackingStore?.Set("rawWhoisText", value); }
        }
#nullable restore
#else
        public string RawWhoisText
        {
            get { return BackingStore?.Get<string>("rawWhoisText"); }
            set { BackingStore?.Set("rawWhoisText", value); }
        }
#endif
        /// <summary>The contact information for the registrant contact.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.Security.WhoisContact? Registrant
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.WhoisContact?>("registrant"); }
            set { BackingStore?.Set("registrant", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.Security.WhoisContact Registrant
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.WhoisContact>("registrant"); }
            set { BackingStore?.Set("registrant", value); }
        }
#endif
        /// <summary>The contact information for the registrar contact.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.Security.WhoisContact? Registrar
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.WhoisContact?>("registrar"); }
            set { BackingStore?.Set("registrar", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.Security.WhoisContact Registrar
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.WhoisContact>("registrar"); }
            set { BackingStore?.Set("registrar", value); }
        }
#endif
        /// <summary>The date and time when this WHOIS record was registered with a registrar. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? RegistrationDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("registrationDateTime"); }
            set { BackingStore?.Set("registrationDateTime", value); }
        }
        /// <summary>The contact information for the technical contact.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.Security.WhoisContact? Technical
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.WhoisContact?>("technical"); }
            set { BackingStore?.Set("technical", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.Security.WhoisContact Technical
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.WhoisContact>("technical"); }
            set { BackingStore?.Set("technical", value); }
        }
#endif
        /// <summary>The WHOIS server that provides the details.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WhoisServer
        {
            get { return BackingStore?.Get<string?>("whoisServer"); }
            set { BackingStore?.Set("whoisServer", value); }
        }
#nullable restore
#else
        public string WhoisServer
        {
            get { return BackingStore?.Get<string>("whoisServer"); }
            set { BackingStore?.Set("whoisServer", value); }
        }
#endif
        /// <summary>The contact information for the zone contact.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.Security.WhoisContact? Zone
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.WhoisContact?>("zone"); }
            set { BackingStore?.Set("zone", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.Security.WhoisContact Zone
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.WhoisContact>("zone"); }
            set { BackingStore?.Set("zone", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Security.WhoisBaseRecord"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.Security.WhoisBaseRecord CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.security.whoisHistoryRecord" => new global::Microsoft.Graph.Models.Security.WhoisHistoryRecord(),
                "#microsoft.graph.security.whoisRecord" => new global::Microsoft.Graph.Models.Security.WhoisRecord(),
                _ => new global::Microsoft.Graph.Models.Security.WhoisBaseRecord(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "abuse", n => { Abuse = n.GetObjectValue<global::Microsoft.Graph.Models.Security.WhoisContact>(global::Microsoft.Graph.Models.Security.WhoisContact.CreateFromDiscriminatorValue); } },
                { "admin", n => { Admin = n.GetObjectValue<global::Microsoft.Graph.Models.Security.WhoisContact>(global::Microsoft.Graph.Models.Security.WhoisContact.CreateFromDiscriminatorValue); } },
                { "billing", n => { Billing = n.GetObjectValue<global::Microsoft.Graph.Models.Security.WhoisContact>(global::Microsoft.Graph.Models.Security.WhoisContact.CreateFromDiscriminatorValue); } },
                { "domainStatus", n => { DomainStatus = n.GetStringValue(); } },
                { "expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                { "firstSeenDateTime", n => { FirstSeenDateTime = n.GetDateTimeOffsetValue(); } },
                { "host", n => { Host = n.GetObjectValue<global::Microsoft.Graph.Models.Security.Host>(global::Microsoft.Graph.Models.Security.Host.CreateFromDiscriminatorValue); } },
                { "lastSeenDateTime", n => { LastSeenDateTime = n.GetDateTimeOffsetValue(); } },
                { "lastUpdateDateTime", n => { LastUpdateDateTime = n.GetDateTimeOffsetValue(); } },
                { "nameservers", n => { Nameservers = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.WhoisNameserver>(global::Microsoft.Graph.Models.Security.WhoisNameserver.CreateFromDiscriminatorValue)?.AsList(); } },
                { "noc", n => { Noc = n.GetObjectValue<global::Microsoft.Graph.Models.Security.WhoisContact>(global::Microsoft.Graph.Models.Security.WhoisContact.CreateFromDiscriminatorValue); } },
                { "rawWhoisText", n => { RawWhoisText = n.GetStringValue(); } },
                { "registrant", n => { Registrant = n.GetObjectValue<global::Microsoft.Graph.Models.Security.WhoisContact>(global::Microsoft.Graph.Models.Security.WhoisContact.CreateFromDiscriminatorValue); } },
                { "registrar", n => { Registrar = n.GetObjectValue<global::Microsoft.Graph.Models.Security.WhoisContact>(global::Microsoft.Graph.Models.Security.WhoisContact.CreateFromDiscriminatorValue); } },
                { "registrationDateTime", n => { RegistrationDateTime = n.GetDateTimeOffsetValue(); } },
                { "technical", n => { Technical = n.GetObjectValue<global::Microsoft.Graph.Models.Security.WhoisContact>(global::Microsoft.Graph.Models.Security.WhoisContact.CreateFromDiscriminatorValue); } },
                { "whoisServer", n => { WhoisServer = n.GetStringValue(); } },
                { "zone", n => { Zone = n.GetObjectValue<global::Microsoft.Graph.Models.Security.WhoisContact>(global::Microsoft.Graph.Models.Security.WhoisContact.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Models.Security.WhoisContact>("abuse", Abuse);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.Security.WhoisContact>("admin", Admin);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.Security.WhoisContact>("billing", Billing);
            writer.WriteStringValue("domainStatus", DomainStatus);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteDateTimeOffsetValue("firstSeenDateTime", FirstSeenDateTime);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.Security.Host>("host", Host);
            writer.WriteDateTimeOffsetValue("lastSeenDateTime", LastSeenDateTime);
            writer.WriteDateTimeOffsetValue("lastUpdateDateTime", LastUpdateDateTime);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.WhoisNameserver>("nameservers", Nameservers);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.Security.WhoisContact>("noc", Noc);
            writer.WriteStringValue("rawWhoisText", RawWhoisText);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.Security.WhoisContact>("registrant", Registrant);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.Security.WhoisContact>("registrar", Registrar);
            writer.WriteDateTimeOffsetValue("registrationDateTime", RegistrationDateTime);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.Security.WhoisContact>("technical", Technical);
            writer.WriteStringValue("whoisServer", WhoisServer);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.Security.WhoisContact>("zone", Zone);
        }
    }
}
#pragma warning restore CS0618
