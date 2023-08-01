using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class AccessPackage : Entity, IParsable {
        /// <summary>The access packages that are incompatible with this package. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AccessPackage>? AccessPackagesIncompatibleWith {
            get { return BackingStore?.Get<List<AccessPackage>?>("accessPackagesIncompatibleWith"); }
            set { BackingStore?.Set("accessPackagesIncompatibleWith", value); }
        }
#nullable restore
#else
        public List<AccessPackage> AccessPackagesIncompatibleWith {
            get { return BackingStore?.Get<List<AccessPackage>>("accessPackagesIncompatibleWith"); }
            set { BackingStore?.Set("accessPackagesIncompatibleWith", value); }
        }
#endif
        /// <summary>Read-only. Nullable. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AccessPackageAssignmentPolicy>? AssignmentPolicies {
            get { return BackingStore?.Get<List<AccessPackageAssignmentPolicy>?>("assignmentPolicies"); }
            set { BackingStore?.Set("assignmentPolicies", value); }
        }
#nullable restore
#else
        public List<AccessPackageAssignmentPolicy> AssignmentPolicies {
            get { return BackingStore?.Get<List<AccessPackageAssignmentPolicy>>("assignmentPolicies"); }
            set { BackingStore?.Set("assignmentPolicies", value); }
        }
#endif
        /// <summary>Required when creating the access package. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AccessPackageCatalog? Catalog {
            get { return BackingStore?.Get<AccessPackageCatalog?>("catalog"); }
            set { BackingStore?.Set("catalog", value); }
        }
#nullable restore
#else
        public AccessPackageCatalog Catalog {
            get { return BackingStore?.Get<AccessPackageCatalog>("catalog"); }
            set { BackingStore?.Set("catalog", value); }
        }
#endif
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The description of the access package.</summary>
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
        /// <summary>Required. The display name of the access package. Supports $filter (eq, contains).</summary>
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
        /// <summary>The access packages whose assigned users are ineligible to be assigned this access package.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AccessPackage>? IncompatibleAccessPackages {
            get { return BackingStore?.Get<List<AccessPackage>?>("incompatibleAccessPackages"); }
            set { BackingStore?.Set("incompatibleAccessPackages", value); }
        }
#nullable restore
#else
        public List<AccessPackage> IncompatibleAccessPackages {
            get { return BackingStore?.Get<List<AccessPackage>>("incompatibleAccessPackages"); }
            set { BackingStore?.Set("incompatibleAccessPackages", value); }
        }
#endif
        /// <summary>The groups whose members are ineligible to be assigned this access package.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Group>? IncompatibleGroups {
            get { return BackingStore?.Get<List<Group>?>("incompatibleGroups"); }
            set { BackingStore?.Set("incompatibleGroups", value); }
        }
#nullable restore
#else
        public List<Group> IncompatibleGroups {
            get { return BackingStore?.Get<List<Group>>("incompatibleGroups"); }
            set { BackingStore?.Set("incompatibleGroups", value); }
        }
#endif
        /// <summary>Whether the access package is hidden from the requestor.</summary>
        public bool? IsHidden {
            get { return BackingStore?.Get<bool?>("isHidden"); }
            set { BackingStore?.Set("isHidden", value); }
        }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? ModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("modifiedDateTime"); }
            set { BackingStore?.Set("modifiedDateTime", value); }
        }
        /// <summary>The resource roles and scopes in this access package.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AccessPackageResourceRoleScope>? ResourceRoleScopes {
            get { return BackingStore?.Get<List<AccessPackageResourceRoleScope>?>("resourceRoleScopes"); }
            set { BackingStore?.Set("resourceRoleScopes", value); }
        }
#nullable restore
#else
        public List<AccessPackageResourceRoleScope> ResourceRoleScopes {
            get { return BackingStore?.Get<List<AccessPackageResourceRoleScope>>("resourceRoleScopes"); }
            set { BackingStore?.Set("resourceRoleScopes", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AccessPackage CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accessPackagesIncompatibleWith", n => { AccessPackagesIncompatibleWith = n.GetCollectionOfObjectValues<AccessPackage>(AccessPackage.CreateFromDiscriminatorValue)?.ToList(); } },
                {"assignmentPolicies", n => { AssignmentPolicies = n.GetCollectionOfObjectValues<AccessPackageAssignmentPolicy>(AccessPackageAssignmentPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"catalog", n => { Catalog = n.GetObjectValue<AccessPackageCatalog>(AccessPackageCatalog.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"incompatibleAccessPackages", n => { IncompatibleAccessPackages = n.GetCollectionOfObjectValues<AccessPackage>(AccessPackage.CreateFromDiscriminatorValue)?.ToList(); } },
                {"incompatibleGroups", n => { IncompatibleGroups = n.GetCollectionOfObjectValues<Group>(Group.CreateFromDiscriminatorValue)?.ToList(); } },
                {"isHidden", n => { IsHidden = n.GetBoolValue(); } },
                {"modifiedDateTime", n => { ModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"resourceRoleScopes", n => { ResourceRoleScopes = n.GetCollectionOfObjectValues<AccessPackageResourceRoleScope>(AccessPackageResourceRoleScope.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AccessPackage>("accessPackagesIncompatibleWith", AccessPackagesIncompatibleWith);
            writer.WriteCollectionOfObjectValues<AccessPackageAssignmentPolicy>("assignmentPolicies", AssignmentPolicies);
            writer.WriteObjectValue<AccessPackageCatalog>("catalog", Catalog);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<AccessPackage>("incompatibleAccessPackages", IncompatibleAccessPackages);
            writer.WriteCollectionOfObjectValues<Group>("incompatibleGroups", IncompatibleGroups);
            writer.WriteBoolValue("isHidden", IsHidden);
            writer.WriteDateTimeOffsetValue("modifiedDateTime", ModifiedDateTime);
            writer.WriteCollectionOfObjectValues<AccessPackageResourceRoleScope>("resourceRoleScopes", ResourceRoleScopes);
        }
    }
}
