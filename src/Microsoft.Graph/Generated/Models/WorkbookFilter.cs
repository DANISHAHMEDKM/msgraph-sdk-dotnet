// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class WorkbookFilter : Entity, IParsable 
    {
        /// <summary>The currently applied filter on the given column. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WorkbookFilterCriteria? Criteria {
            get { return BackingStore?.Get<WorkbookFilterCriteria?>("criteria"); }
            set { BackingStore?.Set("criteria", value); }
        }
#nullable restore
#else
        public WorkbookFilterCriteria Criteria {
            get { return BackingStore?.Get<WorkbookFilterCriteria>("criteria"); }
            set { BackingStore?.Set("criteria", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="WorkbookFilter"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WorkbookFilter CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkbookFilter();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"criteria", n => { Criteria = n.GetObjectValue<WorkbookFilterCriteria>(WorkbookFilterCriteria.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<WorkbookFilterCriteria>("criteria", Criteria);
        }
    }
}
