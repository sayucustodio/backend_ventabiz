using appsales.Domain.Repository;
using appsales.Response;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

namespace appsales.Controllers;
[ApiController]
[Route("api/[controller]")]

public class CustomerController : ControllerBase
{
    private readonly ICustomerRepository customerRepository;

    public CustomerController(ICustomerRepository _customerRepository)
    {
        customerRepository = _customerRepository;
    }

    [HttpGet()]
    public async Task<ActionResult<IEnumerable<CustomerResponse>>> getClientesEmpresa(int codempresa)
    {
        var response = await Task.FromResult(customerRepository.getClientesEmpresa(codempresa));
        return Ok(response);
    }
}
