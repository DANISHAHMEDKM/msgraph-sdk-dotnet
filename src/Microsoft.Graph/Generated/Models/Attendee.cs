// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class Attendee : AttendeeBase, IParsable 
    {
        /// <summary>An alternate date/time proposed by the attendee for a meeting request to start and end. If the attendee hasn&apos;t proposed another time, then this property isn&apos;t included in a response of a GET event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TimeSlot? ProposedNewTime {
            get { return BackingStore?.Get<TimeSlot?>("proposedNewTime"); }
            set { BackingStore?.Set("proposedNewTime", value); }
        }
#nullable restore
#else
        public TimeSlot ProposedNewTime {
            get { return BackingStore?.Get<TimeSlot>("proposedNewTime"); }
            set { BackingStore?.Set("proposedNewTime", value); }
        }
#endif
        /// <summary>The attendee&apos;s response (none, accepted, declined, etc.) for the event and date-time that the response was sent.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ResponseStatus? Status {
            get { return BackingStore?.Get<ResponseStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
#nullable restore
#else
        public ResponseStatus Status {
            get { return BackingStore?.Get<ResponseStatus>("status"); }
            set { BackingStore?.Set("status", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Attendee"/> and sets the default values.
        /// </summary>
        public Attendee() : base()
        {
            OdataType = "#microsoft.graph.attendee";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Attendee"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Attendee CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Attendee();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"proposedNewTime", n => { ProposedNewTime = n.GetObjectValue<TimeSlot>(TimeSlot.CreateFromDiscriminatorValue); } },
                {"status", n => { Status = n.GetObjectValue<ResponseStatus>(ResponseStatus.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<TimeSlot>("proposedNewTime", ProposedNewTime);
            writer.WriteObjectValue<ResponseStatus>("status", Status);
        }
    }
}
