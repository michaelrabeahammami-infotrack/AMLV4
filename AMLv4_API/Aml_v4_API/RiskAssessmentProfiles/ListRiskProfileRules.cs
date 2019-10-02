using Newtonsoft.Json;

namespace AMLv4_API.Aml_v4_API
{
    /// <summary>
    /// Profile Rule list (summaries) for one Risk Profile
    /// </summary>
    public class ListRiskProfileRulesRequest
    {
        [JsonProperty("profileid")]
        public string Profileid { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }
    public class ListRiskProfileRulesResponse : Amlv4BaseResponse
    {
        [JsonProperty("profileid")]
        public long Profileid { get; set; }

        [JsonProperty("profilename")]
        public string Profilename { get; set; }

        [JsonProperty("rulecount")]
        public long Rulecount { get; set; }

        [JsonProperty("rules")]
        public Rule[] Rules { get; set; }
    }
}
