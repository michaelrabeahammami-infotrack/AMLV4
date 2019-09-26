namespace AMLv4_API.Aml_v4_API.Client
{
    public class ClientListForCustomerRequest
    {
        /// <summary>
        /// Type of Client, personal or nonpersonal
        /// </summary>
        public Clienttypefilter? clienttypefilter { get; set; }

        public string uri { get; set; }
    }

    /// <summary>
    /// Type of Client, personal or nonpersonal
    /// </summary>
    public enum Clienttypefilter { nonpersonal, personal };

    public class ClientListForCustomerResponse
    {
        public string error { get; set; }
        public string uri { get; set; }
        public long clientcount { get; set; }
        public Client[] clients { get; set; }
    }

    public class Client
    {
        public long ClientID { get; set; }
        public string Clienttype { get; set; }
        public long ClientReference { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public string DOB { get; set; }
        public string CurrentAddressPostcode { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public string ComplianceStatus { get; set; }
        public string Archived { get; set; }
        public string DateCreated { get; set; }
        public string DateUpdated { get; set; }
        public long AlertCount { get; set; }
        public string CompanyName { get; set; }
        public long? CompanyNo { get; set; }
    }

}
