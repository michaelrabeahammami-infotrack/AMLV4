namespace AMLv4_API.Aml_v4_API.NonPersonalRiskAssessment
{
    /// <summary>
    /// Non-Personal Associates List
    /// </summary>
    public class AssociatesListRequest
    {
        /// <summary>
        /// Use to see asociates used on a specific assessment
        /// </summary>
        public string AssessmentID { get; set; }

        public string ClientID { get; set; }

        public string uri { get; set; }
    }

    public class AssociatesListResponse
    {
        public string error { get; set; }

        public string uri { get; set; }

        public long ClientID { get; set; }

        public long numass { get; set; }

        public Ass[] Ass { get; set; }
    }

    public class Ass
    {
        public long AssociateID { get; set; }

        public long ClientID { get; set; }

        public string Forename { get; set; }

        public string MiddleNames { get; set; }

        public string Surname { get; set; }

        public string CompanyName { get; set; }

        public string Address { get; set; }

        public string DateOfBirth { get; set; }

        public string LinkType { get; set; }

        public string LinkDescription { get; set; }

        public string UserAdded { get; set; }
    }
}
