using BankDomain.Model;

namespace BankDAO
{
    public interface IGerenteRepository
    {
        Gerente addGerente(Gerente Gerente);
        Task updateGerente(Gerente Gerente, Guid id);
        void deleteGerente(Gerente Gerente);
        Gerente? GetGerente(int codGerente);
        List<Gerente> GetAllGerente();

    }
}