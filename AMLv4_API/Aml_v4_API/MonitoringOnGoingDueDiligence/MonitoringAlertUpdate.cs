using Newtonsoft.Json;
using System;

namespace AMLv4_API.Aml_v4_API
{
    /// <summary>
    /// Monitoring Alert Update
    /// </summary>
    public class MonitoringAlertUpdateRequest
    {
        /// <summary>
        /// Unique ID of the Alert record
        /// </summary>
        [JsonProperty("AlertID")]
        public string AlertId { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("Cancelled")]
        public object Cancelled { get; set; }

        [JsonProperty("CancelReason")]
        public object CancelReason { get; set; }
    }

    public class MonitoringAlertUpdateResponse : Amlv4BaseResponse
    {
        [JsonProperty("CustomerID")]
        public string CustomerId { get; set; }

        [JsonProperty("ClientSummary")]
        public string ClientSummary { get; set; }

        [JsonProperty("ClientReference")]
        public string ClientReference { get; set; }

        [JsonProperty("AlertDate")]
        public DateTime AlertDate { get; set; }

        [JsonProperty("AlertType")]
        public string AlertType { get; set; }

        [JsonProperty("AlertSanctionMatch")]
        public string AlertSanctionMatch { get; set; }

        [JsonProperty("AlertID")]
        public long AlertId { get; set; }

        [JsonProperty("Cancelled")]
        public string Cancelled { get; set; }

        [JsonProperty("CancelUserName")]
        public string CancelUserName { get; set; }

        [JsonProperty("CancelReason")]
        public string CancelReason { get; set; }

        [JsonProperty("CancelDate")]
        public string CancelDate { get; set; }

        [JsonProperty("AssessmentID")]
        public long AssessmentId { get; set; }

        [JsonProperty("ClientID")]
        public long ClientId { get; set; }

        [JsonProperty("AmlUserID")]
        public long AmlUserId { get; set; }

        [JsonProperty("AmlCustomerID")]
        public long AmlCustomerId { get; set; }

        [JsonProperty("AmlIntegratorID")]
        public long AmlIntegratorId { get; set; }
    }
}
