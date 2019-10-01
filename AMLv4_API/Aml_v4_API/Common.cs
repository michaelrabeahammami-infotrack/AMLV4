using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Runtime.Serialization;

namespace AMLv4_API.Aml_v4_API
{
    #region Classes

    #region Profile
    public class Profile
    {
        [JsonProperty("profileid")]
        public string Profileid { get; set; }

        [JsonProperty("profilename")]
        public string Profilename { get; set; }

        [JsonProperty("profilestatus")]
        public string Profilestatus { get; set; }

        [JsonProperty("profiletype")]
        public string Profiletype { get; set; }

        [JsonProperty("profilecreated")]
        public DateTime Profilecreated { get; set; }

        [JsonProperty("profileorigin")]
        public string Profileorigin { get; set; }
    }
    #endregion

    #region Client
    public class Client
    {
        [JsonProperty("ClientID")]
        public long ClientId { get; set; }

        [JsonProperty("clienttype")]
        public string Clienttype { get; set; }

        [JsonProperty("ClientReference")]
        public string ClientReference { get; set; }

        [JsonProperty("Title")]
        public string Title { get; set; }

        [JsonProperty("Forename")]
        public string Forename { get; set; }

        [JsonProperty("Surname")]
        public string Surname { get; set; }

        [JsonProperty("OtherNames")]
        public string OtherNames { get; set; }

        [JsonProperty("Suffix")]
        public string Suffix { get; set; }

        [JsonProperty("PreviousName")]
        public string PreviousName { get; set; }

        [JsonProperty("PreviousTitle")]
        public string PreviousTitle { get; set; }

        [JsonProperty("PreviousForename")]
        public string PreviousForename { get; set; }

        [JsonProperty("PreviousSurname")]
        public string PreviousSurname { get; set; }

        [JsonProperty("PreviousOtherNames")]
        public string PreviousOtherNames { get; set; }

        [JsonProperty("PreviousSuffix")]
        public string PreviousSuffix { get; set; }

        [JsonProperty("DOB")]
        public DateTimeOffset Dob { get; set; }

        [JsonProperty("Gender")]
        public string Gender { get; set; }

        [JsonProperty("Nationality")]
        public string Nationality { get; set; }

        [JsonProperty("NationalityName")]
        public string NationalityName { get; set; }

        [JsonProperty("Relationship")]
        public string Relationship { get; set; }

        [JsonProperty("Interview")]
        public string Interview { get; set; }

        [JsonProperty("CurrentAddressFlatFloor")]
        public string CurrentAddressFlatFloor { get; set; }

        [JsonProperty("CurrentAddressHouseNameNumber")]
        public long CurrentAddressHouseNameNumber { get; set; }

        [JsonProperty("CurrentAddressStreet")]
        public string CurrentAddressStreet { get; set; }

        [JsonProperty("CurrentAddressLocality")]
        public string CurrentAddressLocality { get; set; }

        [JsonProperty("CurrentAddressTown")]
        public string CurrentAddressTown { get; set; }

        [JsonProperty("CurrentAddressPostcode")]
        public string CurrentAddressPostcode { get; set; }

        [JsonProperty("CurrentAddressState")]
        public string CurrentAddressState { get; set; }

        [JsonProperty("CountryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("PreviousAddress")]
        public string PreviousAddress { get; set; }

        [JsonProperty("PreviousAddressFlatFloor")]
        public string PreviousAddressFlatFloor { get; set; }

        [JsonProperty("PreviousAddressHouseNameNumber")]
        public string PreviousAddressHouseNameNumber { get; set; }

        [JsonProperty("PreviousAddressStreet")]
        public string PreviousAddressStreet { get; set; }

        [JsonProperty("PreviousAddressLocality")]
        public string PreviousAddressLocality { get; set; }

        [JsonProperty("PreviousAddressTown")]
        public string PreviousAddressTown { get; set; }

        [JsonProperty("PreviousAddressPostcode")]
        public string PreviousAddressPostcode { get; set; }

        [JsonProperty("PreviousAddressState")]
        public string PreviousAddressState { get; set; }

        [JsonProperty("PreviousCountryCode")]
        public string PreviousCountryCode { get; set; }

        [JsonProperty("CountryName")]
        public string CountryName { get; set; }

        [JsonProperty("ComplianceStatus")]
        public string ComplianceStatus { get; set; }

        [JsonProperty("Archived")]
        public string Archived { get; set; }

        [JsonProperty("DateCreated")]
        public string DateCreated { get; set; }

        [JsonProperty("DateUpdated")]
        public string DateUpdated { get; set; }

        [JsonProperty("AlertCount")]
        public long AlertCount { get; set; }

        [JsonProperty("CompanyName")]
        public string CompanyName { get; set; }

        [JsonProperty("CompanyNo")]
        public long? CompanyNo { get; set; }

        [JsonProperty("JurisdictionCode")]
        public string JurisdictionCode { get; set; }

        [JsonProperty("CompanyNoDisplay")]
        public string CompanyNoDisplay { get; set; }

        [JsonProperty("CompanyType")]
        public string CompanyType { get; set; }

        [JsonProperty("CompanyStatus")]
        public string CompanyStatus { get; set; }

        [JsonProperty("RegisteredAddress")]
        public string RegisteredAddress { get; set; }

        [JsonProperty("InceptionDate")]
        public string InceptionDate { get; set; }

        [JsonProperty("CompanyIntroducer")]
        public string CompanyIntroducer { get; set; }
    }
    #endregion

    #region RelationShip
    public class Relationship
    {
        [JsonProperty("RelationshipID")]
        public long RelationshipId { get; set; }

        [JsonProperty("RelatedClientID")]
        public long RelatedClientId { get; set; }

        [JsonProperty("Relationship")]
        public string RelationshipRelationship { get; set; }

        [JsonProperty("clienttype")]
        public string Clienttype { get; set; }

        [JsonProperty("Forename")]
        public string Forename { get; set; }

        [JsonProperty("Surname")]
        public string Surname { get; set; }

        [JsonProperty("DOB")]
        public DateTime Dob { get; set; }

        [JsonProperty("CurrentAddressPostcode")]
        public string CurrentAddressPostcode { get; set; }

        [JsonProperty("CountryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("ComplianceStatus")]
        public string ComplianceStatus { get; set; }

        [JsonProperty("Archived")]
        public string Archived { get; set; }
    }
    #endregion

    #region Customer
    public class Customer
    {
        [JsonProperty("AmlCustomerID")]
        public long AmlCustomerId { get; set; }

        [JsonProperty("CustomerName")]
        public string CustomerName { get; set; }

        [JsonProperty("LoginName")]
        public string LoginName { get; set; }

        [JsonProperty("OrgName")]
        public string OrgName { get; set; }

        [JsonProperty("Address")]
        public string Address { get; set; }

        [JsonProperty("Postcode")]
        public string Postcode { get; set; }

        [JsonProperty("RegistrationDate")]
        public DateTime RegistrationDate { get; set; }

        [JsonProperty("CustomerAccess")]
        public string CustomerAccess { get; set; }

        [JsonProperty("CustomerStatus")]
        public string CustomerStatus { get; set; }

        [JsonProperty("UserLoginName")]
        public string UserLoginName { get; set; }
    }
    #endregion

    #region Document
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
    #endregion

    #region Result
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
    #endregion

    #region User
    public class User
    {
        [JsonProperty("AmlUserID")]
        public long AmlUserId { get; set; }

        [JsonProperty("ContactForename")]
        public string ContactForename { get; set; }

        [JsonProperty("ContactSurname")]
        public string ContactSurname { get; set; }
    }
    #endregion

    #region Alert
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

        [JsonProperty("CustomerID")]
        public string CustomerId { get; set; }

        [JsonProperty("ClientSummary")]
        public string ClientSummary { get; set; }

        [JsonProperty("ClientReference")]
        public string ClientReference { get; set; }

        [JsonProperty("AmlUserID")]
        public long AmlUserId { get; set; }

        [JsonProperty("AmlCustomerID")]
        public long AmlCustomerId { get; set; }

        [JsonProperty("AmlIntegratorID")]
        public long AmlIntegratorId { get; set; }
    }
    #endregion

    #region Rule
    public class Rule
    {
        [JsonProperty("ruleid")]
        public long Ruleid { get; set; }

        [JsonProperty("rulestatus")]
        public string Rulestatus { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }
    }
    #endregion
    
    #endregion

    #region Enums
    public enum CustomerAccess
    {
        [EnumMember(Value = "sub-both")]
        SubBoth,
        [EnumMember(Value = "sub-simple")]
        SubSimple,
        [EnumMember(Value = "transactional")]
        Transactional
    };

    public enum OrgType
    {
        [EnumMember(Value = "accountant")]
        Accountant,
        [EnumMember(Value = "casino")]
        Casino,
        [EnumMember(Value = "estateagent")]
        Estateagent,
        [EnumMember(Value = "highvaluedealer")]
        Highvaluedealer,
        [EnumMember(Value = "insolvencypractitioner")]
        Insolvencypractitioner,
        [EnumMember(Value = "other")]
        Other,
        [EnumMember(Value = "solicitor")]
        Solicitor,
        [EnumMember(Value = "trustorcompanyserviceprovider")]
        Trustorcompanyserviceprovider
    };

    public enum TermsAccepted
    {
        [EnumMember(Value = "yes")]
        Yes
    };

    /// <summary>
    /// Additional rights (MO=Management Oversight, MOD=MO for Document Expiry Alert only)
    /// </summary>
    public enum ServicesAvailable 
    {
        [EnumMember(Value = "")]
        Empty,
        [EnumMember(Value = "MO")]
        Mo,
        [EnumMember(Value = "MOD")]
        Mod 
    };

    public enum UserType 
    {
        [EnumMember(Value = "admin")]
        Admin,
        [EnumMember(Value = "user")]
        User 
    };
    /// <summary>
    /// no|yes - Set to yes to obtain a preview of a new Terms version. Set to no to view
    /// currently agreeed version
    /// </summary>
    public enum IncludeBinary 
    {
        [EnumMember(Value = "no")]
        No,
        [EnumMember(Value = "yes")]
        Yes 
    };

    /// <summary>
    /// Optional upload a document copy
    /// </summary>
    public enum Includebinary
    {
        [EnumMember(Value = "no")]
        No,
        [EnumMember(Value = "yes")]
        Yes
    };

    public enum InterviewValue 
    {
        [EnumMember(Value = "")]
        Empty,
        [EnumMember(Value = "home")]
        Home,
        [EnumMember(Value = "person")]
        Person,
        [EnumMember(Value = "phone")]
        Phone 
    };

    public enum ProfileOverride 
    {
        [EnumMember(Value = "")]
        Empty,
        [EnumMember(Value = "enhanced")]
        Enhanced,
        [EnumMember(Value = "simplified")]
        Simplified 
    };

    public enum Profiletype 
    {
        [EnumMember(Value = "nonpersonal")]
        Nonpersonal,
        [EnumMember(Value = "personal")]
        Personal
    };

    public enum RelationshipValue 
    {
        [EnumMember(Value = "existing")]
        Existing,
        [EnumMember(Value = "new")]
        New,
        [EnumMember(Value = "newknown")]
        Newknown,
        [EnumMember(Value = "")]
        Empty
    };

    public enum AssessmentType 
    {
        [EnumMember(Value = "enhanced")]
        Enhanced,
        [EnumMember(Value = "simplified")]
        Simplified 
    };

    public enum Clienttype 
    {
        [EnumMember(Value = "personal")]
        Personal,
        [EnumMember(Value = "nonpersonal")]
        NonPersonal 
    };

    public enum Compliance 
    {
        [EnumMember(Value = "yes")]
        Yes 
    };

    public enum Gender 
    {
        [EnumMember(Value = "Female")]
        Female,
        [EnumMember(Value = "Male")]
        Male,
        [EnumMember(Value = "Non-binary")]
        NonBinary,
        [EnumMember(Value = "Not Disclosed")]
        NotDisclosed 
    };

    public enum Interview 
    {
        [EnumMember(Value = "home")]
        Home,
        [EnumMember(Value = "person")]
        Person,
        [EnumMember(Value = "phone")]
        Phone,
        [EnumMember(Value = "existing")]
        Existing,
        [EnumMember(Value = "marketing")]
        Marketing,
        [EnumMember(Value = "other")]
        Other,
        [EnumMember(Value = "referral")]
        Referral,
        [EnumMember(Value = "viaexisting")]
        Viaexisting
    };

    public enum Previous 
    {
        [EnumMember(Value = "no")]
        No,
        [EnumMember(Value = "yes")]
        Yes 
    };

    public enum IsNewRelationship
    {
        [EnumMember(Value = "existing")]
        Existing,
        [EnumMember(Value = "new")]
        New,
        [EnumMember(Value = "newknown")]
        Newknown 
    };

    public enum Error 
    {
        [EnumMember(Value = "no")]
        No,
        [EnumMember(Value = "yes")]
        Yes 
    };

    public enum Electronic 
    {
        [EnumMember(Value = "no")]
        No,
        [EnumMember(Value = "yes")]
        Yes
    };

    public enum DocumentCode
    {
        [EnumMember(Value = "uk_passport")]
        uk_passport,
        [EnumMember(Value = "paper_driving_licence")]
        paper_driving_licence,
        [EnumMember(Value = "firearms_cert")]
        firearms_cert,
        [EnumMember(Value = "ni_card_and_p60")]
        ni_card_and_p60,
        [EnumMember(Value = "revenue_document")]
        revenue_document,
        [EnumMember(Value = "bank_statement")]
        bank_statement,
        [EnumMember(Value = "bank_card_statement")]
        bank_card_statement,
        [EnumMember(Value = "eu_state_id_card")]
        eu_state_id_card,
        [EnumMember(Value = "council_tax")]
        council_tax,
        [EnumMember(Value = "photo_driving_licence")]
        photo_driving_licence,
        [EnumMember(Value = "tax_credit")]
        tax_credit,
        [EnumMember(Value = "state_pension")]
        state_pension,
        [EnumMember(Value = "housing_benefit")]
        housing_benefit,
        [EnumMember(Value = "national_id_card_nonuk")]
        national_id_card_nonuk,
        [EnumMember(Value = "ni_er_id_card")]
        ni_er_id_card,
        [EnumMember(Value = "grant")]
        grant,
        [EnumMember(Value = "court_appointment")]
        court_appointment,
        [EnumMember(Value = "nonuk_passport")]
        nonuk_passport,
        [EnumMember(Value = "personal_id_no")]
        personal_id_no,
        [EnumMember(Value = "travel_document")]
        travel_document,
        [EnumMember(Value = "residence_permit")]
        residence_permit,
        [EnumMember(Value = "identity_cert_no")]
        identity_cert_no,
        [EnumMember(Value = "reg_fed_de_cont")]
        reg_fed_de_cont,
        [EnumMember(Value = "cred_de_elector")]
        cred_de_elector,
        [EnumMember(Value = "tax_file_no_aus")]
        tax_file_no_aus,
        [EnumMember(Value = "utility_bill")]
        utility_bill,
        [EnumMember(Value = "mortgage_statement")]
        mortgage_statement
    }

    /// <summary>
    /// Relationship type - if Personal, Spouse | Partner | Family Member, if NonPersonal UBO |
    /// Representative | Shareholder | Officer | Parent | Subsidary | Controller
    /// </summary>
    public enum RelationshipType 
    {
        [EnumMember(Value = "Controller")]
        Controller,
        [EnumMember(Value = "Family Member")]
        FamilyMember,
        [EnumMember(Value = "Officer")]
        Officer,
        [EnumMember(Value = "Parent")]
        Parent,
        [EnumMember(Value = "Partner")]
        Partner,
        [EnumMember(Value = "Representative")]
        Representative,
        [EnumMember(Value = "Shareholder")]
        Shareholder,
        [EnumMember(Value = "Spouse")]
        Spouse,
        [EnumMember(Value = "Subsidary")]
        Subsidary,
        [EnumMember(Value = "UBO")]
        Ubo 
    };
    public enum LinkType 
    {
        [EnumMember(Value = "accountant")]
        Accountant,
        [EnumMember(Value = "controller")]
        Controller,
        [EnumMember(Value = "officer")]
        Officer,
        [EnumMember(Value = "representative")]
        Representative,
        [EnumMember(Value = "shareholder")]
        Shareholder,
        [EnumMember(Value = "structure")]
        Structure,
        [EnumMember(Value = "ubo")]
        Ubo 
    };
    public enum Profilestatus 
    {
        [EnumMember(Value = "archived")]
        Archived,
        [EnumMember(Value = "enabled")]
        Enabled,
        [EnumMember(Value = "pending")]
        Pending
    };

    public enum AllowEnhanced 
    {
        [EnumMember(Value = "no")]
        No,
        [EnumMember(Value = "yes")]
        Yes 
    };

    public enum MatchType 
    {
        [EnumMember(Value = "defined")]
        Defined,
        [EnumMember(Value = "no")]
        No,
        [EnumMember(Value = "yes")]
        Yes 
    };

    /// <summary>
    /// Type of Client, personal or nonpersonal
    /// </summary>
    public enum Clienttypefilter 
    {
        [EnumMember(Value = "nonpersonal")]
        Nonpersonal,
        [EnumMember(Value = "personal")]
        Personal 
    };

    #endregion

    public enum Cancelled { no, yes };

    public enum AllowOtherDocs { no, yes };

    #region JSONConverters
    public class SingleOrArrayConverter<T> : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(T[]);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JToken token = JToken.Load(reader);
            if (token.Type == JTokenType.Array)
            {
                return token.ToObject<T[]>();
            }
            if (token.Type == JTokenType.String)
            {
                var type = typeof(T);
                return new T[] { (T)Activator.CreateInstance(type, token.ToString()) };
            }
            return new T[] { token.ToObject<T>() };
        }

        public override bool CanWrite
        {
            get { return false; }
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
    #endregion
}
