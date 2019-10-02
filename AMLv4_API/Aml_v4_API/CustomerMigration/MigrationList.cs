using Newtonsoft.Json;

namespace AMLv4_API.Aml_v4_API
{
    #region request
    /// <summary>
    /// List available Customers to Migrate
    /// </summary>
    public class MigrationListRequest : Amlv4BaseRequest
    {
        [JsonProperty("IntegratorID")]
        public string IntegratorId { get; set; }
    }
    #endregion

    #region response
    public class MigrationListResponse : Amlv4BaseResponse
    {
        [JsonProperty("customercount")]
        public long Customercount { get; set; }

        [JsonProperty("customers")]
        public Customer[] Customers { get; set; }
    } 
    #endregion
}
