namespace AMLv4_API.Aml_v4_API.IntegratorOnlyAdministratorFunctions
{
    /// <summary>
    /// Archive a Customer (disables authorisation)
    /// </summary>
    public class CustomerArchiveRequest
    {
        public string AmlCustomerID { get; set; }
        public string uri { get; set; }
    }

    public class CustomerArchiveResponse
    {
        public string error { get; set; }
        public string uri { get; set; }
        public long AmlCustomerID { get; set; }
        public string CustomerLoginID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string ContactTitle { get; set; }
        public string ContactForename { get; set; }
        public string ContactSurname { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPosition { get; set; }
        public long CustomerICONumber { get; set; }
        public string MlroContactName { get; set; }
        public string MlroContactEmail { get; set; }
        public string MlroContactPosition { get; set; }
        public long Telephone { get; set; }
        public string Fax { get; set; }
        public string CustomerAccess { get; set; }
        public string AllowOtherDocs { get; set; }
        public string OrgType { get; set; }
        public string CustomerStatus { get; set; }
        public string Archived { get; set; }
    }
}
