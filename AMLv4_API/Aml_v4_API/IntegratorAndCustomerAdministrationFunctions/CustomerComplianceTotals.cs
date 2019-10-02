using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AMLv4_API.Aml_v4_API
{
    public class CustomerComplianceTotalsRequest : Amlv4BaseRequest
    {
        [JsonProperty("AmlCustomerID", NullValueHandling = NullValueHandling.Ignore)]
        public string AmlCustomerId { get; set; }

        [JsonProperty("AmlUserID", NullValueHandling = NullValueHandling.Ignore)]
        public string AmlUserId { get; set; }

        [JsonProperty("ClientType", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Clienttypefilter? ClientType { get; set; }

        [JsonProperty("EndDate", NullValueHandling = NullValueHandling.Ignore)]
        public string EndDate { get; set; }

        [JsonProperty("IncludeArchived", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public IncludeArchived? IncludeArchived { get; set; }

        [JsonProperty("StartDate", NullValueHandling = NullValueHandling.Ignore)]
        public string StartDate { get; set; }
    }

    public class CustomerComplianceTotalsResponse : Amlv4BaseResponse
    {
        [JsonProperty("NumTotal")]
        public long NumTotal { get; set; }

        [JsonProperty("NumComplete")]
        public long NumComplete { get; set; }

        [JsonProperty("NumCompliant")]
        public long NumCompliant { get; set; }

        [JsonProperty("NumNonCompliant")]
        public long NumNonCompliant { get; set; }

        [JsonProperty("NumPending")]
        public long NumPending { get; set; }

        [JsonProperty("PercentCompliant")]
        public long PercentCompliant { get; set; }

        [JsonProperty("PercentNonCompliant")]
        public long PercentNonCompliant { get; set; }

        [JsonProperty("PercentPending")]
        public long PercentPending { get; set; }

        [JsonProperty("NumAlerts")]
        public long NumAlerts { get; set; }
    }
}
