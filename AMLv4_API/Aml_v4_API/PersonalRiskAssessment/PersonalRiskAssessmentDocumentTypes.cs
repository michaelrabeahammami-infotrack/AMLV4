namespace AMLv4_API.Aml_v4_API.PersonalRiskAssessment
{
    public class PersonalRiskAssessmentDocumentTypesRequest
    {
        public string uri { get; set; }

        public string ClientID { get; set; }
    }

    public class PersonalRiskAssessmentDocumentTypesResponse
    {
        public electronic Error { get; set; }

        public string uri { get; set; }

        public long Numidtypes { get; set; }

        public Dtype[] Idtypes { get; set; }

        public long Numadtypes { get; set; }

        public Dtype[] Adtypes { get; set; }
    }

    public class Dtype
    {
        public code Code { get; set; }

        public string Description { get; set; }

        public electronic Electronic { get; set; }
    }

    public enum electronic { No, Yes };

    public enum code
    {
        uk_passport,
        paper_driving_licence,
        firearms_cert,
        ni_card_and_p60,
        revenue_document,
        bank_statement,
        bank_card_statement,
        eu_state_id_card,
        council_tax, 
        photo_driving_licence,
        tax_credit,
        state_pension,
        housing_benefit,
        national_id_card_nonuk,
        ni_er_id_card,
        grant,
        court_appointment,
        nonuk_passport,
        personal_id_no,
        travel_document,
        residence_permit,
        identity_cert_no,
        reg_fed_de_cont,
        cred_de_elector,
        tax_file_no_aus,
        utility_bill,
        mortgage_statement
    }
}
