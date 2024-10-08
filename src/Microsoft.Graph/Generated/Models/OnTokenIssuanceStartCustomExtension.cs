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
    public partial class OnTokenIssuanceStartCustomExtension : global::Microsoft.Graph.Models.CustomAuthenticationExtension, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Collection of claims to be returned by the API called by this custom authentication extension. Used to populate claims mapping experience in Microsoft Entra admin center. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.OnTokenIssuanceStartReturnClaim>? ClaimsForTokenConfiguration
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.OnTokenIssuanceStartReturnClaim>?>("claimsForTokenConfiguration"); }
            set { BackingStore?.Set("claimsForTokenConfiguration", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.OnTokenIssuanceStartReturnClaim> ClaimsForTokenConfiguration
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.OnTokenIssuanceStartReturnClaim>>("claimsForTokenConfiguration"); }
            set { BackingStore?.Set("claimsForTokenConfiguration", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.OnTokenIssuanceStartCustomExtension"/> and sets the default values.
        /// </summary>
        public OnTokenIssuanceStartCustomExtension() : base()
        {
            OdataType = "#microsoft.graph.onTokenIssuanceStartCustomExtension";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.OnTokenIssuanceStartCustomExtension"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.OnTokenIssuanceStartCustomExtension CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.OnTokenIssuanceStartCustomExtension();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "claimsForTokenConfiguration", n => { ClaimsForTokenConfiguration = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.OnTokenIssuanceStartReturnClaim>(global::Microsoft.Graph.Models.OnTokenIssuanceStartReturnClaim.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.OnTokenIssuanceStartReturnClaim>("claimsForTokenConfiguration", ClaimsForTokenConfiguration);
        }
    }
}
#pragma warning restore CS0618
