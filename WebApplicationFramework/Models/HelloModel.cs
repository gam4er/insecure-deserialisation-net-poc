using Newtonsoft.Json;

namespace WebApplicationFramework.Models
{
    public class HelloModel
    {
        [JsonProperty(PropertyName = "body")]
        public dynamic Body { get; set; }
    }
}
