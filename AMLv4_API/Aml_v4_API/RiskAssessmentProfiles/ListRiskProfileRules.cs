namespace AMLv4_API.Aml_v4_API.RiskAssessmentProfiles
{
    /// <summary>
    /// Profile Rule list (summaries) for one Risk Profile
    /// </summary>
    public class ListRiskProfileRulesRequest
    {
        public string profileid { get; set; }
        public string uri { get; set; }
    }
    public class ListRiskProfileRulesResponse
    {
        public string error { get; set; }
        public string uri { get; set; }
        public long profileid { get; set; }
        public string profilename { get; set; }
        public long rulecount { get; set; }
        public Rule[] rules { get; set; }
    }
}
