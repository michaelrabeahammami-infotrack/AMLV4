using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace AMLv4_API.Aml_v4_API
{
    /// <summary>
    /// View client record details
    /// </summary>
    public class ViewClientDataRequest
    {
        [JsonProperty("ClientID")]
        public string ClientId { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }
    public partial class ViewClientDataResponse
    {
        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("ClientID")]
        public long ClientId { get; set; }

        [JsonProperty("clienttype")]
        public string Clienttype { get; set; }

        [JsonProperty("Title")]
        public string Title { get; set; }

        [JsonProperty("Forename")]
        public string Forename { get; set; }

        [JsonProperty("Surname")]
        public string Surname { get; set; }

        [JsonProperty("OtherNames")]
        public string OtherNames { get; set; }

        [JsonProperty("DOB")]
        public DateTime Dob { get; set; }

        [JsonProperty("Suffix")]
        public string Suffix { get; set; }

        [JsonProperty("Gender")]
        public string Gender { get; set; }

        [JsonProperty("Email")]
        public string Email { get; set; }

        [JsonProperty("Phone")]
        public string Phone { get; set; }

        [JsonProperty("SSN")]
        public string Ssn { get; set; }

        [JsonProperty("Nationality")]
        public string Nationality { get; set; }

        [JsonProperty("NationalityName")]
        public string NationalityName { get; set; }

        [JsonProperty("Residency")]
        public string Residency { get; set; }

        [JsonProperty("ResidencyName")]
        public string ResidencyName { get; set; }

        [JsonProperty("PreviousName")]
        public string PreviousName { get; set; }

        [JsonProperty("CurrentAddressFlatFloor")]
        public string CurrentAddressFlatFloor { get; set; }

        [JsonProperty("CurrentAddressHouseNameNumber")]
        public long CurrentAddressHouseNameNumber { get; set; }

        [JsonProperty("CurrentAddressStreet")]
        public string CurrentAddressStreet { get; set; }

        [JsonProperty("CurrentAddressLocality")]
        public string CurrentAddressLocality { get; set; }

        [JsonProperty("CurrentAddressTown")]
        public string CurrentAddressTown { get; set; }

        [JsonProperty("CurrentAddressPostcode")]
        public string CurrentAddressPostcode { get; set; }

        [JsonProperty("CurrentAddressState")]
        public string CurrentAddressState { get; set; }

        [JsonProperty("CountryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("CountryName")]
        public string CountryName { get; set; }

        [JsonProperty("PreviousAddress")]
        public string PreviousAddress { get; set; }

        [JsonProperty("PreviousAddressFlatFloor")]
        public string PreviousAddressFlatFloor { get; set; }

        [JsonProperty("PreviousAddressHouseNameNumber")]
        public string PreviousAddressHouseNameNumber { get; set; }

        [JsonProperty("PreviousAddressStreet")]
        public string PreviousAddressStreet { get; set; }

        [JsonProperty("PreviousAddressLocality")]
        public string PreviousAddressLocality { get; set; }

        [JsonProperty("PreviousAddressTown")]
        public string PreviousAddressTown { get; set; }

        [JsonProperty("PreviousAddressPostcode")]
        public string PreviousAddressPostcode { get; set; }

        [JsonProperty("DateMoved")]
        public string DateMoved { get; set; }

        [JsonProperty("Relationship")]
        public string Relationship { get; set; }

        [JsonProperty("Interview")]
        public string Interview { get; set; }

        [JsonProperty("SearchRef")]
        public string SearchRef { get; set; }

        [JsonProperty("RiskProfile")]
        public long RiskProfile { get; set; }

        [JsonProperty("AssessmentType")]
        public string AssessmentType { get; set; }

        [JsonProperty("AssessmentDateTime")]
        public DateTime AssessmentDateTime { get; set; }

        [JsonProperty("AssessmentResult")]
        public string AssessmentResult { get; set; }

        [JsonProperty("DateCreated")]
        public DateTime DateCreated { get; set; }

        [JsonProperty("DateUpdated")]
        public DateTime DateUpdated { get; set; }

        [JsonProperty("Archived")]
        public string Archived { get; set; }

        [JsonProperty("ClientInformed")]
        public string ClientInformed { get; set; }
    }
}
