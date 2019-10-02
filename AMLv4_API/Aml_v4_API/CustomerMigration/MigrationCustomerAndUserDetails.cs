using Newtonsoft.Json;

namespace AMLv4_API.Aml_v4_API
{
    #region request
    /// <summary>
    /// Retrieve customer and user data from Version 2 for re-reistration
    /// </summary>
    public class MigrationCustomerAndUserDetailsRequest : Amlv4BaseRequest
    {
        [JsonProperty("CustomerID")]
        public string CustomerId { get; set; }

        [JsonProperty("IntegratorID")]
        public string IntegratorId { get; set; }

        [JsonProperty("UserID")]
        public string UserId { get; set; }
    }
    #endregion

    #region response
    public class MigrationCustomerAndUserDetailsResponse : Amlv4BaseResponse
    {
        [JsonProperty("CustomerLoginID")]
        public string CustomerLoginId { get; set; }

        [JsonProperty("CustomerName")]
        public string CustomerName { get; set; }

        [JsonProperty("CustomerAddress")]
        public string CustomerAddress { get; set; }

        [JsonProperty("ContactTitle")]
        public string ContactTitle { get; set; }

        [JsonProperty("ContactForename")]
        public string ContactForename { get; set; }

        [JsonProperty("ContactSurname")]
        public string ContactSurname { get; set; }

        [JsonProperty("ContactEmail")]
        public string ContactEmail { get; set; }

        [JsonProperty("ContactPosition")]
        public string ContactPosition { get; set; }

        [JsonProperty("CustomerICONumber")]
        public long CustomerIcoNumber { get; set; }

        [JsonProperty("MLROContactName")]
        public string MlroContactName { get; set; }

        [JsonProperty("Telephone")]
        public string Telephone { get; set; }

        [JsonProperty("Fax")]
        public string Fax { get; set; }

        [JsonProperty("CustomerAccess")]
        public string CustomerAccess { get; set; }

        [JsonProperty("OrgType")]
        public string OrgType { get; set; }
    } 
    #endregion
}
