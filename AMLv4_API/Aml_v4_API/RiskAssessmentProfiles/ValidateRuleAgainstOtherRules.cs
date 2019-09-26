namespace AMLv4_API.Aml_v4_API.RiskAssessmentProfiles
{
    /// <summary>
    /// Validate rule for consistenncey with other rules
    /// </summary>
    public class ValidateRuleAgainstOtherRulesRequest
    {
        public string ruleid { get; set; }
        public string uri { get; set; }
    }

    public class ValidateRuleAgainstOtherRulesResponse
    {
        public string error { get; set; }
        public string uri { get; set; }
        public long profileid { get; set; }
        public string profilename { get; set; }
        public long ruleid { get; set; }
        public string rulestatus { get; set; }
        public string nationality_match { get; set; }
        public string nationality_value { get; set; }
        public string residency_match { get; set; }
        public string residency_value { get; set; }
        public string relationship_match { get; set; }
        public string relationship_value { get; set; }
        public string interview_match { get; set; }
        public string interview_value { get; set; }
        public string allow_simplified { get; set; }
        public long numids_simplified { get; set; }
        public long numads_simplified { get; set; }
        public string doccert_simplified { get; set; }
        public long numads_enhanced_unverified { get; set; }
        public string allow_enhanced { get; set; }
        public long numids_enhanced_verified { get; set; }
        public long numads_enhanced_verified { get; set; }
        public long numids_electronic_enhanced { get; set; }
        public long numads_electronic_enhanced { get; set; }
        public long numots_electronic_enhanced { get; set; }
        public string doccert_enhanced_verified { get; set; }
        public long numids_enhanced_unverified { get; set; }
        public string doccert_enhanced_unverified { get; set; }
    }
}
