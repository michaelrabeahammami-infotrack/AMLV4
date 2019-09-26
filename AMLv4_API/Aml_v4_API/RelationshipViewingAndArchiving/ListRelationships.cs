namespace AMLv4_API.Aml_v4_API.RelationshipViewingAndArchiving
{
    /// <summary>
    /// List Client existing relationships
    /// </summary>
    public class ListRelationshipsRequest
    {
        public string ClientID { get; set; }
        public string uri { get; set; }
    }
    public partial class ListRelationshipsResponse
    {
        public string error { get; set; }
        public string uri { get; set; }
        public long ClientID { get; set; }
        public long relationshipcount { get; set; }
        public Relationship[] relationships { get; set; }
    }

    public class Relationship
    {
        public long RelationshipID { get; set; }
        public long RelatedClientID { get; set; }
        public long AssociateID { get; set; }
        public string RelationshipRelationship { get; set; }
        public string Clienttype { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public string DOB { get; set; }
        public string CurrentAddressPostcode { get; set; }
        public string CountryCode { get; set; }
        public string ComplianceStatus { get; set; }
        public string Archived { get; set; }
    }
}
