using Newtonsoft.Json;

namespace AMLv4_API.Aml_v4_API
{
    #region Request
    /// <summary>
    /// Agree to adopt AML Default Profiles
    /// </summary>
    public class AdoptProfilesRequest : Amlv4BaseRequest
    {
    }
    #endregion

    #region Response
    public class AdoptProfilesResponse : Amlv4BaseResponse
    {
        [JsonProperty("profilecount")]
        public long Profilecount { get; set; }

        [JsonProperty("profiles")]
        public Profile[] Profiles { get; set; }
    } 
    #endregion
}
