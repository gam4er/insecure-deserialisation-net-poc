using Newtonsoft.Json;

namespace WebApplicationOwinIIS.Models
{
    public class HelloModel
    {
        [JsonProperty(PropertyName = "body")]
        public dynamic Body { get; set; }
    }
}
