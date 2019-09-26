namespace AMLv4_API.Aml_v4_API.PersonalRiskAssessment
{
    /// <summary>
    /// View Assessment Details before or after running
    /// </summary>
    public class ViewRiskAssessmentRequest
    {
        public string AssessmentID { get; set; }

        public string uri { get; set; }
    }

    #region Response
    public partial class ViewRiskAssessmentResponse
    {
        public string error { get; set; }

        public string uri { get; set; }

        public long AssessmentID { get; set; }

        public long ClientID { get; set; }

        public long AmlUserID { get; set; }

        public long AmlCustomerID { get; set; }

        public string clienttype { get; set; }

        public string date { get; set; }

        public string reference { get; set; }

        public string assessmenttype { get; set; }

        public long profileid { get; set; }

        public string profilename { get; set; }

        public string status { get; set; }

        public string displayPrice { get; set; }

        public string price { get; set; }

        public string archived { get; set; }

        public string locked { get; set; }

        public Client client { get; set; }

        public long numdocuments { get; set; }

        public Document[] documents { get; set; }

        public long numrelationships { get; set; }

        public RelationshipType[] relationships { get; set; }

        public long numalerts { get; set; }

        public Alert[] alerts { get; set; }

        public User user { get; set; }

        public Customer customer { get; set; }

        public Result result { get; set; }
    }

    public class Alert
    {
        public string AlertDate { get; set; }

        public string AlertType { get; set; }

        public long AlertDocID { get; set; }

        public string AlertSanctionMatch { get; set; }

        public long AlertID { get; set; }

        public string Cancelled { get; set; }

        public long CancelUserID { get; set; }

        public string CancelUserName { get; set; }

        public string CancelReason { get; set; }

        public string CancelDate { get; set; }

        public long AssessmentID { get; set; }

        public long ClientID { get; set; }
    }

    public class Client
    {
        public long ClientID { get; set; }

        public string clienttype { get; set; }

        public string ClientReference { get; set; }

        public string Title { get; set; }

        public string Forename { get; set; }

        public string Surname { get; set; }

        public string OtherNames { get; set; }

        public string Suffix { get; set; }

        public string PreviousName { get; set; }

        public string PreviousTitle { get; set; }

        public string PreviousForename { get; set; }

        public string PreviousSurname { get; set; }

        public string PreviousOtherNames { get; set; }

        public string PreviousSuffix { get; set; }

        public string DOB { get; set; }

        public string Gender { get; set; }

        public string Nationality { get; set; }

        public string NationalityName { get; set; }

        public string Relationship { get; set; }

        public string Interview { get; set; }

        public string CurrentAddressFlatFloor { get; set; }

        public long CurrentAddressHouseNameNumber { get; set; }

        public string CurrentAddressStreet { get; set; }

        public string CurrentAddressLocality { get; set; }

        public string CurrentAddressTown { get; set; }

        public string CurrentAddressPostcode { get; set; }

        public string CurrentAddressState { get; set; }

        public string CountryCode { get; set; }

        public string PreviousAddress { get; set; }

        public string PreviousAddressFlatFloor { get; set; }

        public string PreviousAddressHouseNameNumber { get; set; }

        public string PreviousAddressStreet { get; set; }

        public string PreviousAddressLocality { get; set; }

        public string PreviousAddressTown { get; set; }

        public string PreviousAddressPostcode { get; set; }

        public string PreviousAddressState { get; set; }

        public string PreviousCountryCode { get; set; }

        public string CountryName { get; set; }
    }

    public class Customer
    {
        public long AmlCustomerID { get; set; }

        public string CustomerName { get; set; }
    }

    public class Document
    {
        public long docid { get; set; }

        public long ClientID { get; set; }

        public string docusage { get; set; }

        public string doctype { get; set; }

        public string docdescription { get; set; }

        public string docref { get; set; }

        public string docstored { get; set; }

        public string expirydate { get; set; }

        public string expired { get; set; }

        public string verifydate { get; set; }

        public string verified { get; set; }

        public long AmlUserID { get; set; }

        public string UserName { get; set; }

        public string archived { get; set; }

        public string aentelectronic { get; set; }

        public string filename { get; set; }
    }

    public class Result
    {
        public long TransactionID { get; set; }

        public string ReportReference { get; set; }

        public string DateOfSearch { get; set; }

        public long NumIdsElectronic { get; set; }

        public long NumAdsElectronic { get; set; }

        public long NumIdsDocument { get; set; }

        public long NumIdsDocElec { get; set; }

        public string VerifiedDocs { get; set; }

        public string ElectronicStatus { get; set; }

        public string OverallStatus { get; set; }

        public string SanctionMatches { get; set; }

        public string FailError { get; set; }
    }

    #endregion
}
