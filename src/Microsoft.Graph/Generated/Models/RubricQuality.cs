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
    public partial class RubricQuality : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The collection of criteria for this rubric quality.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.RubricCriterion>? Criteria
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.RubricCriterion>?>("criteria"); }
            set { BackingStore?.Set("criteria", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.RubricCriterion> Criteria
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.RubricCriterion>>("criteria"); }
            set { BackingStore?.Set("criteria", value); }
        }
#endif
        /// <summary>The description of this rubric quality.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.EducationItemBody? Description
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.EducationItemBody?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.EducationItemBody Description
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.EducationItemBody>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>The name of this rubric quality.</summary>
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
        /// <summary>The ID of this resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? QualityId
        {
            get { return BackingStore?.Get<string?>("qualityId"); }
            set { BackingStore?.Set("qualityId", value); }
        }
#nullable restore
#else
        public string QualityId
        {
            get { return BackingStore?.Get<string>("qualityId"); }
            set { BackingStore?.Set("qualityId", value); }
        }
#endif
        /// <summary>If present, a numerical weight for this quality.  Weights must add up to 100.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.RubricQuality.RubricQuality_weight? Weight
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.RubricQuality.RubricQuality_weight?>("weight"); }
            set { BackingStore?.Set("weight", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.RubricQuality.RubricQuality_weight Weight
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.RubricQuality.RubricQuality_weight>("weight"); }
            set { BackingStore?.Set("weight", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.RubricQuality"/> and sets the default values.
        /// </summary>
        public RubricQuality()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.RubricQuality"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Models.RubricQuality CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.RubricQuality();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "criteria", n => { Criteria = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.RubricCriterion>(global::Microsoft.Graph.Models.RubricCriterion.CreateFromDiscriminatorValue)?.AsList(); } },
                { "description", n => { Description = n.GetObjectValue<global::Microsoft.Graph.Models.EducationItemBody>(global::Microsoft.Graph.Models.EducationItemBody.CreateFromDiscriminatorValue); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "qualityId", n => { QualityId = n.GetStringValue(); } },
                { "weight", n => { Weight = n.GetObjectValue<global::Microsoft.Graph.Models.RubricQuality.RubricQuality_weight>(global::Microsoft.Graph.Models.RubricQuality.RubricQuality_weight.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.RubricCriterion>("criteria", Criteria);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.EducationItemBody>("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("qualityId", QualityId);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.RubricQuality.RubricQuality_weight>("weight", Weight);
            writer.WriteAdditionalData(AdditionalData);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="float"/>, <see cref="global::Microsoft.Graph.Models.ReferenceNumeric"/>, <see cref="string"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class RubricQuality_weight : IBackedModel, IComposedTypeWrapper, IParsable
        {
            /// <summary>Stores model information.</summary>
            public IBackingStore BackingStore { get; private set; }
            /// <summary>Composed type representation for type <see cref="float"/></summary>
            public float? Float
            {
                get { return BackingStore?.Get<float?>("float"); }
                set { BackingStore?.Set("float", value); }
            }
            /// <summary>Composed type representation for type <see cref="global::Microsoft.Graph.Models.ReferenceNumeric"/></summary>
            public global::Microsoft.Graph.Models.ReferenceNumeric? ReferenceNumeric
            {
                get { return BackingStore?.Get<global::Microsoft.Graph.Models.ReferenceNumeric?>("ReferenceNumeric"); }
                set { BackingStore?.Set("ReferenceNumeric", value); }
            }
            /// <summary>Composed type representation for type <see cref="string"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? String
            {
                get { return BackingStore?.Get<string?>("string"); }
                set { BackingStore?.Set("string", value); }
            }
#nullable restore
#else
            public string String
            {
                get { return BackingStore?.Get<string>("string"); }
                set { BackingStore?.Set("string", value); }
            }
#endif
            /// <summary>
            /// Instantiates a new <see cref="global::Microsoft.Graph.Models.RubricQuality.RubricQuality_weight"/> and sets the default values.
            /// </summary>
            public RubricQuality_weight()
            {
                BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            }
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::Microsoft.Graph.Models.RubricQuality.RubricQuality_weight"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Microsoft.Graph.Models.RubricQuality.RubricQuality_weight CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new global::Microsoft.Graph.Models.RubricQuality.RubricQuality_weight();
                if(parseNode.GetEnumValue<global::Microsoft.Graph.Models.ReferenceNumeric>() is global::Microsoft.Graph.Models.ReferenceNumeric referenceNumericValue)
                {
                    result.ReferenceNumeric = referenceNumericValue;
                }
                else if(parseNode.GetFloatValue() is float floatValue)
                {
                    result.Float = floatValue;
                }
                else if(parseNode.GetStringValue() is string stringValue)
                {
                    result.String = stringValue;
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer)
            {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                if(ReferenceNumeric != null)
                {
                    writer.WriteEnumValue<global::Microsoft.Graph.Models.ReferenceNumeric>(null, ReferenceNumeric);
                }
                else if(Float != null)
                {
                    writer.WriteFloatValue(null, Float);
                }
                else if(String != null)
                {
                    writer.WriteStringValue(null, String);
                }
            }
        }
    }
}
#pragma warning restore CS0618
