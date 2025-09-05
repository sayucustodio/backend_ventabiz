using Newtonsoft.Json;

namespace appsales.Response
{
    public class HomeResponse
    {
    }
    public class MenuOpcionesResponse
    {
        [JsonProperty("id")]
        public int id { get; set; }

        public string app { get; set; }

        public string version { get; set; }
        public string img { get; set; }
       // public string version { get; set; }
    }
}
