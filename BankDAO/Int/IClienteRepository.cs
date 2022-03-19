using BankDomain.Model;

namespace BankDAO
{
    public interface IClienteRepository
    {
        Cliente addCliente(Cliente Cliente);
        Task updateCliente(Cliente Cliente, Guid id);
        void deleteCliente(Cliente Cliente);
        Cliente? GetCliente(int nrCliente);
        List<Cliente> GetAllCliente();

    }
}