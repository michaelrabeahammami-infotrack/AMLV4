using Newtonsoft.Json;

namespace AMLv4_API.Aml_v4_API
{
    /// <summary>
    /// Retrieve Customer (All Client) Full CDD report pdf
    /// </summary>
    public class CustomerAllClientsDueDiligenceReportRequest
    {
        [JsonProperty("AmlCustomerID")]
        public string AmlCustomerId { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class CustomerAllClientsDueDiligenceReportResponse
    {
        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("AmlCustomerID")]
        public long AmlCustomerId { get; set; }

        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("binarydata")]
        public string Binarydata { get; set; }
    }
}
