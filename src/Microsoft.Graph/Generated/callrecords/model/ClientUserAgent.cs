// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph.CallRecords
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type ClientUserAgent.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<ClientUserAgent>))]
    public partial class ClientUserAgent : UserAgent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientUserAgent"/> class.
        /// </summary>
        public ClientUserAgent()
        {
            this.ODataType = "microsoft.graph.callRecords.clientUserAgent";
        }

        /// <summary>
        /// Gets or sets azureADAppId.
        /// The unique identifier of the Azure AD application used by this endpoint.
        /// </summary>
        [JsonPropertyName("azureADAppId")]
        public string AzureADAppId { get; set; }
    
        /// <summary>
        /// Gets or sets communicationServiceId.
        /// Immutable resource identifier of the Azure Communication Service associated with this endpoint based on Communication Services APIs.
        /// </summary>
        [JsonPropertyName("communicationServiceId")]
        public string CommunicationServiceId { get; set; }
    
        /// <summary>
        /// Gets or sets platform.
        /// Identifies the platform used by this endpoint. Possible values are: unknown, windows, macOS, iOS, android, web, ipPhone, roomSystem, surfaceHub, holoLens, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("platform")]
        public ClientPlatform? Platform { get; set; }
    
        /// <summary>
        /// Gets or sets productFamily.
        /// Identifies the family of application software used by this endpoint. Possible values are: unknown, teams, skypeForBusiness, lync, unknownFutureValue, azureCommunicationServices. Note that you must use the Prefer: include-unknown-enum-members request header to get the following value(s) in this evolvable enum: azureCommunicationServices.
        /// </summary>
        [JsonPropertyName("productFamily")]
        public ProductFamily? ProductFamily { get; set; }
    
    }
}
