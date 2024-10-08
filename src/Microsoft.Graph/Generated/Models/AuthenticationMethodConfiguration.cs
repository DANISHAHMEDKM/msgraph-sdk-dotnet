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
    public partial class AuthenticationMethodConfiguration : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Groups of users that are excluded from a policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.ExcludeTarget>? ExcludeTargets
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.ExcludeTarget>?>("excludeTargets"); }
            set { BackingStore?.Set("excludeTargets", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.ExcludeTarget> ExcludeTargets
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.ExcludeTarget>>("excludeTargets"); }
            set { BackingStore?.Set("excludeTargets", value); }
        }
#endif
        /// <summary>The state of the policy. Possible values are: enabled, disabled.</summary>
        public global::Microsoft.Graph.Models.AuthenticationMethodState? State
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AuthenticationMethodState?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.AuthenticationMethodConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.AuthenticationMethodConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.emailAuthenticationMethodConfiguration" => new global::Microsoft.Graph.Models.EmailAuthenticationMethodConfiguration(),
                "#microsoft.graph.fido2AuthenticationMethodConfiguration" => new global::Microsoft.Graph.Models.Fido2AuthenticationMethodConfiguration(),
                "#microsoft.graph.microsoftAuthenticatorAuthenticationMethodConfiguration" => new global::Microsoft.Graph.Models.MicrosoftAuthenticatorAuthenticationMethodConfiguration(),
                "#microsoft.graph.smsAuthenticationMethodConfiguration" => new global::Microsoft.Graph.Models.SmsAuthenticationMethodConfiguration(),
                "#microsoft.graph.softwareOathAuthenticationMethodConfiguration" => new global::Microsoft.Graph.Models.SoftwareOathAuthenticationMethodConfiguration(),
                "#microsoft.graph.temporaryAccessPassAuthenticationMethodConfiguration" => new global::Microsoft.Graph.Models.TemporaryAccessPassAuthenticationMethodConfiguration(),
                "#microsoft.graph.voiceAuthenticationMethodConfiguration" => new global::Microsoft.Graph.Models.VoiceAuthenticationMethodConfiguration(),
                "#microsoft.graph.x509CertificateAuthenticationMethodConfiguration" => new global::Microsoft.Graph.Models.X509CertificateAuthenticationMethodConfiguration(),
                _ => new global::Microsoft.Graph.Models.AuthenticationMethodConfiguration(),
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
                { "excludeTargets", n => { ExcludeTargets = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.ExcludeTarget>(global::Microsoft.Graph.Models.ExcludeTarget.CreateFromDiscriminatorValue)?.AsList(); } },
                { "state", n => { State = n.GetEnumValue<global::Microsoft.Graph.Models.AuthenticationMethodState>(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.ExcludeTarget>("excludeTargets", ExcludeTargets);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.AuthenticationMethodState>("state", State);
        }
    }
}
#pragma warning restore CS0618
