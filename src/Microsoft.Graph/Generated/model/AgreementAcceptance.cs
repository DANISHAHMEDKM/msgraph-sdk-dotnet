// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Agreement Acceptance.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class AgreementAcceptance : Entity
    {
    
		///<summary>
		/// The AgreementAcceptance constructor
		///</summary>
        public AgreementAcceptance()
        {
            this.ODataType = "microsoft.graph.agreementAcceptance";
        }
	
        /// <summary>
        /// Gets or sets agreement file id.
        /// The identifier of the agreement file accepted by the user.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "agreementFileId", Required = Newtonsoft.Json.Required.Default)]
        public string AgreementFileId { get; set; }
    
        /// <summary>
        /// Gets or sets agreement id.
        /// The identifier of the agreement.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "agreementId", Required = Newtonsoft.Json.Required.Default)]
        public string AgreementId { get; set; }
    
        /// <summary>
        /// Gets or sets device display name.
        /// The display name of the device used for accepting the agreement.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceDisplayName", Required = Newtonsoft.Json.Required.Default)]
        public string DeviceDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets device id.
        /// The unique identifier of the device used for accepting the agreement.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceId", Required = Newtonsoft.Json.Required.Default)]
        public string DeviceId { get; set; }
    
        /// <summary>
        /// Gets or sets device ostype.
        /// The operating system used to accept the agreement.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceOSType", Required = Newtonsoft.Json.Required.Default)]
        public string DeviceOSType { get; set; }
    
        /// <summary>
        /// Gets or sets device osversion.
        /// The operating system version of the device used to accept the agreement.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceOSVersion", Required = Newtonsoft.Json.Required.Default)]
        public string DeviceOSVersion { get; set; }
    
        /// <summary>
        /// Gets or sets expiration date time.
        /// The expiration date time of the acceptance. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "expirationDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? ExpirationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets recorded date time.
        /// The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "recordedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? RecordedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets state.
        /// The state of the agreement acceptance. Possible values are: accepted, declined.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "state", Required = Newtonsoft.Json.Required.Default)]
        public AgreementAcceptanceState? State { get; set; }
    
        /// <summary>
        /// Gets or sets user display name.
        /// Display name of the user when the acceptance was recorded.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userDisplayName", Required = Newtonsoft.Json.Required.Default)]
        public string UserDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets user email.
        /// Email of the user when the acceptance was recorded.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userEmail", Required = Newtonsoft.Json.Required.Default)]
        public string UserEmail { get; set; }
    
        /// <summary>
        /// Gets or sets user id.
        /// The identifier of the user who accepted the agreement.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userId", Required = Newtonsoft.Json.Required.Default)]
        public string UserId { get; set; }
    
        /// <summary>
        /// Gets or sets user principal name.
        /// UPN of the user when the acceptance was recorded.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userPrincipalName", Required = Newtonsoft.Json.Required.Default)]
        public string UserPrincipalName { get; set; }
    
    }
}
