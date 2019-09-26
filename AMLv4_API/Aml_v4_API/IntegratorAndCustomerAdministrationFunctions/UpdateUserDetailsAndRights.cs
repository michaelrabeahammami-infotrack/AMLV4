namespace AMLv4_API.Aml_v4_API.IntegratorAndCustomerAdministrationFunctions
{
    /// <summary>
    /// Update User details / rights
    /// </summary>
    public class UpdateUserDetailsAndRightsRequest
    {
        public string AmlUserID { get; set; }
        public string ContactEmail { get; set; }
        public string ContactForname { get; set; }
        public string ContactPosition { get; set; }
        public string ContactSurname { get; set; }
        public string ContactTitle { get; set; }

        /// <summary>
        /// Additional rights (MO=Management Oversight, MOD=MO for Document Expiry Alert only)
        /// </summary>
        public ServicesAvailable ServicesAvailable { get; set; }

        /// <summary>
        /// Main access level
        /// </summary>
        public UserType UserType { get; set; }

        public object ContactForename { get; set; }
    }

    public partial class UpdateUserDetailsAndRightsResponse
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
