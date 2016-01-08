// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.AcceptanceTestsHeader.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// Defines headers for responseLong operation.
    /// </summary>
    public partial class HeaderResponseLongHeaders
    {
        /// <summary>
        /// Initializes a new instance of the HeaderResponseLongHeaders class.
        /// </summary>
        public HeaderResponseLongHeaders() { }

        /// <summary>
        /// Initializes a new instance of the HeaderResponseLongHeaders class.
        /// </summary>
        public HeaderResponseLongHeaders(long? value = default(long?))
        {
            Value = value;
        }

        /// <summary>
        /// response with header value "value": 105 or -2
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public long? Value { get; set; }

    }
}
