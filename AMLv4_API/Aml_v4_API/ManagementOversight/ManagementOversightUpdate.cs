using Newtonsoft.Json;

namespace AMLv4_API.Aml_v4_API
{
    /// <summary>
    /// Add Management Oversight Investigation Data
    /// </summary>
    public class ManagementOversightUpdateRequest
    {
        [JsonProperty("AssessmentID")]
        public string AssessmentId { get; set; }

        /// <summary>
        /// Users description of management oversight investigation(s)
        /// </summary>
        [JsonProperty("Description")]
        public string Description { get; set; }

        /// <summary>
        /// part of piped list UKS|SDN|EUS|PEP|INT|NOID if any
        /// </summary>
        [JsonProperty("Satisfied", NullValueHandling = NullValueHandling.Ignore)]
        public string Satisfied { get; set; }

        /// <summary>
        /// part of piped list UKS|SDN|EUS|PEP|INT|NOID if any
        /// </summary>
        [JsonProperty("Unsatisfied", NullValueHandling = NullValueHandling.Ignore)]
        public string Unsatisfied { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class ManagementOversightUpdateResponse : Amlv4BaseResponse
    {
        [JsonProperty("schemafile")]
        public string Schemafile { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
    //RESPONSE IS MISSING!!
}
