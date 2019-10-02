using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace AMLv4_API.Aml_v4_API
{
    /// <summary>
    /// List all Risk Profiles for customer
    /// </summary>
    public class ListRiskProfilesRequest
    {
        [JsonProperty("profilestatus", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Profilestatus? Profilestatus { get; set; }

        [JsonProperty("profiletype", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Profiletype? Profiletype { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class ListRiskProfilesResponse : Amlv4BaseResponse
    {
        [JsonProperty("profilecount")]
        public long Profilecount { get; set; }

        [JsonProperty("profiles")]
        public Profile[] Profiles { get; set; }
    }
}
