// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    /// <summary>
    /// A class that represents a contained app of a WindowsUniversalAppX app.
    /// </summary>
    public class WindowsUniversalAppXContainedApp : MobileContainedApp, IParsable 
    {
        /// <summary>The app user model ID of the contained app of a WindowsUniversalAppX app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppUserModelId {
            get { return BackingStore?.Get<string?>("appUserModelId"); }
            set { BackingStore?.Set("appUserModelId", value); }
        }
#nullable restore
#else
        public string AppUserModelId {
            get { return BackingStore?.Get<string>("appUserModelId"); }
            set { BackingStore?.Set("appUserModelId", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="WindowsUniversalAppXContainedApp"/> and sets the default values.
        /// </summary>
        public WindowsUniversalAppXContainedApp() : base()
        {
            OdataType = "#microsoft.graph.windowsUniversalAppXContainedApp";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="WindowsUniversalAppXContainedApp"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WindowsUniversalAppXContainedApp CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsUniversalAppXContainedApp();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"appUserModelId", n => { AppUserModelId = n.GetStringValue(); } },
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
            writer.WriteStringValue("appUserModelId", AppUserModelId);
        }
    }
}
