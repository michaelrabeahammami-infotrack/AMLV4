using Newtonsoft.Json;
using System;

namespace AMLv4_API.Aml_v4_API
{
    /// <summary>
    /// List Client existing relationships
    /// </summary>
    public class ListRelationshipsRequest : Amlv4BaseRequest
    {
        [JsonProperty("ClientID")]
        public string ClientId { get; set; }
    }
    public class ListRelationshipsResponse : Amlv4BaseResponse
    {
        [JsonProperty("ClientID")]
        public long ClientId { get; set; }

        [JsonProperty("relationshipcount")]
        public long Relationshipcount { get; set; }

        [JsonProperty("relationships")]
        public Relationship[] Relationships { get; set; }
    }
}
