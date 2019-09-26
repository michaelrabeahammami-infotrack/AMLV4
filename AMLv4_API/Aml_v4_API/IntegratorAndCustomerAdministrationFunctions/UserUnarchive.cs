namespace AMLv4_API.Aml_v4_API.IntegratorAndCustomerAdministrationFunctions
{
    /// <summary>
    /// Anarchive User (re-enable auth)
    /// </summary>
    public class UserUnarchiveRequest
    {
        public string AmlUserID { get; set; }
    }

    public class UserUnarchiveResponse
    {
        public string error { get; set; }
        public string uri { get; set; }
        public long AmlUserID { get; set; }
        public long AmlCustomerID { get; set; }
        public string UserLoginID { get; set; }
        public string ContactTitle { get; set; }
        public string ContactForename { get; set; }
        public string ContactSurname { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPosition { get; set; }
        public string UserType { get; set; }
        public string ServicesAvailable { get; set; }
        public string Archived { get; set; }
    }
}
