namespace AMLv4_API.Aml_v4_API.NonPersonalRiskAssessment
{
    /// <summary>
    /// Non Personal Organisation Lookup
    /// </summary>
    public class OrganisationLookupRequest
    {
        public string CompanyName { get; set; }

        public string CompanyRegistrationNumber { get; set; }

        public string CountryCode { get; set; }

        public string Uri { get; set; }
    }

    public class OrganisationLookupResponse
    {
        public string error { get; set; }

        public string uri { get; set; }

        public string picktype { get; set; }

        public Searchcompany searchcompany { get; set; }

        public long numpicks { get; set; }

        public Pick[] picks { get; set; }
    }

    public class Pick
    {
        public long PickId { get; set; }

        public string Clienttype { get; set; }

        public string CountryCode { get; set; }

        public string JurisdictionCode { get; set; }

        public string CountryName { get; set; }

        public string CompanyName { get; set; }

        public string CompanyNo { get; set; }

        public string CompanyNoDisplay { get; set; }

        public string CompanyType { get; set; }

        public string CompanyStatus { get; set; }

        public string RegisteredAddress { get; set; }

        public string InceptionDate { get; set; }
    }

    public class Searchcompany
    {
        public string CompanyName { get; set; }

        public string CountryCode { get; set; }
    }
}
