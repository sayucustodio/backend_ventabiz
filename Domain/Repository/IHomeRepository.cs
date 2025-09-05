using appsales.Request;
using appsales.Response;

namespace appsales.Domain.Repository
{
    public interface IHomeRepository
    {
        IEnumerable<MenuOpcionesResponse> getMenuOpciones();
    }
}
