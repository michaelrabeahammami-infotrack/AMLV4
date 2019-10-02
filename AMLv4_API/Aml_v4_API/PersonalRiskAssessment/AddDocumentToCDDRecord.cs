using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace AMLv4_API.Aml_v4_API
{
    /// <summary>
    /// Add document to client/assessment
    /// </summary>
    public class AddDocumentToCddRecordRequest : Amlv4BaseRequest
    {
        /// <summary>
        /// From #/client/add response, if not set document added only to CDD Record not assessment
        /// </summary>
        [JsonProperty("AssessmentID", NullValueHandling = NullValueHandling.Ignore)]
        public string AssessmentId { get; set; }

        /// <summary>
        /// Base64 encoded document, empty if includebinary == no
        /// </summary>
        [JsonProperty("binarydata", NullValueHandling = NullValueHandling.Ignore)]
        public string Binarydata { get; set; }

        [JsonProperty("ClientID")]
        public string ClientId { get; set; }

        /// <summary>
        /// Physical Document Reference Number
        /// </summary>
        [JsonProperty("docref")]
        public string Docref { get; set; }

        /// <summary>
        /// Personal: Code from #document/types, NonPersonal always 'other'
        /// </summary>
        [JsonProperty("doctype")]
        public string Doctype { get; set; }

        /// <summary>
        /// Document Expiry Date: YYYY-MM-DD
        /// </summary>
        [JsonProperty("expirydate")]
        public string Expirydate { get; set; }

        /// <summary>
        /// Name of File to be uploaded, empty if includebinary == no
        /// </summary>
        [JsonProperty("filename", NullValueHandling = NullValueHandling.Ignore)]
        public string Filename { get; set; }

        /// <summary>
        /// Optional upload a document copy
        /// </summary>
        [JsonProperty("includebinary")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Includebinary Includebinary { get; set; }
    }

    public class AddDocumentToCddRecordResponse : Amlv4BaseResponse
    {
        [JsonProperty("docid")]
        public long Docid { get; set; }

        [JsonProperty("ClientID")]
        public long ClientId { get; set; }

        [JsonProperty("AssessmentID")]
        public long AssessmentId { get; set; }

        [JsonProperty("docusage")]
        public string Docusage { get; set; }

        [JsonProperty("doctype")]
        public string Doctype { get; set; }

        [JsonProperty("docdescription")]
        public string Docdescription { get; set; }

        [JsonProperty("docref")]
        public string Docref { get; set; }

        [JsonProperty("docstored")]
        public string Docstored { get; set; }

        [JsonProperty("expirydate")]
        public DateTime Expirydate { get; set; }

        [JsonProperty("expired")]
        public string Expired { get; set; }

        [JsonProperty("verifydate")]
        public DateTime Verifydate { get; set; }

        [JsonProperty("verified")]
        public string Verified { get; set; }

        [JsonProperty("AmlUserID")]
        public long AmlUserId { get; set; }

        [JsonProperty("UserName")]
        public string UserName { get; set; }

        [JsonProperty("archived")]
        public string Archived { get; set; }

        [JsonProperty("sentelectronic")]
        public string Sentelectronic { get; set; }

        [JsonProperty("filename")]
        public string Filename { get; set; }
    }
}
