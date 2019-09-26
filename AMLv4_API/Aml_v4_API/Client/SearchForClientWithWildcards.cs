namespace AMLv4_API.Aml_v4_API.Client
{
    /// <summary>
    /// Search for clients matching various pattterns
    /// </summary>
    public class SearchForClientWithWildcardsRequest
    {
        /// <summary>
        /// Only searches by specific user (by AMLSearch id)
        /// </summary>
        public string AmlUserID { get; set; }

        /// <summary>
        /// Surname or Forename Surname or Company Name. Add % for wildcards
        /// </summary>
        public string ClientName { get; set; }

        /// <summary>
        /// User reference or Matter no. add % for wildcard
        /// </summary>
        public string ClientReference { get; set; }

        /// <summary>
        /// Type of client to search for
        /// </summary>
        public ClientType? ClientType { get; set; }

        /// <summary>
        /// Filter by status
        /// </summary>
        public ComplianceStatus? ComplianceStatus { get; set; }

        /// <summary>
        /// Last date of client creation (YYYY-MM-DD)
        /// </summary>
        public string EndDate { get; set; }

        /// <summary>
        /// Include archived clients in results (default no)
        /// </summary>
        public IncludeArchived? IncludeArchived { get; set; }

        /// <summary>
        /// Filter by postcode of current address or company registered address
        /// </summary>
        public string Postcode { get; set; }

        /// <summary>
        /// Limit result set. Required if no other parameters set
        /// </summary>
        public string RecordLimit { get; set; }

        /// <summary>
        /// First date of client creation (YYYY-MM-DD)
        /// </summary>
        public string StartDate { get; set; }

        public string Uri { get; set; }

        /// <summary>
        /// Only searches by specific user (Forename Surname, % wildcards)
        /// </summary>
        public string UserName { get; set; }
    }

    /// <summary>
    /// Type of client to search for
    /// </summary>
    public enum ClientType { nonpersonal, personal };

    /// <summary>
    /// Filter by status
    /// </summary>
    public enum ComplianceStatus { compliant, noncompliant, pending };

    /// <summary>
    /// Include archived clients in results (default no)
    /// </summary>
    public enum IncludeArchived { no, yes };


    public class SearchForClientWithWildcardsResponse
    {
        public string error { get; set; }
        public string uri { get; set; }
        public long nummatches { get; set; }
        public Match[] matches { get; set; }
    }

    public class Match
    {
        public string ClientType { get; set; }
        public long ClientID { get; set; }
        public string LastAssessmentDate { get; set; }
        public string ComplianceStatus { get; set; }
        public long AmlUserID { get; set; }
        public long AmlCustomerID { get; set; }
        public long AmlIntegratorID { get; set; }
        public string ClientReference { get; set; }
        public string ClientName { get; set; }
        public string ClientRegNo { get; set; }
        public string ClientAddress { get; set; }
        public string Postcode { get; set; }
        public string DateOfBirth { get; set; }
        public string CountryCode { get; set; }
        public string UserName { get; set; }
        public string CustomerName { get; set; }
        public string IntegratorShortName { get; set; }
        public string Archived { get; set; }
    }

}
