namespace AMLv4_API.Aml_v4_API.ComplianceReports
{
    /// <summary>
    /// Retrieve Customer (All Client) Full CDD report pdf
    /// </summary>
    public class CustomerAllClientsDueDiligenceReportRequest
    {
        public string AmlCustomerId { get; set; }
        public string Uri { get; set; }
    }

    public class CustomerAllClientsDueDiligenceReportResponse
    {
        public string error { get; set; }
        public string uri { get; set; }
        public long AmlCustomerID { get; set; }
        public string filename { get; set; }
        public string binarydata { get; set; }
    }


}
