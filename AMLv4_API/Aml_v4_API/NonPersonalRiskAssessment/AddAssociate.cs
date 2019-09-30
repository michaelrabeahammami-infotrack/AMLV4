using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AMLv4_API.Aml_v4_API
{
    /// <summary>
    /// Non-Personal AAdd Associate
    /// </summary>
    public class AddAssociateRequest
    {
        /// <summary>
        /// Pipe separated '|' values
        /// </summary>
        [JsonProperty("Address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        [JsonProperty("AssessmentID")]
        public string AssessmentId { get; set; }

        [JsonProperty("ClientID")]
        public string ClientId { get; set; }

        /// <summary>
        /// if Company
        /// </summary>
        [JsonProperty("CompanyName", NullValueHandling = NullValueHandling.Ignore)]
        public string CompanyName { get; set; }

        [JsonProperty("DateOfBirth", NullValueHandling = NullValueHandling.Ignore)]
        public string DateOfBirth { get; set; }

        /// <summary>
        /// if Individual
        /// </summary>
        [JsonProperty("Forename", NullValueHandling = NullValueHandling.Ignore)]
        public string Forename { get; set; }

        [JsonProperty("LinkDescription")]
        public string LinkDescription { get; set; }

        [JsonProperty("LinkType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public LinkType LinkType { get; set; }

        /// <summary>
        /// if Individual
        /// </summary>
        [JsonProperty("MiddleNames", NullValueHandling = NullValueHandling.Ignore)]
        public string MiddleNames { get; set; }

        /// <summary>
        /// if Individual
        /// </summary>
        [JsonProperty("Surname", NullValueHandling = NullValueHandling.Ignore)]
        public string Surname { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class AddAssociateResponse
    {
        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("AssociateID")]
        public long AssociateId { get; set; }

        [JsonProperty("ClientID")]
        public long ClientId { get; set; }

        [JsonProperty("Forename")]
        public string Forename { get; set; }

        [JsonProperty("MiddleNames")]
        public string MiddleNames { get; set; }

        [JsonProperty("Surname")]
        public string Surname { get; set; }

        [JsonProperty("CompanyName")]
        public string CompanyName { get; set; }

        [JsonProperty("Address")]
        public string Address { get; set; }

        [JsonProperty("DateOfBirth")]
        public string DateOfBirth { get; set; }

        [JsonProperty("LinkType")]
        public string LinkType { get; set; }

        [JsonProperty("LinkDescription")]
        public string LinkDescription { get; set; }

        [JsonProperty("UserAdded")]
        public string UserAdded { get; set; }
    }
}
