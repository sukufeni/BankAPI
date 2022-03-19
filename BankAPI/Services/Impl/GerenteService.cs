using BankAPI.Services.Int;
using BankDAO;
using BankDomain.Model;

namespace BankAPI.Services.Impl
{
    public class GerenteService : IGerenteService
    {
        private readonly IGerenteRepository _GerenteRepository;

        public GerenteService(IGerenteRepository GerenteRepository)
        {
            _GerenteRepository = GerenteRepository;
        }

        public Gerente addGerente(Gerente Gerente)
        {
            Gerente.idPessoa = new Guid();
            return _GerenteRepository.addGerente(Gerente);
        }

        public void deleteGerente(int codGerente)
        {
            var foundPerson = _GerenteRepository.GetGerente(codGerente);
            if (!Equals(null, foundPerson) && Equals(foundPerson.codGerente, codGerente))
            {
                Gerente personDeleted = foundPerson;
                _GerenteRepository.deleteGerente(personDeleted);
            }
        }

        public List<Gerente> GetAllGerente()
        {
            return _GerenteRepository.GetAllGerente();
        }

        public Gerente? GetGerente(int codGerente)
        {
            return _GerenteRepository.GetGerente(codGerente);
        }

        public Task updateGerente(Gerente Gerente, Guid id)
        {
            return _GerenteRepository.updateGerente(Gerente, id);
        }
    }
}
