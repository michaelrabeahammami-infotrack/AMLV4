namespace AMLv4_API.Aml_v4_API.IntegratorAndCustomerAdministrationFunctions
{
    /// <summary>
    /// Archive client record and disable ongoing monitoring
    /// </summary>
    public class ClientArchiveRequest
    {
        public string ClientID { get; set; }
        public string uri { get; set; }
    }

    public class ClientArchiveResponse
    {
        public string error { get; set; }
        public string uri { get; set; }
        public long ClientID { get; set; }
        public string Archived { get; set; }
    }
}
