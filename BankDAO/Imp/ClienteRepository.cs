using BankDomain;
using BankDomain.Model;

namespace BankDAO.Imp
{
    public class ClienteRepository : IClienteRepository
    {
        private ContextPrincipal context;

        public ClienteRepository(ContextPrincipal context)
        {
            this.context = context;
        }

        public Cliente addCliente(Cliente Cliente)
        {
            Cliente added = context.Clientes.Add(Cliente).Entity;
            context.SaveChanges();
            return added;
        }

        public void deleteCliente(Cliente Cliente)
        {
            context.Clientes.Remove(Cliente);
            context.SaveChanges();
        }

        public List<Cliente> GetAllCliente()
        {
            return context.Clientes.ToList();
        }

        public Cliente? GetCliente(int nrCliente)
        {
            return context.Clientes.FirstOrDefault(p => p.nrCliente== nrCliente);
        }

        public Task updateCliente(Cliente Cliente, Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
