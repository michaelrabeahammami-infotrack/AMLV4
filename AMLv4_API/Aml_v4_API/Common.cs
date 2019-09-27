using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Runtime.Serialization;

namespace AMLv4_API.Aml_v4_API
{
    #region Classes
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
    /// no|yes - Set to no to check terms version, yes to retrieve a copy of the terms
    ///
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
        Newknown 
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
        Personal 
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
        Phone 
    };

    public enum Previous 
    {
        [EnumMember(Value = "no")]
        No,
        [EnumMember(Value = "yes")]
        Yes 
    };

    public enum Relationship 
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

    

    #endregion

    public enum Cancelled { no, yes };

    public enum ClientType { nonpersonal, personal };

    public enum IncludeArchived { no, yes };

    public enum AllowOtherDocs { no, yes };


    public enum LinkType { accountant, controller, officer, representative, shareholder, structure, ubo };

    public enum IsNewRelationShip { Existing, New, Newknown };
    /// <summary>
    /// Relationship type - if Personal, Spouse | Partner | Family Member, if NonPersonal UBO |
    /// Representative | Shareholder | Officer | Parent | Subsidary | Controller
    /// </summary>
    public enum RelationshipType { Controller, FamilyMember, Officer, Parent, Partner, Representative, Shareholder, Spouse, Subsidary, Ubo };

    public enum AllowEnhanced { no, yes };

    public enum Match { defined, no, yes };

    //public enum RelationshipValue { empty, existing, @new, newknown };

    public enum Profilestatus { archived, enabled, pending };

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
