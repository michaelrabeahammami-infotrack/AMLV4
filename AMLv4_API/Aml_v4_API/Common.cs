using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Runtime.Serialization;

namespace AMLv4_API.Aml_v4_API
{

    /// <summary>
    /// no|yes - Set to no to check terms version, yes to retrieve a copy of the terms
    ///
    /// no|yes - Set to yes to obtain a preview of a new Terms version. Set to no to view
    /// currently agreeed version
    /// </summary>
    public enum IncludeBinary { no, yes };

    public enum Cancelled { no, yes };


    //public enum InterviewValue { home, person, phone };

    public class ProfileOverride
    {
        public const string empty = "";
        public const string enhanced = "enhanced";
        public const string simplified = "simplified";
    }

    public enum Profiletype { nonpersonal, personal };

    public static class RelationshipValue
    {

        public const string existing = "existing";
        public const string @new = "new";
        public const string newknown = "newknown";
    }

    public enum ClientType { nonpersonal, personal };

    public enum IncludeArchived { no, yes };

    public enum AllowOtherDocs { no, yes };

    /// <summary>
    /// Additional rights (MO=Management Oversight, MOD=MO for Document Expiry Alert only)
    /// </summary>
    //public enum ServicesAvailable { empty, MO, MOD };

    /// <summary>
    /// Main access level
    /// </summary>
    public enum UserType { admin, user };

    public enum LinkType { accountant, controller, officer, representative, shareholder, structure, ubo };

    public enum Includebinary { No, Yes };


    public enum IsNewRelationShip { Existing, New, Newknown };
    /// <summary>
    /// Relationship type - if Personal, Spouse | Partner | Family Member, if NonPersonal UBO |
    /// Representative | Shareholder | Officer | Parent | Subsidary | Controller
    /// </summary>
    public enum RelationshipType { Controller, FamilyMember, Officer, Parent, Partner, Representative, Shareholder, Spouse, Subsidary, Ubo };

    public enum AllowEnhanced { no, yes };

    public enum Match { defined, no, yes };

    public enum InterviewValue { empty, home, person, phone };

    //public enum RelationshipValue { empty, existing, @new, newknown };

    public enum Profilestatus { archived, enabled, pending };

    public enum CustomerAccess 
    {
        [EnumMember(Value="sub-both")]
        SubBoth,
        [EnumMember(Value="sub-simple")]
        SubSimple,
        [EnumMember(Value="transactional")]
        Transactional 
    };

    public enum OrgType 
    { 
        [EnumMember(Value="accountant")]
        Accountant, 
        [EnumMember(Value="casino")]
        Casino, 
        [EnumMember(Value="estateagent")]
        Estateagent, 
        [EnumMember(Value="highvaluedealer")]
        Highvaluedealer, 
        [EnumMember(Value="insolvencypractitioner")]
        Insolvencypractitioner, 
        [EnumMember(Value="other")]
        Other, 
        [EnumMember(Value="solicitor")]
        Solicitor, 
        [EnumMember(Value="trustorcompanyserviceprovider")]
        Trustorcompanyserviceprovider 
    };

    public enum TermsAccepted 
    { 
        [EnumMember(Value="yes")]
        Yes 
    };


    public class Profile
    {
        public string profileid { get; set; }
        public string profilename { get; set; }
        public string profilestatus { get; set; }
        public string profiletype { get; set; }
        public string profilecreated { get; set; }
        public string profileorigin { get; set; }
        public string simplified { get; set; }
        public string enhanced { get; set; }
        public string matchruleid { get; set; }
    }

    public enum AssessmentType { enhanced, simplified };

    public enum Clienttype { personal };

    public enum Compliance { yes };

    public enum Gender { Female, Male, NonBinary, NotDisclosed };

    public enum Interview { home, person, phone };

    public enum Previous { no, yes };

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
