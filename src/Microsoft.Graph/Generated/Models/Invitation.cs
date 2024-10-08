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
    public partial class Invitation : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The user created as part of the invitation creation. Read-only. The id property is required in the request body to reset a redemption status.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.User? InvitedUser
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.User?>("invitedUser"); }
            set { BackingStore?.Set("invitedUser", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.User InvitedUser
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.User>("invitedUser"); }
            set { BackingStore?.Set("invitedUser", value); }
        }
#endif
        /// <summary>The display name of the user being invited.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InvitedUserDisplayName
        {
            get { return BackingStore?.Get<string?>("invitedUserDisplayName"); }
            set { BackingStore?.Set("invitedUserDisplayName", value); }
        }
#nullable restore
#else
        public string InvitedUserDisplayName
        {
            get { return BackingStore?.Get<string>("invitedUserDisplayName"); }
            set { BackingStore?.Set("invitedUserDisplayName", value); }
        }
#endif
        /// <summary>The email address of the user being invited. Required. The following special characters aren&apos;t permitted in the email address:Tilde (~)Exclamation point (!)Number sign (#)Dollar sign ($)Percent (%)Circumflex (^)Ampersand (&amp;)Asterisk (*)Parentheses (( ))Plus sign (+)Equal sign (=)Brackets ([ ])Braces ({ })Backslash (/)Slash mark (/)Pipe (/|)Semicolon (;)Colon (:)Quotation marks (&apos;)Angle brackets (&lt; &gt;)Question mark (?)Comma (,)However, the following exceptions apply:A period (.) or a hyphen (-) is permitted anywhere in the user name, except at the beginning or end of the name.An underscore (_) is permitted anywhere in the user name, including at the beginning or end of the name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InvitedUserEmailAddress
        {
            get { return BackingStore?.Get<string?>("invitedUserEmailAddress"); }
            set { BackingStore?.Set("invitedUserEmailAddress", value); }
        }
#nullable restore
#else
        public string InvitedUserEmailAddress
        {
            get { return BackingStore?.Get<string>("invitedUserEmailAddress"); }
            set { BackingStore?.Set("invitedUserEmailAddress", value); }
        }
#endif
        /// <summary>Contains configuration for the message being sent to the invited user, including customizing message text, language, and cc recipient list.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.InvitedUserMessageInfo? InvitedUserMessageInfo
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.InvitedUserMessageInfo?>("invitedUserMessageInfo"); }
            set { BackingStore?.Set("invitedUserMessageInfo", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.InvitedUserMessageInfo InvitedUserMessageInfo
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.InvitedUserMessageInfo>("invitedUserMessageInfo"); }
            set { BackingStore?.Set("invitedUserMessageInfo", value); }
        }
#endif
        /// <summary>The users or groups who are sponsors of the invited user. Sponsors are users and groups that are responsible for guest users&apos; privileges in the tenant and for keeping the guest users&apos; information and access up to date.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.DirectoryObject>? InvitedUserSponsors
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.DirectoryObject>?>("invitedUserSponsors"); }
            set { BackingStore?.Set("invitedUserSponsors", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.DirectoryObject> InvitedUserSponsors
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.DirectoryObject>>("invitedUserSponsors"); }
            set { BackingStore?.Set("invitedUserSponsors", value); }
        }
#endif
        /// <summary>The userType of the user being invited. By default, this is Guest. You can invite as Member if you&apos;re a company administrator.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InvitedUserType
        {
            get { return BackingStore?.Get<string?>("invitedUserType"); }
            set { BackingStore?.Set("invitedUserType", value); }
        }
#nullable restore
#else
        public string InvitedUserType
        {
            get { return BackingStore?.Get<string>("invitedUserType"); }
            set { BackingStore?.Set("invitedUserType", value); }
        }
#endif
        /// <summary>The URL the user can use to redeem their invitation. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InviteRedeemUrl
        {
            get { return BackingStore?.Get<string?>("inviteRedeemUrl"); }
            set { BackingStore?.Set("inviteRedeemUrl", value); }
        }
#nullable restore
#else
        public string InviteRedeemUrl
        {
            get { return BackingStore?.Get<string>("inviteRedeemUrl"); }
            set { BackingStore?.Set("inviteRedeemUrl", value); }
        }
#endif
        /// <summary>The URL the user should be redirected to after the invitation is redeemed. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InviteRedirectUrl
        {
            get { return BackingStore?.Get<string?>("inviteRedirectUrl"); }
            set { BackingStore?.Set("inviteRedirectUrl", value); }
        }
#nullable restore
#else
        public string InviteRedirectUrl
        {
            get { return BackingStore?.Get<string>("inviteRedirectUrl"); }
            set { BackingStore?.Set("inviteRedirectUrl", value); }
        }
#endif
        /// <summary>Reset the user&apos;s redemption status and reinvite a user while retaining their user identifier, group memberships, and app assignments. This property allows you to enable a user to sign-in using a different email address from the one in the previous invitation. When true, the invitedUser/id relationship is required. For more information about using this property, see Reset redemption status for a guest user.</summary>
        public bool? ResetRedemption
        {
            get { return BackingStore?.Get<bool?>("resetRedemption"); }
            set { BackingStore?.Set("resetRedemption", value); }
        }
        /// <summary>Indicates whether an email should be sent to the user being invited. The default is false.</summary>
        public bool? SendInvitationMessage
        {
            get { return BackingStore?.Get<bool?>("sendInvitationMessage"); }
            set { BackingStore?.Set("sendInvitationMessage", value); }
        }
        /// <summary>The status of the invitation. Possible values are: PendingAcceptance, Completed, InProgress, and Error.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Status
        {
            get { return BackingStore?.Get<string?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
#nullable restore
#else
        public string Status
        {
            get { return BackingStore?.Get<string>("status"); }
            set { BackingStore?.Set("status", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Invitation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.Invitation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.Invitation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "inviteRedeemUrl", n => { InviteRedeemUrl = n.GetStringValue(); } },
                { "inviteRedirectUrl", n => { InviteRedirectUrl = n.GetStringValue(); } },
                { "invitedUser", n => { InvitedUser = n.GetObjectValue<global::Microsoft.Graph.Models.User>(global::Microsoft.Graph.Models.User.CreateFromDiscriminatorValue); } },
                { "invitedUserDisplayName", n => { InvitedUserDisplayName = n.GetStringValue(); } },
                { "invitedUserEmailAddress", n => { InvitedUserEmailAddress = n.GetStringValue(); } },
                { "invitedUserMessageInfo", n => { InvitedUserMessageInfo = n.GetObjectValue<global::Microsoft.Graph.Models.InvitedUserMessageInfo>(global::Microsoft.Graph.Models.InvitedUserMessageInfo.CreateFromDiscriminatorValue); } },
                { "invitedUserSponsors", n => { InvitedUserSponsors = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.DirectoryObject>(global::Microsoft.Graph.Models.DirectoryObject.CreateFromDiscriminatorValue)?.AsList(); } },
                { "invitedUserType", n => { InvitedUserType = n.GetStringValue(); } },
                { "resetRedemption", n => { ResetRedemption = n.GetBoolValue(); } },
                { "sendInvitationMessage", n => { SendInvitationMessage = n.GetBoolValue(); } },
                { "status", n => { Status = n.GetStringValue(); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Models.User>("invitedUser", InvitedUser);
            writer.WriteStringValue("invitedUserDisplayName", InvitedUserDisplayName);
            writer.WriteStringValue("invitedUserEmailAddress", InvitedUserEmailAddress);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.InvitedUserMessageInfo>("invitedUserMessageInfo", InvitedUserMessageInfo);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.DirectoryObject>("invitedUserSponsors", InvitedUserSponsors);
            writer.WriteStringValue("invitedUserType", InvitedUserType);
            writer.WriteStringValue("inviteRedeemUrl", InviteRedeemUrl);
            writer.WriteStringValue("inviteRedirectUrl", InviteRedirectUrl);
            writer.WriteBoolValue("resetRedemption", ResetRedemption);
            writer.WriteBoolValue("sendInvitationMessage", SendInvitationMessage);
            writer.WriteStringValue("status", Status);
        }
    }
}
#pragma warning restore CS0618
