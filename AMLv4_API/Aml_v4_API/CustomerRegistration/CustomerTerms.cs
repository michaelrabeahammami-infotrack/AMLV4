using Newtonsoft.Json;

namespace AMLv4_API.Aml_v4_API
{
    public class CustomerTermsRequest : Amlv4BaseRequest
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

        [JsonProperty("CustomerAddress")]
        public string CustomerAddress { get; set; }

        [JsonProperty("CustomerName")]
        public string CustomerName { get; set; }
    }

    public class CustomerTermsResponse : Amlv4BaseResponse
    {
        [JsonProperty("TermsBinary")]
        public string TermsBinary { get; set; }

        [JsonProperty("TermsVersion")]
        public string TermsVersion { get; set; }

        [JsonProperty("TermsVersionViewed")]
        public string TermsVersionViewed { get; set; }

        [JsonProperty("AmlTermsVersionCurrent")]
        public string AmlTermsVersionCurrent { get; set; }

        [JsonProperty("AmlTermsVersionNew")]
        public string AmlTermsVersionNew { get; set; }
    }
}
