using Newtonsoft.Json;
using System;

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

    public class Customer
    {
        [JsonProperty("LoginName")]
        public string LoginName { get; set; }

        [JsonProperty("OrgName")]
        public string OrgName { get; set; }

        [JsonProperty("Address")]
        public string Address { get; set; }

        [JsonProperty("Postcode")]
        public string Postcode { get; set; }

        [JsonProperty("RegistrationDate")]
        public DateTime RegistrationDate { get; set; }

        [JsonProperty("CustomerAccess")]
        public string CustomerAccess { get; set; }

        [JsonProperty("CustomerStatus")]
        public string CustomerStatus { get; set; }

        [JsonProperty("UserLoginName")]
        public string UserLoginName { get; set; }
    }
    #endregion
}
