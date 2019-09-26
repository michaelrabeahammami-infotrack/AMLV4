namespace AMLv4_API.Aml_v4_API.PersonalRiskAssessment
{
    /// <summary>
    /// Run Risk Assessment
    /// </summary>
    public class RunRiskAssessmentRequest
    {
        public string AssessmentID { get; set; }

        public string uri { get; set; }
    }

    public class RunRiskAssessmentResponse
    {
        public string error { get; set; }

        public string uri { get; set; }

        public long AssessmentID { get; set; }

        public long ClientID { get; set; }

        public long AmlUserID { get; set; }

        public long AmlCustomerID { get; set; }

        public string clienttype { get; set; }

        public string date { get; set; }

        public string reference { get; set; }

        public string assessmenttype { get; set; }

        public long profileid { get; set; }

        public string profilename { get; set; }

        public string status { get; set; }

        public string DisplayPrice { get; set; }

        public string Price { get; set; }

        public string Archived { get; set; }

        public string Locked { get; set; }

        public Client client { get; set; }

        public long numdocuments { get; set; }

        public Document[] documents { get; set; }

        public long numrelationships { get; set; }

        public RelationshipType[] relationships { get; set; }

        public User user { get; set; }

        public Customer customer { get; set; }

        public Result result { get; set; }
    }

    public class User
    {
        public long AmlUserID { get; set; }

        public string ContactForename { get; set; }

        public string ContactSurname { get; set; }
    }
}
