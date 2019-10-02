using Newtonsoft.Json;
using System;

namespace AMLv4_API.Aml_v4_API
{
    /// <summary>
    /// List Client Documents
    /// </summary>
    public class ListDocumentsOnCddRecordOrAssessmentRequest
    {
        /// <summary>
        /// Use to see documents used on a specific assessment
        /// </summary>
        [JsonProperty("AssessmentID", NullValueHandling = NullValueHandling.Ignore)]
        public string AssessmentId { get; set; }

        [JsonProperty("ClientID")]
        public string ClientId { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class ListDocumentsOnCddRecordOrAssessmentResponse : Amlv4BaseResponse
    {
        [JsonProperty("numids")]
        public long Numids { get; set; }

        [JsonProperty("ids")]
        public Ad[] Ids { get; set; }

        [JsonProperty("numads")]
        public long Numads { get; set; }

        [JsonProperty("ads")]
        public Ad[] Ads { get; set; }

        [JsonProperty("numothers")]
        public long Numothers { get; set; }

        [JsonProperty("others")]
        public object[] Others { get; set; }
    }

    public class Ad
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

        [JsonProperty("AssessmentID", NullValueHandling = NullValueHandling.Ignore)]
        public long? AssessmentId { get; set; }
    }
}