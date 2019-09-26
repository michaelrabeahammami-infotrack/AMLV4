namespace AMLv4_API.Aml_v4_API.RiskAssessmentProfiles
{
    /// <summary>
    /// Enable a pending Risk Profile for use
    /// </summary>
    public class ArchiveRiskProfileRequest
    {
        public string profileid { get; set; }
        public string uri { get; set; }
    }
    public class ArchiveRiskProfileResponse
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
