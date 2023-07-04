using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    /// <summary>
    /// The user experience analytics device startup history entity contains device boot performance history details.
    /// </summary>
    public class UserExperienceAnalyticsDeviceStartupHistory : Entity, IParsable {
        /// <summary>The device core boot time in milliseconds. Supports: $select, $OrderBy. Read-only.</summary>
        public int? CoreBootTimeInMs {
            get { return BackingStore?.Get<int?>("coreBootTimeInMs"); }
            set { BackingStore?.Set("coreBootTimeInMs", value); }
        }
        /// <summary>The device core login time in milliseconds. Supports: $select, $OrderBy. Read-only.</summary>
        public int? CoreLoginTimeInMs {
            get { return BackingStore?.Get<int?>("coreLoginTimeInMs"); }
            set { BackingStore?.Set("coreLoginTimeInMs", value); }
        }
        /// <summary>The Intune device id of the device. Supports: $select, $OrderBy. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceId {
            get { return BackingStore?.Get<string?>("deviceId"); }
            set { BackingStore?.Set("deviceId", value); }
        }
#nullable restore
#else
        public string DeviceId {
            get { return BackingStore?.Get<string>("deviceId"); }
            set { BackingStore?.Set("deviceId", value); }
        }
#endif
        /// <summary>The impact of device feature updates on boot time in milliseconds. Supports: $select, $OrderBy. Read-only.</summary>
        public int? FeatureUpdateBootTimeInMs {
            get { return BackingStore?.Get<int?>("featureUpdateBootTimeInMs"); }
            set { BackingStore?.Set("featureUpdateBootTimeInMs", value); }
        }
        /// <summary>The impact of device group policy client on boot time in milliseconds. Supports: $select, $OrderBy. Read-only.</summary>
        public int? GroupPolicyBootTimeInMs {
            get { return BackingStore?.Get<int?>("groupPolicyBootTimeInMs"); }
            set { BackingStore?.Set("groupPolicyBootTimeInMs", value); }
        }
        /// <summary>The impact of device group policy client on login time in milliseconds. Supports: $select, $OrderBy. Read-only.</summary>
        public int? GroupPolicyLoginTimeInMs {
            get { return BackingStore?.Get<int?>("groupPolicyLoginTimeInMs"); }
            set { BackingStore?.Set("groupPolicyLoginTimeInMs", value); }
        }
        /// <summary>When TRUE, indicates the device boot record is associated with feature updates. When FALSE, indicates the device boot record is not associated with feature updates. Supports: $select, $OrderBy. Read-only.</summary>
        public bool? IsFeatureUpdate {
            get { return BackingStore?.Get<bool?>("isFeatureUpdate"); }
            set { BackingStore?.Set("isFeatureUpdate", value); }
        }
        /// <summary>When TRUE, indicates the device login is the first login after a reboot. When FALSE, indicates the device login is not the first login after a reboot. Supports: $select, $OrderBy. Read-only.</summary>
        public bool? IsFirstLogin {
            get { return BackingStore?.Get<bool?>("isFirstLogin"); }
            set { BackingStore?.Set("isFirstLogin", value); }
        }
        /// <summary>The user experience analytics device boot record&apos;s operating system version. Supports: $select, $OrderBy. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OperatingSystemVersion {
            get { return BackingStore?.Get<string?>("operatingSystemVersion"); }
            set { BackingStore?.Set("operatingSystemVersion", value); }
        }
#nullable restore
#else
        public string OperatingSystemVersion {
            get { return BackingStore?.Get<string>("operatingSystemVersion"); }
            set { BackingStore?.Set("operatingSystemVersion", value); }
        }
#endif
        /// <summary>The time for desktop to become responsive during login process in milliseconds. Supports: $select, $OrderBy. Read-only.</summary>
        public int? ResponsiveDesktopTimeInMs {
            get { return BackingStore?.Get<int?>("responsiveDesktopTimeInMs"); }
            set { BackingStore?.Set("responsiveDesktopTimeInMs", value); }
        }
        /// <summary>Operating System restart category.</summary>
        public UserExperienceAnalyticsOperatingSystemRestartCategory? RestartCategory {
            get { return BackingStore?.Get<UserExperienceAnalyticsOperatingSystemRestartCategory?>("restartCategory"); }
            set { BackingStore?.Set("restartCategory", value); }
        }
        /// <summary>OS restart fault bucket. The fault bucket is used to find additional information about a system crash. Supports: $select, $OrderBy. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RestartFaultBucket {
            get { return BackingStore?.Get<string?>("restartFaultBucket"); }
            set { BackingStore?.Set("restartFaultBucket", value); }
        }
#nullable restore
#else
        public string RestartFaultBucket {
            get { return BackingStore?.Get<string>("restartFaultBucket"); }
            set { BackingStore?.Set("restartFaultBucket", value); }
        }
#endif
        /// <summary>OS restart stop code. This shows the bug check code which can be used to look up the blue screen reason. Supports: $select, $OrderBy. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RestartStopCode {
            get { return BackingStore?.Get<string?>("restartStopCode"); }
            set { BackingStore?.Set("restartStopCode", value); }
        }
#nullable restore
#else
        public string RestartStopCode {
            get { return BackingStore?.Get<string>("restartStopCode"); }
            set { BackingStore?.Set("restartStopCode", value); }
        }
#endif
        /// <summary>The device boot start time. The value cannot be modified and is automatically populated when the device performs a reboot. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2022 would look like this: &apos;2022-01-01T00:00:00Z&apos;. Returned by default. Read-only.</summary>
        public DateTimeOffset? StartTime {
            get { return BackingStore?.Get<DateTimeOffset?>("startTime"); }
            set { BackingStore?.Set("startTime", value); }
        }
        /// <summary>The device total boot time in milliseconds. Supports: $select, $OrderBy. Read-only.</summary>
        public int? TotalBootTimeInMs {
            get { return BackingStore?.Get<int?>("totalBootTimeInMs"); }
            set { BackingStore?.Set("totalBootTimeInMs", value); }
        }
        /// <summary>The device total login time in milliseconds. Supports: $select, $OrderBy. Read-only.</summary>
        public int? TotalLoginTimeInMs {
            get { return BackingStore?.Get<int?>("totalLoginTimeInMs"); }
            set { BackingStore?.Set("totalLoginTimeInMs", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UserExperienceAnalyticsDeviceStartupHistory CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsDeviceStartupHistory();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"coreBootTimeInMs", n => { CoreBootTimeInMs = n.GetIntValue(); } },
                {"coreLoginTimeInMs", n => { CoreLoginTimeInMs = n.GetIntValue(); } },
                {"deviceId", n => { DeviceId = n.GetStringValue(); } },
                {"featureUpdateBootTimeInMs", n => { FeatureUpdateBootTimeInMs = n.GetIntValue(); } },
                {"groupPolicyBootTimeInMs", n => { GroupPolicyBootTimeInMs = n.GetIntValue(); } },
                {"groupPolicyLoginTimeInMs", n => { GroupPolicyLoginTimeInMs = n.GetIntValue(); } },
                {"isFeatureUpdate", n => { IsFeatureUpdate = n.GetBoolValue(); } },
                {"isFirstLogin", n => { IsFirstLogin = n.GetBoolValue(); } },
                {"operatingSystemVersion", n => { OperatingSystemVersion = n.GetStringValue(); } },
                {"responsiveDesktopTimeInMs", n => { ResponsiveDesktopTimeInMs = n.GetIntValue(); } },
                {"restartCategory", n => { RestartCategory = n.GetEnumValue<UserExperienceAnalyticsOperatingSystemRestartCategory>(); } },
                {"restartFaultBucket", n => { RestartFaultBucket = n.GetStringValue(); } },
                {"restartStopCode", n => { RestartStopCode = n.GetStringValue(); } },
                {"startTime", n => { StartTime = n.GetDateTimeOffsetValue(); } },
                {"totalBootTimeInMs", n => { TotalBootTimeInMs = n.GetIntValue(); } },
                {"totalLoginTimeInMs", n => { TotalLoginTimeInMs = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("coreBootTimeInMs", CoreBootTimeInMs);
            writer.WriteIntValue("coreLoginTimeInMs", CoreLoginTimeInMs);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteIntValue("featureUpdateBootTimeInMs", FeatureUpdateBootTimeInMs);
            writer.WriteIntValue("groupPolicyBootTimeInMs", GroupPolicyBootTimeInMs);
            writer.WriteIntValue("groupPolicyLoginTimeInMs", GroupPolicyLoginTimeInMs);
            writer.WriteBoolValue("isFeatureUpdate", IsFeatureUpdate);
            writer.WriteBoolValue("isFirstLogin", IsFirstLogin);
            writer.WriteStringValue("operatingSystemVersion", OperatingSystemVersion);
            writer.WriteIntValue("responsiveDesktopTimeInMs", ResponsiveDesktopTimeInMs);
            writer.WriteEnumValue<UserExperienceAnalyticsOperatingSystemRestartCategory>("restartCategory", RestartCategory);
            writer.WriteStringValue("restartFaultBucket", RestartFaultBucket);
            writer.WriteStringValue("restartStopCode", RestartStopCode);
            writer.WriteDateTimeOffsetValue("startTime", StartTime);
            writer.WriteIntValue("totalBootTimeInMs", TotalBootTimeInMs);
            writer.WriteIntValue("totalLoginTimeInMs", TotalLoginTimeInMs);
        }
    }
}
