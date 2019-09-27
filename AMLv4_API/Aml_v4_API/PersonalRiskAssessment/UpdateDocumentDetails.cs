using Newtonsoft.Json;
using System;

namespace AMLv4_API.Aml_v4_API
{
    /// <summary>
    /// Update document - normally only change of expiry date due to incorrect entry
    /// </summary>
    public class UpdateDocumentDetailsRequest
    {
        /// <summary>
        /// Base64 encoded new document, empty if includebinary == no
        /// </summary>
        [JsonProperty("binarydata", NullValueHandling = NullValueHandling.Ignore)]
        public string Binarydata { get; set; }

        /// <summary>
        /// Unique Document ID from document/view
        /// </summary>
        [JsonProperty("docid")]
        public string Docid { get; set; }

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
        /// Name of new File to be uploaded, empty if includebinary == no
        /// </summary>
        [JsonProperty("filename", NullValueHandling = NullValueHandling.Ignore)]
        public string Filename { get; set; }

        /// <summary>
        /// Optional upload a new document copy (will replace old file)
        /// </summary>
        [JsonProperty("includebinary", NullValueHandling = NullValueHandling.Ignore)]
        public Includebinary? Includebinary { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class UpdateDocumentDetailsResponse
    {
        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("docid")]
        public long Docid { get; set; }

        [JsonProperty("ClientID")]
        public long ClientId { get; set; }

        [JsonProperty("docusage")]
        public string Docusage { get; set; }

        [JsonProperty("doctype")]
        public string Doctype { get; set; }

        [JsonProperty("docdescription")]
        public string Docdescription { get; set; }

        [JsonProperty("docref")]
        public long Docref { get; set; }

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
