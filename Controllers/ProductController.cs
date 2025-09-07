using appsales.Domain.Repository;
using appsales.Response;
using Microsoft.AspNetCore.Mvc;

namespace appsales.Controllers
{

    [ApiController]
    [Route("api/[controller]")]


    public class ProductController : ControllerBase
    {
        private readonly IProductRepository productRepository;

        public ProductController(IProductRepository _productRepository)
        {
            productRepository = _productRepository;
        }

        [HttpGet()]
        public async Task<ActionResult<IEnumerable<ProductResponse>>> getProductsXEmpresas(int codempresa)
        {
            var response = await Task.FromResult(productRepository.getProductsXEmpresasAsync(codempresa));
            return Ok(response);
        }
    }
}
