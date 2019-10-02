using Newtonsoft.Json;
using System;

namespace AMLv4_API.Aml_v4_API
{
    /// <summary>
    /// View Assessment Details before or after running
    /// </summary>
    public class NonPersonalViewRiskAssessmentRequest : Amlv4BaseRequest
    {
        [JsonProperty("AssessmentID")]
        public string AssessmentId { get; set; }
    }

    public class NonPersonalViewRiskAssessmentResponse : Amlv4BaseResponse
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
        public long Reference { get; set; }

        [JsonProperty("assessmenttype")]
        public string Assessmenttype { get; set; }

        [JsonProperty("profileid")]
        public long Profileid { get; set; }

        [JsonProperty("profilename")]
        public string Profilename { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("DisplayPrice")]
        public string DisplayPrice { get; set; }

        [JsonProperty("Price")]
        public string Price { get; set; }

        [JsonProperty("Archived")]
        public string Archived { get; set; }

        [JsonProperty("Locked")]
        public string Locked { get; set; }

        [JsonProperty("client")]
        public Client Client { get; set; }

        [JsonProperty("numdocuments")]
        public long Numdocuments { get; set; }

        [JsonProperty("numrelationships")]
        public long Numrelationships { get; set; }

        [JsonProperty("numalerts")]
        public long Numalerts { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("customer")]
        public Customer Customer { get; set; }

        [JsonProperty("Result")]
        public Result Result { get; set; }
    }
}
