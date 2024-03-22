// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models.ExternalConnectors {
    public class ExternalActivity : Microsoft.Graph.Models.Entity, IParsable 
    {
        /// <summary>Represents an identity used to identify who is responsible for the activity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Identity? PerformedBy {
            get { return BackingStore?.Get<Identity?>("performedBy"); }
            set { BackingStore?.Set("performedBy", value); }
        }
#nullable restore
#else
        public Identity PerformedBy {
            get { return BackingStore?.Get<Identity>("performedBy"); }
            set { BackingStore?.Set("performedBy", value); }
        }
#endif
        /// <summary>The date and time when the particular activity occurred. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? StartDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("startDateTime"); }
            set { BackingStore?.Set("startDateTime", value); }
        }
        /// <summary>The type property</summary>
        public ExternalActivityType? Type {
            get { return BackingStore?.Get<ExternalActivityType?>("type"); }
            set { BackingStore?.Set("type", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ExternalActivity"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ExternalActivity CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.externalConnectors.externalActivityResult" => new ExternalActivityResult(),
                _ => new ExternalActivity(),
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
                {"performedBy", n => { PerformedBy = n.GetObjectValue<Identity>(Identity.CreateFromDiscriminatorValue); } },
                {"startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
                {"type", n => { Type = n.GetEnumValue<ExternalActivityType>(); } },
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
            writer.WriteObjectValue<Identity>("performedBy", PerformedBy);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteEnumValue<ExternalActivityType>("type", Type);
        }
    }
}
