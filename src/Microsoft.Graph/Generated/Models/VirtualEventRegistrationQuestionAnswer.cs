// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class VirtualEventRegistrationQuestionAnswer : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("AdditionalData"); }
            set { BackingStore?.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The booleanValue property</summary>
        public bool? BooleanValue {
            get { return BackingStore?.Get<bool?>("booleanValue"); }
            set { BackingStore?.Set("booleanValue", value); }
        }
        /// <summary>The displayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The multiChoiceValues property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? MultiChoiceValues {
            get { return BackingStore?.Get<List<string>?>("multiChoiceValues"); }
            set { BackingStore?.Set("multiChoiceValues", value); }
        }
#nullable restore
#else
        public List<string> MultiChoiceValues {
            get { return BackingStore?.Get<List<string>>("multiChoiceValues"); }
            set { BackingStore?.Set("multiChoiceValues", value); }
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
        /// <summary>The questionId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? QuestionId {
            get { return BackingStore?.Get<string?>("questionId"); }
            set { BackingStore?.Set("questionId", value); }
        }
#nullable restore
#else
        public string QuestionId {
            get { return BackingStore?.Get<string>("questionId"); }
            set { BackingStore?.Set("questionId", value); }
        }
#endif
        /// <summary>The value property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Value {
            get { return BackingStore?.Get<string?>("value"); }
            set { BackingStore?.Set("value", value); }
        }
#nullable restore
#else
        public string Value {
            get { return BackingStore?.Get<string>("value"); }
            set { BackingStore?.Set("value", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new virtualEventRegistrationQuestionAnswer and sets the default values.
        /// </summary>
        public VirtualEventRegistrationQuestionAnswer() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static VirtualEventRegistrationQuestionAnswer CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new VirtualEventRegistrationQuestionAnswer();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"booleanValue", n => { BooleanValue = n.GetBoolValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"multiChoiceValues", n => { MultiChoiceValues = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"questionId", n => { QuestionId = n.GetStringValue(); } },
                {"value", n => { Value = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("booleanValue", BooleanValue);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfPrimitiveValues<string>("multiChoiceValues", MultiChoiceValues);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("questionId", QuestionId);
            writer.WriteStringValue("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
