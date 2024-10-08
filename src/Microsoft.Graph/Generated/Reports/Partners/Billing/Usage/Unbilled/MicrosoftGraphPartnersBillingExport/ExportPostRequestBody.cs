// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Models.Partners.Billing;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Reports.Partners.Billing.Usage.Unbilled.MicrosoftGraphPartnersBillingExport
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class ExportPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>The attributeSet property</summary>
        public global::Microsoft.Graph.Models.Partners.Billing.AttributeSet? AttributeSet
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Partners.Billing.AttributeSet?>("attributeSet"); }
            set { BackingStore?.Set("attributeSet", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The billingPeriod property</summary>
        public global::Microsoft.Graph.Models.Partners.Billing.BillingPeriod? BillingPeriod
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Partners.Billing.BillingPeriod?>("billingPeriod"); }
            set { BackingStore?.Set("billingPeriod", value); }
        }
        /// <summary>The currencyCode property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CurrencyCode
        {
            get { return BackingStore?.Get<string?>("currencyCode"); }
            set { BackingStore?.Set("currencyCode", value); }
        }
#nullable restore
#else
        public string CurrencyCode
        {
            get { return BackingStore?.Get<string>("currencyCode"); }
            set { BackingStore?.Set("currencyCode", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Reports.Partners.Billing.Usage.Unbilled.MicrosoftGraphPartnersBillingExport.ExportPostRequestBody"/> and sets the default values.
        /// </summary>
        public ExportPostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Reports.Partners.Billing.Usage.Unbilled.MicrosoftGraphPartnersBillingExport.ExportPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Reports.Partners.Billing.Usage.Unbilled.MicrosoftGraphPartnersBillingExport.ExportPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Reports.Partners.Billing.Usage.Unbilled.MicrosoftGraphPartnersBillingExport.ExportPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "attributeSet", n => { AttributeSet = n.GetEnumValue<global::Microsoft.Graph.Models.Partners.Billing.AttributeSet>(); } },
                { "billingPeriod", n => { BillingPeriod = n.GetEnumValue<global::Microsoft.Graph.Models.Partners.Billing.BillingPeriod>(); } },
                { "currencyCode", n => { CurrencyCode = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::Microsoft.Graph.Models.Partners.Billing.AttributeSet>("attributeSet", AttributeSet);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.Partners.Billing.BillingPeriod>("billingPeriod", BillingPeriod);
            writer.WriteStringValue("currencyCode", CurrencyCode);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
