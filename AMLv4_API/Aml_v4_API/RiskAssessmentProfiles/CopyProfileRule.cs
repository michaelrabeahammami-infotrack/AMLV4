using Newtonsoft.Json;

namespace AMLv4_API.Aml_v4_API
{
    /// <summary>
    /// Profile Rule copy for rule of pending Risk Profile
    /// </summary>
    public class CopyProfileRuleRequest
    {
        [JsonProperty("ruleid")]
        public string Ruleid { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }
    public class CopyProfileRuleResponse
    {
        [JsonProperty("schemafile")]
        public string Schemafile { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
