namespace AMLv4_API.Aml_v4_API.RiskAssessmentProfiles
{
    /// <summary>
    /// Add a new Risk Profile (the rules must be added separately)
    /// </summary>
    public class CopyRiskProfileRequest
    {
        public string profilename { get; set; }
        public Profiletype profiletype { get; set; }
        public string uri { get; set; }
    }
    public class CopyRiskProfileResponse
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

    public class Rule
    {
        public long ruleid { get; set; }
        public string rulestatus { get; set; }
        public string summary { get; set; }
    }
}
