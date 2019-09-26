namespace AMLv4_API.Aml_v4_API
{

    /// <summary>
    /// View Customer Terms Verison and new or existing signed PDF
    /// </summary>
    public class CheckCustomerTermsVersionRequest
    {
        /// <summary>
        /// no|yes - Set to no to check terms version, yes to retrieve a copy of the terms
        /// </summary>
        public string IncludeBinary { get; set; }

        public string uri { get; set; }

        /// <summary>
        /// no|yes - Set to yes to obtain a preview of a new Terms version. Set to no to view
        /// currently agreeed version
        /// </summary>
        public string ViewingNewVersion { get; set; }
    }


    public class CheckCustomerTermsVersionResponse
    {
        public string error { get; set; }
        public string uri { get; set; }
        public string TermsBinary { get; set; }
        public string DateAccepted { get; set; }
        public string TermsVersion { get; set; }
        public string TermsVersionViewed { get; set; }
        public string AmlTermsVersionCurrent { get; set; }
        public string AmlTermsVersionNew { get; set; }
    }


}
