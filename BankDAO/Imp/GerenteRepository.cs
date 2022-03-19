using BankDomain;
using BankDomain.Model;

namespace BankDAO.Imp
{
    public class GerenteRepository : IGerenteRepository
    {
        private ContextPrincipal context;

        public GerenteRepository(ContextPrincipal context)
        {
            this.context = context;
        }

        public Gerente addGerente(Gerente Gerente)
        {
            Gerente added = context.Gerentes.Add(Gerente).Entity;
            context.SaveChanges();
            return added;
        }

        public void deleteGerente(Gerente Gerente)
        {
            context.Gerentes.Remove(Gerente);
            context.SaveChanges();
        }

        public List<Gerente> GetAllGerente()
        {
            return context.Gerentes.ToList();
        }

        public Gerente? GetGerente(int codGerente)
        {
            return context.Gerentes.FirstOrDefault(p => p.codGerente == codGerente);
        }

        public Task updateGerente(Gerente Gerente, Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
