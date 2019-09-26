namespace AMLv4_API.Aml_v4_API.PersonalRiskAssessment
{
    /// <summary>
    /// Select Picklist entry and Run Risk Assessment
    /// </summary>
    public class RiskAssessmentPickListSelectRequest
    {
        public string AssessmentID { get; set; }

        public string PickID { get; set; }

        public string uri { get; set; }
    }

    public class RiskAssessmentPickListSelectResponse
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

        public Client Client { get; set; }

        public long numdocuments { get; set; }

        public Document[] documents { get; set; }

        public long numrelationships { get; set; }

        public RelationshipType[] relationships { get; set; }

        public User user { get; set; }

        public Customer customer { get; set; }

        public Result Result { get; set; }
    }
}
