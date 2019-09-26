namespace AMLv4_API.Aml_v4_API.AssessmentArchiving
{
    /// <summary>
    /// Archive Assessment to remove from reports
    /// </summary>
    public class ArchiveAssessmentRequest
    {
        public string AssessmentID { get; set; }
        public string uri { get; set; }
    }

    public class ArchiveAssessmentResponse
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
        public string Archived { get; set; }
        public string ArchiveDate { get; set; }
        public string Locked { get; set; }
        public long numdocuments { get; set; }
        public long numrelationships { get; set; }
        public long numalerts { get; set; }
    }

}
