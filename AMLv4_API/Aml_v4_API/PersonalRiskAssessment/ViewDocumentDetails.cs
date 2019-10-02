using Newtonsoft.Json;
using System;

namespace AMLv4_API.Aml_v4_API
{
    /// <summary>
    /// View Document Details and optionally retrieve uploaded file if any
    /// </summary>
    public class ViewDocumentDetailsRequest
    {
        [JsonProperty("docid")]
        public string Docid { get; set; }

        [JsonProperty("includebinary", NullValueHandling = NullValueHandling.Ignore)]
        public Includebinary? Includebinary { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class ViewDocumentDetailsResponse : Amlv4BaseResponse
    {
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

        [JsonProperty("binarydata")]
        public string Binarydata { get; set; }
    }
}
