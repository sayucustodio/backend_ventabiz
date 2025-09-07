using Newtonsoft.Json;

namespace appsales.Response
{
    public class ProductResponse
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("codigo_sku")]
        public string codigo_sku { get; set; }

        [JsonProperty("nombre")]
        public string nombre { get; set; }

        [JsonProperty("descripcion")]
        public string descripcion { get; set; }

        [JsonProperty("codigo_barra")]
        public string codigo_barra { get; set; }

        [JsonProperty("categoria_id")]
        public int? categoria_id { get; set; }

        [JsonProperty("categoria")]
        public string categoria { get; set; }

        [JsonProperty("precio_compra")]
        public double? precio_compra { get; set; }

        [JsonProperty("precio_venta")]
        public double? precio_venta { get; set; }

        [JsonProperty("stock_actual")]
        public int? stock_actual { get; set; }

        [JsonProperty("stock_minimo")]
        public int? stock_minimo { get; set; }

        [JsonProperty("unidad_medida")]
        public string unidad_medida { get; set; }

        [JsonProperty("imagen_url")]
        public string imagen_url { get; set; }

        [JsonProperty("estado")]
        public bool estado { get; set; }
    }
}
