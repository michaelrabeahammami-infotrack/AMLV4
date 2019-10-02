using Newtonsoft.Json;
using System;

namespace AMLv4_API.Aml_v4_API
{
    /// <summary>
    /// Enable a pending Risk Profile for use
    /// </summary>
    public class EnablePendingRiskProfileRequest : Amlv4BaseRequest
    {
        [JsonProperty("profileid")]
        public string Profileid { get; set; }
    }

    public class EnablePendingRiskProfileResponse : Amlv4BaseResponse
    {
        [JsonProperty("profilecreated")]
        public DateTime Profilecreated { get; set; }

        [JsonProperty("profileid")]
        public long Profileid { get; set; }

        [JsonProperty("profilename")]
        public string Profilename { get; set; }

        [JsonProperty("profileorigin")]
        public string Profileorigin { get; set; }

        [JsonProperty("profilestatus")]
        public string Profilestatus { get; set; }

        [JsonProperty("profiletype")]
        public string Profiletype { get; set; }
    }
}
