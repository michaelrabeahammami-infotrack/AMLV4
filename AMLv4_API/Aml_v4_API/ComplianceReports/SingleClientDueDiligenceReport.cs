using Newtonsoft.Json;

namespace AMLv4_API.Aml_v4_API
{
    /// <summary>
    /// Retrieve Client Full CDD report pdf
    /// </summary>
    public class SingleClientDueDiligenceReportRequest : Amlv4BaseRequest
    {
        [JsonProperty("ClientID")]
        public string ClientId { get; set; }
    }

    public class SingleClientDueDiligenceReportResponse : Amlv4BaseResponse
    {
        [JsonProperty("ClientID")]
        public long? ClientId { get; set; }

        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("binarydata")]
        public string Binarydata { get; set; }
    }
}
