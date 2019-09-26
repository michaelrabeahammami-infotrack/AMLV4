namespace AMLv4_API.Aml_v4_API.IntegratorOnlyAdministratorFunctions
{
    /// <summary>
    /// List all integrators customers
    /// </summary>
    public class CustomerListRequest
    {
        public string uri { get; set; }
    }

    public class CustomerListResponse
    {
        public string error { get; set; }
        public string uri { get; set; }
        public long customercount { get; set; }
        public Customer[] customers { get; set; }
    }

    public class Customer
    {
        public long AmlCustomerID { get; set; }
        public string LoginName { get; set; }
        public string OrgName { get; set; }
        public string Address { get; set; }
        public string Postcode { get; set; }
        public string RegistrationDate { get; set; }
        public string CustomerAccess { get; set; }
        public string CustomerStatus { get; set; }
    }

}
