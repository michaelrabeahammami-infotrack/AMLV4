using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Runtime.Serialization;

namespace AMLv4_API.Aml_v4_API
{
    /// <summary>
    /// Monitoring Alert Update
    /// </summary>
    public class SingleMonitoringAlertViewRequest
    {
        /// <summary>
        /// Unique ID of the Alert record
        /// </summary>
        [JsonProperty("AlertID")]
        public string AlertId { get; set; }

        /// <summary>
        /// Remove (yes) or Reinstate (no) Alert in current active alert list
        /// </summary>
        [JsonProperty("Cancelled", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Cancelled? Cancelled { get; set; }

        /// <summary>
        /// User generated or system calculated from multiple choice
        /// </summary>
        [JsonProperty("CancelReason", NullValueHandling = NullValueHandling.Ignore)]
        public string CancelReason { get; set; }

        /// <summary>
        /// If the alert has caused the client and latest assessment to be changed to Non-Compliant,
        /// set it back to compliant (yes) or leave non-compliant (no) depending on user selection
        /// </summary>
        [JsonProperty("UndoNonCompliance", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Cancelled? UndoNonCompliance { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class SingleMonitoringAlertViewResponse : Amlv4BaseResponse
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
