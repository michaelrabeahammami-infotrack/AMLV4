using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AMLv4_API.Aml_v4_API
{
    /// <summary>
    /// Add Non-Personal Client Data
    /// </summary>
    public class NonPersonalAddClientRequest : Amlv4BaseRequest
    {
        [JsonProperty("AssessmentType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public AssessmentType AssessmentType { get; set; }

        [JsonProperty("clienttype")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Clienttype Clienttype { get; set; }

        [JsonProperty("CompanyIntroducer")]
        public string CompanyIntroducer { get; set; }

        [JsonProperty("CompanyName")]
        public string CompanyName { get; set; }

        [JsonProperty("CompanyNoDisplay")]
        public string CompanyNoDisplay { get; set; }

        [JsonProperty("CompanyRegistrationNumber")]
        public string CompanyRegistrationNumber { get; set; }

        [JsonProperty("CompanyStatus")]
        public string CompanyStatus { get; set; }

        [JsonProperty("CompanyType")]
        public string CompanyType { get; set; }

        [JsonProperty("Compliance", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Compliance? Compliance { get; set; }

        [JsonProperty("CountryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("InceptionDate")]
        public string InceptionDate { get; set; }

        [JsonProperty("Interview")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Interview Interview { get; set; }

        [JsonProperty("JurisdictionCode")]
        public string JurisdictionCode { get; set; }

        [JsonProperty("RegisteredAddress")]
        public string RegisteredAddress { get; set; }

        [JsonProperty("Relationship")]
        [JsonConverter(typeof(StringEnumConverter))]
        public RelationshipValue Relationship { get; set; }

        [JsonProperty("RiskProfile")]
        public string RiskProfile { get; set; }

        [JsonProperty("SearchRef")]
        public string SearchRef { get; set; }
    }

    public class NonPersonalAddClientResponse : Amlv4BaseResponse
    {
        [JsonProperty("ClientID")]
        public long ClientId { get; set; }

        [JsonProperty("AssessmentID")]
        public long AssessmentId { get; set; }

        [JsonProperty("AssessmentType")]
        public string AssessmentType { get; set; }

        [JsonProperty("AssessmentData")]
        public string AssessmentData { get; set; }
    }
}
