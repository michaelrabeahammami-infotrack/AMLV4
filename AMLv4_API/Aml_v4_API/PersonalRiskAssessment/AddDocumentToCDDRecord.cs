using Newtonsoft.Json;

namespace AMLv4_API.Aml_v4_API.PersonalRiskAssessment
{
    /// <summary>
    /// Add document to client/assessment
    /// </summary>
    public class AddDocumentToCddRecordRequest
    {
        /// <summary>
        /// From #/client/add response, if not set document added only to CDD Record not assessment
        /// </summary>
        public string AssessmentID { get; set; }

        /// <summary>
        /// Base64 encoded document, empty if includebinary == no
        /// </summary>
        public string binarydata { get; set; }

        public string ClientId { get; set; }

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
        /// Name of File to be uploaded, empty if includebinary == no
        /// </summary>
        public string filename { get; set; }

        /// <summary>
        /// Optional upload a document copy
        /// </summary>
        public string includebinary { get; set; }

        public string uri { get; set; }
    }

    
    public partial class AddDocumentToCddRecordResponse
    {
        public string error { get; set; }

        public string uri { get; set; }

        public long docid { get; set; }

        public long ClientId { get; set; }

        public long AssessmentID { get; set; }

        public string docusage { get; set; }

        public string doctype { get; set; }

        public string docdescription { get; set; }

        public string docref { get; set; }

        public string docstored { get; set; }

        public string expirydate { get; set; }

        public string expired { get; set; }

        public string verifydate { get; set; }

        public string verified { get; set; }

        public long AmlUserId { get; set; }

        public string UserName { get; set; }

        public string archived { get; set; }

        public string sentelectronic { get; set; }

        public string filename { get; set; }
    }
}
