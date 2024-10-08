// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class SearchRequest : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Contains one or more filters to obtain search results aggregated and filtered to a specific value of a field. Optional.Build this filter based on a prior search that aggregates by the same field. From the response of the prior search, identify the searchBucket that filters results to the specific value of the field, use the string in its aggregationFilterToken property, and build an aggregation filter string in the format &apos;{field}:/&apos;{aggregationFilterToken}/&apos;&apos;. If multiple values for the same field need to be provided, use the strings in its aggregationFilterToken property and build an aggregation filter string in the format &apos;{field}:or(/&apos;{aggregationFilterToken1}/&apos;,/&apos;{aggregationFilterToken2}/&apos;)&apos;. For example, searching and aggregating drive items by file type returns a searchBucket for the file type docx in the response. You can conveniently use the aggregationFilterToken returned for this searchBucket in a subsequent search query and filter matches down to drive items of the docx file type. Example 1 and example 2 show the actual requests and responses.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AggregationFilters
        {
            get { return BackingStore?.Get<List<string>?>("aggregationFilters"); }
            set { BackingStore?.Set("aggregationFilters", value); }
        }
#nullable restore
#else
        public List<string> AggregationFilters
        {
            get { return BackingStore?.Get<List<string>>("aggregationFilters"); }
            set { BackingStore?.Set("aggregationFilters", value); }
        }
#endif
        /// <summary>Specifies aggregations (also known as refiners) to be returned alongside search results. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.AggregationOption>? Aggregations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AggregationOption>?>("aggregations"); }
            set { BackingStore?.Set("aggregations", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.AggregationOption> Aggregations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AggregationOption>>("aggregations"); }
            set { BackingStore?.Set("aggregations", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Contains the ordered collection of fields and limit to collapse results. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.CollapseProperty>? CollapseProperties
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.CollapseProperty>?>("collapseProperties"); }
            set { BackingStore?.Set("collapseProperties", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.CollapseProperty> CollapseProperties
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.CollapseProperty>>("collapseProperties"); }
            set { BackingStore?.Set("collapseProperties", value); }
        }
#endif
        /// <summary>Contains the connection to be targeted.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ContentSources
        {
            get { return BackingStore?.Get<List<string>?>("contentSources"); }
            set { BackingStore?.Set("contentSources", value); }
        }
#nullable restore
#else
        public List<string> ContentSources
        {
            get { return BackingStore?.Get<List<string>>("contentSources"); }
            set { BackingStore?.Set("contentSources", value); }
        }
#endif
        /// <summary>This triggers hybrid sort for messages : the first 3 messages are the most relevant. This property is only applicable to entityType=message. Optional.</summary>
        public bool? EnableTopResults
        {
            get { return BackingStore?.Get<bool?>("enableTopResults"); }
            set { BackingStore?.Set("enableTopResults", value); }
        }
        /// <summary>One or more types of resources expected in the response. Possible values are: event, message, driveItem, externalItem, site, list, listItem, drive, chatMessage, person, acronym, bookmark.  Note that you must use the Prefer: include-unknown-enum-members request header to get the following value(s) in this evolvable enum: chatMessage, person, acronym, bookmark. See known limitations for those combinations of two or more entity types that are supported in the same search request. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.EntityType?>? EntityTypes
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.EntityType?>?>("entityTypes"); }
            set { BackingStore?.Set("entityTypes", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.EntityType?> EntityTypes
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.EntityType?>>("entityTypes"); }
            set { BackingStore?.Set("entityTypes", value); }
        }
#endif
        /// <summary>Contains the fields to be returned for each resource object specified in entityTypes, allowing customization of the fields returned by default; otherwise, including additional fields such as custom managed properties from SharePoint and OneDrive, or custom fields in externalItem from the content that Microsoft Graph connectors bring in. The fields property can use the semantic labels applied to properties. For example, if a property is labeled as title, you can retrieve it using the following syntax: label_title. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Fields
        {
            get { return BackingStore?.Get<List<string>?>("fields"); }
            set { BackingStore?.Set("fields", value); }
        }
#nullable restore
#else
        public List<string> Fields
        {
            get { return BackingStore?.Get<List<string>>("fields"); }
            set { BackingStore?.Set("fields", value); }
        }
#endif
        /// <summary>Specifies the offset for the search results. Offset 0 returns the very first result. Optional.</summary>
        public int? From
        {
            get { return BackingStore?.Get<int?>("from"); }
            set { BackingStore?.Set("from", value); }
        }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The query property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.SearchQuery? Query
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.SearchQuery?>("query"); }
            set { BackingStore?.Set("query", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.SearchQuery Query
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.SearchQuery>("query"); }
            set { BackingStore?.Set("query", value); }
        }
#endif
        /// <summary>Query alteration options formatted in a JSON blob that contains two optional flags related to spelling correction. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.SearchAlterationOptions? QueryAlterationOptions
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.SearchAlterationOptions?>("queryAlterationOptions"); }
            set { BackingStore?.Set("queryAlterationOptions", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.SearchAlterationOptions QueryAlterationOptions
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.SearchAlterationOptions>("queryAlterationOptions"); }
            set { BackingStore?.Set("queryAlterationOptions", value); }
        }
#endif
        /// <summary>The geographic location for the search. Required for searches that use application permissions. For details, see Get the region value.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Region
        {
            get { return BackingStore?.Get<string?>("region"); }
            set { BackingStore?.Set("region", value); }
        }
#nullable restore
#else
        public string Region
        {
            get { return BackingStore?.Get<string>("region"); }
            set { BackingStore?.Set("region", value); }
        }
#endif
        /// <summary>Provides the search result template options to render search results from connectors.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.ResultTemplateOption? ResultTemplateOptions
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ResultTemplateOption?>("resultTemplateOptions"); }
            set { BackingStore?.Set("resultTemplateOptions", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.ResultTemplateOption ResultTemplateOptions
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.ResultTemplateOption>("resultTemplateOptions"); }
            set { BackingStore?.Set("resultTemplateOptions", value); }
        }
#endif
        /// <summary>Indicates the kind of contents to be searched when a search is performed using application permissions. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.SharePointOneDriveOptions? SharePointOneDriveOptions
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.SharePointOneDriveOptions?>("sharePointOneDriveOptions"); }
            set { BackingStore?.Set("sharePointOneDriveOptions", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.SharePointOneDriveOptions SharePointOneDriveOptions
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.SharePointOneDriveOptions>("sharePointOneDriveOptions"); }
            set { BackingStore?.Set("sharePointOneDriveOptions", value); }
        }
#endif
        /// <summary>The size of the page to be retrieved. The maximum value is 500. Optional.</summary>
        public int? Size
        {
            get { return BackingStore?.Get<int?>("size"); }
            set { BackingStore?.Set("size", value); }
        }
        /// <summary>Contains the ordered collection of fields and direction to sort results. There can be at most 5 sort properties in the collection. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.SortProperty>? SortProperties
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.SortProperty>?>("sortProperties"); }
            set { BackingStore?.Set("sortProperties", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.SortProperty> SortProperties
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.SortProperty>>("sortProperties"); }
            set { BackingStore?.Set("sortProperties", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.SearchRequest"/> and sets the default values.
        /// </summary>
        public SearchRequest()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.SearchRequest"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Models.SearchRequest CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.SearchRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "aggregationFilters", n => { AggregationFilters = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "aggregations", n => { Aggregations = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.AggregationOption>(global::Microsoft.Graph.Models.AggregationOption.CreateFromDiscriminatorValue)?.AsList(); } },
                { "collapseProperties", n => { CollapseProperties = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.CollapseProperty>(global::Microsoft.Graph.Models.CollapseProperty.CreateFromDiscriminatorValue)?.AsList(); } },
                { "contentSources", n => { ContentSources = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "enableTopResults", n => { EnableTopResults = n.GetBoolValue(); } },
                { "entityTypes", n => { EntityTypes = n.GetCollectionOfEnumValues<global::Microsoft.Graph.Models.EntityType>()?.AsList(); } },
                { "fields", n => { Fields = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "from", n => { From = n.GetIntValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "query", n => { Query = n.GetObjectValue<global::Microsoft.Graph.Models.SearchQuery>(global::Microsoft.Graph.Models.SearchQuery.CreateFromDiscriminatorValue); } },
                { "queryAlterationOptions", n => { QueryAlterationOptions = n.GetObjectValue<global::Microsoft.Graph.Models.SearchAlterationOptions>(global::Microsoft.Graph.Models.SearchAlterationOptions.CreateFromDiscriminatorValue); } },
                { "region", n => { Region = n.GetStringValue(); } },
                { "resultTemplateOptions", n => { ResultTemplateOptions = n.GetObjectValue<global::Microsoft.Graph.Models.ResultTemplateOption>(global::Microsoft.Graph.Models.ResultTemplateOption.CreateFromDiscriminatorValue); } },
                { "sharePointOneDriveOptions", n => { SharePointOneDriveOptions = n.GetObjectValue<global::Microsoft.Graph.Models.SharePointOneDriveOptions>(global::Microsoft.Graph.Models.SharePointOneDriveOptions.CreateFromDiscriminatorValue); } },
                { "size", n => { Size = n.GetIntValue(); } },
                { "sortProperties", n => { SortProperties = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.SortProperty>(global::Microsoft.Graph.Models.SortProperty.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("aggregationFilters", AggregationFilters);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.AggregationOption>("aggregations", Aggregations);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.CollapseProperty>("collapseProperties", CollapseProperties);
            writer.WriteCollectionOfPrimitiveValues<string>("contentSources", ContentSources);
            writer.WriteBoolValue("enableTopResults", EnableTopResults);
            writer.WriteCollectionOfEnumValues<global::Microsoft.Graph.Models.EntityType>("entityTypes", EntityTypes);
            writer.WriteCollectionOfPrimitiveValues<string>("fields", Fields);
            writer.WriteIntValue("from", From);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.SearchQuery>("query", Query);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.SearchAlterationOptions>("queryAlterationOptions", QueryAlterationOptions);
            writer.WriteStringValue("region", Region);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.ResultTemplateOption>("resultTemplateOptions", ResultTemplateOptions);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.SharePointOneDriveOptions>("sharePointOneDriveOptions", SharePointOneDriveOptions);
            writer.WriteIntValue("size", Size);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.SortProperty>("sortProperties", SortProperties);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
