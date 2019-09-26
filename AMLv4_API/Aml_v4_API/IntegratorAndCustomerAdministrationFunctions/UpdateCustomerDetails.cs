﻿namespace AMLv4_API.Aml_v4_API.IntegratorAndCustomerAdministrationFunctions
{
    /// <summary>
    /// Update Customer Details
    /// </summary>
    public class UpdateCustomerDetailsRequest
    {
        public AllowOtherDocs? AllowOtherDocs { get; set; }
        public string AmlCustomerID { get; set; }
        public string ContactEmail { get; set; }
        public string ContactForename { get; set; }
        public string ContactPosition { get; set; }
        public string ContactSurname { get; set; }
        public string ContactTitle { get; set; }
        public CustomerAccess? CustomerAccess { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerIcoNumber { get; set; }
        public string CustomerName { get; set; }
        public string Fax { get; set; }
        public string MlroContactEmail { get; set; }
        public string MlroContactName { get; set; }
        public string MlroContactPosition { get; set; }
        public OrgType OrgType { get; set; }
        public string Telephone { get; set; }
        public string Uri { get; set; }
    }

    public class UpdateCustomerDetailsResponse
    {
        public string error { get; set; }
        public string uri { get; set; }
        public long AmlCustomerID { get; set; }
        public string CustomerLoginId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string ContactTitle { get; set; }
        public string ContactForename { get; set; }
        public string ContactSurname { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPosition { get; set; }
        public long CustomerICONumber { get; set; }
        public string MlroContactName { get; set; }
        public string MlroContactEmail { get; set; }
        public string MlroContactPosition { get; set; }
        public long Telephone { get; set; }
        public string Fax { get; set; }
        public string CustomerAccess { get; set; }
        public string AllowOtherDocs { get; set; }
        public string OrgType { get; set; }
        public string CustomerStatus { get; set; }
        public string Archived { get; set; }
    }

}
