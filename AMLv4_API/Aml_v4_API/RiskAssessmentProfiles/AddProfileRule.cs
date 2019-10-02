using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AMLv4_API.Aml_v4_API
{
    /// <summary>
    /// Add a new Profile Rule to a pending Risk Profile
    /// </summary>
    public class AddProfileRulesRequest : Amlv4BaseRequest
    {
        [JsonProperty("allow_enhanced")]
        [JsonConverter(typeof(StringEnumConverter))]
        public AllowEnhanced AllowEnhanced { get; set; }

        [JsonProperty("allow_simplified")]
        [JsonConverter(typeof(StringEnumConverter))]
        public AllowEnhanced AllowSimplified { get; set; }

        [JsonProperty("doccert_enhanced_unverified", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public AllowEnhanced? DoccertEnhancedUnverified { get; set; }

        [JsonProperty("doccert_enhanced_verified", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public AllowEnhanced? DoccertEnhancedVerified { get; set; }

        [JsonProperty("doccert_simplified", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public AllowEnhanced? DoccertSimplified { get; set; }

        [JsonProperty("interview_match")]
        [JsonConverter(typeof(StringEnumConverter))]
        public MatchType InterviewMatch { get; set; }

        [JsonProperty("interview_value", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public InterviewValue? InterviewValue { get; set; }

        [JsonProperty("nationality_match")]
        [JsonConverter(typeof(StringEnumConverter))]
        public MatchType NationalityMatch { get; set; }

        [JsonProperty("nationality_value", NullValueHandling = NullValueHandling.Ignore)]
        public string NationalityValue { get; set; }

        [JsonProperty("numads_electronic_enhanced", NullValueHandling = NullValueHandling.Ignore)]
        public string NumadsElectronicEnhanced { get; set; }

        [JsonProperty("numads_enhanced_unverified", NullValueHandling = NullValueHandling.Ignore)]
        public string NumadsEnhancedUnverified { get; set; }

        [JsonProperty("numads_enhanced_verified", NullValueHandling = NullValueHandling.Ignore)]
        public string NumadsEnhancedVerified { get; set; }

        [JsonProperty("numads_simplified", NullValueHandling = NullValueHandling.Ignore)]
        public string NumadsSimplified { get; set; }

        [JsonProperty("numids_electronic_enhanced", NullValueHandling = NullValueHandling.Ignore)]
        public string NumidsElectronicEnhanced { get; set; }

        [JsonProperty("numids_enhanced_unverified", NullValueHandling = NullValueHandling.Ignore)]
        public string NumidsEnhancedUnverified { get; set; }

        [JsonProperty("numids_enhanced_verified", NullValueHandling = NullValueHandling.Ignore)]
        public string NumidsEnhancedVerified { get; set; }

        [JsonProperty("numids_simplified", NullValueHandling = NullValueHandling.Ignore)]
        public string NumidsSimplified { get; set; }

        [JsonProperty("numots_electronic_enhanced", NullValueHandling = NullValueHandling.Ignore)]
        public string NumotsElectronicEnhanced { get; set; }

        [JsonProperty("profileid")]
        public string Profileid { get; set; }

        [JsonProperty("relationship_match")]
        [JsonConverter(typeof(StringEnumConverter))]
        public MatchType RelationshipMatch { get; set; }

        [JsonProperty("relationship_value", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public RelationshipValue? RelationshipValue { get; set; }

        [JsonProperty("residency_match")]
        [JsonConverter(typeof(StringEnumConverter))]
        public MatchType ResidencyMatch { get; set; }

        [JsonProperty("residency_value", NullValueHandling = NullValueHandling.Ignore)]
        public string ResidencyValue { get; set; }
    }
    public class AddPofileRuleResponse : Amlv4BaseResponse
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
