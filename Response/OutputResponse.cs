using Newtonsoft.Json;

namespace appsales.Response
{
    public class OutputResponse
    {
        [JsonProperty("transaccion")]
        public int transaccion { get; set; }
        public string mensaje { get; set; }
    }
}
