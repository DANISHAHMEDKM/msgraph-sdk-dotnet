// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    /// <summary>
    /// Windows Log Collection request entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class DeviceLogCollectionResponse : global::Microsoft.Graph.Models.Entity, IParsable
    {
        /// <summary>The User Principal Name (UPN) of the user that enrolled the device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EnrolledByUser
        {
            get { return BackingStore?.Get<string?>("enrolledByUser"); }
            set { BackingStore?.Set("enrolledByUser", value); }
        }
#nullable restore
#else
        public string EnrolledByUser
        {
            get { return BackingStore?.Get<string>("enrolledByUser"); }
            set { BackingStore?.Set("enrolledByUser", value); }
        }
#endif
        /// <summary>The DateTime of the expiration of the logs.</summary>
        public DateTimeOffset? ExpirationDateTimeUTC
        {
            get { return BackingStore?.Get<DateTimeOffset?>("expirationDateTimeUTC"); }
            set { BackingStore?.Set("expirationDateTimeUTC", value); }
        }
        /// <summary>The UPN for who initiated the request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InitiatedByUserPrincipalName
        {
            get { return BackingStore?.Get<string?>("initiatedByUserPrincipalName"); }
            set { BackingStore?.Set("initiatedByUserPrincipalName", value); }
        }
#nullable restore
#else
        public string InitiatedByUserPrincipalName
        {
            get { return BackingStore?.Get<string>("initiatedByUserPrincipalName"); }
            set { BackingStore?.Set("initiatedByUserPrincipalName", value); }
        }
#endif
        /// <summary>Indicates Intune device unique identifier.</summary>
        public Guid? ManagedDeviceId
        {
            get { return BackingStore?.Get<Guid?>("managedDeviceId"); }
            set { BackingStore?.Set("managedDeviceId", value); }
        }
        /// <summary>The DateTime the request was received.</summary>
        public DateTimeOffset? ReceivedDateTimeUTC
        {
            get { return BackingStore?.Get<DateTimeOffset?>("receivedDateTimeUTC"); }
            set { BackingStore?.Set("receivedDateTimeUTC", value); }
        }
        /// <summary>The DateTime of the request.</summary>
        public DateTimeOffset? RequestedDateTimeUTC
        {
            get { return BackingStore?.Get<DateTimeOffset?>("requestedDateTimeUTC"); }
            set { BackingStore?.Set("requestedDateTimeUTC", value); }
        }
        /// <summary>The size of the logs in KB. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.DeviceLogCollectionResponse.DeviceLogCollectionResponse_sizeInKB? SizeInKB
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.DeviceLogCollectionResponse.DeviceLogCollectionResponse_sizeInKB?>("sizeInKB"); }
            set { BackingStore?.Set("sizeInKB", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.DeviceLogCollectionResponse.DeviceLogCollectionResponse_sizeInKB SizeInKB
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.DeviceLogCollectionResponse.DeviceLogCollectionResponse_sizeInKB>("sizeInKB"); }
            set { BackingStore?.Set("sizeInKB", value); }
        }
#endif
        /// <summary>AppLogUploadStatus</summary>
        public global::Microsoft.Graph.Models.AppLogUploadState? Status
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.AppLogUploadState?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.DeviceLogCollectionResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.DeviceLogCollectionResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.DeviceLogCollectionResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "enrolledByUser", n => { EnrolledByUser = n.GetStringValue(); } },
                { "expirationDateTimeUTC", n => { ExpirationDateTimeUTC = n.GetDateTimeOffsetValue(); } },
                { "initiatedByUserPrincipalName", n => { InitiatedByUserPrincipalName = n.GetStringValue(); } },
                { "managedDeviceId", n => { ManagedDeviceId = n.GetGuidValue(); } },
                { "receivedDateTimeUTC", n => { ReceivedDateTimeUTC = n.GetDateTimeOffsetValue(); } },
                { "requestedDateTimeUTC", n => { RequestedDateTimeUTC = n.GetDateTimeOffsetValue(); } },
                { "sizeInKB", n => { SizeInKB = n.GetObjectValue<global::Microsoft.Graph.Models.DeviceLogCollectionResponse.DeviceLogCollectionResponse_sizeInKB>(global::Microsoft.Graph.Models.DeviceLogCollectionResponse.DeviceLogCollectionResponse_sizeInKB.CreateFromDiscriminatorValue); } },
                { "status", n => { Status = n.GetEnumValue<global::Microsoft.Graph.Models.AppLogUploadState>(); } },
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
            writer.WriteStringValue("enrolledByUser", EnrolledByUser);
            writer.WriteDateTimeOffsetValue("expirationDateTimeUTC", ExpirationDateTimeUTC);
            writer.WriteStringValue("initiatedByUserPrincipalName", InitiatedByUserPrincipalName);
            writer.WriteGuidValue("managedDeviceId", ManagedDeviceId);
            writer.WriteDateTimeOffsetValue("receivedDateTimeUTC", ReceivedDateTimeUTC);
            writer.WriteDateTimeOffsetValue("requestedDateTimeUTC", RequestedDateTimeUTC);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.DeviceLogCollectionResponse.DeviceLogCollectionResponse_sizeInKB>("sizeInKB", SizeInKB);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.AppLogUploadState>("status", Status);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="double"/>, <see cref="global::Microsoft.Graph.Models.ReferenceNumeric"/>, <see cref="string"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class DeviceLogCollectionResponse_sizeInKB : IBackedModel, IComposedTypeWrapper, IParsable
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
            /// Instantiates a new <see cref="global::Microsoft.Graph.Models.DeviceLogCollectionResponse.DeviceLogCollectionResponse_sizeInKB"/> and sets the default values.
            /// </summary>
            public DeviceLogCollectionResponse_sizeInKB()
            {
                BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            }
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::Microsoft.Graph.Models.DeviceLogCollectionResponse.DeviceLogCollectionResponse_sizeInKB"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Microsoft.Graph.Models.DeviceLogCollectionResponse.DeviceLogCollectionResponse_sizeInKB CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new global::Microsoft.Graph.Models.DeviceLogCollectionResponse.DeviceLogCollectionResponse_sizeInKB();
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
