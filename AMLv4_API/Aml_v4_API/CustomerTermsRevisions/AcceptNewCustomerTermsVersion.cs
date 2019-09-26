﻿using Newtonsoft.Json;

namespace AMLv4_API.Aml_v4_API
{
    /// <summary>
    /// Accept new version of customer terms. The version stored for the customer will be updated
    /// to the latest.
    /// </summary>
    public class AcceptNewCustomerTermsVersionRequest
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class AcceptNewCustomerTermsVersionResponse
    {
        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

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
