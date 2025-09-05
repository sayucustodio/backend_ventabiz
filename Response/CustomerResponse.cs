using Newtonsoft.Json;
using System;

namespace appsales.Response
{
    public class CustomerResponse
    {

        [JsonProperty("id")]
        public int id { get; set; }
        public int tipo_documento_id { get; set; }
        //public string tipo_documento { get; set; }

        public string documento { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }

        public string telefono { get; set; }
        public string email { get; set; }
            public string direccion { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public string genero { get; set; }
        public string tipo_cliente { get; set; }
        public bool habilitado { get; set; }
        public int empresa_id { get; set; }
        public string empresa { get; set; }
        
    }
}
