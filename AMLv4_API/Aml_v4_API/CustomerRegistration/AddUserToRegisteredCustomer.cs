﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AMLv4_API.Aml_v4_API
{
    public class AddUserToRegisteredCustomerRequest : Amlv4BaseRequest
    {
        /// <summary>
        /// Use if authorised as an Integrator, otherwise authorise as customer to add to
        /// </summary>
        [JsonProperty("AmlCustomerID", NullValueHandling = NullValueHandling.Ignore)]
        public string AmlCustomerId { get; set; }

        [JsonProperty("ContactEmail")]
        public string ContactEmail { get; set; }

        [JsonProperty("ContactForname", NullValueHandling = NullValueHandling.Ignore)]
        public string ContactForname { get; set; }

        [JsonProperty("ContactSurname")]
        public string ContactSurname { get; set; }

        /// <summary>
        /// Additional rights (MO=Management Oversight, MOD=MO for Document Expiry Alert only)
        /// </summary>
        [JsonProperty("ServicesAvailable", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public ServicesAvailable? ServicesAvailable { get; set; }

        [JsonProperty("UserLoginID")]
        public string UserLoginId { get; set; }

        [JsonProperty("UserType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public UserType UserType { get; set; }

        [JsonProperty("ContactForename")]
        public object ContactForename { get; set; }
    }

    public class AddUserToRegisteredCustomerResponse : Amlv4BaseResponse
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
