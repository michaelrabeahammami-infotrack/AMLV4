namespace AMLv4_API.Aml_v4_API.RiskAssessmentProfiles
{
    /// <summary>
    /// Add a new Risk Profile (the rules must be added separately)
    /// </summary>
    public partial class AddRiskProfileRequest
    {
        public string profilename { get; set; }
        public Profiletype profiletype { get; set; }
        public string uri { get; set; }
    }

    public class AddRiskProfileResponse
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
