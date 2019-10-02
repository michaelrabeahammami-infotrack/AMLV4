using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace AMLv4_API.Aml_v4_API
{
    /// <summary>
    /// Risk Assessment List
    /// </summary>
    public class ListOfAssessmentsForClientRequest : Amlv4BaseRequest
    {
        [JsonProperty("ClientID")]
        public string ClientId { get; set; }

        [JsonProperty("IncludeData")]
        [JsonConverter(typeof(StringEnumConverter))]
        public IncludeData IncludeData { get; set; }
    }
    public class ListOfAssessmentsForClientResponse : Amlv4BaseResponse
    {
        [JsonProperty("numresults")]
        public long Numresults { get; set; }

        [JsonProperty("results")]
        public Result[] Results { get; set; }
    }

    public class ResultData
    {
        [JsonProperty("TransactionID")]
        public long TransactionId { get; set; }

        [JsonProperty("InvoiceReference")]
        public string InvoiceReference { get; set; }

        [JsonProperty("InvoiceNet")]
        public string InvoiceNet { get; set; }

        [JsonProperty("ReportReference")]
        public string ReportReference { get; set; }

        [JsonProperty("DateOfSearch")]
        public DateTime DateOfSearch { get; set; }

        [JsonProperty("NumIdsDocument")]
        public long NumIdsDocument { get; set; }

        [JsonProperty("NumAdsDocument")]
        public long NumAdsDocument { get; set; }

        [JsonProperty("VerifiedDocs")]
        public string VerifiedDocs { get; set; }

        [JsonProperty("ElectronicStatus")]
        public string ElectronicStatus { get; set; }

        [JsonProperty("OverallStatus")]
        public string OverallStatus { get; set; }

        [JsonProperty("SanctionMatches")]
        public string SanctionMatches { get; set; }

        [JsonProperty("FailError")]
        public string FailError { get; set; }
    }
}
