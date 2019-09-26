namespace AMLv4_API.Aml_v4_API.Client
{
    /// <summary>
    /// View client record details
    /// </summary>
    public class ViewClientDataRequest
    {
        public string ClientID { get; set; }
        public string uri { get; set; }
    }
    public class ViewClientDataResponse
    {
        public string error { get; set; }
        public string uri { get; set; }
        public long ClientID { get; set; }
        public string clienttype { get; set; }
        public string Title { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public string OtherNames { get; set; }
        public string DOB { get; set; }
        public string Suffix { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Ssn { get; set; }
        public string Nationality { get; set; }
        public string NationalityName { get; set; }
        public string Residency { get; set; }
        public string ResidencyName { get; set; }
        public string PreviousName { get; set; }
        public string CurrentAddressFlatFloor { get; set; }
        public long CurrentAddressHouseNameNumber { get; set; }
        public string CurrentAddressStreet { get; set; }
        public string CurrentAddressLocality { get; set; }
        public string CurrentAddressTown { get; set; }
        public string CurrentAddressPostcode { get; set; }
        public string CurrentAddressState { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public string PreviousAddress { get; set; }
        public string PreviousAddressFlatFloor { get; set; }
        public string PreviousAddressHouseNameNumber { get; set; }
        public string PreviousAddressStreet { get; set; }
        public string PreviousAddressLocality { get; set; }
        public string PreviousAddressTown { get; set; }
        public string PreviousAddressPostcode { get; set; }
        public string DateMoved { get; set; }
        public string Relationship { get; set; }
        public string Interview { get; set; }
        public string SearchRef { get; set; }
        public long RiskProfile { get; set; }
        public string AssessmentType { get; set; }
        public string AssessmentDateTime { get; set; }
        public string AssessmentResult { get; set; }
        public string DateCreated { get; set; }
        public string DateUpdated { get; set; }
        public string Archived { get; set; }
        public string ClientInformed { get; set; }
    }
}
