using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AMLv4_API.Aml_v4_API
{
    public class ClientListForCustomerRequest
    {
        /// <summary>
        /// Type of Client, personal or nonpersonal
        /// </summary>
        [JsonProperty("clienttypefilter", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Clienttypefilter? Clienttypefilter { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class ClientListForCustomerResponse : Amlv4BaseResponse
    {
        [JsonProperty("clientcount")]
        public long Clientcount { get; set; }

        [JsonProperty("clients")]
        public Client[] Clients { get; set; }
    }
}
