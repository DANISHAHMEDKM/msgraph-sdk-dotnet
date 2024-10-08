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
    public partial class RiskDetection : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Indicates the activity type the detected risk is linked to. Possible values are: signin, user, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Models.ActivityType? Activity
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ActivityType?>("activity"); }
            set { BackingStore?.Set("activity", value); }
        }
        /// <summary>Date and time that the risky activity occurred. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is look like this: 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? ActivityDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("activityDateTime"); }
            set { BackingStore?.Set("activityDateTime", value); }
        }
        /// <summary>Additional information associated with the risk detection in JSON format. For example, &apos;[{/&apos;Key/&apos;:/&apos;userAgent/&apos;,/&apos;Value/&apos;:/&apos;Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/68.0.3440.106 Safari/537.36/&apos;}]&apos;. Possible keys in the additionalInfo JSON string are: userAgent, alertUrl, relatedEventTimeInUtc, relatedUserAgent, deviceInformation, relatedLocation, requestId, correlationId, lastActivityTimeInUtc, malwareName, clientLocation, clientIp, riskReasons. For more information about riskReasons and possible values, see riskReasons values.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AdditionalInfo
        {
            get { return BackingStore?.Get<string?>("additionalInfo"); }
            set { BackingStore?.Set("additionalInfo", value); }
        }
#nullable restore
#else
        public string AdditionalInfo
        {
            get { return BackingStore?.Get<string>("additionalInfo"); }
            set { BackingStore?.Set("additionalInfo", value); }
        }
#endif
        /// <summary>Correlation ID of the sign-in associated with the risk detection. This property is null if the risk detection is not associated with a sign-in.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CorrelationId
        {
            get { return BackingStore?.Get<string?>("correlationId"); }
            set { BackingStore?.Set("correlationId", value); }
        }
#nullable restore
#else
        public string CorrelationId
        {
            get { return BackingStore?.Get<string>("correlationId"); }
            set { BackingStore?.Set("correlationId", value); }
        }
#endif
        /// <summary>Date and time that the risk was detected. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 looks like this: 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? DetectedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("detectedDateTime"); }
            set { BackingStore?.Set("detectedDateTime", value); }
        }
        /// <summary>Timing of the detected risk (real-time/offline). Possible values are: notDefined, realtime, nearRealtime, offline, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Models.RiskDetectionTimingType? DetectionTimingType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.RiskDetectionTimingType?>("detectionTimingType"); }
            set { BackingStore?.Set("detectionTimingType", value); }
        }
        /// <summary>Provides the IP address of the client from where the risk occurred.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IpAddress
        {
            get { return BackingStore?.Get<string?>("ipAddress"); }
            set { BackingStore?.Set("ipAddress", value); }
        }
#nullable restore
#else
        public string IpAddress
        {
            get { return BackingStore?.Get<string>("ipAddress"); }
            set { BackingStore?.Set("ipAddress", value); }
        }
#endif
        /// <summary>Date and time that the risk detection was last updated. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is look like this: 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? LastUpdatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastUpdatedDateTime"); }
            set { BackingStore?.Set("lastUpdatedDateTime", value); }
        }
        /// <summary>Location of the sign-in.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.SignInLocation? Location
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.SignInLocation?>("location"); }
            set { BackingStore?.Set("location", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.SignInLocation Location
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.SignInLocation>("location"); }
            set { BackingStore?.Set("location", value); }
        }
#endif
        /// <summary>Request ID of the sign-in associated with the risk detection. This property is null if the risk detection is not associated with a sign-in.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RequestId
        {
            get { return BackingStore?.Get<string?>("requestId"); }
            set { BackingStore?.Set("requestId", value); }
        }
#nullable restore
#else
        public string RequestId
        {
            get { return BackingStore?.Get<string>("requestId"); }
            set { BackingStore?.Set("requestId", value); }
        }
#endif
        /// <summary>Details of the detected risk. The possible values are: none, adminGeneratedTemporaryPassword, userPerformedSecuredPasswordChange, userPerformedSecuredPasswordReset, adminConfirmedSigninSafe, aiConfirmedSigninSafe, userPassedMFADrivenByRiskBasedPolicy, adminDismissedAllRiskForUser, adminConfirmedSigninCompromised, hidden, adminConfirmedUserCompromised, unknownFutureValue, m365DAdminDismissedDetection. Note that you must use the Prefer: include - unknown -enum-members request header to get the following value(s) in this evolvable enum: m365DAdminDismissedDetection.</summary>
        public global::Microsoft.Graph.Models.RiskDetail? RiskDetail
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.RiskDetail?>("riskDetail"); }
            set { BackingStore?.Set("riskDetail", value); }
        }
        /// <summary>The type of risk event detected. The possible values are adminConfirmedUserCompromised, anomalousToken, anomalousUserActivity, anonymizedIPAddress, generic, impossibleTravel, investigationsThreatIntelligence, suspiciousSendingPatterns, leakedCredentials, maliciousIPAddress,malwareInfectedIPAddress, mcasSuspiciousInboxManipulationRules, newCountry, passwordSpray,riskyIPAddress, suspiciousAPITraffic, suspiciousBrowser,suspiciousInboxForwarding, suspiciousIPAddress, tokenIssuerAnomaly, unfamiliarFeatures, unlikelyTravel. If the risk detection is a premium detection, will show generic. For more information about each value, see Risk types and detection.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RiskEventType
        {
            get { return BackingStore?.Get<string?>("riskEventType"); }
            set { BackingStore?.Set("riskEventType", value); }
        }
#nullable restore
#else
        public string RiskEventType
        {
            get { return BackingStore?.Get<string>("riskEventType"); }
            set { BackingStore?.Set("riskEventType", value); }
        }
#endif
        /// <summary>Level of the detected risk. Possible values are: low, medium, high, hidden, none, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Models.RiskLevel? RiskLevel
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.RiskLevel?>("riskLevel"); }
            set { BackingStore?.Set("riskLevel", value); }
        }
        /// <summary>The state of a detected risky user or sign-in. Possible values are: none, confirmedSafe, remediated, dismissed, atRisk, confirmedCompromised, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Models.RiskState? RiskState
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.RiskState?>("riskState"); }
            set { BackingStore?.Set("riskState", value); }
        }
        /// <summary>Source of the risk detection. For example, activeDirectory.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Source
        {
            get { return BackingStore?.Get<string?>("source"); }
            set { BackingStore?.Set("source", value); }
        }
#nullable restore
#else
        public string Source
        {
            get { return BackingStore?.Get<string>("source"); }
            set { BackingStore?.Set("source", value); }
        }
#endif
        /// <summary>Indicates the type of token issuer for the detected sign-in risk. Possible values are: AzureAD, ADFederationServices, UnknownFutureValue.</summary>
        public global::Microsoft.Graph.Models.TokenIssuerType? TokenIssuerType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.TokenIssuerType?>("tokenIssuerType"); }
            set { BackingStore?.Set("tokenIssuerType", value); }
        }
        /// <summary>The user principal name (UPN) of the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserDisplayName
        {
            get { return BackingStore?.Get<string?>("userDisplayName"); }
            set { BackingStore?.Set("userDisplayName", value); }
        }
#nullable restore
#else
        public string UserDisplayName
        {
            get { return BackingStore?.Get<string>("userDisplayName"); }
            set { BackingStore?.Set("userDisplayName", value); }
        }
#endif
        /// <summary>Unique ID of the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserId
        {
            get { return BackingStore?.Get<string?>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
#nullable restore
#else
        public string UserId
        {
            get { return BackingStore?.Get<string>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
#endif
        /// <summary>The user principal name (UPN) of the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserPrincipalName
        {
            get { return BackingStore?.Get<string?>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
#nullable restore
#else
        public string UserPrincipalName
        {
            get { return BackingStore?.Get<string>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.RiskDetection"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.RiskDetection CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.RiskDetection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "activity", n => { Activity = n.GetEnumValue<global::Microsoft.Graph.Models.ActivityType>(); } },
                { "activityDateTime", n => { ActivityDateTime = n.GetDateTimeOffsetValue(); } },
                { "additionalInfo", n => { AdditionalInfo = n.GetStringValue(); } },
                { "correlationId", n => { CorrelationId = n.GetStringValue(); } },
                { "detectedDateTime", n => { DetectedDateTime = n.GetDateTimeOffsetValue(); } },
                { "detectionTimingType", n => { DetectionTimingType = n.GetEnumValue<global::Microsoft.Graph.Models.RiskDetectionTimingType>(); } },
                { "ipAddress", n => { IpAddress = n.GetStringValue(); } },
                { "lastUpdatedDateTime", n => { LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "location", n => { Location = n.GetObjectValue<global::Microsoft.Graph.Models.SignInLocation>(global::Microsoft.Graph.Models.SignInLocation.CreateFromDiscriminatorValue); } },
                { "requestId", n => { RequestId = n.GetStringValue(); } },
                { "riskDetail", n => { RiskDetail = n.GetEnumValue<global::Microsoft.Graph.Models.RiskDetail>(); } },
                { "riskEventType", n => { RiskEventType = n.GetStringValue(); } },
                { "riskLevel", n => { RiskLevel = n.GetEnumValue<global::Microsoft.Graph.Models.RiskLevel>(); } },
                { "riskState", n => { RiskState = n.GetEnumValue<global::Microsoft.Graph.Models.RiskState>(); } },
                { "source", n => { Source = n.GetStringValue(); } },
                { "tokenIssuerType", n => { TokenIssuerType = n.GetEnumValue<global::Microsoft.Graph.Models.TokenIssuerType>(); } },
                { "userDisplayName", n => { UserDisplayName = n.GetStringValue(); } },
                { "userId", n => { UserId = n.GetStringValue(); } },
                { "userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
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
            writer.WriteEnumValue<global::Microsoft.Graph.Models.ActivityType>("activity", Activity);
            writer.WriteDateTimeOffsetValue("activityDateTime", ActivityDateTime);
            writer.WriteStringValue("additionalInfo", AdditionalInfo);
            writer.WriteStringValue("correlationId", CorrelationId);
            writer.WriteDateTimeOffsetValue("detectedDateTime", DetectedDateTime);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.RiskDetectionTimingType>("detectionTimingType", DetectionTimingType);
            writer.WriteStringValue("ipAddress", IpAddress);
            writer.WriteDateTimeOffsetValue("lastUpdatedDateTime", LastUpdatedDateTime);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.SignInLocation>("location", Location);
            writer.WriteStringValue("requestId", RequestId);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.RiskDetail>("riskDetail", RiskDetail);
            writer.WriteStringValue("riskEventType", RiskEventType);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.RiskLevel>("riskLevel", RiskLevel);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.RiskState>("riskState", RiskState);
            writer.WriteStringValue("source", Source);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.TokenIssuerType>("tokenIssuerType", TokenIssuerType);
            writer.WriteStringValue("userDisplayName", UserDisplayName);
            writer.WriteStringValue("userId", UserId);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}
#pragma warning restore CS0618
