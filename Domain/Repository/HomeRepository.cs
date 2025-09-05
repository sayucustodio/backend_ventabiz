using appsales.Request;
using appsales.Response;
using appsales.Utilities;
using Dapper;

namespace appsales.Domain.Repository
{
    public class HomeRepository: IHomeRepository
    {
        private readonly DbConnection _dbConnection;

        public HomeRepository(DbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public IEnumerable<MenuOpcionesResponse> getMenuOpciones()
        {
            

            var query = "select * from get_menu_opciones_v1();";

            using (var connection = _dbConnection.GetConnection())  // Ahora se usa correctamente
            {
                return connection.Query<MenuOpcionesResponse>(query);
            }
        }
    }
}
