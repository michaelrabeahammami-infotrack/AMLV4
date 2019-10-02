using Newtonsoft.Json;

namespace AMLv4_API.Aml_v4_API
{
    /// <summary>
    /// Use Document in Risk Assessment
    /// </summary>
    public class UseDocumentInAssessmentRequest
    {
        [JsonProperty("AssessmentID")]
        public string AssessmentId { get; set; }

        [JsonProperty("docid")]
        public string Docid { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class UseDocumentInAssessmentResponse : Amlv4BaseResponse
    {
        [JsonProperty("schemafile")]
        public string Schemafile { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
