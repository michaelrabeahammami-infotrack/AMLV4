namespace AMLv4_API.Aml_v4_API
{

    /// <summary>
    /// Retrieve customer and user data from Version 2 for re-reistration
    /// </summary>
    public partial class MigrationCustomerAndUserDetailsRequest
    {
        public string CustomerID { get; set; }
        public string IntegratorID { get; set; }
        public string UserID { get; set; }
    }


    public class MigrationCustomerAndUserDetailsResponse
    {
        public string error { get; set; }
        public string uri { get; set; }
        public string CustomerLoginID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string ContactTitle { get; set; }
        public string ContactForename { get; set; }
        public string ContactSurname { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPosition { get; set; }
        public string CustomerICONumber { get; set; }
        public string MLROContactName { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public string CustomerAccess { get; set; }
        public string OrgType { get; set; }
    }


}
