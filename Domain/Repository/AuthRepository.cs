using appsales.Request;
using appsales.Response;
using appsales.Utilities;
using System.Data.SqlClient;
using Dapper;  // Necesario para `QueryFirst<T>()`

namespace appsales.Domain.Repository
{
    public class AuthRepository : IAuthRepository
    {
        private readonly DbConnection _dbConnection;

        public AuthRepository(DbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public AuthSigninCredentialResponse SignInCredentials(AuthDeviceSingInRequest request)
        {
            var param = new
            {
                usuario = request.p_usuario,
                clave = request.p_clave
            };

            var query = "SELECT * FROM login_app_salesfast_v2(@usuario, @clave);";

            using (var connection = _dbConnection.GetConnection())  // Ahora se usa correctamente
            {
                return connection.QueryFirst<AuthSigninCredentialResponse>(query, param);
            }
        }
    }
}
