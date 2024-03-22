// <auto-generated/>
using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.DeviceAppManagement.MobileApps.Item.Assign {
    public class AssignPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("AdditionalData"); }
            set { BackingStore?.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The mobileAppAssignments property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<MobileAppAssignment>? MobileAppAssignments {
            get { return BackingStore?.Get<List<MobileAppAssignment>?>("mobileAppAssignments"); }
            set { BackingStore?.Set("mobileAppAssignments", value); }
        }
#nullable restore
#else
        public List<MobileAppAssignment> MobileAppAssignments {
            get { return BackingStore?.Get<List<MobileAppAssignment>>("mobileAppAssignments"); }
            set { BackingStore?.Set("mobileAppAssignments", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="AssignPostRequestBody"/> and sets the default values.
        /// </summary>
        public AssignPostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AssignPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AssignPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AssignPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"mobileAppAssignments", n => { MobileAppAssignments = n.GetCollectionOfObjectValues<MobileAppAssignment>(MobileAppAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<MobileAppAssignment>("mobileAppAssignments", MobileAppAssignments);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
