using Newtonsoft.Json;
using System;

namespace AMLv4_API.Aml_v4_API
{
    /// <summary>
    /// Monitoring Alert List
    /// </summary>
    public class MonitorAlertListRequest
    {
        /// <summary>
        /// Optional filter to list for single customer
        /// </summary>
        [JsonProperty("AmlCustomerID", NullValueHandling = NullValueHandling.Ignore)]
        public string AmlCustomerId { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class MonitorAlertListResponse : Amlv4BaseResponse
    {
        [JsonProperty("numalerts")]
        public long Numalerts { get; set; }

        [JsonProperty("alerts")]
        public Alert[] Alerts { get; set; }
    }
}
