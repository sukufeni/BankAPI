using BankDomain.Model;

namespace BankAPI.Services.Int
{
    public interface IClienteService
    {
        Cliente addCliente(Cliente Cliente);
        Task updateCliente(Cliente Cliente, Guid id);
        void deleteCliente(int nrCliente);
        Cliente? GetCliente(int nrCliente);
        List<Cliente> GetAllCliente();
    }
}
