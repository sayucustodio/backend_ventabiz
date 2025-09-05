using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using appsales.Models;
using appsales.Domain.Repository;
using appsales.Request;
using appsales.Response;

namespace appsales.Controllers;
[ApiController]
[Route("api/[controller]")]
public class HomeController : ControllerBase
{
    private readonly IHomeRepository homeRepository;

    public HomeController(IHomeRepository _homeRepository)
    {
        homeRepository = _homeRepository;
    }

    [HttpGet()]
    public async Task<ActionResult<IEnumerable<MenuOpcionesResponse>>> getMenuOpciones()
    {
        var response = await Task.FromResult(homeRepository.getMenuOpciones());

        if (response == null)
            return Unauthorized("Credenciales inválidas");

        return Ok(response);
    }
}
