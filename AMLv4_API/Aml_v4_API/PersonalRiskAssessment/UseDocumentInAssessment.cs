namespace AMLv4_API.Aml_v4_API.PersonalRiskAssessment
{
    /// <summary>
    /// Use Document in Risk Assessment
    /// </summary>
    public class UseDocumentInAssessmentRequest
    {
        public string AssessmentID { get; set; }

        public string docid { get; set; }

        public string uri { get; set; }
    }

    //response is missing on the site!!
}
