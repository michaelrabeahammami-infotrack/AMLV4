namespace AMLv4_API.Aml_v4_API.AssessmentArchiving
{
    /// <summary>
    /// Unarchive Assessment to restore to reports
    /// </summary>
    public class UnarchiveAssessmentRequest
    {
        public string AssessmentID { get; set; }
        public string uri { get; set; }
    }

    public class UnarchiveAssessmentResponse
    {
        public string error { get; set; }
        public string uri { get; set; }
        public long AssessmentID { get; set; }
        public long ClientID { get; set; }
        public long AmlUserID { get; set; }
        public long AmlCustomerID { get; set; }
        public string clienttype { get; set; }
        public string Date { get; set; }
        public string reference { get; set; }
        public string assessmenttype { get; set; }
        public long profileid { get; set; }
        public string profilename { get; set; }
        public string status { get; set; }
        public string Archived { get; set; }
        public string Locked { get; set; }
        public long numdocuments { get; set; }
        public long numrelationships { get; set; }
        public long numalerts { get; set; }
    }

}
