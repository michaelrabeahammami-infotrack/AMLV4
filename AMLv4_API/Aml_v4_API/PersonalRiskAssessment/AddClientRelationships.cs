using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AMLv4_API.Aml_v4_API
{
    /// <summary>
    /// Add Client relationships
    /// </summary>
    public class AddClientRelationshipsRequest
    {
        /// <summary>
        /// required only if adding relationship AFTER Risk Assessment
        /// </summary>
        [JsonProperty("AssessmentID", NullValueHandling = NullValueHandling.Ignore)]
        public string AssessmentId { get; set; }

        /// <summary>
        /// required only if adding relationship to a Non-Personal Associate
        /// </summary>
        [JsonProperty("AssociateID", NullValueHandling = NullValueHandling.Ignore)]
        public string AssociateId { get; set; }

        [JsonProperty("ClientID")]
        public string ClientId { get; set; }

        /// <summary>
        /// The ClientID of the related Client
        /// </summary>
        [JsonProperty("RelatedClientID")]
        public string RelatedClientId { get; set; }

        /// <summary>
        /// Relationship type - if Personal, Spouse | Partner | Family Member, if NonPersonal UBO |
        /// Representative | Shareholder | Officer | Parent | Subsidary | Controller
        /// </summary>
        [JsonProperty("Relationship")]
        [JsonConverter(typeof(StringEnumConverter))]
        public RelationshipType Relationship { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class AddClientRelationshipsResponse
    {
        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("RelationshipID")]
        public long RelationshipId { get; set; }

        [JsonProperty("AssociateID")]
        public long AssociateId { get; set; }

        [JsonProperty("ClientID")]
        public long ClientId { get; set; }

        [JsonProperty("RelatedClientID")]
        public long RelatedClientId { get; set; }

        [JsonProperty("Relationship")]
        public string Relationship { get; set; }

        [JsonProperty("Archived")]
        public string Archived { get; set; }
    }
}
