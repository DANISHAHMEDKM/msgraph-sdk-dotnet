// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class Filter : IAdditionalDataHolder, IBackedModel, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("AdditionalData"); }
            set { BackingStore?.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>*Experimental* Filter group set used to decide whether given object belongs and should be processed as part of this object mapping. An object is considered in scope if ANY of the groups in the collection is evaluated to true.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<FilterGroup>? CategoryFilterGroups {
            get { return BackingStore?.Get<List<FilterGroup>?>("categoryFilterGroups"); }
            set { BackingStore?.Set("categoryFilterGroups", value); }
        }
#nullable restore
#else
        public List<FilterGroup> CategoryFilterGroups {
            get { return BackingStore?.Get<List<FilterGroup>>("categoryFilterGroups"); }
            set { BackingStore?.Set("categoryFilterGroups", value); }
        }
#endif
        /// <summary>Filter group set used to decide whether given object is in scope for provisioning. This is the filter which should be used in most cases. If an object used to satisfy this filter at a given moment, and then the object or the filter was changed so that filter isn&apos;t satisfied any longer, such object will get deprovisioned&apos;. An object is considered in scope if ANY of the groups in the collection is evaluated to true.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<FilterGroup>? Groups {
            get { return BackingStore?.Get<List<FilterGroup>?>("groups"); }
            set { BackingStore?.Set("groups", value); }
        }
#nullable restore
#else
        public List<FilterGroup> Groups {
            get { return BackingStore?.Get<List<FilterGroup>>("groups"); }
            set { BackingStore?.Set("groups", value); }
        }
#endif
        /// <summary>*Experimental* Filter group set used to filter out objects at the early stage of reading them from the directory. If an object doesn&apos;t satisfy this filter, then it will not be processed further. Important to understand is that if an object used to satisfy this filter at a given moment, and then the object or the filter was changed so that filter is no longer satisfied, such object will NOT get deprovisioned. An object is considered in scope if ANY of the groups in the collection is evaluated to true.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<FilterGroup>? InputFilterGroups {
            get { return BackingStore?.Get<List<FilterGroup>?>("inputFilterGroups"); }
            set { BackingStore?.Set("inputFilterGroups", value); }
        }
#nullable restore
#else
        public List<FilterGroup> InputFilterGroups {
            get { return BackingStore?.Get<List<FilterGroup>>("inputFilterGroups"); }
            set { BackingStore?.Set("inputFilterGroups", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Filter"/> and sets the default values.
        /// </summary>
        public Filter()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Filter"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Filter CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Filter();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"categoryFilterGroups", n => { CategoryFilterGroups = n.GetCollectionOfObjectValues<FilterGroup>(FilterGroup.CreateFromDiscriminatorValue)?.ToList(); } },
                {"groups", n => { Groups = n.GetCollectionOfObjectValues<FilterGroup>(FilterGroup.CreateFromDiscriminatorValue)?.ToList(); } },
                {"inputFilterGroups", n => { InputFilterGroups = n.GetCollectionOfObjectValues<FilterGroup>(FilterGroup.CreateFromDiscriminatorValue)?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<FilterGroup>("categoryFilterGroups", CategoryFilterGroups);
            writer.WriteCollectionOfObjectValues<FilterGroup>("groups", Groups);
            writer.WriteCollectionOfObjectValues<FilterGroup>("inputFilterGroups", InputFilterGroups);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
