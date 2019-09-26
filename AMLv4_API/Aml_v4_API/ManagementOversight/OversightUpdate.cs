namespace AMLv4_API.Aml_v4_API.ManagementOversight
{
    /// <summary>
    /// Add Management Oversight Investigation Data
    /// </summary>
    public class OversightUpdateRequest
    {
        public string AssessmentID { get; set; }

        /// <summary>
        /// Users description of management oversight investigation(s)
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// part of piped list UKS|SDN|EUS|PEP|INT|NOID if any
        /// </summary>
        public string Satisfied { get; set; }

        /// <summary>
        /// part of piped list UKS|SDN|EUS|PEP|INT|NOID if any
        /// </summary>
        public string Unsatisfied { get; set; }

        public string uri { get; set; }
    }
    //RESPONSE IS MISSING!!
}
