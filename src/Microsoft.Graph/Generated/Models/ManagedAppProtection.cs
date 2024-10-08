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
    /// Policy used to configure detailed management settings for a specified set of apps
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class ManagedAppProtection : global::Microsoft.Graph.Models.ManagedAppPolicy, IParsable
    {
        /// <summary>Data storage locations where a user may store managed data.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.ManagedAppDataStorageLocation?>? AllowedDataStorageLocations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.ManagedAppDataStorageLocation?>?>("allowedDataStorageLocations"); }
            set { BackingStore?.Set("allowedDataStorageLocations", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.ManagedAppDataStorageLocation?> AllowedDataStorageLocations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.ManagedAppDataStorageLocation?>>("allowedDataStorageLocations"); }
            set { BackingStore?.Set("allowedDataStorageLocations", value); }
        }
#endif
        /// <summary>Data can be transferred from/to these classes of apps</summary>
        public global::Microsoft.Graph.Models.ManagedAppDataTransferLevel? AllowedInboundDataTransferSources
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ManagedAppDataTransferLevel?>("allowedInboundDataTransferSources"); }
            set { BackingStore?.Set("allowedInboundDataTransferSources", value); }
        }
        /// <summary>Represents the level to which the device&apos;s clipboard may be shared between apps</summary>
        public global::Microsoft.Graph.Models.ManagedAppClipboardSharingLevel? AllowedOutboundClipboardSharingLevel
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ManagedAppClipboardSharingLevel?>("allowedOutboundClipboardSharingLevel"); }
            set { BackingStore?.Set("allowedOutboundClipboardSharingLevel", value); }
        }
        /// <summary>Data can be transferred from/to these classes of apps</summary>
        public global::Microsoft.Graph.Models.ManagedAppDataTransferLevel? AllowedOutboundDataTransferDestinations
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ManagedAppDataTransferLevel?>("allowedOutboundDataTransferDestinations"); }
            set { BackingStore?.Set("allowedOutboundDataTransferDestinations", value); }
        }
        /// <summary>Indicates whether contacts can be synced to the user&apos;s device.</summary>
        public bool? ContactSyncBlocked
        {
            get { return BackingStore?.Get<bool?>("contactSyncBlocked"); }
            set { BackingStore?.Set("contactSyncBlocked", value); }
        }
        /// <summary>Indicates whether the backup of a managed app&apos;s data is blocked.</summary>
        public bool? DataBackupBlocked
        {
            get { return BackingStore?.Get<bool?>("dataBackupBlocked"); }
            set { BackingStore?.Set("dataBackupBlocked", value); }
        }
        /// <summary>Indicates whether device compliance is required.</summary>
        public bool? DeviceComplianceRequired
        {
            get { return BackingStore?.Get<bool?>("deviceComplianceRequired"); }
            set { BackingStore?.Set("deviceComplianceRequired", value); }
        }
        /// <summary>Indicates whether use of the app pin is required if the device pin is set.</summary>
        public bool? DisableAppPinIfDevicePinIsSet
        {
            get { return BackingStore?.Get<bool?>("disableAppPinIfDevicePinIsSet"); }
            set { BackingStore?.Set("disableAppPinIfDevicePinIsSet", value); }
        }
        /// <summary>Indicates whether use of the fingerprint reader is allowed in place of a pin if PinRequired is set to True.</summary>
        public bool? FingerprintBlocked
        {
            get { return BackingStore?.Get<bool?>("fingerprintBlocked"); }
            set { BackingStore?.Set("fingerprintBlocked", value); }
        }
        /// <summary>Type of managed browser</summary>
        public global::Microsoft.Graph.Models.ManagedBrowserType? ManagedBrowser
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ManagedBrowserType?>("managedBrowser"); }
            set { BackingStore?.Set("managedBrowser", value); }
        }
        /// <summary>Indicates whether internet links should be opened in the managed browser app, or any custom browser specified by CustomBrowserProtocol (for iOS) or CustomBrowserPackageId/CustomBrowserDisplayName (for Android)</summary>
        public bool? ManagedBrowserToOpenLinksRequired
        {
            get { return BackingStore?.Get<bool?>("managedBrowserToOpenLinksRequired"); }
            set { BackingStore?.Set("managedBrowserToOpenLinksRequired", value); }
        }
        /// <summary>Maximum number of incorrect pin retry attempts before the managed app is either blocked or wiped.</summary>
        public int? MaximumPinRetries
        {
            get { return BackingStore?.Get<int?>("maximumPinRetries"); }
            set { BackingStore?.Set("maximumPinRetries", value); }
        }
        /// <summary>Minimum pin length required for an app-level pin if PinRequired is set to True</summary>
        public int? MinimumPinLength
        {
            get { return BackingStore?.Get<int?>("minimumPinLength"); }
            set { BackingStore?.Set("minimumPinLength", value); }
        }
        /// <summary>Versions less than the specified version will block the managed app from accessing company data.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MinimumRequiredAppVersion
        {
            get { return BackingStore?.Get<string?>("minimumRequiredAppVersion"); }
            set { BackingStore?.Set("minimumRequiredAppVersion", value); }
        }
#nullable restore
#else
        public string MinimumRequiredAppVersion
        {
            get { return BackingStore?.Get<string>("minimumRequiredAppVersion"); }
            set { BackingStore?.Set("minimumRequiredAppVersion", value); }
        }
#endif
        /// <summary>Versions less than the specified version will block the managed app from accessing company data.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MinimumRequiredOsVersion
        {
            get { return BackingStore?.Get<string?>("minimumRequiredOsVersion"); }
            set { BackingStore?.Set("minimumRequiredOsVersion", value); }
        }
#nullable restore
#else
        public string MinimumRequiredOsVersion
        {
            get { return BackingStore?.Get<string>("minimumRequiredOsVersion"); }
            set { BackingStore?.Set("minimumRequiredOsVersion", value); }
        }
#endif
        /// <summary>Versions less than the specified version will result in warning message on the managed app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MinimumWarningAppVersion
        {
            get { return BackingStore?.Get<string?>("minimumWarningAppVersion"); }
            set { BackingStore?.Set("minimumWarningAppVersion", value); }
        }
#nullable restore
#else
        public string MinimumWarningAppVersion
        {
            get { return BackingStore?.Get<string>("minimumWarningAppVersion"); }
            set { BackingStore?.Set("minimumWarningAppVersion", value); }
        }
#endif
        /// <summary>Versions less than the specified version will result in warning message on the managed app from accessing company data.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MinimumWarningOsVersion
        {
            get { return BackingStore?.Get<string?>("minimumWarningOsVersion"); }
            set { BackingStore?.Set("minimumWarningOsVersion", value); }
        }
#nullable restore
#else
        public string MinimumWarningOsVersion
        {
            get { return BackingStore?.Get<string>("minimumWarningOsVersion"); }
            set { BackingStore?.Set("minimumWarningOsVersion", value); }
        }
#endif
        /// <summary>Indicates whether organizational credentials are required for app use.</summary>
        public bool? OrganizationalCredentialsRequired
        {
            get { return BackingStore?.Get<bool?>("organizationalCredentialsRequired"); }
            set { BackingStore?.Set("organizationalCredentialsRequired", value); }
        }
        /// <summary>TimePeriod before the all-level pin must be reset if PinRequired is set to True.</summary>
        public TimeSpan? PeriodBeforePinReset
        {
            get { return BackingStore?.Get<TimeSpan?>("periodBeforePinReset"); }
            set { BackingStore?.Set("periodBeforePinReset", value); }
        }
        /// <summary>The period after which access is checked when the device is not connected to the internet.</summary>
        public TimeSpan? PeriodOfflineBeforeAccessCheck
        {
            get { return BackingStore?.Get<TimeSpan?>("periodOfflineBeforeAccessCheck"); }
            set { BackingStore?.Set("periodOfflineBeforeAccessCheck", value); }
        }
        /// <summary>The amount of time an app is allowed to remain disconnected from the internet before all managed data it is wiped.</summary>
        public TimeSpan? PeriodOfflineBeforeWipeIsEnforced
        {
            get { return BackingStore?.Get<TimeSpan?>("periodOfflineBeforeWipeIsEnforced"); }
            set { BackingStore?.Set("periodOfflineBeforeWipeIsEnforced", value); }
        }
        /// <summary>The period after which access is checked when the device is connected to the internet.</summary>
        public TimeSpan? PeriodOnlineBeforeAccessCheck
        {
            get { return BackingStore?.Get<TimeSpan?>("periodOnlineBeforeAccessCheck"); }
            set { BackingStore?.Set("periodOnlineBeforeAccessCheck", value); }
        }
        /// <summary>Character set which is to be used for a user&apos;s app PIN</summary>
        public global::Microsoft.Graph.Models.ManagedAppPinCharacterSet? PinCharacterSet
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ManagedAppPinCharacterSet?>("pinCharacterSet"); }
            set { BackingStore?.Set("pinCharacterSet", value); }
        }
        /// <summary>Indicates whether an app-level pin is required.</summary>
        public bool? PinRequired
        {
            get { return BackingStore?.Get<bool?>("pinRequired"); }
            set { BackingStore?.Set("pinRequired", value); }
        }
        /// <summary>Indicates whether printing is allowed from managed apps.</summary>
        public bool? PrintBlocked
        {
            get { return BackingStore?.Get<bool?>("printBlocked"); }
            set { BackingStore?.Set("printBlocked", value); }
        }
        /// <summary>Indicates whether users may use the &apos;Save As&apos; menu item to save a copy of protected files.</summary>
        public bool? SaveAsBlocked
        {
            get { return BackingStore?.Get<bool?>("saveAsBlocked"); }
            set { BackingStore?.Set("saveAsBlocked", value); }
        }
        /// <summary>Indicates whether simplePin is blocked.</summary>
        public bool? SimplePinBlocked
        {
            get { return BackingStore?.Get<bool?>("simplePinBlocked"); }
            set { BackingStore?.Set("simplePinBlocked", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.ManagedAppProtection"/> and sets the default values.
        /// </summary>
        public ManagedAppProtection() : base()
        {
            OdataType = "#microsoft.graph.managedAppProtection";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.ManagedAppProtection"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.ManagedAppProtection CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.androidManagedAppProtection" => new global::Microsoft.Graph.Models.AndroidManagedAppProtection(),
                "#microsoft.graph.defaultManagedAppProtection" => new global::Microsoft.Graph.Models.DefaultManagedAppProtection(),
                "#microsoft.graph.iosManagedAppProtection" => new global::Microsoft.Graph.Models.IosManagedAppProtection(),
                "#microsoft.graph.targetedManagedAppProtection" => new global::Microsoft.Graph.Models.TargetedManagedAppProtection(),
                _ => new global::Microsoft.Graph.Models.ManagedAppProtection(),
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
                { "allowedDataStorageLocations", n => { AllowedDataStorageLocations = n.GetCollectionOfEnumValues<global::Microsoft.Graph.Models.ManagedAppDataStorageLocation>()?.AsList(); } },
                { "allowedInboundDataTransferSources", n => { AllowedInboundDataTransferSources = n.GetEnumValue<global::Microsoft.Graph.Models.ManagedAppDataTransferLevel>(); } },
                { "allowedOutboundClipboardSharingLevel", n => { AllowedOutboundClipboardSharingLevel = n.GetEnumValue<global::Microsoft.Graph.Models.ManagedAppClipboardSharingLevel>(); } },
                { "allowedOutboundDataTransferDestinations", n => { AllowedOutboundDataTransferDestinations = n.GetEnumValue<global::Microsoft.Graph.Models.ManagedAppDataTransferLevel>(); } },
                { "contactSyncBlocked", n => { ContactSyncBlocked = n.GetBoolValue(); } },
                { "dataBackupBlocked", n => { DataBackupBlocked = n.GetBoolValue(); } },
                { "deviceComplianceRequired", n => { DeviceComplianceRequired = n.GetBoolValue(); } },
                { "disableAppPinIfDevicePinIsSet", n => { DisableAppPinIfDevicePinIsSet = n.GetBoolValue(); } },
                { "fingerprintBlocked", n => { FingerprintBlocked = n.GetBoolValue(); } },
                { "managedBrowser", n => { ManagedBrowser = n.GetEnumValue<global::Microsoft.Graph.Models.ManagedBrowserType>(); } },
                { "managedBrowserToOpenLinksRequired", n => { ManagedBrowserToOpenLinksRequired = n.GetBoolValue(); } },
                { "maximumPinRetries", n => { MaximumPinRetries = n.GetIntValue(); } },
                { "minimumPinLength", n => { MinimumPinLength = n.GetIntValue(); } },
                { "minimumRequiredAppVersion", n => { MinimumRequiredAppVersion = n.GetStringValue(); } },
                { "minimumRequiredOsVersion", n => { MinimumRequiredOsVersion = n.GetStringValue(); } },
                { "minimumWarningAppVersion", n => { MinimumWarningAppVersion = n.GetStringValue(); } },
                { "minimumWarningOsVersion", n => { MinimumWarningOsVersion = n.GetStringValue(); } },
                { "organizationalCredentialsRequired", n => { OrganizationalCredentialsRequired = n.GetBoolValue(); } },
                { "periodBeforePinReset", n => { PeriodBeforePinReset = n.GetTimeSpanValue(); } },
                { "periodOfflineBeforeAccessCheck", n => { PeriodOfflineBeforeAccessCheck = n.GetTimeSpanValue(); } },
                { "periodOfflineBeforeWipeIsEnforced", n => { PeriodOfflineBeforeWipeIsEnforced = n.GetTimeSpanValue(); } },
                { "periodOnlineBeforeAccessCheck", n => { PeriodOnlineBeforeAccessCheck = n.GetTimeSpanValue(); } },
                { "pinCharacterSet", n => { PinCharacterSet = n.GetEnumValue<global::Microsoft.Graph.Models.ManagedAppPinCharacterSet>(); } },
                { "pinRequired", n => { PinRequired = n.GetBoolValue(); } },
                { "printBlocked", n => { PrintBlocked = n.GetBoolValue(); } },
                { "saveAsBlocked", n => { SaveAsBlocked = n.GetBoolValue(); } },
                { "simplePinBlocked", n => { SimplePinBlocked = n.GetBoolValue(); } },
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
            writer.WriteCollectionOfEnumValues<global::Microsoft.Graph.Models.ManagedAppDataStorageLocation>("allowedDataStorageLocations", AllowedDataStorageLocations);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.ManagedAppDataTransferLevel>("allowedInboundDataTransferSources", AllowedInboundDataTransferSources);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.ManagedAppClipboardSharingLevel>("allowedOutboundClipboardSharingLevel", AllowedOutboundClipboardSharingLevel);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.ManagedAppDataTransferLevel>("allowedOutboundDataTransferDestinations", AllowedOutboundDataTransferDestinations);
            writer.WriteBoolValue("contactSyncBlocked", ContactSyncBlocked);
            writer.WriteBoolValue("dataBackupBlocked", DataBackupBlocked);
            writer.WriteBoolValue("deviceComplianceRequired", DeviceComplianceRequired);
            writer.WriteBoolValue("disableAppPinIfDevicePinIsSet", DisableAppPinIfDevicePinIsSet);
            writer.WriteBoolValue("fingerprintBlocked", FingerprintBlocked);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.ManagedBrowserType>("managedBrowser", ManagedBrowser);
            writer.WriteBoolValue("managedBrowserToOpenLinksRequired", ManagedBrowserToOpenLinksRequired);
            writer.WriteIntValue("maximumPinRetries", MaximumPinRetries);
            writer.WriteIntValue("minimumPinLength", MinimumPinLength);
            writer.WriteStringValue("minimumRequiredAppVersion", MinimumRequiredAppVersion);
            writer.WriteStringValue("minimumRequiredOsVersion", MinimumRequiredOsVersion);
            writer.WriteStringValue("minimumWarningAppVersion", MinimumWarningAppVersion);
            writer.WriteStringValue("minimumWarningOsVersion", MinimumWarningOsVersion);
            writer.WriteBoolValue("organizationalCredentialsRequired", OrganizationalCredentialsRequired);
            writer.WriteTimeSpanValue("periodBeforePinReset", PeriodBeforePinReset);
            writer.WriteTimeSpanValue("periodOfflineBeforeAccessCheck", PeriodOfflineBeforeAccessCheck);
            writer.WriteTimeSpanValue("periodOfflineBeforeWipeIsEnforced", PeriodOfflineBeforeWipeIsEnforced);
            writer.WriteTimeSpanValue("periodOnlineBeforeAccessCheck", PeriodOnlineBeforeAccessCheck);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.ManagedAppPinCharacterSet>("pinCharacterSet", PinCharacterSet);
            writer.WriteBoolValue("pinRequired", PinRequired);
            writer.WriteBoolValue("printBlocked", PrintBlocked);
            writer.WriteBoolValue("saveAsBlocked", SaveAsBlocked);
            writer.WriteBoolValue("simplePinBlocked", SimplePinBlocked);
        }
    }
}
#pragma warning restore CS0618
