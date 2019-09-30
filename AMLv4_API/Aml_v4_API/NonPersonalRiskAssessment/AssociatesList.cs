using Newtonsoft.Json;

namespace AMLv4_API.Aml_v4_API
{
    //// <summary>
    /// Non-Personal Associates List
    /// </summary>
    public class AssociatesListRequest
    {
        /// <summary>
        /// Use to see asociates used on a specific assessment
        /// </summary>
        [JsonProperty("AssessmentID", NullValueHandling = NullValueHandling.Ignore)]
        public string AssessmentId { get; set; }

        [JsonProperty("ClientID")]
        public string ClientId { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class AssociatesListResponse
    {
        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("ClientID")]
        public long ClientId { get; set; }

        [JsonProperty("numass")]
        public long Numass { get; set; }

        [JsonProperty("ass")]
        public Ass[] Ass { get; set; }
    }

    public class Ass
    {
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
