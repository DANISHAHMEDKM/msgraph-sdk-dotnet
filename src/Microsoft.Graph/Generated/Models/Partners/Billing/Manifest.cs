// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models.Partners.Billing
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class Manifest : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The total file count for this partner tenant ID.</summary>
        public int? BlobCount
        {
            get { return BackingStore?.Get<int?>("blobCount"); }
            set { BackingStore?.Set("blobCount", value); }
        }
        /// <summary>A collection of blob objects that contain details of all the files for the partner tenant ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.Partners.Billing.Blob>? Blobs
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Partners.Billing.Blob>?>("blobs"); }
            set { BackingStore?.Set("blobs", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.Partners.Billing.Blob> Blobs
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Partners.Billing.Blob>>("blobs"); }
            set { BackingStore?.Set("blobs", value); }
        }
#endif
        /// <summary>The date and time when a manifest resource was created. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The billing data file format. The possible value is: compressedJSONLines. Each blob is a compressed file and data in the file is in JSON lines format. Decompress the file to access the data.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DataFormat
        {
            get { return BackingStore?.Get<string?>("dataFormat"); }
            set { BackingStore?.Set("dataFormat", value); }
        }
#nullable restore
#else
        public string DataFormat
        {
            get { return BackingStore?.Get<string>("dataFormat"); }
            set { BackingStore?.Set("dataFormat", value); }
        }
#endif
        /// <summary>Version of data represented by the manifest. Any change in eTag indicates a new data version.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ETag
        {
            get { return BackingStore?.Get<string?>("eTag"); }
            set { BackingStore?.Set("eTag", value); }
        }
#nullable restore
#else
        public string ETag
        {
            get { return BackingStore?.Get<string>("eTag"); }
            set { BackingStore?.Set("eTag", value); }
        }
#endif
        /// <summary>Indicates the division of data. If a given partition has more than the supported number, the data is split into multiple files, each file representing a specific partitionValue. By default, the data in the file is partitioned by the number of line items.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PartitionType
        {
            get { return BackingStore?.Get<string?>("partitionType"); }
            set { BackingStore?.Set("partitionType", value); }
        }
#nullable restore
#else
        public string PartitionType
        {
            get { return BackingStore?.Get<string>("partitionType"); }
            set { BackingStore?.Set("partitionType", value); }
        }
#endif
        /// <summary>The Microsoft Entra tenant ID of the partner.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PartnerTenantId
        {
            get { return BackingStore?.Get<string?>("partnerTenantId"); }
            set { BackingStore?.Set("partnerTenantId", value); }
        }
#nullable restore
#else
        public string PartnerTenantId
        {
            get { return BackingStore?.Get<string>("partnerTenantId"); }
            set { BackingStore?.Set("partnerTenantId", value); }
        }
#endif
        /// <summary>The root directory that contains all the files.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RootDirectory
        {
            get { return BackingStore?.Get<string?>("rootDirectory"); }
            set { BackingStore?.Set("rootDirectory", value); }
        }
#nullable restore
#else
        public string RootDirectory
        {
            get { return BackingStore?.Get<string>("rootDirectory"); }
            set { BackingStore?.Set("rootDirectory", value); }
        }
#endif
        /// <summary>The SAS token for accessing the directory or an individual file in the directory.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SasToken
        {
            get { return BackingStore?.Get<string?>("sasToken"); }
            set { BackingStore?.Set("sasToken", value); }
        }
#nullable restore
#else
        public string SasToken
        {
            get { return BackingStore?.Get<string>("sasToken"); }
            set { BackingStore?.Set("sasToken", value); }
        }
#endif
        /// <summary>The version of the manifest schema.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SchemaVersion
        {
            get { return BackingStore?.Get<string?>("schemaVersion"); }
            set { BackingStore?.Set("schemaVersion", value); }
        }
#nullable restore
#else
        public string SchemaVersion
        {
            get { return BackingStore?.Get<string>("schemaVersion"); }
            set { BackingStore?.Set("schemaVersion", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Partners.Billing.Manifest"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.Partners.Billing.Manifest CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.Partners.Billing.Manifest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "blobCount", n => { BlobCount = n.GetIntValue(); } },
                { "blobs", n => { Blobs = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.Partners.Billing.Blob>(global::Microsoft.Graph.Models.Partners.Billing.Blob.CreateFromDiscriminatorValue)?.AsList(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "dataFormat", n => { DataFormat = n.GetStringValue(); } },
                { "eTag", n => { ETag = n.GetStringValue(); } },
                { "partitionType", n => { PartitionType = n.GetStringValue(); } },
                { "partnerTenantId", n => { PartnerTenantId = n.GetStringValue(); } },
                { "rootDirectory", n => { RootDirectory = n.GetStringValue(); } },
                { "sasToken", n => { SasToken = n.GetStringValue(); } },
                { "schemaVersion", n => { SchemaVersion = n.GetStringValue(); } },
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
            writer.WriteIntValue("blobCount", BlobCount);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.Partners.Billing.Blob>("blobs", Blobs);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("dataFormat", DataFormat);
            writer.WriteStringValue("eTag", ETag);
            writer.WriteStringValue("partitionType", PartitionType);
            writer.WriteStringValue("partnerTenantId", PartnerTenantId);
            writer.WriteStringValue("rootDirectory", RootDirectory);
            writer.WriteStringValue("sasToken", SasToken);
            writer.WriteStringValue("schemaVersion", SchemaVersion);
        }
    }
}
#pragma warning restore CS0618
