using appsales.Request;
using appsales.Response;
using appsales.Domain.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace appsales.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepository;

        public AuthController(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }

        [HttpPost()]
        public async Task<ActionResult<AuthSigninCredentialResponse>> SignInCredentials([FromBody] AuthDeviceSingInRequest request)
        {
            var response = await Task.FromResult(_authRepository.SignInCredentials(request));

            if (response == null)
                return Unauthorized("Credenciales inválidas");

            return Ok(response);
        }
    }
}
