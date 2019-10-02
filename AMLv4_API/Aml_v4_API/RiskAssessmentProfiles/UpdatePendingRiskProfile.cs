using Newtonsoft.Json;
using System;

namespace AMLv4_API.Aml_v4_API
{
    /// <summary>
    /// Update Risk Profile (name only - whilst Pending)
    /// </summary>
    public class UpdatePendingRiskProfileRequest : Amlv4BaseRequest
    {
        [JsonProperty("profileid")]
        public string Profileid { get; set; }

        [JsonProperty("profilename")]
        public string Profilename { get; set; }
    }
    public class UpdatePendingRiskProfileResponse : Amlv4BaseResponse
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
