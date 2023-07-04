using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class DeviceManagement : Entity, IParsable {
        /// <summary>Apple push notification certificate.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.ApplePushNotificationCertificate? ApplePushNotificationCertificate {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ApplePushNotificationCertificate?>("applePushNotificationCertificate"); }
            set { BackingStore?.Set("applePushNotificationCertificate", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.ApplePushNotificationCertificate ApplePushNotificationCertificate {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ApplePushNotificationCertificate>("applePushNotificationCertificate"); }
            set { BackingStore?.Set("applePushNotificationCertificate", value); }
        }
#endif
        /// <summary>The Audit Events</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AuditEvent>? AuditEvents {
            get { return BackingStore?.Get<List<AuditEvent>?>("auditEvents"); }
            set { BackingStore?.Set("auditEvents", value); }
        }
#nullable restore
#else
        public List<AuditEvent> AuditEvents {
            get { return BackingStore?.Get<List<AuditEvent>>("auditEvents"); }
            set { BackingStore?.Set("auditEvents", value); }
        }
#endif
        /// <summary>The list of Compliance Management Partners configured by the tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ComplianceManagementPartner>? ComplianceManagementPartners {
            get { return BackingStore?.Get<List<ComplianceManagementPartner>?>("complianceManagementPartners"); }
            set { BackingStore?.Set("complianceManagementPartners", value); }
        }
#nullable restore
#else
        public List<ComplianceManagementPartner> ComplianceManagementPartners {
            get { return BackingStore?.Get<List<ComplianceManagementPartner>>("complianceManagementPartners"); }
            set { BackingStore?.Set("complianceManagementPartners", value); }
        }
#endif
        /// <summary>The Exchange on premises conditional access settings. On premises conditional access will require devices to be both enrolled and compliant for mail access</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public OnPremisesConditionalAccessSettings? ConditionalAccessSettings {
            get { return BackingStore?.Get<OnPremisesConditionalAccessSettings?>("conditionalAccessSettings"); }
            set { BackingStore?.Set("conditionalAccessSettings", value); }
        }
#nullable restore
#else
        public OnPremisesConditionalAccessSettings ConditionalAccessSettings {
            get { return BackingStore?.Get<OnPremisesConditionalAccessSettings>("conditionalAccessSettings"); }
            set { BackingStore?.Set("conditionalAccessSettings", value); }
        }
#endif
        /// <summary>The list of detected apps associated with a device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DetectedApp>? DetectedApps {
            get { return BackingStore?.Get<List<DetectedApp>?>("detectedApps"); }
            set { BackingStore?.Set("detectedApps", value); }
        }
#nullable restore
#else
        public List<DetectedApp> DetectedApps {
            get { return BackingStore?.Get<List<DetectedApp>>("detectedApps"); }
            set { BackingStore?.Set("detectedApps", value); }
        }
#endif
        /// <summary>The list of device categories with the tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceCategory>? DeviceCategories {
            get { return BackingStore?.Get<List<DeviceCategory>?>("deviceCategories"); }
            set { BackingStore?.Set("deviceCategories", value); }
        }
#nullable restore
#else
        public List<DeviceCategory> DeviceCategories {
            get { return BackingStore?.Get<List<DeviceCategory>>("deviceCategories"); }
            set { BackingStore?.Set("deviceCategories", value); }
        }
#endif
        /// <summary>The device compliance policies.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceCompliancePolicy>? DeviceCompliancePolicies {
            get { return BackingStore?.Get<List<DeviceCompliancePolicy>?>("deviceCompliancePolicies"); }
            set { BackingStore?.Set("deviceCompliancePolicies", value); }
        }
#nullable restore
#else
        public List<DeviceCompliancePolicy> DeviceCompliancePolicies {
            get { return BackingStore?.Get<List<DeviceCompliancePolicy>>("deviceCompliancePolicies"); }
            set { BackingStore?.Set("deviceCompliancePolicies", value); }
        }
#endif
        /// <summary>The device compliance state summary for this account.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.DeviceCompliancePolicyDeviceStateSummary? DeviceCompliancePolicyDeviceStateSummary {
            get { return BackingStore?.Get<Microsoft.Graph.Models.DeviceCompliancePolicyDeviceStateSummary?>("deviceCompliancePolicyDeviceStateSummary"); }
            set { BackingStore?.Set("deviceCompliancePolicyDeviceStateSummary", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.DeviceCompliancePolicyDeviceStateSummary DeviceCompliancePolicyDeviceStateSummary {
            get { return BackingStore?.Get<Microsoft.Graph.Models.DeviceCompliancePolicyDeviceStateSummary>("deviceCompliancePolicyDeviceStateSummary"); }
            set { BackingStore?.Set("deviceCompliancePolicyDeviceStateSummary", value); }
        }
#endif
        /// <summary>The summary states of compliance policy settings for this account.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceCompliancePolicySettingStateSummary>? DeviceCompliancePolicySettingStateSummaries {
            get { return BackingStore?.Get<List<DeviceCompliancePolicySettingStateSummary>?>("deviceCompliancePolicySettingStateSummaries"); }
            set { BackingStore?.Set("deviceCompliancePolicySettingStateSummaries", value); }
        }
#nullable restore
#else
        public List<DeviceCompliancePolicySettingStateSummary> DeviceCompliancePolicySettingStateSummaries {
            get { return BackingStore?.Get<List<DeviceCompliancePolicySettingStateSummary>>("deviceCompliancePolicySettingStateSummaries"); }
            set { BackingStore?.Set("deviceCompliancePolicySettingStateSummaries", value); }
        }
#endif
        /// <summary>The device configuration device state summary for this account.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceConfigurationDeviceStateSummary? DeviceConfigurationDeviceStateSummaries {
            get { return BackingStore?.Get<DeviceConfigurationDeviceStateSummary?>("deviceConfigurationDeviceStateSummaries"); }
            set { BackingStore?.Set("deviceConfigurationDeviceStateSummaries", value); }
        }
#nullable restore
#else
        public DeviceConfigurationDeviceStateSummary DeviceConfigurationDeviceStateSummaries {
            get { return BackingStore?.Get<DeviceConfigurationDeviceStateSummary>("deviceConfigurationDeviceStateSummaries"); }
            set { BackingStore?.Set("deviceConfigurationDeviceStateSummaries", value); }
        }
#endif
        /// <summary>The device configurations.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceConfiguration>? DeviceConfigurations {
            get { return BackingStore?.Get<List<DeviceConfiguration>?>("deviceConfigurations"); }
            set { BackingStore?.Set("deviceConfigurations", value); }
        }
#nullable restore
#else
        public List<DeviceConfiguration> DeviceConfigurations {
            get { return BackingStore?.Get<List<DeviceConfiguration>>("deviceConfigurations"); }
            set { BackingStore?.Set("deviceConfigurations", value); }
        }
#endif
        /// <summary>The list of device enrollment configurations</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceEnrollmentConfiguration>? DeviceEnrollmentConfigurations {
            get { return BackingStore?.Get<List<DeviceEnrollmentConfiguration>?>("deviceEnrollmentConfigurations"); }
            set { BackingStore?.Set("deviceEnrollmentConfigurations", value); }
        }
#nullable restore
#else
        public List<DeviceEnrollmentConfiguration> DeviceEnrollmentConfigurations {
            get { return BackingStore?.Get<List<DeviceEnrollmentConfiguration>>("deviceEnrollmentConfigurations"); }
            set { BackingStore?.Set("deviceEnrollmentConfigurations", value); }
        }
#endif
        /// <summary>The list of Device Management Partners configured by the tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceManagementPartner>? DeviceManagementPartners {
            get { return BackingStore?.Get<List<DeviceManagementPartner>?>("deviceManagementPartners"); }
            set { BackingStore?.Set("deviceManagementPartners", value); }
        }
#nullable restore
#else
        public List<DeviceManagementPartner> DeviceManagementPartners {
            get { return BackingStore?.Get<List<DeviceManagementPartner>>("deviceManagementPartners"); }
            set { BackingStore?.Set("deviceManagementPartners", value); }
        }
#endif
        /// <summary>Device protection overview.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.DeviceProtectionOverview? DeviceProtectionOverview {
            get { return BackingStore?.Get<Microsoft.Graph.Models.DeviceProtectionOverview?>("deviceProtectionOverview"); }
            set { BackingStore?.Set("deviceProtectionOverview", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.DeviceProtectionOverview DeviceProtectionOverview {
            get { return BackingStore?.Get<Microsoft.Graph.Models.DeviceProtectionOverview>("deviceProtectionOverview"); }
            set { BackingStore?.Set("deviceProtectionOverview", value); }
        }
#endif
        /// <summary>The list of Exchange Connectors configured by the tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceManagementExchangeConnector>? ExchangeConnectors {
            get { return BackingStore?.Get<List<DeviceManagementExchangeConnector>?>("exchangeConnectors"); }
            set { BackingStore?.Set("exchangeConnectors", value); }
        }
#nullable restore
#else
        public List<DeviceManagementExchangeConnector> ExchangeConnectors {
            get { return BackingStore?.Get<List<DeviceManagementExchangeConnector>>("exchangeConnectors"); }
            set { BackingStore?.Set("exchangeConnectors", value); }
        }
#endif
        /// <summary>Collection of imported Windows autopilot devices.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ImportedWindowsAutopilotDeviceIdentity>? ImportedWindowsAutopilotDeviceIdentities {
            get { return BackingStore?.Get<List<ImportedWindowsAutopilotDeviceIdentity>?>("importedWindowsAutopilotDeviceIdentities"); }
            set { BackingStore?.Set("importedWindowsAutopilotDeviceIdentities", value); }
        }
#nullable restore
#else
        public List<ImportedWindowsAutopilotDeviceIdentity> ImportedWindowsAutopilotDeviceIdentities {
            get { return BackingStore?.Get<List<ImportedWindowsAutopilotDeviceIdentity>>("importedWindowsAutopilotDeviceIdentities"); }
            set { BackingStore?.Set("importedWindowsAutopilotDeviceIdentities", value); }
        }
#endif
        /// <summary>Intune Account Id for given tenant</summary>
        public Guid? IntuneAccountId {
            get { return BackingStore?.Get<Guid?>("intuneAccountId"); }
            set { BackingStore?.Set("intuneAccountId", value); }
        }
        /// <summary>intuneBrand contains data which is used in customizing the appearance of the Company Portal applications as well as the end user web portal.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.IntuneBrand? IntuneBrand {
            get { return BackingStore?.Get<Microsoft.Graph.Models.IntuneBrand?>("intuneBrand"); }
            set { BackingStore?.Set("intuneBrand", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.IntuneBrand IntuneBrand {
            get { return BackingStore?.Get<Microsoft.Graph.Models.IntuneBrand>("intuneBrand"); }
            set { BackingStore?.Set("intuneBrand", value); }
        }
#endif
        /// <summary>The IOS software update installation statuses for this account.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<IosUpdateDeviceStatus>? IosUpdateStatuses {
            get { return BackingStore?.Get<List<IosUpdateDeviceStatus>?>("iosUpdateStatuses"); }
            set { BackingStore?.Set("iosUpdateStatuses", value); }
        }
#nullable restore
#else
        public List<IosUpdateDeviceStatus> IosUpdateStatuses {
            get { return BackingStore?.Get<List<IosUpdateDeviceStatus>>("iosUpdateStatuses"); }
            set { BackingStore?.Set("iosUpdateStatuses", value); }
        }
#endif
        /// <summary>Device overview</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.ManagedDeviceOverview? ManagedDeviceOverview {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ManagedDeviceOverview?>("managedDeviceOverview"); }
            set { BackingStore?.Set("managedDeviceOverview", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.ManagedDeviceOverview ManagedDeviceOverview {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ManagedDeviceOverview>("managedDeviceOverview"); }
            set { BackingStore?.Set("managedDeviceOverview", value); }
        }
#endif
        /// <summary>The list of managed devices.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ManagedDevice>? ManagedDevices {
            get { return BackingStore?.Get<List<ManagedDevice>?>("managedDevices"); }
            set { BackingStore?.Set("managedDevices", value); }
        }
#nullable restore
#else
        public List<ManagedDevice> ManagedDevices {
            get { return BackingStore?.Get<List<ManagedDevice>>("managedDevices"); }
            set { BackingStore?.Set("managedDevices", value); }
        }
#endif
        /// <summary>The collection property of MobileAppTroubleshootingEvent.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<MobileAppTroubleshootingEvent>? MobileAppTroubleshootingEvents {
            get { return BackingStore?.Get<List<MobileAppTroubleshootingEvent>?>("mobileAppTroubleshootingEvents"); }
            set { BackingStore?.Set("mobileAppTroubleshootingEvents", value); }
        }
#nullable restore
#else
        public List<MobileAppTroubleshootingEvent> MobileAppTroubleshootingEvents {
            get { return BackingStore?.Get<List<MobileAppTroubleshootingEvent>>("mobileAppTroubleshootingEvents"); }
            set { BackingStore?.Set("mobileAppTroubleshootingEvents", value); }
        }
#endif
        /// <summary>The list of Mobile threat Defense connectors configured by the tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<MobileThreatDefenseConnector>? MobileThreatDefenseConnectors {
            get { return BackingStore?.Get<List<MobileThreatDefenseConnector>?>("mobileThreatDefenseConnectors"); }
            set { BackingStore?.Set("mobileThreatDefenseConnectors", value); }
        }
#nullable restore
#else
        public List<MobileThreatDefenseConnector> MobileThreatDefenseConnectors {
            get { return BackingStore?.Get<List<MobileThreatDefenseConnector>>("mobileThreatDefenseConnectors"); }
            set { BackingStore?.Set("mobileThreatDefenseConnectors", value); }
        }
#endif
        /// <summary>The Notification Message Templates.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<NotificationMessageTemplate>? NotificationMessageTemplates {
            get { return BackingStore?.Get<List<NotificationMessageTemplate>?>("notificationMessageTemplates"); }
            set { BackingStore?.Set("notificationMessageTemplates", value); }
        }
#nullable restore
#else
        public List<NotificationMessageTemplate> NotificationMessageTemplates {
            get { return BackingStore?.Get<List<NotificationMessageTemplate>>("notificationMessageTemplates"); }
            set { BackingStore?.Set("notificationMessageTemplates", value); }
        }
#endif
        /// <summary>The remote assist partners.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<RemoteAssistancePartner>? RemoteAssistancePartners {
            get { return BackingStore?.Get<List<RemoteAssistancePartner>?>("remoteAssistancePartners"); }
            set { BackingStore?.Set("remoteAssistancePartners", value); }
        }
#nullable restore
#else
        public List<RemoteAssistancePartner> RemoteAssistancePartners {
            get { return BackingStore?.Get<List<RemoteAssistancePartner>>("remoteAssistancePartners"); }
            set { BackingStore?.Set("remoteAssistancePartners", value); }
        }
#endif
        /// <summary>Reports singleton</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceManagementReports? Reports {
            get { return BackingStore?.Get<DeviceManagementReports?>("reports"); }
            set { BackingStore?.Set("reports", value); }
        }
#nullable restore
#else
        public DeviceManagementReports Reports {
            get { return BackingStore?.Get<DeviceManagementReports>("reports"); }
            set { BackingStore?.Set("reports", value); }
        }
#endif
        /// <summary>The Resource Operations.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ResourceOperation>? ResourceOperations {
            get { return BackingStore?.Get<List<ResourceOperation>?>("resourceOperations"); }
            set { BackingStore?.Set("resourceOperations", value); }
        }
#nullable restore
#else
        public List<ResourceOperation> ResourceOperations {
            get { return BackingStore?.Get<List<ResourceOperation>>("resourceOperations"); }
            set { BackingStore?.Set("resourceOperations", value); }
        }
#endif
        /// <summary>The Role Assignments.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceAndAppManagementRoleAssignment>? RoleAssignments {
            get { return BackingStore?.Get<List<DeviceAndAppManagementRoleAssignment>?>("roleAssignments"); }
            set { BackingStore?.Set("roleAssignments", value); }
        }
#nullable restore
#else
        public List<DeviceAndAppManagementRoleAssignment> RoleAssignments {
            get { return BackingStore?.Get<List<DeviceAndAppManagementRoleAssignment>>("roleAssignments"); }
            set { BackingStore?.Set("roleAssignments", value); }
        }
#endif
        /// <summary>The Role Definitions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<RoleDefinition>? RoleDefinitions {
            get { return BackingStore?.Get<List<RoleDefinition>?>("roleDefinitions"); }
            set { BackingStore?.Set("roleDefinitions", value); }
        }
#nullable restore
#else
        public List<RoleDefinition> RoleDefinitions {
            get { return BackingStore?.Get<List<RoleDefinition>>("roleDefinitions"); }
            set { BackingStore?.Set("roleDefinitions", value); }
        }
#endif
        /// <summary>Account level settings.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceManagementSettings? Settings {
            get { return BackingStore?.Get<DeviceManagementSettings?>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
#nullable restore
#else
        public DeviceManagementSettings Settings {
            get { return BackingStore?.Get<DeviceManagementSettings>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
#endif
        /// <summary>The software update status summary.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.SoftwareUpdateStatusSummary? SoftwareUpdateStatusSummary {
            get { return BackingStore?.Get<Microsoft.Graph.Models.SoftwareUpdateStatusSummary?>("softwareUpdateStatusSummary"); }
            set { BackingStore?.Set("softwareUpdateStatusSummary", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.SoftwareUpdateStatusSummary SoftwareUpdateStatusSummary {
            get { return BackingStore?.Get<Microsoft.Graph.Models.SoftwareUpdateStatusSummary>("softwareUpdateStatusSummary"); }
            set { BackingStore?.Set("softwareUpdateStatusSummary", value); }
        }
#endif
        /// <summary>Tenant mobile device management subscription state.</summary>
        public DeviceManagementSubscriptionState? SubscriptionState {
            get { return BackingStore?.Get<DeviceManagementSubscriptionState?>("subscriptionState"); }
            set { BackingStore?.Set("subscriptionState", value); }
        }
        /// <summary>The telecom expense management partners.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TelecomExpenseManagementPartner>? TelecomExpenseManagementPartners {
            get { return BackingStore?.Get<List<TelecomExpenseManagementPartner>?>("telecomExpenseManagementPartners"); }
            set { BackingStore?.Set("telecomExpenseManagementPartners", value); }
        }
#nullable restore
#else
        public List<TelecomExpenseManagementPartner> TelecomExpenseManagementPartners {
            get { return BackingStore?.Get<List<TelecomExpenseManagementPartner>>("telecomExpenseManagementPartners"); }
            set { BackingStore?.Set("telecomExpenseManagementPartners", value); }
        }
#endif
        /// <summary>The terms and conditions associated with device management of the company.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.TermsAndConditions>? TermsAndConditions {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.TermsAndConditions>?>("termsAndConditions"); }
            set { BackingStore?.Set("termsAndConditions", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.TermsAndConditions> TermsAndConditions {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.TermsAndConditions>>("termsAndConditions"); }
            set { BackingStore?.Set("termsAndConditions", value); }
        }
#endif
        /// <summary>The list of troubleshooting events for the tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceManagementTroubleshootingEvent>? TroubleshootingEvents {
            get { return BackingStore?.Get<List<DeviceManagementTroubleshootingEvent>?>("troubleshootingEvents"); }
            set { BackingStore?.Set("troubleshootingEvents", value); }
        }
#nullable restore
#else
        public List<DeviceManagementTroubleshootingEvent> TroubleshootingEvents {
            get { return BackingStore?.Get<List<DeviceManagementTroubleshootingEvent>>("troubleshootingEvents"); }
            set { BackingStore?.Set("troubleshootingEvents", value); }
        }
#endif
        /// <summary>User experience analytics appHealth Application Performance</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.UserExperienceAnalyticsAppHealthApplicationPerformance>? UserExperienceAnalyticsAppHealthApplicationPerformance {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.UserExperienceAnalyticsAppHealthApplicationPerformance>?>("userExperienceAnalyticsAppHealthApplicationPerformance"); }
            set { BackingStore?.Set("userExperienceAnalyticsAppHealthApplicationPerformance", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.UserExperienceAnalyticsAppHealthApplicationPerformance> UserExperienceAnalyticsAppHealthApplicationPerformance {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.UserExperienceAnalyticsAppHealthApplicationPerformance>>("userExperienceAnalyticsAppHealthApplicationPerformance"); }
            set { BackingStore?.Set("userExperienceAnalyticsAppHealthApplicationPerformance", value); }
        }
#endif
        /// <summary>User experience analytics appHealth Application Performance by App Version details</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDetails>? UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDetails {
            get { return BackingStore?.Get<List<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDetails>?>("userExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDetails"); }
            set { BackingStore?.Set("userExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDetails", value); }
        }
#nullable restore
#else
        public List<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDetails> UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDetails {
            get { return BackingStore?.Get<List<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDetails>>("userExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDetails"); }
            set { BackingStore?.Set("userExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDetails", value); }
        }
#endif
        /// <summary>User experience analytics appHealth Application Performance by App Version Device Id</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId>? UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceId {
            get { return BackingStore?.Get<List<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId>?>("userExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceId"); }
            set { BackingStore?.Set("userExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceId", value); }
        }
#nullable restore
#else
        public List<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId> UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceId {
            get { return BackingStore?.Get<List<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId>>("userExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceId"); }
            set { BackingStore?.Set("userExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceId", value); }
        }
#endif
        /// <summary>User experience analytics appHealth Application Performance by OS Version</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UserExperienceAnalyticsAppHealthAppPerformanceByOSVersion>? UserExperienceAnalyticsAppHealthApplicationPerformanceByOSVersion {
            get { return BackingStore?.Get<List<UserExperienceAnalyticsAppHealthAppPerformanceByOSVersion>?>("userExperienceAnalyticsAppHealthApplicationPerformanceByOSVersion"); }
            set { BackingStore?.Set("userExperienceAnalyticsAppHealthApplicationPerformanceByOSVersion", value); }
        }
#nullable restore
#else
        public List<UserExperienceAnalyticsAppHealthAppPerformanceByOSVersion> UserExperienceAnalyticsAppHealthApplicationPerformanceByOSVersion {
            get { return BackingStore?.Get<List<UserExperienceAnalyticsAppHealthAppPerformanceByOSVersion>>("userExperienceAnalyticsAppHealthApplicationPerformanceByOSVersion"); }
            set { BackingStore?.Set("userExperienceAnalyticsAppHealthApplicationPerformanceByOSVersion", value); }
        }
#endif
        /// <summary>User experience analytics appHealth Model Performance</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.UserExperienceAnalyticsAppHealthDeviceModelPerformance>? UserExperienceAnalyticsAppHealthDeviceModelPerformance {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.UserExperienceAnalyticsAppHealthDeviceModelPerformance>?>("userExperienceAnalyticsAppHealthDeviceModelPerformance"); }
            set { BackingStore?.Set("userExperienceAnalyticsAppHealthDeviceModelPerformance", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.UserExperienceAnalyticsAppHealthDeviceModelPerformance> UserExperienceAnalyticsAppHealthDeviceModelPerformance {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.UserExperienceAnalyticsAppHealthDeviceModelPerformance>>("userExperienceAnalyticsAppHealthDeviceModelPerformance"); }
            set { BackingStore?.Set("userExperienceAnalyticsAppHealthDeviceModelPerformance", value); }
        }
#endif
        /// <summary>User experience analytics appHealth Device Performance</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.UserExperienceAnalyticsAppHealthDevicePerformance>? UserExperienceAnalyticsAppHealthDevicePerformance {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.UserExperienceAnalyticsAppHealthDevicePerformance>?>("userExperienceAnalyticsAppHealthDevicePerformance"); }
            set { BackingStore?.Set("userExperienceAnalyticsAppHealthDevicePerformance", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.UserExperienceAnalyticsAppHealthDevicePerformance> UserExperienceAnalyticsAppHealthDevicePerformance {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.UserExperienceAnalyticsAppHealthDevicePerformance>>("userExperienceAnalyticsAppHealthDevicePerformance"); }
            set { BackingStore?.Set("userExperienceAnalyticsAppHealthDevicePerformance", value); }
        }
#endif
        /// <summary>User experience analytics device performance details</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.UserExperienceAnalyticsAppHealthDevicePerformanceDetails>? UserExperienceAnalyticsAppHealthDevicePerformanceDetails {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.UserExperienceAnalyticsAppHealthDevicePerformanceDetails>?>("userExperienceAnalyticsAppHealthDevicePerformanceDetails"); }
            set { BackingStore?.Set("userExperienceAnalyticsAppHealthDevicePerformanceDetails", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.UserExperienceAnalyticsAppHealthDevicePerformanceDetails> UserExperienceAnalyticsAppHealthDevicePerformanceDetails {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.UserExperienceAnalyticsAppHealthDevicePerformanceDetails>>("userExperienceAnalyticsAppHealthDevicePerformanceDetails"); }
            set { BackingStore?.Set("userExperienceAnalyticsAppHealthDevicePerformanceDetails", value); }
        }
#endif
        /// <summary>User experience analytics appHealth OS version Performance</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.UserExperienceAnalyticsAppHealthOSVersionPerformance>? UserExperienceAnalyticsAppHealthOSVersionPerformance {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.UserExperienceAnalyticsAppHealthOSVersionPerformance>?>("userExperienceAnalyticsAppHealthOSVersionPerformance"); }
            set { BackingStore?.Set("userExperienceAnalyticsAppHealthOSVersionPerformance", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.UserExperienceAnalyticsAppHealthOSVersionPerformance> UserExperienceAnalyticsAppHealthOSVersionPerformance {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.UserExperienceAnalyticsAppHealthOSVersionPerformance>>("userExperienceAnalyticsAppHealthOSVersionPerformance"); }
            set { BackingStore?.Set("userExperienceAnalyticsAppHealthOSVersionPerformance", value); }
        }
#endif
        /// <summary>User experience analytics appHealth overview</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UserExperienceAnalyticsCategory? UserExperienceAnalyticsAppHealthOverview {
            get { return BackingStore?.Get<UserExperienceAnalyticsCategory?>("userExperienceAnalyticsAppHealthOverview"); }
            set { BackingStore?.Set("userExperienceAnalyticsAppHealthOverview", value); }
        }
#nullable restore
#else
        public UserExperienceAnalyticsCategory UserExperienceAnalyticsAppHealthOverview {
            get { return BackingStore?.Get<UserExperienceAnalyticsCategory>("userExperienceAnalyticsAppHealthOverview"); }
            set { BackingStore?.Set("userExperienceAnalyticsAppHealthOverview", value); }
        }
#endif
        /// <summary>User experience analytics baselines</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UserExperienceAnalyticsBaseline>? UserExperienceAnalyticsBaselines {
            get { return BackingStore?.Get<List<UserExperienceAnalyticsBaseline>?>("userExperienceAnalyticsBaselines"); }
            set { BackingStore?.Set("userExperienceAnalyticsBaselines", value); }
        }
#nullable restore
#else
        public List<UserExperienceAnalyticsBaseline> UserExperienceAnalyticsBaselines {
            get { return BackingStore?.Get<List<UserExperienceAnalyticsBaseline>>("userExperienceAnalyticsBaselines"); }
            set { BackingStore?.Set("userExperienceAnalyticsBaselines", value); }
        }
#endif
        /// <summary>User experience analytics categories</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UserExperienceAnalyticsCategory>? UserExperienceAnalyticsCategories {
            get { return BackingStore?.Get<List<UserExperienceAnalyticsCategory>?>("userExperienceAnalyticsCategories"); }
            set { BackingStore?.Set("userExperienceAnalyticsCategories", value); }
        }
#nullable restore
#else
        public List<UserExperienceAnalyticsCategory> UserExperienceAnalyticsCategories {
            get { return BackingStore?.Get<List<UserExperienceAnalyticsCategory>>("userExperienceAnalyticsCategories"); }
            set { BackingStore?.Set("userExperienceAnalyticsCategories", value); }
        }
#endif
        /// <summary>User experience analytics device performance</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.UserExperienceAnalyticsDevicePerformance>? UserExperienceAnalyticsDevicePerformance {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.UserExperienceAnalyticsDevicePerformance>?>("userExperienceAnalyticsDevicePerformance"); }
            set { BackingStore?.Set("userExperienceAnalyticsDevicePerformance", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.UserExperienceAnalyticsDevicePerformance> UserExperienceAnalyticsDevicePerformance {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.UserExperienceAnalyticsDevicePerformance>>("userExperienceAnalyticsDevicePerformance"); }
            set { BackingStore?.Set("userExperienceAnalyticsDevicePerformance", value); }
        }
#endif
        /// <summary>User experience analytics device scores</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.UserExperienceAnalyticsDeviceScores>? UserExperienceAnalyticsDeviceScores {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.UserExperienceAnalyticsDeviceScores>?>("userExperienceAnalyticsDeviceScores"); }
            set { BackingStore?.Set("userExperienceAnalyticsDeviceScores", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.UserExperienceAnalyticsDeviceScores> UserExperienceAnalyticsDeviceScores {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.UserExperienceAnalyticsDeviceScores>>("userExperienceAnalyticsDeviceScores"); }
            set { BackingStore?.Set("userExperienceAnalyticsDeviceScores", value); }
        }
#endif
        /// <summary>User experience analytics device Startup History</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.UserExperienceAnalyticsDeviceStartupHistory>? UserExperienceAnalyticsDeviceStartupHistory {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.UserExperienceAnalyticsDeviceStartupHistory>?>("userExperienceAnalyticsDeviceStartupHistory"); }
            set { BackingStore?.Set("userExperienceAnalyticsDeviceStartupHistory", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.UserExperienceAnalyticsDeviceStartupHistory> UserExperienceAnalyticsDeviceStartupHistory {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.UserExperienceAnalyticsDeviceStartupHistory>>("userExperienceAnalyticsDeviceStartupHistory"); }
            set { BackingStore?.Set("userExperienceAnalyticsDeviceStartupHistory", value); }
        }
#endif
        /// <summary>User experience analytics device Startup Processes</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UserExperienceAnalyticsDeviceStartupProcess>? UserExperienceAnalyticsDeviceStartupProcesses {
            get { return BackingStore?.Get<List<UserExperienceAnalyticsDeviceStartupProcess>?>("userExperienceAnalyticsDeviceStartupProcesses"); }
            set { BackingStore?.Set("userExperienceAnalyticsDeviceStartupProcesses", value); }
        }
#nullable restore
#else
        public List<UserExperienceAnalyticsDeviceStartupProcess> UserExperienceAnalyticsDeviceStartupProcesses {
            get { return BackingStore?.Get<List<UserExperienceAnalyticsDeviceStartupProcess>>("userExperienceAnalyticsDeviceStartupProcesses"); }
            set { BackingStore?.Set("userExperienceAnalyticsDeviceStartupProcesses", value); }
        }
#endif
        /// <summary>User experience analytics metric history</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.UserExperienceAnalyticsMetricHistory>? UserExperienceAnalyticsMetricHistory {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.UserExperienceAnalyticsMetricHistory>?>("userExperienceAnalyticsMetricHistory"); }
            set { BackingStore?.Set("userExperienceAnalyticsMetricHistory", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.UserExperienceAnalyticsMetricHistory> UserExperienceAnalyticsMetricHistory {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.UserExperienceAnalyticsMetricHistory>>("userExperienceAnalyticsMetricHistory"); }
            set { BackingStore?.Set("userExperienceAnalyticsMetricHistory", value); }
        }
#endif
        /// <summary>User experience analytics model scores</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.UserExperienceAnalyticsModelScores>? UserExperienceAnalyticsModelScores {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.UserExperienceAnalyticsModelScores>?>("userExperienceAnalyticsModelScores"); }
            set { BackingStore?.Set("userExperienceAnalyticsModelScores", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.UserExperienceAnalyticsModelScores> UserExperienceAnalyticsModelScores {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.UserExperienceAnalyticsModelScores>>("userExperienceAnalyticsModelScores"); }
            set { BackingStore?.Set("userExperienceAnalyticsModelScores", value); }
        }
#endif
        /// <summary>User experience analytics overview</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.UserExperienceAnalyticsOverview? UserExperienceAnalyticsOverview {
            get { return BackingStore?.Get<Microsoft.Graph.Models.UserExperienceAnalyticsOverview?>("userExperienceAnalyticsOverview"); }
            set { BackingStore?.Set("userExperienceAnalyticsOverview", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.UserExperienceAnalyticsOverview UserExperienceAnalyticsOverview {
            get { return BackingStore?.Get<Microsoft.Graph.Models.UserExperienceAnalyticsOverview>("userExperienceAnalyticsOverview"); }
            set { BackingStore?.Set("userExperienceAnalyticsOverview", value); }
        }
#endif
        /// <summary>User experience analytics device Startup Score History</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.UserExperienceAnalyticsScoreHistory>? UserExperienceAnalyticsScoreHistory {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.UserExperienceAnalyticsScoreHistory>?>("userExperienceAnalyticsScoreHistory"); }
            set { BackingStore?.Set("userExperienceAnalyticsScoreHistory", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.UserExperienceAnalyticsScoreHistory> UserExperienceAnalyticsScoreHistory {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.UserExperienceAnalyticsScoreHistory>>("userExperienceAnalyticsScoreHistory"); }
            set { BackingStore?.Set("userExperienceAnalyticsScoreHistory", value); }
        }
#endif
        /// <summary>User experience analytics device settings</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.UserExperienceAnalyticsSettings? UserExperienceAnalyticsSettings {
            get { return BackingStore?.Get<Microsoft.Graph.Models.UserExperienceAnalyticsSettings?>("userExperienceAnalyticsSettings"); }
            set { BackingStore?.Set("userExperienceAnalyticsSettings", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.UserExperienceAnalyticsSettings UserExperienceAnalyticsSettings {
            get { return BackingStore?.Get<Microsoft.Graph.Models.UserExperienceAnalyticsSettings>("userExperienceAnalyticsSettings"); }
            set { BackingStore?.Set("userExperienceAnalyticsSettings", value); }
        }
#endif
        /// <summary>User experience analytics work from anywhere hardware readiness metrics.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric? UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric {
            get { return BackingStore?.Get<Microsoft.Graph.Models.UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric?>("userExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric"); }
            set { BackingStore?.Set("userExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric {
            get { return BackingStore?.Get<Microsoft.Graph.Models.UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric>("userExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric"); }
            set { BackingStore?.Set("userExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric", value); }
        }
#endif
        /// <summary>User experience analytics work from anywhere metrics.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UserExperienceAnalyticsWorkFromAnywhereMetric>? UserExperienceAnalyticsWorkFromAnywhereMetrics {
            get { return BackingStore?.Get<List<UserExperienceAnalyticsWorkFromAnywhereMetric>?>("userExperienceAnalyticsWorkFromAnywhereMetrics"); }
            set { BackingStore?.Set("userExperienceAnalyticsWorkFromAnywhereMetrics", value); }
        }
#nullable restore
#else
        public List<UserExperienceAnalyticsWorkFromAnywhereMetric> UserExperienceAnalyticsWorkFromAnywhereMetrics {
            get { return BackingStore?.Get<List<UserExperienceAnalyticsWorkFromAnywhereMetric>>("userExperienceAnalyticsWorkFromAnywhereMetrics"); }
            set { BackingStore?.Set("userExperienceAnalyticsWorkFromAnywhereMetrics", value); }
        }
#endif
        /// <summary>The user experience analytics work from anywhere model performance</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.UserExperienceAnalyticsWorkFromAnywhereModelPerformance>? UserExperienceAnalyticsWorkFromAnywhereModelPerformance {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.UserExperienceAnalyticsWorkFromAnywhereModelPerformance>?>("userExperienceAnalyticsWorkFromAnywhereModelPerformance"); }
            set { BackingStore?.Set("userExperienceAnalyticsWorkFromAnywhereModelPerformance", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.UserExperienceAnalyticsWorkFromAnywhereModelPerformance> UserExperienceAnalyticsWorkFromAnywhereModelPerformance {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.UserExperienceAnalyticsWorkFromAnywhereModelPerformance>>("userExperienceAnalyticsWorkFromAnywhereModelPerformance"); }
            set { BackingStore?.Set("userExperienceAnalyticsWorkFromAnywhereModelPerformance", value); }
        }
#endif
        /// <summary>The Windows autopilot device identities contained collection.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WindowsAutopilotDeviceIdentity>? WindowsAutopilotDeviceIdentities {
            get { return BackingStore?.Get<List<WindowsAutopilotDeviceIdentity>?>("windowsAutopilotDeviceIdentities"); }
            set { BackingStore?.Set("windowsAutopilotDeviceIdentities", value); }
        }
#nullable restore
#else
        public List<WindowsAutopilotDeviceIdentity> WindowsAutopilotDeviceIdentities {
            get { return BackingStore?.Get<List<WindowsAutopilotDeviceIdentity>>("windowsAutopilotDeviceIdentities"); }
            set { BackingStore?.Set("windowsAutopilotDeviceIdentities", value); }
        }
#endif
        /// <summary>The windows information protection app learning summaries.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WindowsInformationProtectionAppLearningSummary>? WindowsInformationProtectionAppLearningSummaries {
            get { return BackingStore?.Get<List<WindowsInformationProtectionAppLearningSummary>?>("windowsInformationProtectionAppLearningSummaries"); }
            set { BackingStore?.Set("windowsInformationProtectionAppLearningSummaries", value); }
        }
#nullable restore
#else
        public List<WindowsInformationProtectionAppLearningSummary> WindowsInformationProtectionAppLearningSummaries {
            get { return BackingStore?.Get<List<WindowsInformationProtectionAppLearningSummary>>("windowsInformationProtectionAppLearningSummaries"); }
            set { BackingStore?.Set("windowsInformationProtectionAppLearningSummaries", value); }
        }
#endif
        /// <summary>The windows information protection network learning summaries.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WindowsInformationProtectionNetworkLearningSummary>? WindowsInformationProtectionNetworkLearningSummaries {
            get { return BackingStore?.Get<List<WindowsInformationProtectionNetworkLearningSummary>?>("windowsInformationProtectionNetworkLearningSummaries"); }
            set { BackingStore?.Set("windowsInformationProtectionNetworkLearningSummaries", value); }
        }
#nullable restore
#else
        public List<WindowsInformationProtectionNetworkLearningSummary> WindowsInformationProtectionNetworkLearningSummaries {
            get { return BackingStore?.Get<List<WindowsInformationProtectionNetworkLearningSummary>>("windowsInformationProtectionNetworkLearningSummaries"); }
            set { BackingStore?.Set("windowsInformationProtectionNetworkLearningSummaries", value); }
        }
#endif
        /// <summary>The list of affected malware in the tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.WindowsMalwareInformation>? WindowsMalwareInformation {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.WindowsMalwareInformation>?>("windowsMalwareInformation"); }
            set { BackingStore?.Set("windowsMalwareInformation", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.WindowsMalwareInformation> WindowsMalwareInformation {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.WindowsMalwareInformation>>("windowsMalwareInformation"); }
            set { BackingStore?.Set("windowsMalwareInformation", value); }
        }
#endif
        /// <summary>Malware overview for windows devices.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.WindowsMalwareOverview? WindowsMalwareOverview {
            get { return BackingStore?.Get<Microsoft.Graph.Models.WindowsMalwareOverview?>("windowsMalwareOverview"); }
            set { BackingStore?.Set("windowsMalwareOverview", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.WindowsMalwareOverview WindowsMalwareOverview {
            get { return BackingStore?.Get<Microsoft.Graph.Models.WindowsMalwareOverview>("windowsMalwareOverview"); }
            set { BackingStore?.Set("windowsMalwareOverview", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceManagement CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagement();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"applePushNotificationCertificate", n => { ApplePushNotificationCertificate = n.GetObjectValue<Microsoft.Graph.Models.ApplePushNotificationCertificate>(Microsoft.Graph.Models.ApplePushNotificationCertificate.CreateFromDiscriminatorValue); } },
                {"auditEvents", n => { AuditEvents = n.GetCollectionOfObjectValues<AuditEvent>(AuditEvent.CreateFromDiscriminatorValue)?.ToList(); } },
                {"complianceManagementPartners", n => { ComplianceManagementPartners = n.GetCollectionOfObjectValues<ComplianceManagementPartner>(ComplianceManagementPartner.CreateFromDiscriminatorValue)?.ToList(); } },
                {"conditionalAccessSettings", n => { ConditionalAccessSettings = n.GetObjectValue<OnPremisesConditionalAccessSettings>(OnPremisesConditionalAccessSettings.CreateFromDiscriminatorValue); } },
                {"detectedApps", n => { DetectedApps = n.GetCollectionOfObjectValues<DetectedApp>(DetectedApp.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceCategories", n => { DeviceCategories = n.GetCollectionOfObjectValues<DeviceCategory>(DeviceCategory.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceCompliancePolicies", n => { DeviceCompliancePolicies = n.GetCollectionOfObjectValues<DeviceCompliancePolicy>(DeviceCompliancePolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceCompliancePolicyDeviceStateSummary", n => { DeviceCompliancePolicyDeviceStateSummary = n.GetObjectValue<Microsoft.Graph.Models.DeviceCompliancePolicyDeviceStateSummary>(Microsoft.Graph.Models.DeviceCompliancePolicyDeviceStateSummary.CreateFromDiscriminatorValue); } },
                {"deviceCompliancePolicySettingStateSummaries", n => { DeviceCompliancePolicySettingStateSummaries = n.GetCollectionOfObjectValues<DeviceCompliancePolicySettingStateSummary>(DeviceCompliancePolicySettingStateSummary.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceConfigurationDeviceStateSummaries", n => { DeviceConfigurationDeviceStateSummaries = n.GetObjectValue<DeviceConfigurationDeviceStateSummary>(DeviceConfigurationDeviceStateSummary.CreateFromDiscriminatorValue); } },
                {"deviceConfigurations", n => { DeviceConfigurations = n.GetCollectionOfObjectValues<DeviceConfiguration>(DeviceConfiguration.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceEnrollmentConfigurations", n => { DeviceEnrollmentConfigurations = n.GetCollectionOfObjectValues<DeviceEnrollmentConfiguration>(DeviceEnrollmentConfiguration.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceManagementPartners", n => { DeviceManagementPartners = n.GetCollectionOfObjectValues<DeviceManagementPartner>(DeviceManagementPartner.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceProtectionOverview", n => { DeviceProtectionOverview = n.GetObjectValue<Microsoft.Graph.Models.DeviceProtectionOverview>(Microsoft.Graph.Models.DeviceProtectionOverview.CreateFromDiscriminatorValue); } },
                {"exchangeConnectors", n => { ExchangeConnectors = n.GetCollectionOfObjectValues<DeviceManagementExchangeConnector>(DeviceManagementExchangeConnector.CreateFromDiscriminatorValue)?.ToList(); } },
                {"importedWindowsAutopilotDeviceIdentities", n => { ImportedWindowsAutopilotDeviceIdentities = n.GetCollectionOfObjectValues<ImportedWindowsAutopilotDeviceIdentity>(ImportedWindowsAutopilotDeviceIdentity.CreateFromDiscriminatorValue)?.ToList(); } },
                {"intuneAccountId", n => { IntuneAccountId = n.GetGuidValue(); } },
                {"intuneBrand", n => { IntuneBrand = n.GetObjectValue<Microsoft.Graph.Models.IntuneBrand>(Microsoft.Graph.Models.IntuneBrand.CreateFromDiscriminatorValue); } },
                {"iosUpdateStatuses", n => { IosUpdateStatuses = n.GetCollectionOfObjectValues<IosUpdateDeviceStatus>(IosUpdateDeviceStatus.CreateFromDiscriminatorValue)?.ToList(); } },
                {"managedDeviceOverview", n => { ManagedDeviceOverview = n.GetObjectValue<Microsoft.Graph.Models.ManagedDeviceOverview>(Microsoft.Graph.Models.ManagedDeviceOverview.CreateFromDiscriminatorValue); } },
                {"managedDevices", n => { ManagedDevices = n.GetCollectionOfObjectValues<ManagedDevice>(ManagedDevice.CreateFromDiscriminatorValue)?.ToList(); } },
                {"mobileAppTroubleshootingEvents", n => { MobileAppTroubleshootingEvents = n.GetCollectionOfObjectValues<MobileAppTroubleshootingEvent>(MobileAppTroubleshootingEvent.CreateFromDiscriminatorValue)?.ToList(); } },
                {"mobileThreatDefenseConnectors", n => { MobileThreatDefenseConnectors = n.GetCollectionOfObjectValues<MobileThreatDefenseConnector>(MobileThreatDefenseConnector.CreateFromDiscriminatorValue)?.ToList(); } },
                {"notificationMessageTemplates", n => { NotificationMessageTemplates = n.GetCollectionOfObjectValues<NotificationMessageTemplate>(NotificationMessageTemplate.CreateFromDiscriminatorValue)?.ToList(); } },
                {"remoteAssistancePartners", n => { RemoteAssistancePartners = n.GetCollectionOfObjectValues<RemoteAssistancePartner>(RemoteAssistancePartner.CreateFromDiscriminatorValue)?.ToList(); } },
                {"reports", n => { Reports = n.GetObjectValue<DeviceManagementReports>(DeviceManagementReports.CreateFromDiscriminatorValue); } },
                {"resourceOperations", n => { ResourceOperations = n.GetCollectionOfObjectValues<ResourceOperation>(ResourceOperation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"roleAssignments", n => { RoleAssignments = n.GetCollectionOfObjectValues<DeviceAndAppManagementRoleAssignment>(DeviceAndAppManagementRoleAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"roleDefinitions", n => { RoleDefinitions = n.GetCollectionOfObjectValues<RoleDefinition>(RoleDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
                {"settings", n => { Settings = n.GetObjectValue<DeviceManagementSettings>(DeviceManagementSettings.CreateFromDiscriminatorValue); } },
                {"softwareUpdateStatusSummary", n => { SoftwareUpdateStatusSummary = n.GetObjectValue<Microsoft.Graph.Models.SoftwareUpdateStatusSummary>(Microsoft.Graph.Models.SoftwareUpdateStatusSummary.CreateFromDiscriminatorValue); } },
                {"subscriptionState", n => { SubscriptionState = n.GetEnumValue<DeviceManagementSubscriptionState>(); } },
                {"telecomExpenseManagementPartners", n => { TelecomExpenseManagementPartners = n.GetCollectionOfObjectValues<TelecomExpenseManagementPartner>(TelecomExpenseManagementPartner.CreateFromDiscriminatorValue)?.ToList(); } },
                {"termsAndConditions", n => { TermsAndConditions = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.TermsAndConditions>(Microsoft.Graph.Models.TermsAndConditions.CreateFromDiscriminatorValue)?.ToList(); } },
                {"troubleshootingEvents", n => { TroubleshootingEvents = n.GetCollectionOfObjectValues<DeviceManagementTroubleshootingEvent>(DeviceManagementTroubleshootingEvent.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsAppHealthApplicationPerformance", n => { UserExperienceAnalyticsAppHealthApplicationPerformance = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.UserExperienceAnalyticsAppHealthApplicationPerformance>(Microsoft.Graph.Models.UserExperienceAnalyticsAppHealthApplicationPerformance.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDetails", n => { UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDetails = n.GetCollectionOfObjectValues<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDetails>(UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDetails.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceId", n => { UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceId = n.GetCollectionOfObjectValues<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId>(UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsAppHealthApplicationPerformanceByOSVersion", n => { UserExperienceAnalyticsAppHealthApplicationPerformanceByOSVersion = n.GetCollectionOfObjectValues<UserExperienceAnalyticsAppHealthAppPerformanceByOSVersion>(UserExperienceAnalyticsAppHealthAppPerformanceByOSVersion.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsAppHealthDeviceModelPerformance", n => { UserExperienceAnalyticsAppHealthDeviceModelPerformance = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.UserExperienceAnalyticsAppHealthDeviceModelPerformance>(Microsoft.Graph.Models.UserExperienceAnalyticsAppHealthDeviceModelPerformance.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsAppHealthDevicePerformance", n => { UserExperienceAnalyticsAppHealthDevicePerformance = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.UserExperienceAnalyticsAppHealthDevicePerformance>(Microsoft.Graph.Models.UserExperienceAnalyticsAppHealthDevicePerformance.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsAppHealthDevicePerformanceDetails", n => { UserExperienceAnalyticsAppHealthDevicePerformanceDetails = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.UserExperienceAnalyticsAppHealthDevicePerformanceDetails>(Microsoft.Graph.Models.UserExperienceAnalyticsAppHealthDevicePerformanceDetails.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsAppHealthOSVersionPerformance", n => { UserExperienceAnalyticsAppHealthOSVersionPerformance = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.UserExperienceAnalyticsAppHealthOSVersionPerformance>(Microsoft.Graph.Models.UserExperienceAnalyticsAppHealthOSVersionPerformance.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsAppHealthOverview", n => { UserExperienceAnalyticsAppHealthOverview = n.GetObjectValue<UserExperienceAnalyticsCategory>(UserExperienceAnalyticsCategory.CreateFromDiscriminatorValue); } },
                {"userExperienceAnalyticsBaselines", n => { UserExperienceAnalyticsBaselines = n.GetCollectionOfObjectValues<UserExperienceAnalyticsBaseline>(UserExperienceAnalyticsBaseline.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsCategories", n => { UserExperienceAnalyticsCategories = n.GetCollectionOfObjectValues<UserExperienceAnalyticsCategory>(UserExperienceAnalyticsCategory.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsDevicePerformance", n => { UserExperienceAnalyticsDevicePerformance = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.UserExperienceAnalyticsDevicePerformance>(Microsoft.Graph.Models.UserExperienceAnalyticsDevicePerformance.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsDeviceScores", n => { UserExperienceAnalyticsDeviceScores = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.UserExperienceAnalyticsDeviceScores>(Microsoft.Graph.Models.UserExperienceAnalyticsDeviceScores.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsDeviceStartupHistory", n => { UserExperienceAnalyticsDeviceStartupHistory = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.UserExperienceAnalyticsDeviceStartupHistory>(Microsoft.Graph.Models.UserExperienceAnalyticsDeviceStartupHistory.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsDeviceStartupProcesses", n => { UserExperienceAnalyticsDeviceStartupProcesses = n.GetCollectionOfObjectValues<UserExperienceAnalyticsDeviceStartupProcess>(UserExperienceAnalyticsDeviceStartupProcess.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsMetricHistory", n => { UserExperienceAnalyticsMetricHistory = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.UserExperienceAnalyticsMetricHistory>(Microsoft.Graph.Models.UserExperienceAnalyticsMetricHistory.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsModelScores", n => { UserExperienceAnalyticsModelScores = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.UserExperienceAnalyticsModelScores>(Microsoft.Graph.Models.UserExperienceAnalyticsModelScores.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsOverview", n => { UserExperienceAnalyticsOverview = n.GetObjectValue<Microsoft.Graph.Models.UserExperienceAnalyticsOverview>(Microsoft.Graph.Models.UserExperienceAnalyticsOverview.CreateFromDiscriminatorValue); } },
                {"userExperienceAnalyticsScoreHistory", n => { UserExperienceAnalyticsScoreHistory = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.UserExperienceAnalyticsScoreHistory>(Microsoft.Graph.Models.UserExperienceAnalyticsScoreHistory.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsSettings", n => { UserExperienceAnalyticsSettings = n.GetObjectValue<Microsoft.Graph.Models.UserExperienceAnalyticsSettings>(Microsoft.Graph.Models.UserExperienceAnalyticsSettings.CreateFromDiscriminatorValue); } },
                {"userExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric", n => { UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric = n.GetObjectValue<Microsoft.Graph.Models.UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric>(Microsoft.Graph.Models.UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric.CreateFromDiscriminatorValue); } },
                {"userExperienceAnalyticsWorkFromAnywhereMetrics", n => { UserExperienceAnalyticsWorkFromAnywhereMetrics = n.GetCollectionOfObjectValues<UserExperienceAnalyticsWorkFromAnywhereMetric>(UserExperienceAnalyticsWorkFromAnywhereMetric.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsWorkFromAnywhereModelPerformance", n => { UserExperienceAnalyticsWorkFromAnywhereModelPerformance = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.UserExperienceAnalyticsWorkFromAnywhereModelPerformance>(Microsoft.Graph.Models.UserExperienceAnalyticsWorkFromAnywhereModelPerformance.CreateFromDiscriminatorValue)?.ToList(); } },
                {"windowsAutopilotDeviceIdentities", n => { WindowsAutopilotDeviceIdentities = n.GetCollectionOfObjectValues<WindowsAutopilotDeviceIdentity>(WindowsAutopilotDeviceIdentity.CreateFromDiscriminatorValue)?.ToList(); } },
                {"windowsInformationProtectionAppLearningSummaries", n => { WindowsInformationProtectionAppLearningSummaries = n.GetCollectionOfObjectValues<WindowsInformationProtectionAppLearningSummary>(WindowsInformationProtectionAppLearningSummary.CreateFromDiscriminatorValue)?.ToList(); } },
                {"windowsInformationProtectionNetworkLearningSummaries", n => { WindowsInformationProtectionNetworkLearningSummaries = n.GetCollectionOfObjectValues<WindowsInformationProtectionNetworkLearningSummary>(WindowsInformationProtectionNetworkLearningSummary.CreateFromDiscriminatorValue)?.ToList(); } },
                {"windowsMalwareInformation", n => { WindowsMalwareInformation = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.WindowsMalwareInformation>(Microsoft.Graph.Models.WindowsMalwareInformation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"windowsMalwareOverview", n => { WindowsMalwareOverview = n.GetObjectValue<Microsoft.Graph.Models.WindowsMalwareOverview>(Microsoft.Graph.Models.WindowsMalwareOverview.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Models.ApplePushNotificationCertificate>("applePushNotificationCertificate", ApplePushNotificationCertificate);
            writer.WriteCollectionOfObjectValues<AuditEvent>("auditEvents", AuditEvents);
            writer.WriteCollectionOfObjectValues<ComplianceManagementPartner>("complianceManagementPartners", ComplianceManagementPartners);
            writer.WriteObjectValue<OnPremisesConditionalAccessSettings>("conditionalAccessSettings", ConditionalAccessSettings);
            writer.WriteCollectionOfObjectValues<DetectedApp>("detectedApps", DetectedApps);
            writer.WriteCollectionOfObjectValues<DeviceCategory>("deviceCategories", DeviceCategories);
            writer.WriteCollectionOfObjectValues<DeviceCompliancePolicy>("deviceCompliancePolicies", DeviceCompliancePolicies);
            writer.WriteObjectValue<Microsoft.Graph.Models.DeviceCompliancePolicyDeviceStateSummary>("deviceCompliancePolicyDeviceStateSummary", DeviceCompliancePolicyDeviceStateSummary);
            writer.WriteCollectionOfObjectValues<DeviceCompliancePolicySettingStateSummary>("deviceCompliancePolicySettingStateSummaries", DeviceCompliancePolicySettingStateSummaries);
            writer.WriteObjectValue<DeviceConfigurationDeviceStateSummary>("deviceConfigurationDeviceStateSummaries", DeviceConfigurationDeviceStateSummaries);
            writer.WriteCollectionOfObjectValues<DeviceConfiguration>("deviceConfigurations", DeviceConfigurations);
            writer.WriteCollectionOfObjectValues<DeviceEnrollmentConfiguration>("deviceEnrollmentConfigurations", DeviceEnrollmentConfigurations);
            writer.WriteCollectionOfObjectValues<DeviceManagementPartner>("deviceManagementPartners", DeviceManagementPartners);
            writer.WriteObjectValue<Microsoft.Graph.Models.DeviceProtectionOverview>("deviceProtectionOverview", DeviceProtectionOverview);
            writer.WriteCollectionOfObjectValues<DeviceManagementExchangeConnector>("exchangeConnectors", ExchangeConnectors);
            writer.WriteCollectionOfObjectValues<ImportedWindowsAutopilotDeviceIdentity>("importedWindowsAutopilotDeviceIdentities", ImportedWindowsAutopilotDeviceIdentities);
            writer.WriteGuidValue("intuneAccountId", IntuneAccountId);
            writer.WriteObjectValue<Microsoft.Graph.Models.IntuneBrand>("intuneBrand", IntuneBrand);
            writer.WriteCollectionOfObjectValues<IosUpdateDeviceStatus>("iosUpdateStatuses", IosUpdateStatuses);
            writer.WriteObjectValue<Microsoft.Graph.Models.ManagedDeviceOverview>("managedDeviceOverview", ManagedDeviceOverview);
            writer.WriteCollectionOfObjectValues<ManagedDevice>("managedDevices", ManagedDevices);
            writer.WriteCollectionOfObjectValues<MobileAppTroubleshootingEvent>("mobileAppTroubleshootingEvents", MobileAppTroubleshootingEvents);
            writer.WriteCollectionOfObjectValues<MobileThreatDefenseConnector>("mobileThreatDefenseConnectors", MobileThreatDefenseConnectors);
            writer.WriteCollectionOfObjectValues<NotificationMessageTemplate>("notificationMessageTemplates", NotificationMessageTemplates);
            writer.WriteCollectionOfObjectValues<RemoteAssistancePartner>("remoteAssistancePartners", RemoteAssistancePartners);
            writer.WriteObjectValue<DeviceManagementReports>("reports", Reports);
            writer.WriteCollectionOfObjectValues<ResourceOperation>("resourceOperations", ResourceOperations);
            writer.WriteCollectionOfObjectValues<DeviceAndAppManagementRoleAssignment>("roleAssignments", RoleAssignments);
            writer.WriteCollectionOfObjectValues<RoleDefinition>("roleDefinitions", RoleDefinitions);
            writer.WriteObjectValue<DeviceManagementSettings>("settings", Settings);
            writer.WriteObjectValue<Microsoft.Graph.Models.SoftwareUpdateStatusSummary>("softwareUpdateStatusSummary", SoftwareUpdateStatusSummary);
            writer.WriteEnumValue<DeviceManagementSubscriptionState>("subscriptionState", SubscriptionState);
            writer.WriteCollectionOfObjectValues<TelecomExpenseManagementPartner>("telecomExpenseManagementPartners", TelecomExpenseManagementPartners);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.TermsAndConditions>("termsAndConditions", TermsAndConditions);
            writer.WriteCollectionOfObjectValues<DeviceManagementTroubleshootingEvent>("troubleshootingEvents", TroubleshootingEvents);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.UserExperienceAnalyticsAppHealthApplicationPerformance>("userExperienceAnalyticsAppHealthApplicationPerformance", UserExperienceAnalyticsAppHealthApplicationPerformance);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDetails>("userExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDetails", UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDetails);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId>("userExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceId", UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceId);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsAppHealthAppPerformanceByOSVersion>("userExperienceAnalyticsAppHealthApplicationPerformanceByOSVersion", UserExperienceAnalyticsAppHealthApplicationPerformanceByOSVersion);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.UserExperienceAnalyticsAppHealthDeviceModelPerformance>("userExperienceAnalyticsAppHealthDeviceModelPerformance", UserExperienceAnalyticsAppHealthDeviceModelPerformance);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.UserExperienceAnalyticsAppHealthDevicePerformance>("userExperienceAnalyticsAppHealthDevicePerformance", UserExperienceAnalyticsAppHealthDevicePerformance);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.UserExperienceAnalyticsAppHealthDevicePerformanceDetails>("userExperienceAnalyticsAppHealthDevicePerformanceDetails", UserExperienceAnalyticsAppHealthDevicePerformanceDetails);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.UserExperienceAnalyticsAppHealthOSVersionPerformance>("userExperienceAnalyticsAppHealthOSVersionPerformance", UserExperienceAnalyticsAppHealthOSVersionPerformance);
            writer.WriteObjectValue<UserExperienceAnalyticsCategory>("userExperienceAnalyticsAppHealthOverview", UserExperienceAnalyticsAppHealthOverview);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsBaseline>("userExperienceAnalyticsBaselines", UserExperienceAnalyticsBaselines);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsCategory>("userExperienceAnalyticsCategories", UserExperienceAnalyticsCategories);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.UserExperienceAnalyticsDevicePerformance>("userExperienceAnalyticsDevicePerformance", UserExperienceAnalyticsDevicePerformance);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.UserExperienceAnalyticsDeviceScores>("userExperienceAnalyticsDeviceScores", UserExperienceAnalyticsDeviceScores);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.UserExperienceAnalyticsDeviceStartupHistory>("userExperienceAnalyticsDeviceStartupHistory", UserExperienceAnalyticsDeviceStartupHistory);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsDeviceStartupProcess>("userExperienceAnalyticsDeviceStartupProcesses", UserExperienceAnalyticsDeviceStartupProcesses);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.UserExperienceAnalyticsMetricHistory>("userExperienceAnalyticsMetricHistory", UserExperienceAnalyticsMetricHistory);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.UserExperienceAnalyticsModelScores>("userExperienceAnalyticsModelScores", UserExperienceAnalyticsModelScores);
            writer.WriteObjectValue<Microsoft.Graph.Models.UserExperienceAnalyticsOverview>("userExperienceAnalyticsOverview", UserExperienceAnalyticsOverview);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.UserExperienceAnalyticsScoreHistory>("userExperienceAnalyticsScoreHistory", UserExperienceAnalyticsScoreHistory);
            writer.WriteObjectValue<Microsoft.Graph.Models.UserExperienceAnalyticsSettings>("userExperienceAnalyticsSettings", UserExperienceAnalyticsSettings);
            writer.WriteObjectValue<Microsoft.Graph.Models.UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric>("userExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric", UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsWorkFromAnywhereMetric>("userExperienceAnalyticsWorkFromAnywhereMetrics", UserExperienceAnalyticsWorkFromAnywhereMetrics);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.UserExperienceAnalyticsWorkFromAnywhereModelPerformance>("userExperienceAnalyticsWorkFromAnywhereModelPerformance", UserExperienceAnalyticsWorkFromAnywhereModelPerformance);
            writer.WriteCollectionOfObjectValues<WindowsAutopilotDeviceIdentity>("windowsAutopilotDeviceIdentities", WindowsAutopilotDeviceIdentities);
            writer.WriteCollectionOfObjectValues<WindowsInformationProtectionAppLearningSummary>("windowsInformationProtectionAppLearningSummaries", WindowsInformationProtectionAppLearningSummaries);
            writer.WriteCollectionOfObjectValues<WindowsInformationProtectionNetworkLearningSummary>("windowsInformationProtectionNetworkLearningSummaries", WindowsInformationProtectionNetworkLearningSummaries);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.WindowsMalwareInformation>("windowsMalwareInformation", WindowsMalwareInformation);
            writer.WriteObjectValue<Microsoft.Graph.Models.WindowsMalwareOverview>("windowsMalwareOverview", WindowsMalwareOverview);
        }
    }
}
