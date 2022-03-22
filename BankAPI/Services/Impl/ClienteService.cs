using BankAPI.Services.Int;
using BankDAO;
using BankDomain.Model;

namespace BankAPI.Services.Impl
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _ClienteRepository;
        private readonly IContaService _ContaSevice;

        public ClienteService(IClienteRepository ClienteRepository, IContaService contaService)
        {
            _ClienteRepository = ClienteRepository;
            _ContaSevice = contaService;
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
            List<Cliente>retClientes = _ClienteRepository.GetAllCliente();
            foreach (Cliente cliente in retClientes)
            {
                cliente.Contas = new List<Conta>();
                cliente.Contas.AddRange(_ContaSevice.GetContas(cliente.nrCliente));
            }
            return retClientes;
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
