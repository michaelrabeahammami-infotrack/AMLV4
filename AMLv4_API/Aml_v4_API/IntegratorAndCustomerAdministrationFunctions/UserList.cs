using Newtonsoft.Json;

namespace AMLv4_API.Aml_v4_API
{
    /// <summary>
    /// List Users for Customer
    /// </summary>
    public class UserListRequest
    {
        [JsonProperty("AmlCustomerID")]
        public string AmlCustomerId { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class UserListResponse
    {
        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("usercount")]
        public long Usercount { get; set; }

        [JsonProperty("users")]
        public User[] Users { get; set; }
    }
}
