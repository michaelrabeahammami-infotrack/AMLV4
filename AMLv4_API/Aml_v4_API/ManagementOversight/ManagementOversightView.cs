using Newtonsoft.Json;

namespace AMLv4_API.Aml_v4_API
{
    /// <summary>
    /// View Management Oversight
    /// </summary>
    public class ManagementOversightViewRequest
    {
        [JsonProperty("AssessmentID")]
        public string AssessmentId { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class ManagementOversightViewResponse
    {
        [JsonProperty("schemafile")]
        public string Schemafile { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
