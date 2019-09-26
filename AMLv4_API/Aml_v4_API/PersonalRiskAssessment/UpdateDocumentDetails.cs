namespace AMLv4_API.Aml_v4_API.PersonalRiskAssessment
{
    /// <summary>
    /// Update document - normally only change of expiry date due to incorrect entry
    /// </summary>
    public class UpdateDocumentDetailsRequest
    {
        /// <summary>
        /// Base64 encoded new document, empty if includebinary == no
        /// </summary>
        public string binarydata { get; set; }

        /// <summary>
        /// Unique Document ID from document/view
        /// </summary>
        public string docid { get; set; }

        /// <summary>
        /// Physical Document Reference Number
        /// </summary>
        public string docref { get; set; }

        /// <summary>
        /// Personal: Code from #document/types, NonPersonal always 'other'
        /// </summary>
        public string doctype { get; set; }

        /// <summary>
        /// Document Expiry Date: YYYY-MM-DD
        /// </summary>
        public string expirydate { get; set; }

        /// <summary>
        /// Name of new File to be uploaded, empty if includebinary == no
        /// </summary>
        public string filename { get; set; }

        /// <summary>
        /// Optional upload a new document copy (will replace old file)
        /// </summary>
        public Includebinary? includebinary { get; set; }

        public string uri { get; set; }
    }

    public class UpdateDocumentDetailsResponse
    {
        public string error { get; set; }

        public string uri { get; set; }

        public long docid { get; set; }

        public long ClientID { get; set; }

        public string docusage { get; set; }

        public string doctype { get; set; }

        public string docdescription { get; set; }

        public long docref { get; set; }

        public string docstored { get; set; }

        public string expirydate { get; set; }

        public string expired { get; set; }

        public string verifydate { get; set; }

        public string verified { get; set; }

        public long AmlUserID { get; set; }

        public string UserName { get; set; }

        public string archived { get; set; }

        public string sentelectronic { get; set; }

        public string filename { get; set; }
    }
}
