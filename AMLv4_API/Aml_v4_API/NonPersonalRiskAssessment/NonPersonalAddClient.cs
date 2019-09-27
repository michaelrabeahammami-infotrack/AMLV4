namespace AMLv4_API.Aml_v4_API
{
    /// <summary>
    /// Add Non-Personal Client Data
    /// </summary>
    public class NonPersonalAddClientRequest
    {
        public AssessmentType AssessmentType { get; set; }

        public Clienttype Clienttype { get; set; }

        public string CompanyIntroducer { get; set; }

        public string CompanyName { get; set; }

        public string CompanyNoDisplay { get; set; }

        public string CompanyRegistrationNumber { get; set; }

        public string CompanyStatus { get; set; }

        public string CompanyType { get; set; }

        public Compliance? Compliance { get; set; }

        public string CountryCode { get; set; }

        public string InceptionDate { get; set; }

        public Interview Interview { get; set; }

        public string JurisdictionCode { get; set; }

        public string RegisteredAddress { get; set; }

        public IsNewRelationship Relationship { get; set; }

        public string RiskProfile { get; set; }

        public string SearchRef { get; set; }

        public string uri { get; set; }
    }

    public class NonPersonalAddClientResponse
    {
        public string error { get; set; }

        public string uri { get; set; }

        public long ClientID { get; set; }

        public long AssessmentId { get; set; }

        public string AssessmentType { get; set; }

        public string AssessmentData { get; set; }
    }
}
