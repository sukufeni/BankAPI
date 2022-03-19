using BankAPI.Services.Int;
using BankDAO;
using BankDomain.Model;

namespace BankAPI.Services.Impl
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _ClienteRepository;

        public ClienteService(IClienteRepository ClienteRepository)
        {
            _ClienteRepository = ClienteRepository;
        }

        public Cliente addCliente(Cliente cliente)
        {
            cliente.idPessoa = new Guid();
            return _ClienteRepository.addCliente(cliente);
        }

        public void deleteCliente(int nrCliente)
        {
            var foundPerson = _ClienteRepository.GetCliente(nrCliente);
            if (!Equals(null, foundPerson) && Equals(foundPerson.nrCliente, nrCliente))
            {
                Cliente personDeleted = foundPerson;
                _ClienteRepository.deleteCliente(personDeleted);
            }
        }

        public List<Cliente> GetAllCliente()
        {
            return _ClienteRepository.GetAllCliente();
        }

        public Cliente? GetCliente(int nrCliente)
        {
            return _ClienteRepository.GetCliente(nrCliente);
        }

        public Task updateCliente(Cliente Cliente, Guid id)
        {
            return _ClienteRepository.updateCliente(Cliente, id);
        }
    }
}
