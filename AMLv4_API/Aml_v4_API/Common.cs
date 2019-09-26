﻿using Newtonsoft.Json;
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

    #endregion

    public enum Cancelled { no, yes };

    public enum ClientType { nonpersonal, personal };

    public enum IncludeArchived { no, yes };

    public enum AllowOtherDocs { no, yes };


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
