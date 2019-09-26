namespace AMLv4_API.Aml_v4_API.RiskAssessmentProfiles
{
    /// <summary>
    /// View detail of specific Risk Profile, and list of rules with summary description
    /// </summary>
    public class ViewRiskProfileRequest
    {
        public string profileid { get; set; }
        public string uri { get; set; }
    }
    public class ViewRiskProfileResponse
    {
        public string error { get; set; }
        public string uri { get; set; }
        public string profilecreated { get; set; }
        public long profileid { get; set; }
        public string profilename { get; set; }
        public string profileorigin { get; set; }
        public string profilestatus { get; set; }
        public string profiletype { get; set; }
        public long rulecount { get; set; }
        public Rule[] rules { get; set; }
    }
}
