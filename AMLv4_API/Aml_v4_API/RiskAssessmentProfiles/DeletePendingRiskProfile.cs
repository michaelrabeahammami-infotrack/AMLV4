using Newtonsoft.Json;
using System;

namespace AMLv4_API.Aml_v4_API
{
    /// <summary>
    /// Delete pending Risk Profile and list of rules
    /// </summary>
    public class DeletePendingRiskProfileRequest
    {
        [JsonProperty("profileid")]
        public string Profileid { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }
    public class DeletePendingRiskProfileResponse : Amlv4BaseResponse
    {
        [JsonProperty("profilecreated")]
        public DateTime Profilecreated { get; set; }

        [JsonProperty("profileid")]
        public long Profileid { get; set; }

        [JsonProperty("profilename")]
        public string Profilename { get; set; }

        [JsonProperty("profileorigin")]
        public string Profileorigin { get; set; }

        [JsonProperty("profilestatus")]
        public string Profilestatus { get; set; }

        [JsonProperty("profiletype")]
        public string Profiletype { get; set; }
    }
}
