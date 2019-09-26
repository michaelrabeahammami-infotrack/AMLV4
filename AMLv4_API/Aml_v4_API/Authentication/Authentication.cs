namespace AMLv4_API.Aml_v4_API
{

    #region Request

    /// <summary>
    /// Authenticate and get a URI response
    /// </summary>
    public class AuthenticationRequest
    {

        public string CustomerID { get; set; }
        public string IntegratorID { get; set; }

        ///// <summary>
        ///// Optional - Used to supply Billing Reference only in this context
        ///// </summary>
        //public Options Options { get; set; }

        //public string Password { get; set; }

        ///// <summary>
        ///// Optional - Supply with auth to auto-add new users
        ///// </summary>
        //public UserData UserData { get; set; }

        public string UserID { get; set; }
    }

    /// <summary>
    /// Optional - Used to supply Billing Reference only in this context
    /// </summary>
    public class Options
    {
        public string BillingRef { get; set; }
    }

    /// <summary>
    /// Optional - Supply with auth to auto-add new users
    /// </summary>
    public partial class UserData
    {
        public string ContactEmail { get; set; }
        public string ContactForname { get; set; }
        public string ContactSurname { get; set; }
        public UserType UserType { get; set; }
        public object ContactForename { get; set; }
    }



    #endregion Request

    #region Response
    public class AuthenticationResponse
    {
        public string error { get; set; }
        public string uri { get; set; }
        public string mode { get; set; }
        public string logintype { get; set; }
        public string OrgName { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string usertype { get; set; }
        public string version { get; set; }
        public string AmlIntegratorID { get; set; }
        public string AmlCustomerID { get; set; }
        public string AmlUserID { get; set; }
        public string CustomerAccess { get; set; }
        public string CustomerStatus { get; set; }
        public string UserStatus { get; set; }
        public string CustomerLoginID { get; set; }
        public string UserLoginID { get; set; }
        public string LimitedLive { get; set; }
    }

    #endregion Response

}

