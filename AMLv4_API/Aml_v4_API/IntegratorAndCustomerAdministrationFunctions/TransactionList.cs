namespace AMLv4_API.Aml_v4_API.IntegratorAndCustomerAdministrationFunctions
{
    /// <summary>
    /// Authenticate and get a URI response
    /// </summary>
    public class TransactionListRequest
    {
        public string AmlCustomerID { get; set; }
        public string AmlUserID { get; set; }
        public string BillingRef { get; set; }
        public long? ClientID { get; set; }

        /// <summary>
        /// YYYY-MM-DD filter list by start date
        /// </summary>
        public string EndDate { get; set; }

        /// <summary>
        /// YYYY-MM-DD filter list by start date
        /// </summary>
        public string StartDate { get; set; }

        public string uri { get; set; }
    }

    public class TransactionListResponse
    {
        public string error { get; set; }
        public string uri { get; set; }
        public long numtrans { get; set; }
        public Tran[] trans { get; set; }
    }

    public class Tran
    {
        public long TransactionsID { get; set; }
        public string TransactionDate { get; set; }
        public string NetAmount { get; set; }
        public string VatAmount { get; set; }
        public string GrossAmount { get; set; }
        public string DisplayNetAmount { get; set; }
        public long AmlProductID { get; set; }
        public string ProductName { get; set; }
        public string Summary { get; set; }
        public long AssessmentID { get; set; }
        public long ClientID { get; set; }
        public string ClientReference { get; set; }
        public long AmlUserID { get; set; }
        public string UserLoginId { get; set; }
        public string UserName { get; set; }
        public long AmlCustomerID { get; set; }
        public string CustomerLoginID { get; set; }
        public string CustomerName { get; set; }
        public string BillingRef { get; set; }
        public string Transactionuri { get; set; }
        public string HasInvoice { get; set; }
    }

}
