namespace AMLv4_API.Aml_v4_API.PersonalRiskAssessment
{
    /// <summary>
    /// Risk Assessment Result
    /// </summary>
    public class RiskAssessmentResultRequest
    {
        public string AssessmentID { get; set; }
        public string uri { get; set; }
    }

    public class RiskAssessmentResultResponse
    {
        public string error { get; set; }
        public string uri { get; set; }
        public long AssessmentID { get; set; }
        public long ClientID { get; set; }
        public string ClientType { get; set; }
        public string ClientReference { get; set; }
        public string ClientArchived { get; set; }
        public string ClientName { get; set; }
        public string ClientDob { get; set; }
        public string ClientPostCode { get; set; }
        public string ClientCountryCode { get; set; }
        public long ProfileId { get; set; }
        public string ProfileName { get; set; }
        public string UserName { get; set; }
        public string AssessmentType { get; set; }
        public string AssessmentDate { get; set; }
        public string AssessmentResult { get; set; }
        public string AssessmentArchived { get; set; }
        public string ReportBinary { get; set; }
    }
}
