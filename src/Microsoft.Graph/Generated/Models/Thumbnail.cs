// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class Thumbnail : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The content stream for the thumbnail.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? Content
        {
            get { return BackingStore?.Get<byte[]?>("content"); }
            set { BackingStore?.Set("content", value); }
        }
#nullable restore
#else
        public byte[] Content
        {
            get { return BackingStore?.Get<byte[]>("content"); }
            set { BackingStore?.Set("content", value); }
        }
#endif
        /// <summary>The height of the thumbnail, in pixels.</summary>
        public int? Height
        {
            get { return BackingStore?.Get<int?>("height"); }
            set { BackingStore?.Set("height", value); }
        }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The unique identifier of the item that provided the thumbnail. This is only available when a folder thumbnail is requested.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SourceItemId
        {
            get { return BackingStore?.Get<string?>("sourceItemId"); }
            set { BackingStore?.Set("sourceItemId", value); }
        }
#nullable restore
#else
        public string SourceItemId
        {
            get { return BackingStore?.Get<string>("sourceItemId"); }
            set { BackingStore?.Set("sourceItemId", value); }
        }
#endif
        /// <summary>The URL used to fetch the thumbnail content.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url
        {
            get { return BackingStore?.Get<string?>("url"); }
            set { BackingStore?.Set("url", value); }
        }
#nullable restore
#else
        public string Url
        {
            get { return BackingStore?.Get<string>("url"); }
            set { BackingStore?.Set("url", value); }
        }
#endif
        /// <summary>The width of the thumbnail, in pixels.</summary>
        public int? Width
        {
            get { return BackingStore?.Get<int?>("width"); }
            set { BackingStore?.Set("width", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.Thumbnail"/> and sets the default values.
        /// </summary>
        public Thumbnail()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Thumbnail"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Models.Thumbnail CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.Thumbnail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "content", n => { Content = n.GetByteArrayValue(); } },
                { "height", n => { Height = n.GetIntValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "sourceItemId", n => { SourceItemId = n.GetStringValue(); } },
                { "url", n => { Url = n.GetStringValue(); } },
                { "width", n => { Width = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteByteArrayValue("content", Content);
            writer.WriteIntValue("height", Height);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("sourceItemId", SourceItemId);
            writer.WriteStringValue("url", Url);
            writer.WriteIntValue("width", Width);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
