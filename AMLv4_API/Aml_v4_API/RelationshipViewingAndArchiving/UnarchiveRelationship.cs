namespace AMLv4_API.Aml_v4_API.RelationshipViewingAndArchiving
{
    /// <summary>
    /// Unarchive a Client Relationship
    /// </summary>
    public class UnarchiveRelationshipRequest
    {
        public string RelationshipID { get; set; }
        public string uri { get; set; }
    }
    public class UnarchiveRelationshipResponse
    {
        public string error { get; set; }
        public long RelationshipID { get; set; }
        public long ClientID { get; set; }
        public long RelatedClientID { get; set; }
        public string Relationship { get; set; }
        public string Archived { get; set; }
    }

}
