namespace AMLv4_API.Aml_v4_API.RiskAssessmentProfiles
{
    /// <summary>
    /// Validate pending Risk Profile and list of rules to ensure can be enabled
    /// </summary>
    public class ValidatePendingRiskProfileRequest
    {
        public string profileid { get; set; }
        public string uri { get; set; }
    }

    public class ValidatePendingRiskProfileResponse
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
