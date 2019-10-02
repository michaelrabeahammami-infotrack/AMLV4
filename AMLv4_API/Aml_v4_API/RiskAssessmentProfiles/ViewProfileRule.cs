using Newtonsoft.Json;

namespace AMLv4_API.Aml_v4_API
{
    /// <summary>
    /// Profile Rule view (summaries) for one Risk Profile
    /// </summary>
    public class ViewProfileRuleRequest
    {
        [JsonProperty("ruleid")]
        public string Ruleid { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class ViewProfileRuleResponse : Amlv4BaseResponse
    {
        [JsonProperty("profileid")]
        public long Profileid { get; set; }

        [JsonProperty("profilename")]
        public string Profilename { get; set; }

        [JsonProperty("ruleid")]
        public long Ruleid { get; set; }

        [JsonProperty("rulestatus")]
        public string Rulestatus { get; set; }

        [JsonProperty("nationality_match")]
        public string NationalityMatch { get; set; }

        [JsonProperty("nationality_value")]
        public string NationalityValue { get; set; }

        [JsonProperty("residency_match")]
        public string ResidencyMatch { get; set; }

        [JsonProperty("residency_value")]
        public string ResidencyValue { get; set; }

        [JsonProperty("relationship_match")]
        public string RelationshipMatch { get; set; }

        [JsonProperty("relationship_value")]
        public string RelationshipValue { get; set; }

        [JsonProperty("interview_match")]
        public string InterviewMatch { get; set; }

        [JsonProperty("interview_value")]
        public string InterviewValue { get; set; }

        [JsonProperty("allow_simplified")]
        public string AllowSimplified { get; set; }

        [JsonProperty("numids_simplified")]
        public long NumidsSimplified { get; set; }

        [JsonProperty("numads_simplified")]
        public long NumadsSimplified { get; set; }

        [JsonProperty("doccert_simplified")]
        public string DoccertSimplified { get; set; }

        [JsonProperty("numads_enhanced_unverified")]
        public long NumadsEnhancedUnverified { get; set; }

        [JsonProperty("allow_enhanced")]
        public string AllowEnhanced { get; set; }

        [JsonProperty("numids_enhanced_verified")]
        public long NumidsEnhancedVerified { get; set; }

        [JsonProperty("numads_enhanced_verified")]
        public long NumadsEnhancedVerified { get; set; }

        [JsonProperty("numids_electronic_enhanced")]
        public long NumidsElectronicEnhanced { get; set; }

        [JsonProperty("numads_electronic_enhanced")]
        public long NumadsElectronicEnhanced { get; set; }

        [JsonProperty("numots_electronic_enhanced")]
        public long NumotsElectronicEnhanced { get; set; }

        [JsonProperty("doccert_enhanced_verified")]
        public string DoccertEnhancedVerified { get; set; }

        [JsonProperty("numids_enhanced_unverified")]
        public long NumidsEnhancedUnverified { get; set; }

        [JsonProperty("doccert_enhanced_unverified")]
        public string DoccertEnhancedUnverified { get; set; }
    }
}
