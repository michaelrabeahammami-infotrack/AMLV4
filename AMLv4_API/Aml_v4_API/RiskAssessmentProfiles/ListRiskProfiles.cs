namespace AMLv4_API.Aml_v4_API.RiskAssessmentProfiles
{
    /// <summary>
    /// List all Risk Profiles for customer
    /// </summary>
    public class ListRiskProfilesRequest
    {
        public Profilestatus? profilestatus { get; set; }
        public Profiletype? profiletype { get; set; }
        public string uri { get; set; }
    }

    public class ListRiskProfilesResponse
    {
        public string error { get; set; }
        public string uri { get; set; }
        public long profilecount { get; set; }
        public Profile[] profiles { get; set; }
    }

    public class Profile
    {
        public long profileid { get; set; }
        public string profilename { get; set; }
        public string profilestatus { get; set; }
        public string profiletype { get; set; }
        public string profilecreated { get; set; }
        public string profileorigin { get; set; }
    }
}
