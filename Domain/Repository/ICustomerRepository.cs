using appsales.Response;

namespace appsales.Domain.Repository
{
    public interface ICustomerRepository
    {
        IEnumerable<CustomerResponse> getClientesEmpresa(int codempresa);
    }
}
