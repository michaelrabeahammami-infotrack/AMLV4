﻿using Newtonsoft.Json;

namespace AMLv4_API.Aml_v4_API
{
    /// <summary>
    /// View a single Client Relationship
    /// </summary>
    public class ViewRelationshipsRequest
    {
        [JsonProperty("RelationshipID")]
        public string RelationshipId { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }
    public class ViewRelationshipsResponse
    {
        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("RelationshipID")]
        public long RelationshipId { get; set; }

        [JsonProperty("ClientID")]
        public long ClientId { get; set; }

        [JsonProperty("AssociateID")]
        public long AssociateId { get; set; }

        [JsonProperty("RelatedClientID")]
        public long RelatedClientId { get; set; }

        [JsonProperty("Relationship")]
        public string Relationship { get; set; }

        [JsonProperty("Archived")]
        public string Archived { get; set; }
    }
}
