using Newtonsoft.Json;
using System;

namespace AMLv4_API.Aml_v4_API
{
    /// <summary>
    /// Non Personal Organisation Lookup
    /// </summary>
    public class OrganisationLookupRequest
    {
        [JsonProperty("CompanyName", NullValueHandling = NullValueHandling.Ignore)]
        public string CompanyName { get; set; }

        [JsonProperty("CompanyRegistrationNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string CompanyRegistrationNumber { get; set; }

        [JsonProperty("CountryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class OrganisationLookupResponse : Amlv4BaseResponse
    {
        [JsonProperty("picktype")]
        public string Picktype { get; set; }

        [JsonProperty("searchcompany")]
        public Searchcompany Searchcompany { get; set; }

        [JsonProperty("numpicks")]
        public long Numpicks { get; set; }

        [JsonProperty("picks")]
        public Pick[] Picks { get; set; }
    }

    public class Pick
    {
        [JsonProperty("PickID")]
        public long PickId { get; set; }

        [JsonProperty("clienttype")]
        public string Clienttype { get; set; }

        [JsonProperty("CountryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("JurisdictionCode")]
        public string JurisdictionCode { get; set; }

        [JsonProperty("CountryName")]
        public string CountryName { get; set; }

        [JsonProperty("CompanyName")]
        public string CompanyName { get; set; }

        [JsonProperty("CompanyNo")]
        public string CompanyNo { get; set; }

        [JsonProperty("CompanyNoDisplay")]
        public string CompanyNoDisplay { get; set; }

        [JsonProperty("CompanyType")]
        public string CompanyType { get; set; }

        [JsonProperty("CompanyStatus")]
        public string CompanyStatus { get; set; }

        [JsonProperty("RegisteredAddress")]
        public string RegisteredAddress { get; set; }

        [JsonProperty("InceptionDate")]
        public DateTime InceptionDate { get; set; }
    }

    public class Searchcompany
    {
        [JsonProperty("CompanyName")]
        public string CompanyName { get; set; }

        [JsonProperty("CountryCode")]
        public string CountryCode { get; set; }
    }
}
