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
    public partial class CallTranscriptEventMessageDetail : global::Microsoft.Graph.Models.EventMessageDetail, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Unique identifier of the call.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CallId
        {
            get { return BackingStore?.Get<string?>("callId"); }
            set { BackingStore?.Set("callId", value); }
        }
#nullable restore
#else
        public string CallId
        {
            get { return BackingStore?.Get<string>("callId"); }
            set { BackingStore?.Set("callId", value); }
        }
#endif
        /// <summary>Unique identifier for a call transcript.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CallTranscriptICalUid
        {
            get { return BackingStore?.Get<string?>("callTranscriptICalUid"); }
            set { BackingStore?.Set("callTranscriptICalUid", value); }
        }
#nullable restore
#else
        public string CallTranscriptICalUid
        {
            get { return BackingStore?.Get<string>("callTranscriptICalUid"); }
            set { BackingStore?.Set("callTranscriptICalUid", value); }
        }
#endif
        /// <summary>The organizer of the meeting.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.IdentitySet? MeetingOrganizer
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.IdentitySet?>("meetingOrganizer"); }
            set { BackingStore?.Set("meetingOrganizer", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.IdentitySet MeetingOrganizer
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.IdentitySet>("meetingOrganizer"); }
            set { BackingStore?.Set("meetingOrganizer", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.CallTranscriptEventMessageDetail"/> and sets the default values.
        /// </summary>
        public CallTranscriptEventMessageDetail() : base()
        {
            OdataType = "#microsoft.graph.callTranscriptEventMessageDetail";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.CallTranscriptEventMessageDetail"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.CallTranscriptEventMessageDetail CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.CallTranscriptEventMessageDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "callId", n => { CallId = n.GetStringValue(); } },
                { "callTranscriptICalUid", n => { CallTranscriptICalUid = n.GetStringValue(); } },
                { "meetingOrganizer", n => { MeetingOrganizer = n.GetObjectValue<global::Microsoft.Graph.Models.IdentitySet>(global::Microsoft.Graph.Models.IdentitySet.CreateFromDiscriminatorValue); } },
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
            writer.WriteStringValue("callId", CallId);
            writer.WriteStringValue("callTranscriptICalUid", CallTranscriptICalUid);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.IdentitySet>("meetingOrganizer", MeetingOrganizer);
        }
    }
}
#pragma warning restore CS0618
