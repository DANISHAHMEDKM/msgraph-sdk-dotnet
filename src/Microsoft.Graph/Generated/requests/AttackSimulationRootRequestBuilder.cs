// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type AttackSimulationRootRequestBuilder.
    /// </summary>
    public partial class AttackSimulationRootRequestBuilder : EntityRequestBuilder, IAttackSimulationRootRequestBuilder
    {

        /// <summary>
        /// Constructs a new AttackSimulationRootRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public AttackSimulationRootRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IAttackSimulationRootRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IAttackSimulationRootRequest Request(IEnumerable<Option> options)
        {
            return new AttackSimulationRootRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for SimulationAutomations.
        /// </summary>
        /// <returns>The <see cref="IAttackSimulationRootSimulationAutomationsCollectionRequestBuilder"/>.</returns>
        public IAttackSimulationRootSimulationAutomationsCollectionRequestBuilder SimulationAutomations
        {
            get
            {
                return new AttackSimulationRootSimulationAutomationsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("simulationAutomations"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Simulations.
        /// </summary>
        /// <returns>The <see cref="IAttackSimulationRootSimulationsCollectionRequestBuilder"/>.</returns>
        public IAttackSimulationRootSimulationsCollectionRequestBuilder Simulations
        {
            get
            {
                return new AttackSimulationRootSimulationsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("simulations"), this.Client);
            }
        }
    
    }
}