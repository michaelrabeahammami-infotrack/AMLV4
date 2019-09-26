namespace AMLv4_API.Aml_v4_API.NonPersonalRiskAssessment
{
    /// <summary>
    /// Non-Personal AAdd Associate
    /// </summary>
    public class AddAssociateRequest
    {
        /// <summary>
        /// Pipe separated '|' values
        /// </summary>
        public string Address { get; set; }

        public string AssessmentID { get; set; }
        public string ClientID { get; set; }

        /// <summary>
        /// if Company
        /// </summary>
        public string CompanyName { get; set; }

        public string DateOfBirth { get; set; }

        /// <summary>
        /// if Individual
        /// </summary>
        public string Forename { get; set; }

        public string LinkDescription { get; set; }
        public LinkType LinkType { get; set; }

        /// <summary>
        /// if Individual
        /// </summary>
        public string MiddleNames { get; set; }

        /// <summary>
        /// if Individual
        /// </summary>
        public string Surname { get; set; }

        public string uri { get; set; }
    }

    public class AddAssociateResponse
    {
        public string error { get; set; }
        public string uri { get; set; }
        public long AssociateId { get; set; }
        public long ClientId { get; set; }
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
