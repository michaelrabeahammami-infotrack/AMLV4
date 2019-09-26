﻿namespace AMLv4_API.Aml_v4_API.MonitoringOnGoingDueDiligence
{
    /// <summary>
    /// Monitoring Alert Update
    /// </summary>
    public class MonitoringAlertUpdateRequest
    {
        /// <summary>
        /// Unique ID of the Alert record
        /// </summary>
        public string AlertID { get; set; }
        public string Uri { get; set; }
        public string Cancelled { get; set; }
        public string CancelReason { get; set; }
    }

    public class MonitoringAlertUpdateResponse
    {
        public string error { get; set; }
        public string uri { get; set; }
        public string CustomerID { get; set; }
        public string ClientSummary { get; set; }
        public string ClientReference { get; set; }
        public string AlertDate { get; set; }
        public string AlertType { get; set; }
        public string AlertSanctionMatch { get; set; }
        public long AlertID { get; set; }
        public string Cancelled { get; set; }
        public string CancelUserName { get; set; }
        public string CancelReason { get; set; }
        public string CancelDate { get; set; }
        public long AssessmentID { get; set; }
        public long ClientID { get; set; }
        public long AmlUserID { get; set; }
        public long AmlCustomerID { get; set; }
        public long AmlIntegratorID { get; set; }
    }
}
