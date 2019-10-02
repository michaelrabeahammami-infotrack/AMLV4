using Newtonsoft.Json;
using System;

namespace AMLv4_API.Aml_v4_API
{
    /// <summary>
    /// Archive Assessment to remove from reports
    /// </summary>
    public class ArchiveAssessmentRequest : Amlv4BaseRequest
    {
        [JsonProperty("AssessmentID")]
        public string AssessmentId { get; set; }
    }

    public class ArchiveAssessmentResponse : Amlv4BaseResponse
    {
        [JsonProperty("AssessmentID")]
        public long AssessmentId { get; set; }

        [JsonProperty("ClientID")]
        public long ClientId { get; set; }

        [JsonProperty("AmlUserID")]
        public long AmlUserId { get; set; }

        [JsonProperty("AmlCustomerID")]
        public long AmlCustomerId { get; set; }

        [JsonProperty("clienttype")]
        public string Clienttype { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("assessmenttype")]
        public string Assessmenttype { get; set; }

        [JsonProperty("profileid")]
        public long Profileid { get; set; }

        [JsonProperty("profilename")]
        public string Profilename { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("Archived")]
        public string Archived { get; set; }

        [JsonProperty("ArchiveDate")]
        public DateTime ArchiveDate { get; set; }

        [JsonProperty("Locked")]
        public string Locked { get; set; }

        [JsonProperty("numdocuments")]
        public long Numdocuments { get; set; }

        [JsonProperty("numrelationships")]
        public long Numrelationships { get; set; }

        [JsonProperty("numalerts")]
        public long Numalerts { get; set; }
    }
}
