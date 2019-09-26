namespace AMLv4_API.Aml_v4_API.AssessmentList
{
    /// <summary>
    /// Risk Assessment List
    /// </summary>
    public class ListOfAssessmentsForClientRequest
    {
        public string ClientID { get; set; }
        public string IncludeData { get; set; }
        public string uri { get; set; }
    }

    public enum IncludeData { No, Yes };

    public class ListOfAssessmentsForClientResponse
    {
        public string error { get; set; }
        public string uri { get; set; }
        public long numresults { get; set; }
        public Result[] results { get; set; }
    }

    public class Result
    {
        public long AssessmentID { get; set; }
        public long ClientID { get; set; }
        public string ClientType { get; set; }
        public string ClientReference { get; set; }
        public string ClientArchived { get; set; }
        public string ClientName { get; set; }
        public string ClientDob { get; set; }
        public string ClientPostCode { get; set; }
        public string ClientCountryCode { get; set; }
        public long ProfileID { get; set; }
        public string ProfileName { get; set; }
        public string UserName { get; set; }
        public string AssessmentType { get; set; }
        public string AssessmentDate { get; set; }
        public string AssessmentResult { get; set; }
        public string AssessmentArchived { get; set; }
        public long AssessmentAlertCount { get; set; }
        public ResultData ResultData { get; set; }
    }

    public class ResultData
    {
        public long TransactionID { get; set; }
        public string InvoiceReference { get; set; }
        public string InvoiceNet { get; set; }
        public string ReportReference { get; set; }
        public string DateOfSearch { get; set; }
        public long NumIdsDocument { get; set; }
        public long NumAdsDocument { get; set; }
        public string VerifiedDocs { get; set; }
        public string ElectronicStatus { get; set; }
        public string OverallStatus { get; set; }
        public string SanctionMatches { get; set; }
        public string FailError { get; set; }
    }


}
