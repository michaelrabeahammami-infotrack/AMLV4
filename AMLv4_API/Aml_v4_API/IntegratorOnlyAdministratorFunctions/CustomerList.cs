using Newtonsoft.Json;
using System;

namespace AMLv4_API.Aml_v4_API
{
    /// <summary>
    /// List all integrators customers
    /// </summary>
    public class CustomerListRequest : Amlv4BaseRequest
    {
    }

    public class CustomerListResponse : Amlv4BaseResponse
    {
        [JsonProperty("customercount")]
        public long Customercount { get; set; }

        [JsonProperty("customers")]
        public Customer[] Customers { get; set; }
    }
}
