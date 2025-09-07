using appsales.Request;
using appsales.Response;

namespace appsales.Domain.Repository
{
    public interface ICategoryRepository
    {
        IEnumerable<CategoryResponse> getCategoriasEmpresaAsync(int codempresa);
        OutputResponse createCategoryAsync(CreateCategoryRequest request);
        OutputResponse updateCategoryAsync(UpdateCategoryRequest request);


    }
}
