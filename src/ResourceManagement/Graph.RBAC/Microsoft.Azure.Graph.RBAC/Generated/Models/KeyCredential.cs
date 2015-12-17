// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Graph.RBAC.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Active Directory service principal Key Credential information
    /// </summary>
    public partial class KeyCredential
    {
        /// <summary>
        /// Initializes a new instance of the KeyCredential class.
        /// </summary>
        public KeyCredential() { }

        /// <summary>
        /// Initializes a new instance of the KeyCredential class.
        /// </summary>
        public KeyCredential(DateTime? startDate = default(DateTime?), DateTime? endDate = default(DateTime?), string value = default(string), string keyId = default(string), string usage = default(string), string type = default(string))
        {
            StartDate = startDate;
            EndDate = endDate;
            Value = value;
            KeyId = keyId;
            Usage = usage;
            Type = type;
        }

        /// <summary>
        /// Gets or sets start date
        /// </summary>
        [JsonProperty(PropertyName = "startDate")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or sets end date
        /// </summary>
        [JsonProperty(PropertyName = "endDate")]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or sets value
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets key Id
        /// </summary>
        [JsonProperty(PropertyName = "keyId")]
        public string KeyId { get; set; }

        /// <summary>
        /// Gets or sets usage
        /// </summary>
        [JsonProperty(PropertyName = "usage")]
        public string Usage { get; set; }

        /// <summary>
        /// Gets or sets type
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}
