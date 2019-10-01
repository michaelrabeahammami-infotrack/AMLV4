using Newtonsoft.Json;

namespace AMLv4_API.Aml_v4_API
{
    /// <summary>
    /// Archive a Client Relationship
    /// </summary>
    public class ArchiveRelationshipRequest
    {
        [JsonProperty("RelationshipID")]
        public string RelationshipId { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class ArchiveRelationshipResponse
    {
        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("RelationshipID")]
        public long RelationshipId { get; set; }

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
