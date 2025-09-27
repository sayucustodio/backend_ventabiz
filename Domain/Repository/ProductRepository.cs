using appsales.Request;
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


        public OutputResponse createProductAsync(CreateProductRequest request)
        {
            var param = new
            {
                p_empresa_id = request.codempresa,
                p_codigo_sku = request.codigo_sku,
                p_nombre = request.nombre,
                p_descripcion = request.descripcion,
                p_codigo_barra = request.codigo_barra,
                p_categoria_id = request.categoria_id,
                p_precio_compra = request.precio_compra,
                p_precio_venta = request.precio_venta,
                p_stock_actual = request.stock_actual,
                p_stock_minimo = request.stock_minimo,
                p_unidad_medida = request.unidad_medida,
                p_imagen_url = request.imagen_url,
                p_estado = request.estado
            };

            var query = @"SELECT * FROM crear_producto_empresa(
                    @p_empresa_id,
                    @p_codigo_sku,
                    @p_nombre,
                    @p_descripcion,
                    @p_codigo_barra,
                    @p_categoria_id,
                    @p_precio_compra,
                    @p_precio_venta,
                    @p_stock_actual,
                    @p_stock_minimo,
                    @p_unidad_medida,
                    @p_imagen_url,
                    @p_estado
                );";

            using (var connection = _dbConnection.GetConnection())
            {
                return connection.QueryFirst<OutputResponse>(query, param);
            }
        }


    }
}
