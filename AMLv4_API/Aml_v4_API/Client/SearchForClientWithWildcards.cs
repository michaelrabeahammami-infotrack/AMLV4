using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace AMLv4_API.Aml_v4_API
{
    /// <summary>
    /// Search for clients matching various pattterns
    /// </summary>
    public class SearchForClientWithWildcardsRequest : Amlv4BaseRequest
    {
        /// <summary>
        /// Only searches by specific user (by AMLSearch id)
        /// </summary>
        [JsonProperty("AmlUserID", NullValueHandling = NullValueHandling.Ignore)]
        public string AmlUserId { get; set; }

        /// <summary>
        /// Surname or Forename Surname or Company Name. Add % for wildcards
        /// </summary>
        [JsonProperty("ClientName", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientName { get; set; }

        /// <summary>
        /// User reference or Matter no. add % for wildcard
        /// </summary>
        [JsonProperty("ClientReference", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientReference { get; set; }

        /// <summary>
        /// Type of client to search for
        /// </summary>
        [JsonProperty("ClientType", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Clienttypefilter? ClientType { get; set; }

        /// <summary>
        /// Filter by status
        /// </summary>
        [JsonProperty("ComplianceStatus", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public ComplianceStatus? ComplianceStatus { get; set; }

        /// <summary>
        /// Last date of client creation (YYYY-MM-DD)
        /// </summary>
        [JsonProperty("EndDate", NullValueHandling = NullValueHandling.Ignore)]
        public string EndDate { get; set; }

        /// <summary>
        /// Include archived clients in results (default no)
        /// </summary>
        [JsonProperty("IncludeArchived", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public IncludeArchived? IncludeArchived { get; set; }

        /// <summary>
        /// Filter by postcode of current address or company registered address
        /// </summary>
        [JsonProperty("Postcode", NullValueHandling = NullValueHandling.Ignore)]
        public string Postcode { get; set; }

        /// <summary>
        /// Limit result set. Required if no other parameters set
        /// </summary>
        [JsonProperty("RecordLimit", NullValueHandling = NullValueHandling.Ignore)]
        public string RecordLimit { get; set; }

        /// <summary>
        /// First date of client creation (YYYY-MM-DD)
        /// </summary>
        [JsonProperty("StartDate", NullValueHandling = NullValueHandling.Ignore)]
        public string StartDate { get; set; }

        /// <summary>
        /// Only searches by specific user (Forename Surname, % wildcards)
        /// </summary>
        [JsonProperty("UserName", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }
    }

    public class SearchForClientWithWildcardsResponse : Amlv4BaseResponse
    {
        [JsonProperty("nummatches")]
        public long Nummatches { get; set; }

        [JsonProperty("matches")]
        public Match[] Matches { get; set; }
    }
}
