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
    /// A complex type to store the PowerShell script rule data for a Win32 LOB app.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class Win32LobAppPowerShellScriptRule : global::Microsoft.Graph.Models.Win32LobAppRule, IParsable
    {
        /// <summary>The script output comparison value. Do not specify a value if the rule is used for detection.</summary>
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
        /// <summary>The display name for the rule. Do not specify this value if the rule is used for detection.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName
        {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName
        {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>A value indicating whether a signature check is enforced.</summary>
        public bool? EnforceSignatureCheck
        {
            get { return BackingStore?.Get<bool?>("enforceSignatureCheck"); }
            set { BackingStore?.Set("enforceSignatureCheck", value); }
        }
        /// <summary>Contains all supported Powershell Script output detection type.</summary>
        public global::Microsoft.Graph.Models.Win32LobAppPowerShellScriptRuleOperationType? OperationType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Win32LobAppPowerShellScriptRuleOperationType?>("operationType"); }
            set { BackingStore?.Set("operationType", value); }
        }
        /// <summary>Contains properties for detection operator.</summary>
        public global::Microsoft.Graph.Models.Win32LobAppRuleOperator? Operator
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Win32LobAppRuleOperator?>("operator"); }
            set { BackingStore?.Set("operator", value); }
        }
        /// <summary>A value indicating whether the script should run as 32-bit.</summary>
        public bool? RunAs32Bit
        {
            get { return BackingStore?.Get<bool?>("runAs32Bit"); }
            set { BackingStore?.Set("runAs32Bit", value); }
        }
        /// <summary>The execution context of the script. Do not specify this value if the rule is used for detection. Script detection rules will run in the same context as the associated app install context. Possible values are: system, user.</summary>
        public global::Microsoft.Graph.Models.RunAsAccountType? RunAsAccount
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.RunAsAccountType?>("runAsAccount"); }
            set { BackingStore?.Set("runAsAccount", value); }
        }
        /// <summary>The base64-encoded script content.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ScriptContent
        {
            get { return BackingStore?.Get<string?>("scriptContent"); }
            set { BackingStore?.Set("scriptContent", value); }
        }
#nullable restore
#else
        public string ScriptContent
        {
            get { return BackingStore?.Get<string>("scriptContent"); }
            set { BackingStore?.Set("scriptContent", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.Win32LobAppPowerShellScriptRule"/> and sets the default values.
        /// </summary>
        public Win32LobAppPowerShellScriptRule() : base()
        {
            OdataType = "#microsoft.graph.win32LobAppPowerShellScriptRule";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Win32LobAppPowerShellScriptRule"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.Win32LobAppPowerShellScriptRule CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.Win32LobAppPowerShellScriptRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "comparisonValue", n => { ComparisonValue = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "enforceSignatureCheck", n => { EnforceSignatureCheck = n.GetBoolValue(); } },
                { "operationType", n => { OperationType = n.GetEnumValue<global::Microsoft.Graph.Models.Win32LobAppPowerShellScriptRuleOperationType>(); } },
                { "operator", n => { Operator = n.GetEnumValue<global::Microsoft.Graph.Models.Win32LobAppRuleOperator>(); } },
                { "runAs32Bit", n => { RunAs32Bit = n.GetBoolValue(); } },
                { "runAsAccount", n => { RunAsAccount = n.GetEnumValue<global::Microsoft.Graph.Models.RunAsAccountType>(); } },
                { "scriptContent", n => { ScriptContent = n.GetStringValue(); } },
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
            writer.WriteStringValue("comparisonValue", ComparisonValue);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("enforceSignatureCheck", EnforceSignatureCheck);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.Win32LobAppPowerShellScriptRuleOperationType>("operationType", OperationType);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.Win32LobAppRuleOperator>("operator", Operator);
            writer.WriteBoolValue("runAs32Bit", RunAs32Bit);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.RunAsAccountType>("runAsAccount", RunAsAccount);
            writer.WriteStringValue("scriptContent", ScriptContent);
        }
    }
}
#pragma warning restore CS0618
