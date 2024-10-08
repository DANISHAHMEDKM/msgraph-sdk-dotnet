// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class UserTeamwork : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The list of associatedTeamInfo objects that a user is associated with.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.AssociatedTeamInfo>? AssociatedTeams
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AssociatedTeamInfo>?>("associatedTeams"); }
            set { BackingStore?.Set("associatedTeams", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.AssociatedTeamInfo> AssociatedTeams
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AssociatedTeamInfo>>("associatedTeams"); }
            set { BackingStore?.Set("associatedTeams", value); }
        }
#endif
        /// <summary>The apps installed in the personal scope of this user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.UserScopeTeamsAppInstallation>? InstalledApps
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.UserScopeTeamsAppInstallation>?>("installedApps"); }
            set { BackingStore?.Set("installedApps", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.UserScopeTeamsAppInstallation> InstalledApps
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.UserScopeTeamsAppInstallation>>("installedApps"); }
            set { BackingStore?.Set("installedApps", value); }
        }
#endif
        /// <summary>Represents the location that a user selected in Microsoft Teams and doesn&apos;t follow the Office&apos;s locale setting. A user’s locale is represented by their preferred language and country or region. For example, en-us. The language component follows two-letter codes as defined in ISO 639-1, and the country component follows two-letter codes as defined in ISO 3166-1 alpha-2.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Locale
        {
            get { return BackingStore?.Get<string?>("locale"); }
            set { BackingStore?.Set("locale", value); }
        }
#nullable restore
#else
        public string Locale
        {
            get { return BackingStore?.Get<string>("locale"); }
            set { BackingStore?.Set("locale", value); }
        }
#endif
        /// <summary>Represents the region of the organization or the user. For users with multigeo licenses, the property contains the user&apos;s region (if available). For users without multigeo licenses, the property contains the organization&apos;s region.The region value can be any region supported by the Teams payload. The possible values are: Americas, Europe and MiddleEast, Asia Pacific, UAE, Australia, Brazil, Canada, Switzerland, Germany, France, India, Japan, South Korea, Norway, Singapore, United Kingdom, South Africa, Sweden, Qatar, Poland, Italy, Israel, Spain, Mexico, USGov Community Cloud, USGov Community Cloud High, USGov Department of Defense, and China.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Region
        {
            get { return BackingStore?.Get<string?>("region"); }
            set { BackingStore?.Set("region", value); }
        }
#nullable restore
#else
        public string Region
        {
            get { return BackingStore?.Get<string>("region"); }
            set { BackingStore?.Set("region", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.UserTeamwork"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.UserTeamwork CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.UserTeamwork();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "associatedTeams", n => { AssociatedTeams = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.AssociatedTeamInfo>(global::Microsoft.Graph.Models.AssociatedTeamInfo.CreateFromDiscriminatorValue)?.AsList(); } },
                { "installedApps", n => { InstalledApps = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.UserScopeTeamsAppInstallation>(global::Microsoft.Graph.Models.UserScopeTeamsAppInstallation.CreateFromDiscriminatorValue)?.AsList(); } },
                { "locale", n => { Locale = n.GetStringValue(); } },
                { "region", n => { Region = n.GetStringValue(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.AssociatedTeamInfo>("associatedTeams", AssociatedTeams);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.UserScopeTeamsAppInstallation>("installedApps", InstalledApps);
            writer.WriteStringValue("locale", Locale);
            writer.WriteStringValue("region", Region);
        }
    }
}
#pragma warning restore CS0618
