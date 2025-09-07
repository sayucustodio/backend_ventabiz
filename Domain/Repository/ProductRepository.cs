using appsales.Response;
using appsales.Utilities;
using Dapper;

namespace appsales.Domain.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly DbConnection _dbConnection;

        public ProductRepository(DbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public IEnumerable<ProductResponse> getProductsXEmpresasAsync(int codempresa)
        {
            // Definir la consulta SQL con un parámetro
            var query = "SELECT * FROM obtener_productos_por_empresa(@codempresa)";

            using (var connection = _dbConnection.GetConnection())
            {
                return connection.Query<ProductResponse>(query, new { codempresa });
            }
        }
    }
}
