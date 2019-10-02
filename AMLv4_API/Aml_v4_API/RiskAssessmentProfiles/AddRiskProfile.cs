using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace AMLv4_API.Aml_v4_API
{
    /// <summary>
    /// Add a new Risk Profile (the rules must be added separately)
    /// </summary>
    public class AddRiskProfileRequest : Amlv4BaseRequest
    {
        [JsonProperty("profilename")]
        public string Profilename { get; set; }

        [JsonProperty("profiletype")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Profiletype Profiletype { get; set; }
    }

    public class AddRiskProfileResponse : Amlv4BaseResponse
    {
        [JsonProperty("profileid")]
        public long Profileid { get; set; }

        [JsonProperty("profilename")]
        public string Profilename { get; set; }

        [JsonProperty("profiletype")]
        public string Profiletype { get; set; }

        [JsonProperty("profilestatus")]
        public string Profilestatus { get; set; }

        [JsonProperty("profilecreated")]
        public DateTime Profilecreated { get; set; }

        [JsonProperty("profileorigin")]
        public string Profileorigin { get; set; }
    }
}
