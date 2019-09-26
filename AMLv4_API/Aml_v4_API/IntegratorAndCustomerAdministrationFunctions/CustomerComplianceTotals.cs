namespace AMLv4_API.Aml_v4_API.IntegratorAndCustomerAdministrationFunctions
{
    public class CustomerComplianceTotalsRequest
    {
        public string AmlCustomerID { get; set; }
        public string AmlUserID { get; set; }
        public ClientType? ClientType { get; set; }
        public string EndDate { get; set; }
        public IncludeArchived? IncludeArchived { get; set; }
        public string StartDate { get; set; }
        public string Uri { get; set; }
    }

    public class CustomerComplianceTotalsResponse
    {
        public string error { get; set; }
        public string uri { get; set; }
        public long NumTotal { get; set; }
        public long NumComplete { get; set; }
        public long NumCompliant { get; set; }
        public long NumNonCompliant { get; set; }
        public long NumPending { get; set; }
        public long PercentCompliant { get; set; }
        public long PercentNonCompliant { get; set; }
        public long PercentPending { get; set; }
        public long NumAlerts { get; set; }
    }


}
