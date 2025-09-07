using Newtonsoft.Json;

namespace appsales.Response
{
    public class CategoryResponse
    {
        [JsonProperty("id")]
        public int id { get; set; }
        public string nombre { get; set; }
        //public string tipo_documento { get; set; }

        public string descripcion { get; set; }
        public bool estado { get; set; }
        public int  cantidad_productos { get; set; }
       
    }
}
