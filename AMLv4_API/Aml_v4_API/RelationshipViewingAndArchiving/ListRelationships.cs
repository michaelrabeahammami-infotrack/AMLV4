using Newtonsoft.Json;
using System;

namespace AMLv4_API.Aml_v4_API
{
    /// <summary>
    /// List Client existing relationships
    /// </summary>
    public class ListRelationshipsRequest
    {
        [JsonProperty("ClientID")]
        public string ClientId { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }
    public class ListRelationshipsResponse
    {
        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("ClientID")]
        public long ClientId { get; set; }

        [JsonProperty("relationshipcount")]
        public long Relationshipcount { get; set; }

        [JsonProperty("relationships")]
        public Relationship[] Relationships { get; set; }
    }
}
