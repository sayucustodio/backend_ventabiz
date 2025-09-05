using Newtonsoft.Json;

namespace appsales.Response
{
    public class AuthSigninCredentialResponse
    {
      
            [JsonProperty("id")]
            public int id { get; set; }

            public string documento { get; set; }

            public string nombre { get; set; }

         public string apellidos { get; set; }

        public string usuario { get; set; }

            public string tipo_usuario_nombre { get; set; }
        public int empresa_id { get; set; }
        public string razon_social { get; set; }
        public int mensaje { get; set; }



    }
}
