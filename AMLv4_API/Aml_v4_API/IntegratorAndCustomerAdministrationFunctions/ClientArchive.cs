using Newtonsoft.Json;

namespace AMLv4_API.Aml_v4_API
{
    /// <summary>
    /// Archive client record and disable ongoing monitoring
    /// </summary>
    public class ClientArchiveRequest : Amlv4BaseRequest
    {
        [JsonProperty("ClientID")]
        public string ClientId { get; set; }
    }

    public class ClientArchiveResponse : Amlv4BaseResponse
    {
        [JsonProperty("ClientID")]
        public long ClientId { get; set; }

        [JsonProperty("Archived")]
        public string Archived { get; set; }
    }
}
