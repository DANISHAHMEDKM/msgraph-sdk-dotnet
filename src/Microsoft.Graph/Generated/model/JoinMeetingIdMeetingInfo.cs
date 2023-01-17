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
    /// The type JoinMeetingIdMeetingInfo.
    /// </summary>
    public partial class JoinMeetingIdMeetingInfo : MeetingInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JoinMeetingIdMeetingInfo"/> class.
        /// </summary>
        public JoinMeetingIdMeetingInfo()
        {
            this.ODataType = "microsoft.graph.joinMeetingIdMeetingInfo";
        }

        /// <summary>
        /// Gets or sets joinMeetingId.
        /// The ID used to join the meeting.
        /// </summary>
        [JsonPropertyName("joinMeetingId")]
        public string JoinMeetingId { get; set; }
    
        /// <summary>
        /// Gets or sets passcode.
        /// The passcode used to join the meeting. Optional.
        /// </summary>
        [JsonPropertyName("passcode")]
        public string Passcode { get; set; }
    
    }
}