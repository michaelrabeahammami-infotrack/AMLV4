namespace AMLv4_API.Aml_v4_API
{
    /// <summary>
    /// List available Customers to Migrate
    /// </summary>
    public partial class MigrationListRequest
    {
        public string IntegratorID { get; set; }
    }


    public class MigrationListResponse
    {
        public string error { get; set; }
        public string customercount { get; set; }
        public Customer[] customers { get; set; }
    }

    public class Customer
    {
        public string LoginName { get; set; }
        public string OrgName { get; set; }
        public string Address { get; set; }
        public string Postcode { get; set; }
        public string RegistrationDate { get; set; }
        public string CustomerAccess { get; set; }
        public string CustomerStatus { get; set; }
        public string UserLoginName { get; set; }
    }


}
