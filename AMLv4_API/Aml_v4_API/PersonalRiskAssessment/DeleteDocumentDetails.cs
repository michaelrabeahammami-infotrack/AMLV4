namespace AMLv4_API.Aml_v4_API.PersonalRiskAssessment
{
    /// <summary>
    /// Permanently Delete Document Details (use before linking to an assessment, normally after
    /// upload in error)
    /// </summary>
    public class DeleteDocumentDetailsRequest
    {
        public string docid { get; set; }

        public string uri { get; set; }
    }

    public class DeleteDocumentDetailsResponse
    {
        public string error { get; set; }

        public string uri { get; set; }

        public long docid { get; set; }

        public long clientId { get; set; }

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
