// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type SearchRequest.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<SearchRequestObject>))]
    public partial class SearchRequestObject
    {

        /// <summary>
        /// Gets or sets aggregationFilters.
        /// Contains one or more filters to obtain search results aggregated and filtered to a specific value of a field. Optional.Build this filter based on a prior search that aggregates by the same field. From the response of the prior search, identify the searchBucket that filters results to the specific value of the field, use the string in its aggregationFilterToken property, and build an aggregation filter string in the format '{field}:/'{aggregationFilterToken}/''. If multiple values for the same field need to be provided, use the strings in its aggregationFilterToken property and build an aggregation filter string in the format '{field}:or(/'{aggregationFilterToken1}/',/'{aggregationFilterToken2}/')'. For example, searching and aggregating drive items by file type returns a searchBucket for the file type docx in the response. You can conveniently use the aggregationFilterToken returned for this searchBucket in a subsequent search query and filter matches down to drive items of the docx file type. Example 1 and example 2 show the actual requests and responses.
        /// </summary>
        [JsonPropertyName("aggregationFilters")]
        public IEnumerable<string> AggregationFilters { get; set; }
    
        /// <summary>
        /// Gets or sets aggregations.
        /// Specifies aggregations (also known as refiners) to be returned alongside search results. Optional.
        /// </summary>
        [JsonPropertyName("aggregations")]
        public IEnumerable<AggregationOption> Aggregations { get; set; }
    
        /// <summary>
        /// Gets or sets contentSources.
        /// Contains the connection to be targeted. Respects the following format : /external/connections/connectionid where connectionid is the ConnectionId defined in the Connectors Administration.  Note: contentSource is only applicable when entityType=externalItem. Optional.
        /// </summary>
        [JsonPropertyName("contentSources")]
        public IEnumerable<string> ContentSources { get; set; }
    
        /// <summary>
        /// Gets or sets enableTopResults.
        /// This triggers hybrid sort for messages: the first 3 messages are the most relevant. This property is only applicable to entityType=message. Optional.
        /// </summary>
        [JsonPropertyName("enableTopResults")]
        public bool? EnableTopResults { get; set; }
    
        /// <summary>
        /// Gets or sets entityTypes.
        /// One or more types of resources expected in the response. Possible values are: list, site, listItem, message, event, drive, driveItem, person, externalItem. See known limitations for those combinations of two or more entity types that are supported in the same search request. Required.
        /// </summary>
        [JsonPropertyName("entityTypes")]
        public IEnumerable<EntityType> EntityTypes { get; set; }
    
        /// <summary>
        /// Gets or sets fields.
        /// Contains the fields to be returned for each resource object specified in entityTypes, allowing customization of the fields returned by default otherwise, including additional fields such as custom managed properties from SharePoint and OneDrive, or custom fields in externalItem from content that Microsoft Graph connectors bring in. The fields property can be using the semantic labels applied to properties. For example, if a property is label as title, you can retrieve it using the following syntax : label_title.Optional.
        /// </summary>
        [JsonPropertyName("fields")]
        public IEnumerable<string> Fields { get; set; }
    
        /// <summary>
        /// Gets or sets from.
        /// Specifies the offset for the search results. Offset 0 returns the very first result. Optional.
        /// </summary>
        [JsonPropertyName("from")]
        public Int32? From { get; set; }
    
        /// <summary>
        /// Gets or sets query.
        /// Contains the query terms. Required.
        /// </summary>
        [JsonPropertyName("query")]
        public SearchQuery Query { get; set; }
    
        /// <summary>
        /// Gets or sets queryAlterationOptions.
        /// Query alteration options formatted in a JSON blob that contains two optional flags related to spelling correction. Optional.
        /// </summary>
        [JsonPropertyName("queryAlterationOptions")]
        public SearchAlterationOptions QueryAlterationOptions { get; set; }
    
        /// <summary>
        /// Gets or sets resultTemplateOptions.
        /// Provides the search result templates options for rendering connectors search results.
        /// </summary>
        [JsonPropertyName("resultTemplateOptions")]
        public ResultTemplateOption ResultTemplateOptions { get; set; }
    
        /// <summary>
        /// Gets or sets size.
        /// The size of the page to be retrieved. Optional.
        /// </summary>
        [JsonPropertyName("size")]
        public Int32? Size { get; set; }
    
        /// <summary>
        /// Gets or sets sortProperties.
        /// Contains the ordered collection of fields and direction to sort results. There can be at most 5 sort properties in the collection. Optional.
        /// </summary>
        [JsonPropertyName("sortProperties")]
        public IEnumerable<SortProperty> SortProperties { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
