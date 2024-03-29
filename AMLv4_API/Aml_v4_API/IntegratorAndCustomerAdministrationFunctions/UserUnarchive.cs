﻿using Newtonsoft.Json;

namespace AMLv4_API.Aml_v4_API
{
    /// <summary>
    /// Anarchive User (re-enable auth)
    /// </summary>
    public class UserUnarchiveRequest : Amlv4BaseRequest
    {
        [JsonProperty("AmlUserID")]
        public string AmlUserId { get; set; }
    }

    public class UserUnarchiveResponse : Amlv4BaseResponse
    {
        [JsonProperty("AmlUserID")]
        public long AmlUserId { get; set; }

        [JsonProperty("AmlCustomerID")]
        public long AmlCustomerId { get; set; }

        [JsonProperty("UserLoginID")]
        public string UserLoginId { get; set; }

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

        [JsonProperty("UserType")]
        public string UserType { get; set; }

        [JsonProperty("ServicesAvailable")]
        public string ServicesAvailable { get; set; }

        [JsonProperty("Archived")]
        public string Archived { get; set; }
    }
}
