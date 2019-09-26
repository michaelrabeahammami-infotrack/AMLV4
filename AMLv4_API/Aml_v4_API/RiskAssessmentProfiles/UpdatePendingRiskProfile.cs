namespace AMLv4_API.Aml_v4_API.RiskAssessmentProfiles
{
    /// <summary>
    /// Update Risk Profile (name only - whilst Pending)
    /// </summary>
    public class UpdatePendingRiskProfileRequest
    {
        public string profileid { get; set; }
        public string profilename { get; set; }
        public string uri { get; set; }
    }
    public class UpdatePendingRiskProfileResponse
    {
        public string error { get; set; }
        public string uri { get; set; }
        public long profileid { get; set; }
        public string profilename { get; set; }
        public string profiletype { get; set; }
        public string profilestatus { get; set; }
        public string profilecreated { get; set; }
        public string profileorigin { get; set; }
    }
}
