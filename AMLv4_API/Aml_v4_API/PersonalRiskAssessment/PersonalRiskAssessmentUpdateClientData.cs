using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AMLv4_API.Aml_v4_API
{
    #region request
    /// <summary>
    /// Personal Risk Assessment, Client data update
    /// </summary>
    public class PersonalRiskAssessmentUpdateClientDataRequest
    {
        [JsonProperty("AssessmentType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public AssessmentType AssessmentType { get; set; }

        [JsonProperty("ClientID")]
        public string ClientId { get; set; }

        [JsonProperty("clienttype")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Clienttype Clienttype { get; set; }

        [JsonProperty("compliance")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Compliance Compliance { get; set; }

        [JsonProperty("CountryCode", NullValueHandling = NullValueHandling.Ignore)]
        public string CountryCode { get; set; }

        [JsonProperty("CurrentAddressFlatFloor", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentAddressFlatFloor { get; set; }

        [JsonProperty("CurrentAddressHouseNameNumber")]
        public string CurrentAddressHouseNameNumber { get; set; }

        [JsonProperty("CurrentAddressLocality", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentAddressLocality { get; set; }

        [JsonProperty("CurrentAddressPostcode")]
        public string CurrentAddressPostcode { get; set; }

        [JsonProperty("CurrentAddressState", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentAddressState { get; set; }

        [JsonProperty("CurrentAddressStreet", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentAddressStreet { get; set; }

        [JsonProperty("CurrentAddressTown")]
        public string CurrentAddressTown { get; set; }

        [JsonProperty("DateMoved", NullValueHandling = NullValueHandling.Ignore)]
        public string DateMoved { get; set; }

        [JsonProperty("DOB")]
        public string Dob { get; set; }

        [JsonProperty("Email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        [JsonProperty("Forename")]
        public string Forename { get; set; }

        [JsonProperty("Gender")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Gender Gender { get; set; }

        [JsonProperty("Interview")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Interview Interview { get; set; }

        [JsonProperty("Nationality")]
        public string Nationality { get; set; }

        [JsonProperty("OtherNames", NullValueHandling = NullValueHandling.Ignore)]
        public string OtherNames { get; set; }

        [JsonProperty("Phone", NullValueHandling = NullValueHandling.Ignore)]
        public string Phone { get; set; }

        [JsonProperty("PreviousAddress")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Previous PreviousAddress { get; set; }

        [JsonProperty("PreviousAddressFlatFloor", NullValueHandling = NullValueHandling.Ignore)]
        public string PreviousAddressFlatFloor { get; set; }

        [JsonProperty("PreviousAddressHouseNameNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string PreviousAddressHouseNameNumber { get; set; }

        [JsonProperty("PreviousAddressLocality", NullValueHandling = NullValueHandling.Ignore)]
        public string PreviousAddressLocality { get; set; }

        [JsonProperty("PreviousAddressPostcode", NullValueHandling = NullValueHandling.Ignore)]
        public string PreviousAddressPostcode { get; set; }

        [JsonProperty("PreviousAddressState", NullValueHandling = NullValueHandling.Ignore)]
        public string PreviousAddressState { get; set; }

        [JsonProperty("PreviousAddressStreet", NullValueHandling = NullValueHandling.Ignore)]
        public string PreviousAddressStreet { get; set; }

        [JsonProperty("PreviousAddressTown", NullValueHandling = NullValueHandling.Ignore)]
        public string PreviousAddressTown { get; set; }

        [JsonProperty("PreviousCountryCode", NullValueHandling = NullValueHandling.Ignore)]
        public string PreviousCountryCode { get; set; }

        [JsonProperty("PreviousForename", NullValueHandling = NullValueHandling.Ignore)]
        public string PreviousForename { get; set; }

        [JsonProperty("PreviousName")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Previous PreviousName { get; set; }

        [JsonProperty("PreviousOtherNames", NullValueHandling = NullValueHandling.Ignore)]
        public string PreviousOtherNames { get; set; }

        [JsonProperty("PreviousSuffix", NullValueHandling = NullValueHandling.Ignore)]
        public string PreviousSuffix { get; set; }

        [JsonProperty("PreviousSurname", NullValueHandling = NullValueHandling.Ignore)]
        public string PreviousSurname { get; set; }

        [JsonProperty("PreviousTitle", NullValueHandling = NullValueHandling.Ignore)]
        public string PreviousTitle { get; set; }

        [JsonProperty("Relationship", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public RelationshipType? Relationship { get; set; }

        [JsonProperty("Residency")]
        public string Residency { get; set; }

        [JsonProperty("RiskProfile")]
        public string RiskProfile { get; set; }

        [JsonProperty("SSN", NullValueHandling = NullValueHandling.Ignore)]
        public string Ssn { get; set; }

        [JsonProperty("Suffix", NullValueHandling = NullValueHandling.Ignore)]
        public string Suffix { get; set; }

        [JsonProperty("Surname")]
        public string Surname { get; set; }

        [JsonProperty("Title")]
        public string Title { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }
    #endregion

    #region response
    public class PersonalRiskAssessmentUpdateClientDataResponse
    {
        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("ClientID")]
        public long ClientId { get; set; }

        [JsonProperty("AssessmentID")]
        public long AssessmentId { get; set; }

        [JsonProperty("AssessmentType")]
        public string AssessmentType { get; set; }

        [JsonProperty("AssessmentData")]
        public string AssessmentData { get; set; }
    } 
    #endregion
}