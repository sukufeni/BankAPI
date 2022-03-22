using BankDomain.Model;

namespace BankAPI.Services.Int
{
    public interface IContaService
    {
        decimal transferir(int clientAccout, int destClientAccount, decimal valor);
        decimal saque(int nrClientAccount, decimal valor);
        decimal deposito(int nrClientAccount, decimal valor);
        decimal getTotal(int nrClientAccount);
        Conta GetConta(int clientId);
        List<Conta> GetContas(int clientId);
    }
}
