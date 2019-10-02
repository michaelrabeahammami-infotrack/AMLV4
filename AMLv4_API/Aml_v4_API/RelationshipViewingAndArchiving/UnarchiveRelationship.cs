using Newtonsoft.Json;

namespace AMLv4_API.Aml_v4_API
{
    /// <summary>
    /// Unarchive a Client Relationship
    /// </summary>
    public class UnarchiveRelationshipRequest : Amlv4BaseRequest
    {
        [JsonProperty("RelationshipID")]
        public string RelationshipId { get; set; }
    }
    public class UnarchiveRelationshipResponse : Amlv4BaseResponse
    {
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
