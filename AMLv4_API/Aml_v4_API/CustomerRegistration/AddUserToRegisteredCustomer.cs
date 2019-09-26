namespace AMLv4_API.Aml_v4_API
{
    public partial class AddUserToRegisteredCustomerRequest
    {
        /// <summary>
        /// Use if authorised as an Integrator, otherwise authorise as customer to add to
        /// </summary>
        public string AmlCustomerID { get; set; }

        public string ContactEmail { get; set; }
        public string ContactForename { get; set; }
        public string ContactSurname { get; set; }

        /// <summary>
        /// Additional rights (MO=Management Oversight, MOD=MO for Document Expiry Alert only)
        /// </summary>
        public string ServicesAvailable { get; set; }

        public string uri { get; set; }
        public string UserLoginID { get; set; }
        public string UserType { get; set; }
    }

    /// <summary>
    /// Additional rights (MO=Management Oversight, MOD=MO for Document Expiry Alert only)
    /// </summary>
    public class ServicesAvailable
    {
        public const string Empty = "";
        public const string MO = "MO";
        public const string MOD = "MOD";
    }

    public class AddUserToRegisteredCustomerResponse
    {
        public string error { get; set; }
        public string uri { get; set; }
        public string AmlUserID { get; set; }
        public string AmlCustomerID { get; set; }
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
