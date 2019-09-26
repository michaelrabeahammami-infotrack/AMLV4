namespace AMLv4_API.Aml_v4_API.RiskAssessmentProfiles
{
    /// <summary>
    /// Add a new Profile Rule to a pending Risk Profile
    /// </summary>
    public class AddProfileRulesRequest
    {
        public AllowEnhanced allow_enhanced { get; set; }
        public AllowEnhanced allow_simplified { get; set; }
        public AllowEnhanced? doccert_enhanced_unverified { get; set; }
        public AllowEnhanced? doccert_enhanced_verified { get; set; }
        public AllowEnhanced? doccert_simplified { get; set; }
        public Match interview_match { get; set; }
        public InterviewValue? interview_value { get; set; }
        public Match nationality_match { get; set; }
        public string nationality_value { get; set; }
        public string numads_electronic_enhanced { get; set; }
        public string numads_enhanced_unverified { get; set; }
        public string numads_enhanced_verified { get; set; }
        public string numads_simplified { get; set; }
        public string numids_electronic_enhanced { get; set; }
        public string numids_enhanced_unverified { get; set; }
        public string numids_enhanced_verified { get; set; }
        public string numids_simplified { get; set; }
        public string numots_electronic_enhanced { get; set; }
        public string profileid { get; set; }
        public Match relationship_match { get; set; }
        //public RelationshipValue? relationship_value { get; set; }
        public Match residency_match { get; set; }
        public string residency_value { get; set; }
        public string uri { get; set; }
    }

    public class AddPofileRuleResponse
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
        public long numids_enhancedun_verified { get; set; }
        public string doccert_enhanced_unverified { get; set; }
    }
}
