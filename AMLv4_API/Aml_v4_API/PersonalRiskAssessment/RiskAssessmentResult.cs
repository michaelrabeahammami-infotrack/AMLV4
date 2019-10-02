using Newtonsoft.Json;
using System;

namespace AMLv4_API.Aml_v4_API
{
    /// <summary>
    /// Risk Assessment Result
    /// </summary>
    public class RiskAssessmentResultRequest
    {
        [JsonProperty("AssessmentID")]
        public string AssessmentId { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class RiskAssessmentResultResponse : Amlv4BaseResponse
    {
        [JsonProperty("AssessmentID")]
        public long AssessmentId { get; set; }

        [JsonProperty("ClientID")]
        public long ClientId { get; set; }

        [JsonProperty("ClientType")]
        public string ClientType { get; set; }

        [JsonProperty("ClientReference")]
        public string ClientReference { get; set; }

        [JsonProperty("ClientArchived")]
        public string ClientArchived { get; set; }

        [JsonProperty("ClientName")]
        public string ClientName { get; set; }

        [JsonProperty("ClientDOB")]
        public DateTime ClientDob { get; set; }

        [JsonProperty("ClientPostCode")]
        public string ClientPostCode { get; set; }

        [JsonProperty("ClientCountryCode")]
        public string ClientCountryCode { get; set; }

        [JsonProperty("ProfileID")]
        public long ProfileId { get; set; }

        [JsonProperty("ProfileName")]
        public string ProfileName { get; set; }

        [JsonProperty("UserName")]
        public string UserName { get; set; }

        [JsonProperty("AssessmentType")]
        public string AssessmentType { get; set; }

        [JsonProperty("AssessmentDate")]
        public DateTime AssessmentDate { get; set; }

        [JsonProperty("AssessmentResult")]
        public string AssessmentResult { get; set; }

        [JsonProperty("AssessmentArchived")]
        public string AssessmentArchived { get; set; }

        [JsonProperty("ReportBinary")]
        public string ReportBinary { get; set; }
    }
}
