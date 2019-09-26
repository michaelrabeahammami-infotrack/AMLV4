using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AMLv4_API.Aml_v4_API
{
    /// <summary>
    /// Lookup available risk profiles and CDD
    /// </summary>
    public class SelectRiskProfileCddRequest
    {
        [JsonProperty("interview_value")]
        [JsonConverter(typeof(StringEnumConverter))]
        public InterviewValue InterviewValue { get; set; }

        [JsonProperty("nationality_value")]
        public string NationalityValue { get; set; }

        [JsonProperty("ProfileOverride", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public ProfileOverride? ProfileOverride { get; set; }

        [JsonProperty("profiletype")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Profiletype Profiletype { get; set; }

        [JsonProperty("relationship_value")]
        [JsonConverter(typeof(StringEnumConverter))]
        public RelationshipValue RelationshipValue { get; set; }

        [JsonProperty("residency_value")]
        public string ResidencyValue { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class SelectRiskProfileCddResponse
    {
        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("profilecount")]
        public long Profilecount { get; set; }

        [JsonProperty("profiles")]
        public Profile[] Profiles { get; set; }
    }
}
