﻿// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    /// <summary>
    /// Represents an assignment on a <see cref="PlannerTask"/>.
    /// </summary>
    public partial class PlannerAssignment
    {
        /// <summary>
        /// OData type name for PlannerAssignment resource.
        /// </summary>
        internal const string ODataTypeName = "#microsoft.graph.plannerAssignment";

        /// <summary>
        /// Ensures that @odata.type property is included when this object is serialized. 
        /// This is required since this object is used as a value in dynamic properties of open types. 
        /// </summary>
        /// <param name="context">Serialization context. This parameter is ignored.</param>
        [OnSerializing]
        internal void AddODataType(StreamingContext context)
        {
            if (this.AdditionalData == null)
            {
                this.AdditionalData = new Dictionary<string, object>();
            }

            this.AdditionalData.Add(CoreConstants.Serialization.ODataType, ODataTypeName);
        }
    }
}
