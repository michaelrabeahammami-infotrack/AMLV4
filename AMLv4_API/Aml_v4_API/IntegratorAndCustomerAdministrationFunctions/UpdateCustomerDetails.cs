using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AMLv4_API.Aml_v4_API
{
    /// <summary>
    /// Update Customer Details
    /// </summary>
    public class UpdateCustomerDetailsRequest
    {
        [JsonProperty("AllowOtherDocs", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public AllowOtherDocs? AllowOtherDocs { get; set; }

        [JsonProperty("AmlCustomerID")]
        public string AmlCustomerId { get; set; }

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

        [JsonProperty("CustomerAccess", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public CustomerAccess? CustomerAccess { get; set; }

        [JsonProperty("CustomerAddress")]
        public string CustomerAddress { get; set; }

        [JsonProperty("CustomerICONumber")]
        public string CustomerIcoNumber { get; set; }

        [JsonProperty("CustomerName")]
        public string CustomerName { get; set; }

        [JsonProperty("Fax", NullValueHandling = NullValueHandling.Ignore)]
        public string Fax { get; set; }

        [JsonProperty("MLROContactEmail")]
        public string MlroContactEmail { get; set; }

        [JsonProperty("MLROContactName")]
        public string MlroContactName { get; set; }

        [JsonProperty("MLROContactPosition", NullValueHandling = NullValueHandling.Ignore)]
        public string MlroContactPosition { get; set; }

        [JsonProperty("OrgType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public OrgType OrgType { get; set; }

        [JsonProperty("Telephone")]
        public string Telephone { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class UpdateCustomerDetailsResponse : Amlv4BaseResponse
    {
        [JsonProperty("AmlCustomerID")]
        public long AmlCustomerId { get; set; }

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

        [JsonProperty("MLROContactEmail")]
        public string MlroContactEmail { get; set; }

        [JsonProperty("MLROContactPosition")]
        public string MlroContactPosition { get; set; }

        [JsonProperty("Telephone")]
        public long Telephone { get; set; }

        [JsonProperty("Fax")]
        public string Fax { get; set; }

        [JsonProperty("CustomerAccess")]
        public string CustomerAccess { get; set; }

        [JsonProperty("AllowOtherDocs")]
        public string AllowOtherDocs { get; set; }

        [JsonProperty("OrgType")]
        public string OrgType { get; set; }

        [JsonProperty("CustomerStatus")]
        public string CustomerStatus { get; set; }

        [JsonProperty("Archived")]
        public string Archived { get; set; }
    }
}
