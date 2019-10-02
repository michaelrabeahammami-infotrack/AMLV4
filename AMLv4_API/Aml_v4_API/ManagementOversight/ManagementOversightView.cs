using Newtonsoft.Json;

namespace AMLv4_API.Aml_v4_API
{
    /// <summary>
    /// View Management Oversight
    /// </summary>
    public class ManagementOversightViewRequest : Amlv4BaseRequest
    {
        [JsonProperty("AssessmentID")]
        public string AssessmentId { get; set; }
    }

    public class ManagementOversightViewResponse : Amlv4BaseResponse
    {
        [JsonProperty("schemafile")]
        public string Schemafile { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
