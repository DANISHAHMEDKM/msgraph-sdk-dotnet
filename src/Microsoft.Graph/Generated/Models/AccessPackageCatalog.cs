// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class AccessPackageCatalog : Entity, IParsable {
        /// <summary>The access packages in this catalog. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AccessPackage>? AccessPackages {
            get { return BackingStore?.Get<List<AccessPackage>?>("accessPackages"); }
            set { BackingStore?.Set("accessPackages", value); }
        }
#nullable restore
#else
        public List<AccessPackage> AccessPackages {
            get { return BackingStore?.Get<List<AccessPackage>>("accessPackages"); }
            set { BackingStore?.Set("accessPackages", value); }
        }
#endif
        /// <summary>Whether the catalog is created by a user or entitlement management. The possible values are: userManaged, serviceDefault, serviceManaged, unknownFutureValue.</summary>
        public AccessPackageCatalogType? CatalogType {
            get { return BackingStore?.Get<AccessPackageCatalogType?>("catalogType"); }
            set { BackingStore?.Set("catalogType", value); }
        }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The customWorkflowExtensions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CustomCalloutExtension>? CustomWorkflowExtensions {
            get { return BackingStore?.Get<List<CustomCalloutExtension>?>("customWorkflowExtensions"); }
            set { BackingStore?.Set("customWorkflowExtensions", value); }
        }
#nullable restore
#else
        public List<CustomCalloutExtension> CustomWorkflowExtensions {
            get { return BackingStore?.Get<List<CustomCalloutExtension>>("customWorkflowExtensions"); }
            set { BackingStore?.Set("customWorkflowExtensions", value); }
        }
#endif
        /// <summary>The description of the access package catalog.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>The display name of the access package catalog.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>Whether the access packages in this catalog can be requested by users outside of the tenant.</summary>
        public bool? IsExternallyVisible {
            get { return BackingStore?.Get<bool?>("isExternallyVisible"); }
            set { BackingStore?.Set("isExternallyVisible", value); }
        }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? ModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("modifiedDateTime"); }
            set { BackingStore?.Set("modifiedDateTime", value); }
        }
        /// <summary>The resourceRoles property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AccessPackageResourceRole>? ResourceRoles {
            get { return BackingStore?.Get<List<AccessPackageResourceRole>?>("resourceRoles"); }
            set { BackingStore?.Set("resourceRoles", value); }
        }
#nullable restore
#else
        public List<AccessPackageResourceRole> ResourceRoles {
            get { return BackingStore?.Get<List<AccessPackageResourceRole>>("resourceRoles"); }
            set { BackingStore?.Set("resourceRoles", value); }
        }
#endif
        /// <summary>Access package resources in this catalog.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AccessPackageResource>? Resources {
            get { return BackingStore?.Get<List<AccessPackageResource>?>("resources"); }
            set { BackingStore?.Set("resources", value); }
        }
#nullable restore
#else
        public List<AccessPackageResource> Resources {
            get { return BackingStore?.Get<List<AccessPackageResource>>("resources"); }
            set { BackingStore?.Set("resources", value); }
        }
#endif
        /// <summary>The resourceScopes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AccessPackageResourceScope>? ResourceScopes {
            get { return BackingStore?.Get<List<AccessPackageResourceScope>?>("resourceScopes"); }
            set { BackingStore?.Set("resourceScopes", value); }
        }
#nullable restore
#else
        public List<AccessPackageResourceScope> ResourceScopes {
            get { return BackingStore?.Get<List<AccessPackageResourceScope>>("resourceScopes"); }
            set { BackingStore?.Set("resourceScopes", value); }
        }
#endif
        /// <summary>Has the value published if the access packages are available for management. The possible values are: unpublished, published, unknownFutureValue.</summary>
        public AccessPackageCatalogState? State {
            get { return BackingStore?.Get<AccessPackageCatalogState?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AccessPackageCatalog CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackageCatalog();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accessPackages", n => { AccessPackages = n.GetCollectionOfObjectValues<AccessPackage>(AccessPackage.CreateFromDiscriminatorValue)?.ToList(); } },
                {"catalogType", n => { CatalogType = n.GetEnumValue<AccessPackageCatalogType>(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"customWorkflowExtensions", n => { CustomWorkflowExtensions = n.GetCollectionOfObjectValues<CustomCalloutExtension>(CustomCalloutExtension.CreateFromDiscriminatorValue)?.ToList(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"isExternallyVisible", n => { IsExternallyVisible = n.GetBoolValue(); } },
                {"modifiedDateTime", n => { ModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"resourceRoles", n => { ResourceRoles = n.GetCollectionOfObjectValues<AccessPackageResourceRole>(AccessPackageResourceRole.CreateFromDiscriminatorValue)?.ToList(); } },
                {"resourceScopes", n => { ResourceScopes = n.GetCollectionOfObjectValues<AccessPackageResourceScope>(AccessPackageResourceScope.CreateFromDiscriminatorValue)?.ToList(); } },
                {"resources", n => { Resources = n.GetCollectionOfObjectValues<AccessPackageResource>(AccessPackageResource.CreateFromDiscriminatorValue)?.ToList(); } },
                {"state", n => { State = n.GetEnumValue<AccessPackageCatalogState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AccessPackage>("accessPackages", AccessPackages);
            writer.WriteEnumValue<AccessPackageCatalogType>("catalogType", CatalogType);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteCollectionOfObjectValues<CustomCalloutExtension>("customWorkflowExtensions", CustomWorkflowExtensions);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("isExternallyVisible", IsExternallyVisible);
            writer.WriteDateTimeOffsetValue("modifiedDateTime", ModifiedDateTime);
            writer.WriteCollectionOfObjectValues<AccessPackageResourceRole>("resourceRoles", ResourceRoles);
            writer.WriteCollectionOfObjectValues<AccessPackageResource>("resources", Resources);
            writer.WriteCollectionOfObjectValues<AccessPackageResourceScope>("resourceScopes", ResourceScopes);
            writer.WriteEnumValue<AccessPackageCatalogState>("state", State);
        }
    }
}
