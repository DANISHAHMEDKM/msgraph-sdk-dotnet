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
    /// A complex type to store file or folder rule data for a Win32 LOB app.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class Win32LobAppFileSystemRule : global::Microsoft.Graph.Models.Win32LobAppRule, IParsable
    {
        /// <summary>A value indicating whether to expand environment variables in the 32-bit context on 64-bit systems.</summary>
        public bool? Check32BitOn64System
        {
            get { return BackingStore?.Get<bool?>("check32BitOn64System"); }
            set { BackingStore?.Set("check32BitOn64System", value); }
        }
        /// <summary>The file or folder comparison value.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ComparisonValue
        {
            get { return BackingStore?.Get<string?>("comparisonValue"); }
            set { BackingStore?.Set("comparisonValue", value); }
        }
#nullable restore
#else
        public string ComparisonValue
        {
            get { return BackingStore?.Get<string>("comparisonValue"); }
            set { BackingStore?.Set("comparisonValue", value); }
        }
#endif
        /// <summary>The file or folder name to look up.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FileOrFolderName
        {
            get { return BackingStore?.Get<string?>("fileOrFolderName"); }
            set { BackingStore?.Set("fileOrFolderName", value); }
        }
#nullable restore
#else
        public string FileOrFolderName
        {
            get { return BackingStore?.Get<string>("fileOrFolderName"); }
            set { BackingStore?.Set("fileOrFolderName", value); }
        }
#endif
        /// <summary>A list of possible operations for rules used to make determinations about an application based on files or folders. Unless noted, can be used with either detection or requirement rules.</summary>
        public global::Microsoft.Graph.Models.Win32LobAppFileSystemOperationType? OperationType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Win32LobAppFileSystemOperationType?>("operationType"); }
            set { BackingStore?.Set("operationType", value); }
        }
        /// <summary>Contains properties for detection operator.</summary>
        public global::Microsoft.Graph.Models.Win32LobAppRuleOperator? Operator
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Win32LobAppRuleOperator?>("operator"); }
            set { BackingStore?.Set("operator", value); }
        }
        /// <summary>The file or folder path to look up.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Path
        {
            get { return BackingStore?.Get<string?>("path"); }
            set { BackingStore?.Set("path", value); }
        }
#nullable restore
#else
        public string Path
        {
            get { return BackingStore?.Get<string>("path"); }
            set { BackingStore?.Set("path", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.Win32LobAppFileSystemRule"/> and sets the default values.
        /// </summary>
        public Win32LobAppFileSystemRule() : base()
        {
            OdataType = "#microsoft.graph.win32LobAppFileSystemRule";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Win32LobAppFileSystemRule"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.Win32LobAppFileSystemRule CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.Win32LobAppFileSystemRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "check32BitOn64System", n => { Check32BitOn64System = n.GetBoolValue(); } },
                { "comparisonValue", n => { ComparisonValue = n.GetStringValue(); } },
                { "fileOrFolderName", n => { FileOrFolderName = n.GetStringValue(); } },
                { "operationType", n => { OperationType = n.GetEnumValue<global::Microsoft.Graph.Models.Win32LobAppFileSystemOperationType>(); } },
                { "operator", n => { Operator = n.GetEnumValue<global::Microsoft.Graph.Models.Win32LobAppRuleOperator>(); } },
                { "path", n => { Path = n.GetStringValue(); } },
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
            writer.WriteBoolValue("check32BitOn64System", Check32BitOn64System);
            writer.WriteStringValue("comparisonValue", ComparisonValue);
            writer.WriteStringValue("fileOrFolderName", FileOrFolderName);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.Win32LobAppFileSystemOperationType>("operationType", OperationType);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.Win32LobAppRuleOperator>("operator", Operator);
            writer.WriteStringValue("path", Path);
        }
    }
}
#pragma warning restore CS0618
