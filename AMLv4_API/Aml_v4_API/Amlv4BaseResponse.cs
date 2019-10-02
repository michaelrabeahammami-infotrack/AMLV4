using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AMLv4_API.Aml_v4_API
{
    public class Amlv4BaseResponse
    {
        [JsonProperty("error")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Error Error { get; set; }

        [JsonProperty("code")]
        [JsonConverter(typeof(SingleOrArrayConverter<Code>))]
        public Code[] Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class Code
    {
        public Code(string message)
        {
            Message = message;
        }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("keyword")]
        public string Keyword { get; set; }

        [JsonProperty("parameter")]
        public string[] Parameter { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("data_path")]
        public string DataPath { get; set; }

        [JsonProperty("schema")]
        public Schema Schema { get; set; }

        [JsonProperty("schema_path")]
        public string SchemaPath { get; set; }

        [JsonProperty("cause")]
        public string Cause { get; set; }
    }

    public class Schema
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("enum")]
        public string[] Enum { get; set; }
    }
}
