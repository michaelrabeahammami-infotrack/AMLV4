using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AMLv4_API.Aml_v4_API
{
    /// <summary>
    /// View Customer Terms Verison and new or existing signed PDF
    /// </summary>
    public class CheckCustomerTermsVersionRequest
    {
        /// <summary>
        /// no|yes - Set to no to check terms version, yes to retrieve a copy of the terms
        /// </summary>
        [JsonProperty("IncludeBinary", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public IncludeBinary? IncludeBinary { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        /// <summary>
        /// no|yes - Set to yes to obtain a preview of a new Terms version. Set to no to view
        /// currently agreeed version
        /// </summary>
        [JsonProperty("ViewingNewVersion", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public IncludeBinary? ViewingNewVersion { get; set; }
    }

    public class CheckCustomerTermsVersionResponse
    {
        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("TermsBinary")]
        public string TermsBinary { get; set; }

        [JsonProperty("DateAccepted")]
        public string DateAccepted { get; set; }

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
