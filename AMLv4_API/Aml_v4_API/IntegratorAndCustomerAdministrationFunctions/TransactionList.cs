using Newtonsoft.Json;
using System;

namespace AMLv4_API.Aml_v4_API
{
    /// <summary>
    /// Authenticate and get a URI response
    /// </summary>
    public class TransactionListRequest
    {
        [JsonProperty("AmlCustomerID", NullValueHandling = NullValueHandling.Ignore)]
        public string AmlCustomerId { get; set; }

        [JsonProperty("AmlUserID", NullValueHandling = NullValueHandling.Ignore)]
        public string AmlUserId { get; set; }

        [JsonProperty("BillingRef", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingRef { get; set; }

        [JsonProperty("ClientID", NullValueHandling = NullValueHandling.Ignore)]
        public long? ClientId { get; set; }

        /// <summary>
        /// YYYY-MM-DD filter list by start date
        /// </summary>
        [JsonProperty("EndDate", NullValueHandling = NullValueHandling.Ignore)]
        public string EndDate { get; set; }

        /// <summary>
        /// YYYY-MM-DD filter list by start date
        /// </summary>
        [JsonProperty("StartDate", NullValueHandling = NullValueHandling.Ignore)]
        public string StartDate { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class TransactionListResponse : Amlv4BaseResponse
    {
        [JsonProperty("numtrans")]
        public long Numtrans { get; set; }

        [JsonProperty("trans")]
        public Tran[] Trans { get; set; }
    }

    public class Tran
    {
        [JsonProperty("TransactionsID")]
        public long TransactionsId { get; set; }

        [JsonProperty("TransactionDate")]
        public DateTime TransactionDate { get; set; }

        [JsonProperty("NetAmount")]
        public string NetAmount { get; set; }

        [JsonProperty("VatAmount")]
        public string VatAmount { get; set; }

        [JsonProperty("GrossAmount")]
        public string GrossAmount { get; set; }

        [JsonProperty("DisplayNetAmount")]
        public string DisplayNetAmount { get; set; }

        [JsonProperty("AmlProductID")]
        public long AmlProductId { get; set; }

        [JsonProperty("ProductName")]
        public string ProductName { get; set; }

        [JsonProperty("Summary")]
        public string Summary { get; set; }

        [JsonProperty("AssessmentID")]
        public long AssessmentId { get; set; }

        [JsonProperty("ClientID")]
        public long ClientId { get; set; }

        [JsonProperty("ClientReference")]
        public string ClientReference { get; set; }

        [JsonProperty("AmlUserID")]
        public long AmlUserId { get; set; }

        [JsonProperty("UserLoginID")]
        public string UserLoginId { get; set; }

        [JsonProperty("UserName")]
        public string UserName { get; set; }

        [JsonProperty("AmlCustomerID")]
        public long AmlCustomerId { get; set; }

        [JsonProperty("CustomerLoginID")]
        public string CustomerLoginId { get; set; }

        [JsonProperty("CustomerName")]
        public string CustomerName { get; set; }

        [JsonProperty("BillingRef")]
        public string BillingRef { get; set; }

        [JsonProperty("Transactionuri")]
        public string Transactionuri { get; set; }

        [JsonProperty("HasInvoice")]
        public string HasInvoice { get; set; }
    }
}
