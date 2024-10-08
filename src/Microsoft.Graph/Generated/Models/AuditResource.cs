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
    /// <summary>
    /// A class containing the properties for Audit Resource.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class AuditResource : IAdditionalDataHolder, IBackedModel, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Audit resource&apos;s type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AuditResourceType
        {
            get { return BackingStore?.Get<string?>("auditResourceType"); }
            set { BackingStore?.Set("auditResourceType", value); }
        }
#nullable restore
#else
        public string AuditResourceType
        {
            get { return BackingStore?.Get<string>("auditResourceType"); }
            set { BackingStore?.Set("auditResourceType", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Display name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName
        {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName
        {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>List of modified properties.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.AuditProperty>? ModifiedProperties
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AuditProperty>?>("modifiedProperties"); }
            set { BackingStore?.Set("modifiedProperties", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.AuditProperty> ModifiedProperties
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AuditProperty>>("modifiedProperties"); }
            set { BackingStore?.Set("modifiedProperties", value); }
        }
#endif
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
        /// <summary>Audit resource&apos;s Id.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourceId
        {
            get { return BackingStore?.Get<string?>("resourceId"); }
            set { BackingStore?.Set("resourceId", value); }
        }
#nullable restore
#else
        public string ResourceId
        {
            get { return BackingStore?.Get<string>("resourceId"); }
            set { BackingStore?.Set("resourceId", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.AuditResource"/> and sets the default values.
        /// </summary>
        public AuditResource()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.AuditResource"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Models.AuditResource CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.AuditResource();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "auditResourceType", n => { AuditResourceType = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "modifiedProperties", n => { ModifiedProperties = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.AuditProperty>(global::Microsoft.Graph.Models.AuditProperty.CreateFromDiscriminatorValue)?.AsList(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "resourceId", n => { ResourceId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("auditResourceType", AuditResourceType);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.AuditProperty>("modifiedProperties", ModifiedProperties);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("resourceId", ResourceId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
