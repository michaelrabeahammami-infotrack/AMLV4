namespace AMLv4_API.Aml_v4_API
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    #region Request
    /// <summary>
    /// Register a new Customer
    /// </summary>
    public class RegisterCustomerRequest
    {
        [JsonProperty("CustData")]
        public CustData CustData { get; set; }

        [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
        public string Uri { get; set; }
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
    public class RegisterCustomerResponse
    {
        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("code")]
        [JsonConverter(typeof(SingleOrArrayConverter<Code>))]
        public Code[] Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class Code
    {
        public Code(string message)
        {
            Message = message;
        }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("keyword")]
        public string Keyword { get; set; }

        [JsonProperty("parameter")]
        public string[] Parameter { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("data_path")]
        public string DataPath { get; set; }

        [JsonProperty("schema")]
        public Schema Schema { get; set; }

        [JsonProperty("schema_path")]
        public string SchemaPath { get; set; }

        [JsonProperty("cause")]
        public string Cause { get; set; }
    }

    public class Schema
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("enum")]
        public string[] Enum { get; set; }
    }
    #endregion
}
