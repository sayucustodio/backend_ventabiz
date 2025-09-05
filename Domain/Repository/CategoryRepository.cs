using appsales.Request;
using appsales.Response;
using appsales.Utilities;
using Dapper;
namespace appsales.Domain.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DbConnection _dbConnection;

        public CategoryRepository(DbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public IEnumerable<CategoryResponse> getCategoriasEmpresaAsync(int codempresa)
        {
            // Definir la consulta SQL con un parámetro
            var query = "SELECT * FROM obtener_categorias_por_empresa(@codempresa)";

            using (var connection = _dbConnection.GetConnection())
            {
                return connection.Query<CategoryResponse>(query, new { codempresa });
            }
        }

        public OutputResponse createCategoryAsync(CreateCategoryRequest request)
        {
            var param = new
            {
                p_empresa_id = request.codempresa,
                p_nombre = request.nombre,
                p_descripcion = request.descripcion
            };

            var query = "SELECT * FROM crear_categoria_empresa(@p_empresa_id, @p_nombre, @p_descripcion);";

            using (var connection = _dbConnection.GetConnection())  // Ahora se usa correctamente
            {
                return connection.QueryFirst<OutputResponse>(query, param);
            }
        }
    }
    }
