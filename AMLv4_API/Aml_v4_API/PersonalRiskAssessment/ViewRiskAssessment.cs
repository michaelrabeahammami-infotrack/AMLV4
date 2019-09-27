using Newtonsoft.Json;
using System;

namespace AMLv4_API.Aml_v4_API
{
    /// <summary>
    /// View Assessment Details before or after running
    /// </summary>
    public class ViewRiskAssessmentRequest
    {
        [JsonProperty("AssessmentID")]
        public string AssessmentId { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class ViewRiskAssessmentResponse
    {
        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("AssessmentID")]
        public long AssessmentId { get; set; }

        [JsonProperty("ClientID")]
        public long ClientId { get; set; }

        [JsonProperty("AmlUserID")]
        public long AmlUserId { get; set; }

        [JsonProperty("AmlCustomerID")]
        public long AmlCustomerId { get; set; }

        [JsonProperty("clienttype")]
        public string Clienttype { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("assessmenttype")]
        public string Assessmenttype { get; set; }

        [JsonProperty("profileid")]
        public long Profileid { get; set; }

        [JsonProperty("profilename")]
        public string Profilename { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("DisplayPrice")]
        public string DisplayPrice { get; set; }

        [JsonProperty("Price")]
        public string Price { get; set; }

        [JsonProperty("Archived")]
        public string Archived { get; set; }

        [JsonProperty("Locked")]
        public string Locked { get; set; }

        [JsonProperty("client")]
        public Client Client { get; set; }

        [JsonProperty("numdocuments")]
        public long Numdocuments { get; set; }

        [JsonProperty("documents")]
        public Document[] Documents { get; set; }

        [JsonProperty("numrelationships")]
        public long Numrelationships { get; set; }

        [JsonProperty("relationships")]
        public Relationship[] Relationships { get; set; }

        [JsonProperty("numalerts")]
        public long Numalerts { get; set; }

        [JsonProperty("alerts")]
        public Alert[] Alerts { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("customer")]
        public Customer Customer { get; set; }

        [JsonProperty("Result")]
        public Result Result { get; set; }
    }

    public class Alert
    {
        [JsonProperty("AlertDate")]
        public DateTime AlertDate { get; set; }

        [JsonProperty("AlertType")]
        public string AlertType { get; set; }

        [JsonProperty("AlertDocID")]
        public long AlertDocId { get; set; }

        [JsonProperty("AlertSanctionMatch")]
        public string AlertSanctionMatch { get; set; }

        [JsonProperty("AlertID")]
        public long AlertId { get; set; }

        [JsonProperty("Cancelled")]
        public string Cancelled { get; set; }

        [JsonProperty("CancelUserID")]
        public long CancelUserId { get; set; }

        [JsonProperty("CancelUserName")]
        public string CancelUserName { get; set; }

        [JsonProperty("CancelReason")]
        public string CancelReason { get; set; }

        [JsonProperty("CancelDate")]
        public DateTime CancelDate { get; set; }

        [JsonProperty("AssessmentID")]
        public long AssessmentId { get; set; }

        [JsonProperty("ClientID")]
        public long ClientId { get; set; }
    }

    public class Document
    {
        [JsonProperty("docid")]
        public long Docid { get; set; }

        [JsonProperty("ClientID")]
        public long ClientId { get; set; }

        [JsonProperty("docusage")]
        public string Docusage { get; set; }

        [JsonProperty("doctype")]
        public string Doctype { get; set; }

        [JsonProperty("docdescription")]
        public string Docdescription { get; set; }

        [JsonProperty("docref")]
        public string Docref { get; set; }

        [JsonProperty("docstored")]
        public string Docstored { get; set; }

        [JsonProperty("expirydate")]
        public DateTime Expirydate { get; set; }

        [JsonProperty("expired")]
        public string Expired { get; set; }

        [JsonProperty("verifydate")]
        public DateTime Verifydate { get; set; }

        [JsonProperty("verified")]
        public string Verified { get; set; }

        [JsonProperty("AmlUserID")]
        public long AmlUserId { get; set; }

        [JsonProperty("UserName")]
        public string UserName { get; set; }

        [JsonProperty("archived")]
        public string Archived { get; set; }

        [JsonProperty("sentelectronic")]
        public string Sentelectronic { get; set; }

        [JsonProperty("filename")]
        public string Filename { get; set; }
    }

    public class Result
    {
        [JsonProperty("TransactionID")]
        public long TransactionId { get; set; }

        [JsonProperty("ReportReference")]
        public string ReportReference { get; set; }

        [JsonProperty("DateOfSearch")]
        public DateTimeOffset DateOfSearch { get; set; }

        [JsonProperty("NumIdsElectronic")]
        public long NumIdsElectronic { get; set; }

        [JsonProperty("NumAdsElectronic")]
        public long NumAdsElectronic { get; set; }

        [JsonProperty("NumIdsDocument")]
        public long NumIdsDocument { get; set; }

        [JsonProperty("NumIdsDocElec")]
        public long NumIdsDocElec { get; set; }

        [JsonProperty("VerifiedDocs")]
        public string VerifiedDocs { get; set; }

        [JsonProperty("ElectronicStatus")]
        public string ElectronicStatus { get; set; }

        [JsonProperty("OverallStatus")]
        public string OverallStatus { get; set; }

        [JsonProperty("SanctionMatches")]
        public string SanctionMatches { get; set; }

        [JsonProperty("FailError")]
        public string FailError { get; set; }
    }

    public class User
    {
        [JsonProperty("AmlUserID")]
        public long AmlUserId { get; set; }

        [JsonProperty("ContactForename")]
        public string ContactForename { get; set; }

        [JsonProperty("ContactSurname")]
        public string ContactSurname { get; set; }
    }
}