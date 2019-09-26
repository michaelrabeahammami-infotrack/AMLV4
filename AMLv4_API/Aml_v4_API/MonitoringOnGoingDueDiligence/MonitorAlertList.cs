namespace AMLv4_API.Aml_v4_API.MonitoringOnGoingDueDiligence
{
    /// <summary>
    /// Monitoring Alert List
    /// </summary>
    public class OversightUpdateRequest
    {
        /// <summary>
        /// Optional filter to list for single customer
        /// </summary>
        public string AmlCustomerID { get; set; }

        public string uri { get; set; }
    }

    public class OversightUpdateResponse
    {
        public string error { get; set; }
        public string uri { get; set; }
        public long numalerts { get; set; }
        public Alert[] alerts { get; set; }
    }

    public class Alert
    {
        public string CustomerID { get; set; }
        public string ClientSummary { get; set; }
        public string ClientReference { get; set; }
        public string AlertDate { get; set; }
        public string AlertType { get; set; }
        public string AlertSanctionMatch { get; set; }
        public long AlertID { get; set; }
        public string Cancelled { get; set; }
        public long AssessmentID { get; set; }
        public long ClientID { get; set; }
        public long AmlUserID { get; set; }
        public long AmlCustomerID { get; set; }
        public long AmlIntegratorID { get; set; }
        public long? AlertDocID { get; set; }
    }


}
