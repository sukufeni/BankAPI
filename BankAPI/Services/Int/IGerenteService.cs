using BankDomain.Model;

namespace BankAPI.Services.Int
{
    public interface IGerenteService
    {
        Gerente addGerente(Gerente Gerente);
        Task updateGerente(Gerente Gerente, Guid id);
        void deleteGerente(int codGerente);
        Gerente? GetGerente(int codGerente);
        List<Gerente> GetAllGerente();
    }
}
