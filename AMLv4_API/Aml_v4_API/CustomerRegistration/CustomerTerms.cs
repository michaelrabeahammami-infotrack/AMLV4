namespace AMLv4_API.Aml_v4_API
{
    public class CustomerTermsRequest
    {
        public string ContactEmail { get; set; }
        public string ContactForename { get; set; }
        public string ContactPosition { get; set; }
        public string ContactSurname { get; set; }
        public string ContactTitle { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerName { get; set; }
        public string uri { get; set; }
    }


    public class CustomerTermsResponse
    {
        public string error { get; set; }
        public string uri { get; set; }
        public string TermsBinary { get; set; }
        public string TermsVersion { get; set; }
        public string TermsVersionViewed { get; set; }
        public string AmlTermsVersionCurrent { get; set; }
        public string AmlTermsVersionNew { get; set; }
    }

}
