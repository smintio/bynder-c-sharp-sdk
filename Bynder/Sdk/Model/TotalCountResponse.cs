﻿// Copyright (c) Bynder. All rights reserved.
// Licensed under the MIT License. See LICENSE file in the project root for full license information.

using Newtonsoft.Json;

namespace Bynder.Sdk.Model
{
    public class TotalCountResponse
    {
        /// <summary>
        /// The count
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }
    }
}
