namespace AMLv4_API.Aml_v4_API
{
    /// <summary>
    /// Lookup available risk profiles and CDD
    /// </summary>
    public class SelectRiskProfileCddRequest
    {
        public string interview_value { get; set; }
        public string nationality_value { get; set; }
        public string ProfileOverride { get; set; }
        public string profiletype { get; set; }
        public string relationship_value { get; set; }
        public string residency_value { get; set; }
        public string uri { get; set; }
    }

    public class SelectRiskProfileCddResponse
    {
        public string error { get; set; }
        public string uri { get; set; }
        public string profilecount { get; set; }
        public Profile[] profiles { get; set; }
    }
}
