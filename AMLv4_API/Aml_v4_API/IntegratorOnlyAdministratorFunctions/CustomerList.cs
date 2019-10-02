using Newtonsoft.Json;
using System;

namespace AMLv4_API.Aml_v4_API
{
    /// <summary>
    /// List all integrators customers
    /// </summary>
    public class CustomerListRequest
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class CustomerListResponse
    {
        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("customercount")]
        public long Customercount { get; set; }

        [JsonProperty("customers")]
        public Customer[] Customers { get; set; }
    }
}
