namespace AMLv4_API.Aml_v4_API.NonPersonalRiskAssessment
{
    public class NonPersonalViewRiskAssessmentResponse
    {
        public string Error { get; set; }
        public string Uri { get; set; }
        public long AssessmentId { get; set; }
        public long ClientId { get; set; }
        public long AmlUserId { get; set; }
        public long AmlCustomerId { get; set; }
        public string Clienttype { get; set; }
        public string Date { get; set; }
        public long Reference { get; set; }
        public string Assessmenttype { get; set; }
        public long Profileid { get; set; }
        public string Profilename { get; set; }
        public string Status { get; set; }
        public string DisplayPrice { get; set; }
        public string Price { get; set; }
        public string Archived { get; set; }
        public string Locked { get; set; }
        public Client Client { get; set; }
        public long Numdocuments { get; set; }
        public long Numrelationships { get; set; }
        public long Numalerts { get; set; }
        public User User { get; set; }
        public Customer Customer { get; set; }
        public Result Result { get; set; }
    }

    public class Customer
    {
        public long AmlCustomerId { get; set; }
        public string CustomerName { get; set; }
    }

    public class Result
    {
        public long TransactionId { get; set; }
        public string ReportReference { get; set; }
        public string DateOfSearch { get; set; }
        public string ElectronicStatus { get; set; }
        public string OverallStatus { get; set; }
        public string SanctionMatches { get; set; }
        public string FailError { get; set; }
    }

    public class User
    {
        public long AmlUserId { get; set; }
        public string ContactForename { get; set; }
        public string ContactSurname { get; set; }
    }
}
