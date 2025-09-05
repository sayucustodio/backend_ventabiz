using appsales.Request;
using appsales.Response;

namespace appsales.Domain.Repository
{
    public interface IAuthRepository
    {
        AuthSigninCredentialResponse SignInCredentials(AuthDeviceSingInRequest request);

    }
}
