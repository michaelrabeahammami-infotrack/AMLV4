using Newtonsoft.Json;

namespace AMLv4_API.Aml_v4_API
{
    #region request
    /// <summary>
    /// List available Customers to Migrate
    /// </summary>
    public class MigrationListRequest
    {
        [JsonProperty("IntegratorID")]
        public string IntegratorId { get; set; }
    }
    #endregion

    #region response
    public class MigrationListResponse
    {
        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("customercount")]
        public long Customercount { get; set; }

        [JsonProperty("customers")]
        public Customer[] Customers { get; set; }
    } 
    #endregion
}
