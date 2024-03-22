// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class CloudPcDeviceImage : Entity, IParsable 
    {
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
        /// <summary>The errorCode property</summary>
        public CloudPcDeviceImageErrorCode? ErrorCode {
            get { return BackingStore?.Get<CloudPcDeviceImageErrorCode?>("errorCode"); }
            set { BackingStore?.Set("errorCode", value); }
        }
        /// <summary>The expirationDate property</summary>
        public Date? ExpirationDate {
            get { return BackingStore?.Get<Date?>("expirationDate"); }
            set { BackingStore?.Set("expirationDate", value); }
        }
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The operatingSystem property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OperatingSystem {
            get { return BackingStore?.Get<string?>("operatingSystem"); }
            set { BackingStore?.Set("operatingSystem", value); }
        }
#nullable restore
#else
        public string OperatingSystem {
            get { return BackingStore?.Get<string>("operatingSystem"); }
            set { BackingStore?.Set("operatingSystem", value); }
        }
#endif
        /// <summary>The osBuildNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OsBuildNumber {
            get { return BackingStore?.Get<string?>("osBuildNumber"); }
            set { BackingStore?.Set("osBuildNumber", value); }
        }
#nullable restore
#else
        public string OsBuildNumber {
            get { return BackingStore?.Get<string>("osBuildNumber"); }
            set { BackingStore?.Set("osBuildNumber", value); }
        }
#endif
        /// <summary>The osStatus property</summary>
        public CloudPcDeviceImageOsStatus? OsStatus {
            get { return BackingStore?.Get<CloudPcDeviceImageOsStatus?>("osStatus"); }
            set { BackingStore?.Set("osStatus", value); }
        }
        /// <summary>The sourceImageResourceId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SourceImageResourceId {
            get { return BackingStore?.Get<string?>("sourceImageResourceId"); }
            set { BackingStore?.Set("sourceImageResourceId", value); }
        }
#nullable restore
#else
        public string SourceImageResourceId {
            get { return BackingStore?.Get<string>("sourceImageResourceId"); }
            set { BackingStore?.Set("sourceImageResourceId", value); }
        }
#endif
        /// <summary>The status property</summary>
        public CloudPcDeviceImageStatus? Status {
            get { return BackingStore?.Get<CloudPcDeviceImageStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>The version property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Version {
            get { return BackingStore?.Get<string?>("version"); }
            set { BackingStore?.Set("version", value); }
        }
#nullable restore
#else
        public string Version {
            get { return BackingStore?.Get<string>("version"); }
            set { BackingStore?.Set("version", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="CloudPcDeviceImage"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CloudPcDeviceImage CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudPcDeviceImage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"errorCode", n => { ErrorCode = n.GetEnumValue<CloudPcDeviceImageErrorCode>(); } },
                {"expirationDate", n => { ExpirationDate = n.GetDateValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"operatingSystem", n => { OperatingSystem = n.GetStringValue(); } },
                {"osBuildNumber", n => { OsBuildNumber = n.GetStringValue(); } },
                {"osStatus", n => { OsStatus = n.GetEnumValue<CloudPcDeviceImageOsStatus>(); } },
                {"sourceImageResourceId", n => { SourceImageResourceId = n.GetStringValue(); } },
                {"status", n => { Status = n.GetEnumValue<CloudPcDeviceImageStatus>(); } },
                {"version", n => { Version = n.GetStringValue(); } },
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
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<CloudPcDeviceImageErrorCode>("errorCode", ErrorCode);
            writer.WriteDateValue("expirationDate", ExpirationDate);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("operatingSystem", OperatingSystem);
            writer.WriteStringValue("osBuildNumber", OsBuildNumber);
            writer.WriteEnumValue<CloudPcDeviceImageOsStatus>("osStatus", OsStatus);
            writer.WriteStringValue("sourceImageResourceId", SourceImageResourceId);
            writer.WriteEnumValue<CloudPcDeviceImageStatus>("status", Status);
            writer.WriteStringValue("version", Version);
        }
    }
}
