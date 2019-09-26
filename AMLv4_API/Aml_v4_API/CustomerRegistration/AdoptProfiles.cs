using System.Collections.Generic;

namespace AMLv4_API.Aml_v4_API
{
    /// <summary>
    /// Agree to adopt AML Default Profiles
    /// </summary>
    public class AdoptProfilesRequest
    {
        public string uri { get; set; }
    }


    public class AdoptProfilesResponse
    {
        public string error { get; set; }
        public string uri { get; set; }
        public string profilecount { get; set; }
        public Profile[] profiles { get; set; }
    }

}
