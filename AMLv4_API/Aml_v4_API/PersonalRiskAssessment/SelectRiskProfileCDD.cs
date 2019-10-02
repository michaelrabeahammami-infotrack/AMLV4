using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AMLv4_API.Aml_v4_API
{
    #region request
    /// <summary>
    /// Lookup available risk profiles and CDD
    /// </summary>
    public class SelectRiskProfileCddRequest : Amlv4BaseRequest
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
    }
    #endregion

    #region response
    public class SelectRiskProfileCddResponse : Amlv4BaseResponse
    {
        [JsonProperty("profilecount")]
        public long Profilecount { get; set; }

        [JsonProperty("profiles")]
        public Profile[] Profiles { get; set; }
    } 
    #endregion
}
