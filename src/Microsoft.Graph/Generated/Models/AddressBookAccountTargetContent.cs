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
    public partial class AddressBookAccountTargetContent : global::Microsoft.Graph.Models.AccountTargetContent, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>List of user emails targeted for an attack simulation training campaign.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AccountTargetEmails
        {
            get { return BackingStore?.Get<List<string>?>("accountTargetEmails"); }
            set { BackingStore?.Set("accountTargetEmails", value); }
        }
#nullable restore
#else
        public List<string> AccountTargetEmails
        {
            get { return BackingStore?.Get<List<string>>("accountTargetEmails"); }
            set { BackingStore?.Set("accountTargetEmails", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.AddressBookAccountTargetContent"/> and sets the default values.
        /// </summary>
        public AddressBookAccountTargetContent() : base()
        {
            OdataType = "#microsoft.graph.addressBookAccountTargetContent";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.AddressBookAccountTargetContent"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.AddressBookAccountTargetContent CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.AddressBookAccountTargetContent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "accountTargetEmails", n => { AccountTargetEmails = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
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
            writer.WriteCollectionOfPrimitiveValues<string>("accountTargetEmails", AccountTargetEmails);
        }
    }
}
#pragma warning restore CS0618
