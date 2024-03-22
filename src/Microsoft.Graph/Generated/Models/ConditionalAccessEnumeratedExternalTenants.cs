// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class ConditionalAccessEnumeratedExternalTenants : ConditionalAccessExternalTenants, IParsable 
    {
        /// <summary>A collection of tenant IDs that define the scope of a policy targeting conditional access for guests and external users.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Members {
            get { return BackingStore?.Get<List<string>?>("members"); }
            set { BackingStore?.Set("members", value); }
        }
#nullable restore
#else
        public List<string> Members {
            get { return BackingStore?.Get<List<string>>("members"); }
            set { BackingStore?.Set("members", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="ConditionalAccessEnumeratedExternalTenants"/> and sets the default values.
        /// </summary>
        public ConditionalAccessEnumeratedExternalTenants() : base()
        {
            OdataType = "#microsoft.graph.conditionalAccessEnumeratedExternalTenants";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ConditionalAccessEnumeratedExternalTenants"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ConditionalAccessEnumeratedExternalTenants CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConditionalAccessEnumeratedExternalTenants();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"members", n => { Members = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
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
            writer.WriteCollectionOfPrimitiveValues<string>("members", Members);
        }
    }
}
