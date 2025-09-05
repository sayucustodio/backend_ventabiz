using appsales.Request;
using appsales.Response;
using appsales.Utilities;
using Dapper;

namespace appsales.Domain.Repository

{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DbConnection _dbConnection;

        public CustomerRepository(DbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public IEnumerable<CustomerResponse> getClientesEmpresa(int codempresa)
        {
            // Definir la consulta SQL con un parámetro
            var query = "SELECT * FROM get_clientes_empresa_v1(@codempresa)";

            using (var connection = _dbConnection.GetConnection())
            {
                return connection.Query<CustomerResponse>(query, new { codempresa });
            }
        }

    
    }
}
