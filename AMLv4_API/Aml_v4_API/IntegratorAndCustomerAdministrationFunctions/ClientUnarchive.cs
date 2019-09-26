namespace AMLv4_API.Aml_v4_API.IntegratorAndCustomerAdministrationFunctions
{
    /// <summary>
    /// Un-Archive client record and re-enable ongoing monitoring
    /// </summary>
    public class ClientUnarchiveRequest
    {
        public string ClientID { get; set; }
        public string uri { get; set; }
    }
    public class ClientUnarchiveResponse
    {
        public string error { get; set; }
        public string uri { get; set; }
        public long ClientID { get; set; }
        public string Archived { get; set; }
    }

}
