namespace AMLv4_API.Aml_v4_API.RiskAssessmentProfiles
{
    /// <summary>
    /// Profile Rule copy for rule of pending Risk Profile
    /// </summary>
    public class CopyProfileRuleRequest
    {
        public string ruleid { get; set; }
        public string uri { get; set; }
    }
    public class CopyProfileRuleResponse
    {
        public string schemafile { get; set; }
        public string status { get; set; }
    }
}
