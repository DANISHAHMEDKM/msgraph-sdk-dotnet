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
    public partial class ScheduleChangeRequest : global::Microsoft.Graph.Models.ChangeTrackedEntity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The assignedTo property</summary>
        public global::Microsoft.Graph.Models.ScheduleChangeRequestActor? AssignedTo
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ScheduleChangeRequestActor?>("assignedTo"); }
            set { BackingStore?.Set("assignedTo", value); }
        }
        /// <summary>The managerActionDateTime property</summary>
        public DateTimeOffset? ManagerActionDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("managerActionDateTime"); }
            set { BackingStore?.Set("managerActionDateTime", value); }
        }
        /// <summary>The managerActionMessage property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManagerActionMessage
        {
            get { return BackingStore?.Get<string?>("managerActionMessage"); }
            set { BackingStore?.Set("managerActionMessage", value); }
        }
#nullable restore
#else
        public string ManagerActionMessage
        {
            get { return BackingStore?.Get<string>("managerActionMessage"); }
            set { BackingStore?.Set("managerActionMessage", value); }
        }
#endif
        /// <summary>The managerUserId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManagerUserId
        {
            get { return BackingStore?.Get<string?>("managerUserId"); }
            set { BackingStore?.Set("managerUserId", value); }
        }
#nullable restore
#else
        public string ManagerUserId
        {
            get { return BackingStore?.Get<string>("managerUserId"); }
            set { BackingStore?.Set("managerUserId", value); }
        }
#endif
        /// <summary>The senderDateTime property</summary>
        public DateTimeOffset? SenderDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("senderDateTime"); }
            set { BackingStore?.Set("senderDateTime", value); }
        }
        /// <summary>The senderMessage property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SenderMessage
        {
            get { return BackingStore?.Get<string?>("senderMessage"); }
            set { BackingStore?.Set("senderMessage", value); }
        }
#nullable restore
#else
        public string SenderMessage
        {
            get { return BackingStore?.Get<string>("senderMessage"); }
            set { BackingStore?.Set("senderMessage", value); }
        }
#endif
        /// <summary>The senderUserId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SenderUserId
        {
            get { return BackingStore?.Get<string?>("senderUserId"); }
            set { BackingStore?.Set("senderUserId", value); }
        }
#nullable restore
#else
        public string SenderUserId
        {
            get { return BackingStore?.Get<string>("senderUserId"); }
            set { BackingStore?.Set("senderUserId", value); }
        }
#endif
        /// <summary>The state property</summary>
        public global::Microsoft.Graph.Models.ScheduleChangeState? State
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ScheduleChangeState?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.ScheduleChangeRequest"/> and sets the default values.
        /// </summary>
        public ScheduleChangeRequest() : base()
        {
            OdataType = "#microsoft.graph.scheduleChangeRequest";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.ScheduleChangeRequest"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.ScheduleChangeRequest CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.offerShiftRequest" => new global::Microsoft.Graph.Models.OfferShiftRequest(),
                "#microsoft.graph.openShiftChangeRequest" => new global::Microsoft.Graph.Models.OpenShiftChangeRequest(),
                "#microsoft.graph.swapShiftsChangeRequest" => new global::Microsoft.Graph.Models.SwapShiftsChangeRequest(),
                "#microsoft.graph.timeOffRequest" => new global::Microsoft.Graph.Models.TimeOffRequest(),
                _ => new global::Microsoft.Graph.Models.ScheduleChangeRequest(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "assignedTo", n => { AssignedTo = n.GetEnumValue<global::Microsoft.Graph.Models.ScheduleChangeRequestActor>(); } },
                { "managerActionDateTime", n => { ManagerActionDateTime = n.GetDateTimeOffsetValue(); } },
                { "managerActionMessage", n => { ManagerActionMessage = n.GetStringValue(); } },
                { "managerUserId", n => { ManagerUserId = n.GetStringValue(); } },
                { "senderDateTime", n => { SenderDateTime = n.GetDateTimeOffsetValue(); } },
                { "senderMessage", n => { SenderMessage = n.GetStringValue(); } },
                { "senderUserId", n => { SenderUserId = n.GetStringValue(); } },
                { "state", n => { State = n.GetEnumValue<global::Microsoft.Graph.Models.ScheduleChangeState>(); } },
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
            writer.WriteEnumValue<global::Microsoft.Graph.Models.ScheduleChangeRequestActor>("assignedTo", AssignedTo);
            writer.WriteStringValue("managerActionMessage", ManagerActionMessage);
            writer.WriteStringValue("senderMessage", SenderMessage);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.ScheduleChangeState>("state", State);
        }
    }
}
#pragma warning restore CS0618
