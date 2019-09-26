namespace AMLv4_API.Aml_v4_API.IntegratorAndCustomerAdministrationFunctions
{
    /// <summary>
    /// List Users for Customer
    /// </summary>
    public class UserListRequest
    {
        public string AmlCustomerID { get; set; }
        public string uri { get; set; }
    }

    public class UserListResponse
    {
        public string error { get; set; }
        public string uri { get; set; }
        public long usercount { get; set; }
        public User[] users { get; set; }
    }

    public class User
    {
        public long AmlUserID { get; set; }
        public string LoginName { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string UserType { get; set; }
        public string ServicesAvailable { get; set; }
        public string Archived { get; set; }
    }


}
