using Newtonsoft.Json;

namespace AMLv4_API.Aml_v4_API
{
    public class Amlv4BaseRequest
    {
        [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
        public string Uri { get; set; }
    }
}
