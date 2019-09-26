namespace AMLv4_API.Aml_v4_API.RiskAssessmentProfiles
{
    /// <summary>
    /// Archive an enabled Risk Profile and list of rules to allow use
    /// </summary>
    public class UnarchiveRiskProfileRequest
    {
        public string profileid { get; set; }
        public string uri { get; set; }
    }
    public class UnarchiveRiskProfileResponse
    {
        public string error { get; set; }
        public string uri { get; set; }
        public string profilecreated { get; set; }
        public long profileid { get; set; }
        public string profilename { get; set; }
        public string profileorigin { get; set; }
        public string profilestatus { get; set; }
        public string profiletype { get; set; }
    }
}
