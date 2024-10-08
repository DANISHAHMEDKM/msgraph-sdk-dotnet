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
    public partial class Chat : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The chatType property</summary>
        public global::Microsoft.Graph.Models.ChatType? ChatType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ChatType?>("chatType"); }
            set { BackingStore?.Set("chatType", value); }
        }
        /// <summary>Date and time at which the chat was created. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>A collection of all the apps in the chat. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.TeamsAppInstallation>? InstalledApps
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.TeamsAppInstallation>?>("installedApps"); }
            set { BackingStore?.Set("installedApps", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.TeamsAppInstallation> InstalledApps
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.TeamsAppInstallation>>("installedApps"); }
            set { BackingStore?.Set("installedApps", value); }
        }
#endif
        /// <summary>Preview of the last message sent in the chat. Null if no messages were sent in the chat. Currently, only the list chats operation supports this property.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.ChatMessageInfo? LastMessagePreview
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ChatMessageInfo?>("lastMessagePreview"); }
            set { BackingStore?.Set("lastMessagePreview", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.ChatMessageInfo LastMessagePreview
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ChatMessageInfo>("lastMessagePreview"); }
            set { BackingStore?.Set("lastMessagePreview", value); }
        }
#endif
        /// <summary>Date and time at which the chat was renamed or the list of members was last changed. Read-only.</summary>
        public DateTimeOffset? LastUpdatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastUpdatedDateTime"); }
            set { BackingStore?.Set("lastUpdatedDateTime", value); }
        }
        /// <summary>A collection of all the members in the chat. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.ConversationMember>? Members
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.ConversationMember>?>("members"); }
            set { BackingStore?.Set("members", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.ConversationMember> Members
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.ConversationMember>>("members"); }
            set { BackingStore?.Set("members", value); }
        }
#endif
        /// <summary>A collection of all the messages in the chat. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.ChatMessage>? Messages
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.ChatMessage>?>("messages"); }
            set { BackingStore?.Set("messages", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.ChatMessage> Messages
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.ChatMessage>>("messages"); }
            set { BackingStore?.Set("messages", value); }
        }
#endif
        /// <summary>Represents details about an online meeting. If the chat isn&apos;t associated with an online meeting, the property is empty. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.TeamworkOnlineMeetingInfo? OnlineMeetingInfo
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.TeamworkOnlineMeetingInfo?>("onlineMeetingInfo"); }
            set { BackingStore?.Set("onlineMeetingInfo", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.TeamworkOnlineMeetingInfo OnlineMeetingInfo
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.TeamworkOnlineMeetingInfo>("onlineMeetingInfo"); }
            set { BackingStore?.Set("onlineMeetingInfo", value); }
        }
#endif
        /// <summary>A collection of permissions granted to apps for the chat.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.ResourceSpecificPermissionGrant>? PermissionGrants
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.ResourceSpecificPermissionGrant>?>("permissionGrants"); }
            set { BackingStore?.Set("permissionGrants", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.ResourceSpecificPermissionGrant> PermissionGrants
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.ResourceSpecificPermissionGrant>>("permissionGrants"); }
            set { BackingStore?.Set("permissionGrants", value); }
        }
#endif
        /// <summary>A collection of all the pinned messages in the chat. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.PinnedChatMessageInfo>? PinnedMessages
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.PinnedChatMessageInfo>?>("pinnedMessages"); }
            set { BackingStore?.Set("pinnedMessages", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.PinnedChatMessageInfo> PinnedMessages
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.PinnedChatMessageInfo>>("pinnedMessages"); }
            set { BackingStore?.Set("pinnedMessages", value); }
        }
#endif
        /// <summary>A collection of all the tabs in the chat. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.TeamsTab>? Tabs
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.TeamsTab>?>("tabs"); }
            set { BackingStore?.Set("tabs", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.TeamsTab> Tabs
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.TeamsTab>>("tabs"); }
            set { BackingStore?.Set("tabs", value); }
        }
#endif
        /// <summary>The identifier of the tenant in which the chat was created. Read-only.</summary>
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
        /// <summary>(Optional) Subject or topic for the chat. Only available for group chats.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Topic
        {
            get { return BackingStore?.Get<string?>("topic"); }
            set { BackingStore?.Set("topic", value); }
        }
#nullable restore
#else
        public string Topic
        {
            get { return BackingStore?.Get<string>("topic"); }
            set { BackingStore?.Set("topic", value); }
        }
#endif
        /// <summary>Represents caller-specific information about the chat, such as the last message read date and time. This property is populated only when the request is made in a delegated context.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.ChatViewpoint? Viewpoint
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ChatViewpoint?>("viewpoint"); }
            set { BackingStore?.Set("viewpoint", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.ChatViewpoint Viewpoint
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ChatViewpoint>("viewpoint"); }
            set { BackingStore?.Set("viewpoint", value); }
        }
#endif
        /// <summary>The URL for the chat in Microsoft Teams. The URL should be treated as an opaque blob, and not parsed. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebUrl
        {
            get { return BackingStore?.Get<string?>("webUrl"); }
            set { BackingStore?.Set("webUrl", value); }
        }
#nullable restore
#else
        public string WebUrl
        {
            get { return BackingStore?.Get<string>("webUrl"); }
            set { BackingStore?.Set("webUrl", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Chat"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.Chat CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.Chat();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "chatType", n => { ChatType = n.GetEnumValue<global::Microsoft.Graph.Models.ChatType>(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "installedApps", n => { InstalledApps = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.TeamsAppInstallation>(global::Microsoft.Graph.Models.TeamsAppInstallation.CreateFromDiscriminatorValue)?.AsList(); } },
                { "lastMessagePreview", n => { LastMessagePreview = n.GetObjectValue<global::Microsoft.Graph.Models.ChatMessageInfo>(global::Microsoft.Graph.Models.ChatMessageInfo.CreateFromDiscriminatorValue); } },
                { "lastUpdatedDateTime", n => { LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "members", n => { Members = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.ConversationMember>(global::Microsoft.Graph.Models.ConversationMember.CreateFromDiscriminatorValue)?.AsList(); } },
                { "messages", n => { Messages = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.ChatMessage>(global::Microsoft.Graph.Models.ChatMessage.CreateFromDiscriminatorValue)?.AsList(); } },
                { "onlineMeetingInfo", n => { OnlineMeetingInfo = n.GetObjectValue<global::Microsoft.Graph.Models.TeamworkOnlineMeetingInfo>(global::Microsoft.Graph.Models.TeamworkOnlineMeetingInfo.CreateFromDiscriminatorValue); } },
                { "permissionGrants", n => { PermissionGrants = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.ResourceSpecificPermissionGrant>(global::Microsoft.Graph.Models.ResourceSpecificPermissionGrant.CreateFromDiscriminatorValue)?.AsList(); } },
                { "pinnedMessages", n => { PinnedMessages = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.PinnedChatMessageInfo>(global::Microsoft.Graph.Models.PinnedChatMessageInfo.CreateFromDiscriminatorValue)?.AsList(); } },
                { "tabs", n => { Tabs = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.TeamsTab>(global::Microsoft.Graph.Models.TeamsTab.CreateFromDiscriminatorValue)?.AsList(); } },
                { "tenantId", n => { TenantId = n.GetStringValue(); } },
                { "topic", n => { Topic = n.GetStringValue(); } },
                { "viewpoint", n => { Viewpoint = n.GetObjectValue<global::Microsoft.Graph.Models.ChatViewpoint>(global::Microsoft.Graph.Models.ChatViewpoint.CreateFromDiscriminatorValue); } },
                { "webUrl", n => { WebUrl = n.GetStringValue(); } },
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
            writer.WriteEnumValue<global::Microsoft.Graph.Models.ChatType>("chatType", ChatType);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.TeamsAppInstallation>("installedApps", InstalledApps);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.ChatMessageInfo>("lastMessagePreview", LastMessagePreview);
            writer.WriteDateTimeOffsetValue("lastUpdatedDateTime", LastUpdatedDateTime);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.ConversationMember>("members", Members);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.ChatMessage>("messages", Messages);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.TeamworkOnlineMeetingInfo>("onlineMeetingInfo", OnlineMeetingInfo);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.ResourceSpecificPermissionGrant>("permissionGrants", PermissionGrants);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.PinnedChatMessageInfo>("pinnedMessages", PinnedMessages);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.TeamsTab>("tabs", Tabs);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteStringValue("topic", Topic);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.ChatViewpoint>("viewpoint", Viewpoint);
            writer.WriteStringValue("webUrl", WebUrl);
        }
    }
}
#pragma warning restore CS0618
