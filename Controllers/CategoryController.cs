using appsales.Domain.Repository;
using appsales.Request;
using appsales.Response;
using Microsoft.AspNetCore.Mvc;

namespace appsales.Controllers;

        [ApiController]
[Route("api/[controller]")]
public class CategoryController : ControllerBase
    {
    private readonly ICategoryRepository categoryRepository;

    public CategoryController(ICategoryRepository _categoryRepository)
    {
        categoryRepository = _categoryRepository;
    }

    [HttpGet()]
    public async Task<ActionResult<IEnumerable<CategoryResponse>>> getCategoriasEmpresa(int codempresa)
    {
        var response = await Task.FromResult(categoryRepository.getCategoriasEmpresaAsync(codempresa));
        return Ok(response);
    }
    [HttpPost("create")]
    public async Task<ActionResult<OutputResponse>> createCategory([FromBody] CreateCategoryRequest request)
    {
        var response = await Task.FromResult(categoryRepository.createCategoryAsync(request));

        if (response == null)
            return Unauthorized("Credenciales inválidas");

        return Ok(response);
    }
}

