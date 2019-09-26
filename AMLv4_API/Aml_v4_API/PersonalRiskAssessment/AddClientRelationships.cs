namespace AMLv4_API.Aml_v4_API.PersonalRiskAssessment
{
    /// <summary>
    /// Add Client relationships
    /// </summary>
    public class AddClientRelationshipsRequest
    {
        /// <summary>
        /// required only if adding relationship AFTER Risk Assessment
        /// </summary>
        public string AssessmentID { get; set; }

        /// <summary>
        /// required only if adding relationship to a Non-Personal Associate
        /// </summary>
        public string AssociateID { get; set; }

        public string ClientID { get; set; }

        /// <summary>
        /// The ClientID of the related Client
        /// </summary>
        public string RelatedClientID { get; set; }

        /// <summary>
        /// Relationship type - if Personal, Spouse | Partner | Family Member, if NonPersonal UBO |
        /// Representative | Shareholder | Officer | Parent | Subsidary | Controller
        /// </summary>
        public RelationshipType Relationship { get; set; }

        public string uri { get; set; }
    }

    public class AddClientRelationshipsResponse
    {
        public string error { get; set; }

        public long RelationshipID { get; set; }

        public long AssociateID { get; set; }

        public long ClientID { get; set; }

        public long RelatedClientID { get; set; }

        public RelationshipType Relationship { get; set; }

        public string Archived { get; set; }
    }
}
