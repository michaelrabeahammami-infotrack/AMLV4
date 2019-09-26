﻿using Newtonsoft.Json;

namespace AMLv4_API.Aml_v4_API
{
    /// <summary>
    /// Agree to adopt AML Default Profiles
    /// </summary>
    public class AdoptProfilesRequest
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public partial class AdoptProfilesResponse
    {
        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("profilecount")]
        public long Profilecount { get; set; }

        [JsonProperty("profiles")]
        public Profile[] Profiles { get; set; }
    }
}