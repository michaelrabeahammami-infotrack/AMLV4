namespace AMLv4_API.Aml_v4_API.PersonalRiskAssessment
{
    /// <summary>
    /// List Client Documents
    /// </summary>
    public partial class ListDocumentsOnCddRecordOrAssessmentRequest
    {
        /// <summary>
        /// Use to see documents used on a specific assessment
        /// </summary>
        public string AssessmentID { get; set; }
        public string ClientID { get; set; }
        public string uri { get; set; }
    }

    public partial class ListDocumentsOnCddRecordOrAssessmentResponse
    {
        public string error { get; set; }

        public string uri { get; set; }

        public long numids { get; set; }

        public Ad[] ids { get; set; }

        public long numads { get; set; }

        public Ad[] ads { get; set; }

        public long numothers { get; set; }

        public object[] others { get; set; }
    }

    public partial class Ad
    {
        public long Docid { get; set; }

        public long ClientId { get; set; }

        public string Docusage { get; set; }

        public string Doctype { get; set; }

        public string Docdescription { get; set; }

        public string Docref { get; set; }

        public string Docstored { get; set; }

        public string Expirydate { get; set; }

        public string Expired { get; set; }

        public string Verifydate { get; set; }

        public string Verified { get; set; }

        public long AmlUserId { get; set; }

        public string UserName { get; set; }

        public string Archived { get; set; }

        public string Sentelectronic { get; set; }

        public string Filename { get; set; }

        public long? AssessmentId { get; set; }
    }
}