namespace AMLv4_API.Aml_v4_API
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    #region Request
    /// <summary>
    /// Register a new Customer
    /// </summary>
    public class RegisterCustomerRequest : Amlv4BaseRequest
    {
        [JsonProperty("CustData")]
        public CustData CustData { get; set; }
    }

    public class CustData
    {
        [JsonProperty("ContactEmail")]
        public string ContactEmail { get; set; }

        [JsonProperty("ContactForename")]
        public string ContactForename { get; set; }

        [JsonProperty("ContactPosition")]
        public string ContactPosition { get; set; }

        [JsonProperty("ContactSurname")]
        public string ContactSurname { get; set; }

        [JsonProperty("ContactTitle", NullValueHandling = NullValueHandling.Ignore)]
        public string ContactTitle { get; set; }

        [JsonProperty("CustomerAccess")]
        [JsonConverter(typeof(StringEnumConverter))]
        public CustomerAccess CustomerAccess { get; set; }

        [JsonProperty("CustomerAddress")]
        public string CustomerAddress { get; set; }

        [JsonProperty("CustomerICONumber")]        
        public string CustomerIcoNumber { get; set; }

        [JsonProperty("CustomerName")]
        public string CustomerName { get; set; }

        [JsonProperty("MLROContactEmail")]        
        public string MlroContactEmail { get; set; }

        [JsonProperty("MLROContactName")]        
        public string MlroContactName { get; set; }

        [JsonProperty("MLROContactPosition")]        
        public string MlroContactPosition { get; set; }

        [JsonProperty("OrgType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public OrgType OrgType { get; set; }

        [JsonProperty("Telephone")]
        public string Telephone { get; set; }

        [JsonProperty("TermsAccepted")]
        [JsonConverter(typeof(StringEnumConverter))]
        public TermsAccepted TermsAccepted { get; set; }
    }

    #endregion

    #region Response
    public class RegisterCustomerResponse : Amlv4BaseResponse
    {
        [JsonProperty("version")]
        public string Version { get; set; }
    }
    
    #endregion
}
