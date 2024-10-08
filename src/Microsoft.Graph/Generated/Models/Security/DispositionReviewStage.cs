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
    public partial class DispositionReviewStage : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Name representing each stage within a collection.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name
        {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#nullable restore
#else
        public string Name
        {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#endif
        /// <summary>A collection of reviewers at each stage.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ReviewersEmailAddresses
        {
            get { return BackingStore?.Get<List<string>?>("reviewersEmailAddresses"); }
            set { BackingStore?.Set("reviewersEmailAddresses", value); }
        }
#nullable restore
#else
        public List<string> ReviewersEmailAddresses
        {
            get { return BackingStore?.Get<List<string>>("reviewersEmailAddresses"); }
            set { BackingStore?.Set("reviewersEmailAddresses", value); }
        }
#endif
        /// <summary>The unique sequence number for each stage of the disposition review.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StageNumber
        {
            get { return BackingStore?.Get<string?>("stageNumber"); }
            set { BackingStore?.Set("stageNumber", value); }
        }
#nullable restore
#else
        public string StageNumber
        {
            get { return BackingStore?.Get<string>("stageNumber"); }
            set { BackingStore?.Set("stageNumber", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Security.DispositionReviewStage"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.Security.DispositionReviewStage CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.Security.DispositionReviewStage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "name", n => { Name = n.GetStringValue(); } },
                { "reviewersEmailAddresses", n => { ReviewersEmailAddresses = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "stageNumber", n => { StageNumber = n.GetStringValue(); } },
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
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfPrimitiveValues<string>("reviewersEmailAddresses", ReviewersEmailAddresses);
            writer.WriteStringValue("stageNumber", StageNumber);
        }
    }
}
#pragma warning restore CS0618
