namespace AMLv4_API.Aml_v4_API
{
    /// <summary>
    /// Personal Risk Assessment, initial Client data
    /// </summary>
    public partial class PersonalRiskAssessmentClientDataRequest
    {
        public string AssessmentType { get; set; }
        public string clienttype { get; set; }
        public string compliance { get; set; }
        public string CountryCode { get; set; }
        public string CurrentAddressFlatFloor { get; set; }
        public string CurrentAddressHouseNameNumber { get; set; }
        public string CurrentAddressLocality { get; set; }
        public string CurrentAddressPostcode { get; set; }
        public string CurrentAddressState { get; set; }
        public string CurrentAddressStreet { get; set; }
        public string CurrentAddressTown { get; set; }
        public string DateMoved { get; set; }
        public string DOB { get; set; }
        public string Email { get; set; }
        public string Forename { get; set; }
        public string Gender { get; set; }
        public string Interview { get; set; }
        public string Nationality { get; set; }
        public string OtherNames { get; set; }
        public string Phone { get; set; }
        public string PreviousAddress { get; set; }
        public string PreviousAddressFlatFloor { get; set; }
        public string PreviousAddressHouseNameNumber { get; set; }
        public string PreviousAddressLocality { get; set; }
        public string PreviousAddressPostcode { get; set; }
        public string PreviousAddressState { get; set; }
        public string PreviousAddressStreet { get; set; }
        public string PreviousAddressTown { get; set; }
        public string PreviousCountryCode { get; set; }
        public string PreviousForename { get; set; }
        public string PreviousName { get; set; }
        public string PreviousOtherNames { get; set; }
        public string PreviousSuffix { get; set; }
        public string PreviousSurname { get; set; }
        public string PreviousTitle { get; set; }
        public string Relationship { get; set; }
        public string Residency { get; set; }
        public string RiskProfile { get; set; }
        public string SSN { get; set; }
        public string Suffix { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public string uri { get; set; }
    }
    public class PersonalRiskAssessmentClientDataResponse
    {
        public string error { get; set; }
        public string uri { get; set; }
        public string ClientID { get; set; }
        public string AssessmentID { get; set; }
        public string AssessmentType { get; set; }
        public string AssessmentData { get; set; }
    }
}
