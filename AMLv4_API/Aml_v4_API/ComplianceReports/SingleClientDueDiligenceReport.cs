using Newtonsoft.Json;

namespace AMLv4_API.Aml_v4_API
{
    /// <summary>
    /// Retrieve Client Full CDD report pdf
    /// </summary>
    public class SingleClientDueDiligenceReportRequest
    {
        [JsonProperty("ClientID")]
        public string ClientId { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class SingleClientDueDiligenceReportResponse
    {
        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("ClientID")]
        public long? ClientId { get; set; }

        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("binarydata")]
        public string Binarydata { get; set; }
    }
}
