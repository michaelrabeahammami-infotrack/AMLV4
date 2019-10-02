using Newtonsoft.Json;
using System;

namespace AMLv4_API.Aml_v4_API
{
    /// <summary>
    /// Copy an existing Risk profile and rules
    /// </summary>
    public class CopyRiskProfileRequest : Amlv4BaseRequest
    {
        [JsonProperty("profileid")]
        public string Profileid { get; set; }
    }
    public class CopyRiskProfileResponse : Amlv4BaseResponse
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

        [JsonProperty("rulecount")]
        public long Rulecount { get; set; }

        [JsonProperty("rules")]
        public Rule[] Rules { get; set; }
    }
}
