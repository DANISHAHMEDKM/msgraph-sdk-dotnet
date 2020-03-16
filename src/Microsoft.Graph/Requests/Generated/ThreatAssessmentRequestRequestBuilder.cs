// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type ThreatAssessmentRequestRequestBuilder.
    /// </summary>
    public partial class ThreatAssessmentRequestRequestBuilder : EntityRequestBuilder, IThreatAssessmentRequestRequestBuilder
    {

        /// <summary>
        /// Constructs a new ThreatAssessmentRequestRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ThreatAssessmentRequestRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IThreatAssessmentRequestRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IThreatAssessmentRequestRequest Request(IEnumerable<Option> options)
        {
            return new ThreatAssessmentRequestRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Results.
        /// </summary>
        /// <returns>The <see cref="IThreatAssessmentRequestResultsCollectionRequestBuilder"/>.</returns>
        public IThreatAssessmentRequestResultsCollectionRequestBuilder Results
        {
            get
            {
                return new ThreatAssessmentRequestResultsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("results"), this.Client);
            }
        }
    
    }
}
