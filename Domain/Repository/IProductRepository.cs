using appsales.Request;
using appsales.Response;

namespace appsales.Domain.Repository
{
    public interface IProductRepository
    {
        IEnumerable<ProductResponse> getProductsXEmpresasAsync(int codempresa);
        OutputResponse createProductAsync(CreateProductRequest request);
    }
}
