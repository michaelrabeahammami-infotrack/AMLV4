using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AMLv4_API.Aml_v4_API
{
    /// <summary>
    /// List Document Types and relevance for client
    /// </summary>
    public class PersonalRiskAssessmentDocumentTypesRequest
    {
        [JsonProperty("ClientID")]
        public string ClientId { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class PersonalRiskAssessmentDocumentTypesResponse : Amlv4BaseResponse
    {
        [JsonProperty("numidtypes")]
        public long Numidtypes { get; set; }

        [JsonProperty("idtypes")]
        public Dtype[] Idtypes { get; set; }

        [JsonProperty("numadtypes")]
        public long Numadtypes { get; set; }

        [JsonProperty("adtypes")]
        public Dtype[] Adtypes { get; set; }
    }

    public class Dtype
    {
        [JsonProperty("code")]
        [JsonConverter(typeof(StringEnumConverter))]
        public DocumentCode Code { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("electronic")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Electronic Electronic { get; set; }
    }
}
