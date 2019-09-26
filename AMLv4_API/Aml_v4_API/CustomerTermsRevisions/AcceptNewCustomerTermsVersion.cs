namespace AMLv4_API.Aml_v4_API
{
    /// <summary>
    /// Accept new version of customer terms. The version stored for the customer will be updated
    /// to the latest.
    /// </summary>
    public partial class AcceptNewCustomerTermsVersionRequest
    {
        public string uri { get; set; }
    }

    public class AcceptNewCustomerTermsVersionResponse
    {
        public string error { get; set; }
        public string uri { get; set; }
        public string DateAccepted { get; set; }
        public string TermsVersion { get; set; }
        public string TermsVersionViewed { get; set; }
        public string AmlTermsVersionCurrent { get; set; }
        public string AmlTermsVersionNew { get; set; }
    }



}
