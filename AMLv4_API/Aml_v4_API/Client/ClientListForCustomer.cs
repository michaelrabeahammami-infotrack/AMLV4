namespace AMLv4_API.Aml_v4_API
{
    public class ClientListForCustomerRequest
    {
        /// <summary>
        /// Type of Client, personal or nonpersonal
        /// </summary>
        public Clienttype? clienttypefilter { get; set; }

        public string uri { get; set; }
    }

    public class ClientListForCustomerResponse
    {
        public string error { get; set; }
        public string uri { get; set; }
        public long clientcount { get; set; }
        public Client[] clients { get; set; }
    }
}
