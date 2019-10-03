using Newtonsoft.Json;

namespace AMLv4_API.Aml_v4_API
{

    #region Request

    /// <summary>
    /// Authenticate and get a URI response
    /// </summary>
    public class AuthenticationRequest
    {
        [JsonProperty("CustomerID")]
        public string CustomerId { get; set; }

        [JsonProperty("IntegratorID")]
        public string IntegratorId { get; set; }

        /// <summary>
        /// Optional - Used to supply Billing Reference only in this context
        /// </summary>
        [JsonProperty("Options", NullValueHandling = NullValueHandling.Ignore)]
        public Options Options { get; set; }

        [JsonProperty("Password", NullValueHandling = NullValueHandling.Ignore)]
        public string Password { get; set; }

        /// <summary>
        /// Optional - Supply with auth to auto-add new users
        /// </summary>
        [JsonProperty("UserData", NullValueHandling = NullValueHandling.Ignore)]
        public UserData UserData { get; set; }

        [JsonProperty("UserID")]
        public string UserId { get; set; }
    }

    #endregion Request

    #region Response
    public class AuthenticationResponse
    {
        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("logintype")]
        public string Logintype { get; set; }

        [JsonProperty("OrgName")]
        public string OrgName { get; set; }

        [JsonProperty("Forename")]
        public string Forename { get; set; }

        [JsonProperty("Surname")]
        public string Surname { get; set; }

        [JsonProperty("Email")]
        public string Email { get; set; }

        [JsonProperty("usertype")]
        public string Usertype { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("AmlIntegratorID")]
        public long AmlIntegratorId { get; set; }

        [JsonProperty("AmlCustomerID")]
        public long AmlCustomerId { get; set; }

        [JsonProperty("AmlUserID")]
        public long AmlUserId { get; set; }

        [JsonProperty("CustomerAccess")]
        public string CustomerAccess { get; set; }

        [JsonProperty("CustomerStatus")]
        public string CustomerStatus { get; set; }

        [JsonProperty("UserStatus")]
        public string UserStatus { get; set; }

        [JsonProperty("CustomerLoginID")]
        public string CustomerLoginId { get; set; }

        [JsonProperty("UserLoginID")]
        public string UserLoginId { get; set; }

        [JsonProperty("LimitedLive")]
        public string LimitedLive { get; set; }
    }

    #endregion Response

}

