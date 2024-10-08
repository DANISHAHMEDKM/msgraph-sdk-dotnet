// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models.Security
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class Alert : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The adversary or activity group that is associated with this alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ActorDisplayName
        {
            get { return BackingStore?.Get<string?>("actorDisplayName"); }
            set { BackingStore?.Set("actorDisplayName", value); }
        }
#nullable restore
#else
        public string ActorDisplayName
        {
            get { return BackingStore?.Get<string>("actorDisplayName"); }
            set { BackingStore?.Set("actorDisplayName", value); }
        }
#endif
        /// <summary>A collection of other alert properties, including user-defined properties. Any custom details defined in the alert, and any dynamic content in the alert details, are stored here.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.Security.Dictionary? AdditionalDataProperty
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.Dictionary?>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.Security.Dictionary AdditionalDataProperty
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.Dictionary>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
#endif
        /// <summary>The ID of the policy that generated the alert, and populated when there is a specific policy that generated the alert, whether configured by a customer or a built-in policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AlertPolicyId
        {
            get { return BackingStore?.Get<string?>("alertPolicyId"); }
            set { BackingStore?.Set("alertPolicyId", value); }
        }
#nullable restore
#else
        public string AlertPolicyId
        {
            get { return BackingStore?.Get<string>("alertPolicyId"); }
            set { BackingStore?.Set("alertPolicyId", value); }
        }
#endif
        /// <summary>URL for the Microsoft 365 Defender portal alert page.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AlertWebUrl
        {
            get { return BackingStore?.Get<string?>("alertWebUrl"); }
            set { BackingStore?.Set("alertWebUrl", value); }
        }
#nullable restore
#else
        public string AlertWebUrl
        {
            get { return BackingStore?.Get<string>("alertWebUrl"); }
            set { BackingStore?.Set("alertWebUrl", value); }
        }
#endif
        /// <summary>Owner of the alert, or null if no owner is assigned.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssignedTo
        {
            get { return BackingStore?.Get<string?>("assignedTo"); }
            set { BackingStore?.Set("assignedTo", value); }
        }
#nullable restore
#else
        public string AssignedTo
        {
            get { return BackingStore?.Get<string>("assignedTo"); }
            set { BackingStore?.Set("assignedTo", value); }
        }
#endif
        /// <summary>The attack kill-chain category that the alert belongs to. Aligned with the MITRE ATT&amp;CK framework.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Category
        {
            get { return BackingStore?.Get<string?>("category"); }
            set { BackingStore?.Set("category", value); }
        }
#nullable restore
#else
        public string Category
        {
            get { return BackingStore?.Get<string>("category"); }
            set { BackingStore?.Set("category", value); }
        }
#endif
        /// <summary>Specifies whether the alert represents a true threat. Possible values are: unknown, falsePositive, truePositive, informationalExpectedActivity, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Models.Security.AlertClassification? Classification
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.AlertClassification?>("classification"); }
            set { BackingStore?.Set("classification", value); }
        }
        /// <summary>Array of comments created by the Security Operations (SecOps) team during the alert management process.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.Security.AlertComment>? Comments
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.AlertComment>?>("comments"); }
            set { BackingStore?.Set("comments", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.Security.AlertComment> Comments
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.AlertComment>>("comments"); }
            set { BackingStore?.Set("comments", value); }
        }
#endif
        /// <summary>Time when Microsoft 365 Defender created the alert.</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>String value describing each alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description
        {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description
        {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>Detection technology or sensor that identified the notable component or activity. Possible values are: unknown, microsoftDefenderForEndpoint, antivirus, smartScreen, customTi, microsoftDefenderForOffice365, automatedInvestigation, microsoftThreatExperts, customDetection, microsoftDefenderForIdentity, cloudAppSecurity, microsoft365Defender, azureAdIdentityProtection, manual, microsoftDataLossPrevention, appGovernancePolicy, appGovernanceDetection, unknownFutureValue, microsoftDefenderForCloud, microsoftDefenderForIoT, microsoftDefenderForServers, microsoftDefenderForStorage, microsoftDefenderForDNS, microsoftDefenderForDatabases, microsoftDefenderForContainers, microsoftDefenderForNetwork, microsoftDefenderForAppService, microsoftDefenderForKeyVault, microsoftDefenderForResourceManager, microsoftDefenderForApiManagement, microsoftSentinel, nrtAlerts, scheduledAlerts, microsoftDefenderThreatIntelligenceAnalytics, builtInMl. You must use the Prefer: include-unknown-enum-members request header to get the following value(s) in this evolvable enum: microsoftDefenderForCloud, microsoftDefenderForIoT, microsoftDefenderForServers, microsoftDefenderForStorage, microsoftDefenderForDNS, microsoftDefenderForDatabases, microsoftDefenderForContainers, microsoftDefenderForNetwork, microsoftDefenderForAppService, microsoftDefenderForKeyVault, microsoftDefenderForResourceManager, microsoftDefenderForApiManagement, microsoftSentinel, nrtAlerts, scheduledAlerts, microsoftDefenderThreatIntelligenceAnalytics, builtInMl.</summary>
        public global::Microsoft.Graph.Models.Security.DetectionSource? DetectionSource
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.DetectionSource?>("detectionSource"); }
            set { BackingStore?.Set("detectionSource", value); }
        }
        /// <summary>The ID of the detector that triggered the alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DetectorId
        {
            get { return BackingStore?.Get<string?>("detectorId"); }
            set { BackingStore?.Set("detectorId", value); }
        }
#nullable restore
#else
        public string DetectorId
        {
            get { return BackingStore?.Get<string>("detectorId"); }
            set { BackingStore?.Set("detectorId", value); }
        }
#endif
        /// <summary>Specifies the result of the investigation, whether the alert represents a true attack and if so, the nature of the attack. Possible values are: unknown, apt, malware, securityPersonnel, securityTesting, unwantedSoftware, other, multiStagedAttack, compromisedAccount, phishing, maliciousUserActivity, notMalicious, notEnoughDataToValidate, confirmedUserActivity, lineOfBusinessApplication, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Models.Security.AlertDetermination? Determination
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.AlertDetermination?>("determination"); }
            set { BackingStore?.Set("determination", value); }
        }
        /// <summary>Collection of evidence related to the alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.Security.AlertEvidence>? Evidence
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.AlertEvidence>?>("evidence"); }
            set { BackingStore?.Set("evidence", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.Security.AlertEvidence> Evidence
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.AlertEvidence>>("evidence"); }
            set { BackingStore?.Set("evidence", value); }
        }
#endif
        /// <summary>The earliest activity associated with the alert.</summary>
        public DateTimeOffset? FirstActivityDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("firstActivityDateTime"); }
            set { BackingStore?.Set("firstActivityDateTime", value); }
        }
        /// <summary>Unique identifier to represent the incident this alert resource is associated with.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IncidentId
        {
            get { return BackingStore?.Get<string?>("incidentId"); }
            set { BackingStore?.Set("incidentId", value); }
        }
#nullable restore
#else
        public string IncidentId
        {
            get { return BackingStore?.Get<string>("incidentId"); }
            set { BackingStore?.Set("incidentId", value); }
        }
#endif
        /// <summary>URL for the incident page in the Microsoft 365 Defender portal.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IncidentWebUrl
        {
            get { return BackingStore?.Get<string?>("incidentWebUrl"); }
            set { BackingStore?.Set("incidentWebUrl", value); }
        }
#nullable restore
#else
        public string IncidentWebUrl
        {
            get { return BackingStore?.Get<string>("incidentWebUrl"); }
            set { BackingStore?.Set("incidentWebUrl", value); }
        }
#endif
        /// <summary>The oldest activity associated with the alert.</summary>
        public DateTimeOffset? LastActivityDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastActivityDateTime"); }
            set { BackingStore?.Set("lastActivityDateTime", value); }
        }
        /// <summary>Time when the alert was last updated at Microsoft 365 Defender.</summary>
        public DateTimeOffset? LastUpdateDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastUpdateDateTime"); }
            set { BackingStore?.Set("lastUpdateDateTime", value); }
        }
        /// <summary>The attack techniques, as aligned with the MITRE ATT&amp;CK framework.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? MitreTechniques
        {
            get { return BackingStore?.Get<List<string>?>("mitreTechniques"); }
            set { BackingStore?.Set("mitreTechniques", value); }
        }
#nullable restore
#else
        public List<string> MitreTechniques
        {
            get { return BackingStore?.Get<List<string>>("mitreTechniques"); }
            set { BackingStore?.Set("mitreTechniques", value); }
        }
#endif
        /// <summary>The name of the product which published this alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductName
        {
            get { return BackingStore?.Get<string?>("productName"); }
            set { BackingStore?.Set("productName", value); }
        }
#nullable restore
#else
        public string ProductName
        {
            get { return BackingStore?.Get<string>("productName"); }
            set { BackingStore?.Set("productName", value); }
        }
#endif
        /// <summary>The ID of the alert as it appears in the security provider product that generated the alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProviderAlertId
        {
            get { return BackingStore?.Get<string?>("providerAlertId"); }
            set { BackingStore?.Set("providerAlertId", value); }
        }
#nullable restore
#else
        public string ProviderAlertId
        {
            get { return BackingStore?.Get<string>("providerAlertId"); }
            set { BackingStore?.Set("providerAlertId", value); }
        }
#endif
        /// <summary>Recommended response and remediation actions to take in the event this alert was generated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecommendedActions
        {
            get { return BackingStore?.Get<string?>("recommendedActions"); }
            set { BackingStore?.Set("recommendedActions", value); }
        }
#nullable restore
#else
        public string RecommendedActions
        {
            get { return BackingStore?.Get<string>("recommendedActions"); }
            set { BackingStore?.Set("recommendedActions", value); }
        }
#endif
        /// <summary>Time when the alert was resolved.</summary>
        public DateTimeOffset? ResolvedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("resolvedDateTime"); }
            set { BackingStore?.Set("resolvedDateTime", value); }
        }
        /// <summary>The serviceSource property</summary>
        public global::Microsoft.Graph.Models.Security.ServiceSource? ServiceSource
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.ServiceSource?>("serviceSource"); }
            set { BackingStore?.Set("serviceSource", value); }
        }
        /// <summary>The severity property</summary>
        public global::Microsoft.Graph.Models.Security.AlertSeverity? Severity
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.AlertSeverity?>("severity"); }
            set { BackingStore?.Set("severity", value); }
        }
        /// <summary>The status property</summary>
        public global::Microsoft.Graph.Models.Security.AlertStatus? Status
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.AlertStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>The system tags associated with the alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SystemTags
        {
            get { return BackingStore?.Get<List<string>?>("systemTags"); }
            set { BackingStore?.Set("systemTags", value); }
        }
#nullable restore
#else
        public List<string> SystemTags
        {
            get { return BackingStore?.Get<List<string>>("systemTags"); }
            set { BackingStore?.Set("systemTags", value); }
        }
#endif
        /// <summary>The Microsoft Entra tenant the alert was created in.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantId
        {
            get { return BackingStore?.Get<string?>("tenantId"); }
            set { BackingStore?.Set("tenantId", value); }
        }
#nullable restore
#else
        public string TenantId
        {
            get { return BackingStore?.Get<string>("tenantId"); }
            set { BackingStore?.Set("tenantId", value); }
        }
#endif
        /// <summary>The threat associated with this alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ThreatDisplayName
        {
            get { return BackingStore?.Get<string?>("threatDisplayName"); }
            set { BackingStore?.Set("threatDisplayName", value); }
        }
#nullable restore
#else
        public string ThreatDisplayName
        {
            get { return BackingStore?.Get<string>("threatDisplayName"); }
            set { BackingStore?.Set("threatDisplayName", value); }
        }
#endif
        /// <summary>Threat family associated with this alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ThreatFamilyName
        {
            get { return BackingStore?.Get<string?>("threatFamilyName"); }
            set { BackingStore?.Set("threatFamilyName", value); }
        }
#nullable restore
#else
        public string ThreatFamilyName
        {
            get { return BackingStore?.Get<string>("threatFamilyName"); }
            set { BackingStore?.Set("threatFamilyName", value); }
        }
#endif
        /// <summary>Brief identifying string value describing the alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title
        {
            get { return BackingStore?.Get<string?>("title"); }
            set { BackingStore?.Set("title", value); }
        }
#nullable restore
#else
        public string Title
        {
            get { return BackingStore?.Get<string>("title"); }
            set { BackingStore?.Set("title", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Security.Alert"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.Security.Alert CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.Security.Alert();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "actorDisplayName", n => { ActorDisplayName = n.GetStringValue(); } },
                { "additionalData", n => { AdditionalDataProperty = n.GetObjectValue<global::Microsoft.Graph.Models.Security.Dictionary>(global::Microsoft.Graph.Models.Security.Dictionary.CreateFromDiscriminatorValue); } },
                { "alertPolicyId", n => { AlertPolicyId = n.GetStringValue(); } },
                { "alertWebUrl", n => { AlertWebUrl = n.GetStringValue(); } },
                { "assignedTo", n => { AssignedTo = n.GetStringValue(); } },
                { "category", n => { Category = n.GetStringValue(); } },
                { "classification", n => { Classification = n.GetEnumValue<global::Microsoft.Graph.Models.Security.AlertClassification>(); } },
                { "comments", n => { Comments = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.AlertComment>(global::Microsoft.Graph.Models.Security.AlertComment.CreateFromDiscriminatorValue)?.AsList(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "detectionSource", n => { DetectionSource = n.GetEnumValue<global::Microsoft.Graph.Models.Security.DetectionSource>(); } },
                { "detectorId", n => { DetectorId = n.GetStringValue(); } },
                { "determination", n => { Determination = n.GetEnumValue<global::Microsoft.Graph.Models.Security.AlertDetermination>(); } },
                { "evidence", n => { Evidence = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.AlertEvidence>(global::Microsoft.Graph.Models.Security.AlertEvidence.CreateFromDiscriminatorValue)?.AsList(); } },
                { "firstActivityDateTime", n => { FirstActivityDateTime = n.GetDateTimeOffsetValue(); } },
                { "incidentId", n => { IncidentId = n.GetStringValue(); } },
                { "incidentWebUrl", n => { IncidentWebUrl = n.GetStringValue(); } },
                { "lastActivityDateTime", n => { LastActivityDateTime = n.GetDateTimeOffsetValue(); } },
                { "lastUpdateDateTime", n => { LastUpdateDateTime = n.GetDateTimeOffsetValue(); } },
                { "mitreTechniques", n => { MitreTechniques = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "productName", n => { ProductName = n.GetStringValue(); } },
                { "providerAlertId", n => { ProviderAlertId = n.GetStringValue(); } },
                { "recommendedActions", n => { RecommendedActions = n.GetStringValue(); } },
                { "resolvedDateTime", n => { ResolvedDateTime = n.GetDateTimeOffsetValue(); } },
                { "serviceSource", n => { ServiceSource = n.GetEnumValue<global::Microsoft.Graph.Models.Security.ServiceSource>(); } },
                { "severity", n => { Severity = n.GetEnumValue<global::Microsoft.Graph.Models.Security.AlertSeverity>(); } },
                { "status", n => { Status = n.GetEnumValue<global::Microsoft.Graph.Models.Security.AlertStatus>(); } },
                { "systemTags", n => { SystemTags = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "tenantId", n => { TenantId = n.GetStringValue(); } },
                { "threatDisplayName", n => { ThreatDisplayName = n.GetStringValue(); } },
                { "threatFamilyName", n => { ThreatFamilyName = n.GetStringValue(); } },
                { "title", n => { Title = n.GetStringValue(); } },
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
            writer.WriteStringValue("actorDisplayName", ActorDisplayName);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.Security.Dictionary>("additionalData", AdditionalDataProperty);
            writer.WriteStringValue("alertPolicyId", AlertPolicyId);
            writer.WriteStringValue("alertWebUrl", AlertWebUrl);
            writer.WriteStringValue("assignedTo", AssignedTo);
            writer.WriteStringValue("category", Category);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.Security.AlertClassification>("classification", Classification);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.AlertComment>("comments", Comments);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.Security.DetectionSource>("detectionSource", DetectionSource);
            writer.WriteStringValue("detectorId", DetectorId);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.Security.AlertDetermination>("determination", Determination);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.AlertEvidence>("evidence", Evidence);
            writer.WriteDateTimeOffsetValue("firstActivityDateTime", FirstActivityDateTime);
            writer.WriteStringValue("incidentId", IncidentId);
            writer.WriteStringValue("incidentWebUrl", IncidentWebUrl);
            writer.WriteDateTimeOffsetValue("lastActivityDateTime", LastActivityDateTime);
            writer.WriteDateTimeOffsetValue("lastUpdateDateTime", LastUpdateDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("mitreTechniques", MitreTechniques);
            writer.WriteStringValue("productName", ProductName);
            writer.WriteStringValue("providerAlertId", ProviderAlertId);
            writer.WriteStringValue("recommendedActions", RecommendedActions);
            writer.WriteDateTimeOffsetValue("resolvedDateTime", ResolvedDateTime);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.Security.ServiceSource>("serviceSource", ServiceSource);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.Security.AlertSeverity>("severity", Severity);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.Security.AlertStatus>("status", Status);
            writer.WriteCollectionOfPrimitiveValues<string>("systemTags", SystemTags);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteStringValue("threatDisplayName", ThreatDisplayName);
            writer.WriteStringValue("threatFamilyName", ThreatFamilyName);
            writer.WriteStringValue("title", Title);
        }
    }
}
#pragma warning restore CS0618
