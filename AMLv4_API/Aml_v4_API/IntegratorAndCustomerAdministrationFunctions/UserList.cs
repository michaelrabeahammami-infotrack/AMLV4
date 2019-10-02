using Newtonsoft.Json;

namespace AMLv4_API.Aml_v4_API
{
    /// <summary>
    /// List Users for Customer
    /// </summary>
    public class UserListRequest : Amlv4BaseRequest
    {
        [JsonProperty("AmlCustomerID")]
        public string AmlCustomerId { get; set; }
    }

    public class UserListResponse : Amlv4BaseResponse
    {
        [JsonProperty("usercount")]
        public long Usercount { get; set; }

        [JsonProperty("users")]
        public User[] Users { get; set; }
    }
}
