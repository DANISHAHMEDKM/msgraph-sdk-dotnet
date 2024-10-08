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
    public partial class SecureScore : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Active user count of the given tenant.</summary>
        public int? ActiveUserCount
        {
            get { return BackingStore?.Get<int?>("activeUserCount"); }
            set { BackingStore?.Set("activeUserCount", value); }
        }
        /// <summary>Average score by different scopes (for example, average by industry, average by seating) and control category (Identity, Data, Device, Apps, Infrastructure) within the scope.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.AverageComparativeScore>? AverageComparativeScores
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AverageComparativeScore>?>("averageComparativeScores"); }
            set { BackingStore?.Set("averageComparativeScores", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.AverageComparativeScore> AverageComparativeScores
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AverageComparativeScore>>("averageComparativeScores"); }
            set { BackingStore?.Set("averageComparativeScores", value); }
        }
#endif
        /// <summary>GUID string for tenant ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AzureTenantId
        {
            get { return BackingStore?.Get<string?>("azureTenantId"); }
            set { BackingStore?.Set("azureTenantId", value); }
        }
#nullable restore
#else
        public string AzureTenantId
        {
            get { return BackingStore?.Get<string>("azureTenantId"); }
            set { BackingStore?.Set("azureTenantId", value); }
        }
#endif
        /// <summary>Contains tenant scores for a set of controls.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.ControlScore>? ControlScores
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.ControlScore>?>("controlScores"); }
            set { BackingStore?.Set("controlScores", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.ControlScore> ControlScores
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.ControlScore>>("controlScores"); }
            set { BackingStore?.Set("controlScores", value); }
        }
#endif
        /// <summary>When the report was created.</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Tenant current attained score on specified date.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.SecureScore.SecureScore_currentScore? CurrentScore
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.SecureScore.SecureScore_currentScore?>("currentScore"); }
            set { BackingStore?.Set("currentScore", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.SecureScore.SecureScore_currentScore CurrentScore
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.SecureScore.SecureScore_currentScore>("currentScore"); }
            set { BackingStore?.Set("currentScore", value); }
        }
#endif
        /// <summary>Microsoft-provided services for the tenant (for example, Exchange online, Skype, Sharepoint).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? EnabledServices
        {
            get { return BackingStore?.Get<List<string>?>("enabledServices"); }
            set { BackingStore?.Set("enabledServices", value); }
        }
#nullable restore
#else
        public List<string> EnabledServices
        {
            get { return BackingStore?.Get<List<string>>("enabledServices"); }
            set { BackingStore?.Set("enabledServices", value); }
        }
#endif
        /// <summary>Licensed user count of the given tenant.</summary>
        public int? LicensedUserCount
        {
            get { return BackingStore?.Get<int?>("licensedUserCount"); }
            set { BackingStore?.Set("licensedUserCount", value); }
        }
        /// <summary>Tenant maximum possible score on specified date.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.SecureScore.SecureScore_maxScore? MaxScore
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.SecureScore.SecureScore_maxScore?>("maxScore"); }
            set { BackingStore?.Set("maxScore", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.SecureScore.SecureScore_maxScore MaxScore
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.SecureScore.SecureScore_maxScore>("maxScore"); }
            set { BackingStore?.Set("maxScore", value); }
        }
#endif
        /// <summary>Complex type containing details about the security product/service vendor, provider, and subprovider (for example, vendor=Microsoft; provider=SecureScore). Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.SecurityVendorInformation? VendorInformation
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.SecurityVendorInformation?>("vendorInformation"); }
            set { BackingStore?.Set("vendorInformation", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.SecurityVendorInformation VendorInformation
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.SecurityVendorInformation>("vendorInformation"); }
            set { BackingStore?.Set("vendorInformation", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.SecureScore"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.SecureScore CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.SecureScore();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "activeUserCount", n => { ActiveUserCount = n.GetIntValue(); } },
                { "averageComparativeScores", n => { AverageComparativeScores = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.AverageComparativeScore>(global::Microsoft.Graph.Models.AverageComparativeScore.CreateFromDiscriminatorValue)?.AsList(); } },
                { "azureTenantId", n => { AzureTenantId = n.GetStringValue(); } },
                { "controlScores", n => { ControlScores = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.ControlScore>(global::Microsoft.Graph.Models.ControlScore.CreateFromDiscriminatorValue)?.AsList(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "currentScore", n => { CurrentScore = n.GetObjectValue<global::Microsoft.Graph.Models.SecureScore.SecureScore_currentScore>(global::Microsoft.Graph.Models.SecureScore.SecureScore_currentScore.CreateFromDiscriminatorValue); } },
                { "enabledServices", n => { EnabledServices = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "licensedUserCount", n => { LicensedUserCount = n.GetIntValue(); } },
                { "maxScore", n => { MaxScore = n.GetObjectValue<global::Microsoft.Graph.Models.SecureScore.SecureScore_maxScore>(global::Microsoft.Graph.Models.SecureScore.SecureScore_maxScore.CreateFromDiscriminatorValue); } },
                { "vendorInformation", n => { VendorInformation = n.GetObjectValue<global::Microsoft.Graph.Models.SecurityVendorInformation>(global::Microsoft.Graph.Models.SecurityVendorInformation.CreateFromDiscriminatorValue); } },
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
            writer.WriteIntValue("activeUserCount", ActiveUserCount);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.AverageComparativeScore>("averageComparativeScores", AverageComparativeScores);
            writer.WriteStringValue("azureTenantId", AzureTenantId);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.ControlScore>("controlScores", ControlScores);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.SecureScore.SecureScore_currentScore>("currentScore", CurrentScore);
            writer.WriteCollectionOfPrimitiveValues<string>("enabledServices", EnabledServices);
            writer.WriteIntValue("licensedUserCount", LicensedUserCount);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.SecureScore.SecureScore_maxScore>("maxScore", MaxScore);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.SecurityVendorInformation>("vendorInformation", VendorInformation);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="double"/>, <see cref="global::Microsoft.Graph.Models.ReferenceNumeric"/>, <see cref="string"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class SecureScore_currentScore : IBackedModel, IComposedTypeWrapper, IParsable
        {
            /// <summary>Stores model information.</summary>
            public IBackingStore BackingStore { get; private set; }
            /// <summary>Composed type representation for type <see cref="double"/></summary>
            public double? Double
            {
                get { return BackingStore?.Get<double?>("double"); }
                set { BackingStore?.Set("double", value); }
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
            /// Instantiates a new <see cref="global::Microsoft.Graph.Models.SecureScore.SecureScore_currentScore"/> and sets the default values.
            /// </summary>
            public SecureScore_currentScore()
            {
                BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            }
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::Microsoft.Graph.Models.SecureScore.SecureScore_currentScore"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Microsoft.Graph.Models.SecureScore.SecureScore_currentScore CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new global::Microsoft.Graph.Models.SecureScore.SecureScore_currentScore();
                if(parseNode.GetEnumValue<global::Microsoft.Graph.Models.ReferenceNumeric>() is global::Microsoft.Graph.Models.ReferenceNumeric referenceNumericValue)
                {
                    result.ReferenceNumeric = referenceNumericValue;
                }
                else if(parseNode.GetDoubleValue() is double doubleValue)
                {
                    result.Double = doubleValue;
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
                else if(Double != null)
                {
                    writer.WriteDoubleValue(null, Double);
                }
                else if(String != null)
                {
                    writer.WriteStringValue(null, String);
                }
            }
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="double"/>, <see cref="global::Microsoft.Graph.Models.ReferenceNumeric"/>, <see cref="string"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class SecureScore_maxScore : IBackedModel, IComposedTypeWrapper, IParsable
        {
            /// <summary>Stores model information.</summary>
            public IBackingStore BackingStore { get; private set; }
            /// <summary>Composed type representation for type <see cref="double"/></summary>
            public double? Double
            {
                get { return BackingStore?.Get<double?>("double"); }
                set { BackingStore?.Set("double", value); }
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
            /// Instantiates a new <see cref="global::Microsoft.Graph.Models.SecureScore.SecureScore_maxScore"/> and sets the default values.
            /// </summary>
            public SecureScore_maxScore()
            {
                BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            }
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::Microsoft.Graph.Models.SecureScore.SecureScore_maxScore"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Microsoft.Graph.Models.SecureScore.SecureScore_maxScore CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new global::Microsoft.Graph.Models.SecureScore.SecureScore_maxScore();
                if(parseNode.GetEnumValue<global::Microsoft.Graph.Models.ReferenceNumeric>() is global::Microsoft.Graph.Models.ReferenceNumeric referenceNumericValue)
                {
                    result.ReferenceNumeric = referenceNumericValue;
                }
                else if(parseNode.GetDoubleValue() is double doubleValue)
                {
                    result.Double = doubleValue;
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
                else if(Double != null)
                {
                    writer.WriteDoubleValue(null, Double);
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
