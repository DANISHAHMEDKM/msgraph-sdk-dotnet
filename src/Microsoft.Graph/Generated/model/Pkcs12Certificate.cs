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
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Pkcs12Certificate.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Pkcs12Certificate : ApiAuthenticationConfigurationBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Pkcs12Certificate"/> class.
        /// </summary>
        public Pkcs12Certificate()
        {
            this.ODataType = "microsoft.graph.pkcs12Certificate";
        }

        /// <summary>
        /// Gets or sets password.
        /// The password for the pfx file. Required. If no password is used, you must still provide a value of ''.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "password", Required = Newtonsoft.Json.Required.Default)]
        public string Password { get; set; }
    
        /// <summary>
        /// Gets or sets pkcs12Value.
        /// Represents the pfx content that is sent. The value should be a base-64 encoded version of the actual certificate content. Required.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pkcs12Value", Required = Newtonsoft.Json.Required.Default)]
        public string Pkcs12Value { get; set; }
    
    }
}