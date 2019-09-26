namespace AMLv4_API.Aml_v4_API.ComplianceReports
{
    /// <summary>
    /// Risk Assessment List
    /// </summary>
    /// <summary>
    /// Retrieve Client Full CDD report pdf
    /// </summary>
    public class SingleClientDueDiligenceReportRequest
    {
        public string ClientId { get; set; }
        public string Uri { get; set; }
    }

    public class SingleClientDueDiligenceReportResponse
    {
        public string error { get; set; }
        public string uri { get; set; }
        public long ClientID { get; set; }
        public string filename { get; set; }
        public string binarydata { get; set; }
    }
}
