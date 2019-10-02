using Newtonsoft.Json;

namespace AMLv4_API.Aml_v4_API
{
    /// <summary>
    /// Un-Archive client record and re-enable ongoing monitoring
    /// </summary>
    public class ClientUnarchiveRequest : Amlv4BaseRequest
    {
        [JsonProperty("ClientID")]
        public string ClientId { get; set; }
    }
     class ClientUnarchiveResponse : Amlv4BaseResponse
    {
        [JsonProperty("ClientID")]
        public long ClientId { get; set; }

        [JsonProperty("Archived")]
        public string Archived { get; set; }
    }
}
