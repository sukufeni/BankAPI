using BankAPI.Services.Int;
using BankDAO.Int;
using BankDomain.Model;

namespace BankAPI.Services.Impl
{
    public class ContaService : IContaService
    {
        private readonly IContaRepository _ContaRepository;

        public ContaService(IContaRepository contaRepository)
        {
            _ContaRepository = contaRepository;
        }

        public decimal deposito(int clientAccount, decimal valor)
        {

            Conta handledConta = this.GetConta(clientAccount);

            if (handledConta == null) throw new Exception("Erro ao depositar!");
            if (valor < 0) throw new Exception("Valor negativo!");
            handledConta.saldoConta += valor;

            return handledConta.saldoConta;

        }

        public decimal getTotal(int client)
        {
            Conta handledConta = this.GetConta(client);

            if (handledConta == null) throw new Exception("Erro ao depositar!");
            return handledConta.saldoConta;
        }

        public decimal saque(int clientAccount, decimal valor)
        {

            Conta handledConta = this.GetConta(clientAccount);

            if (handledConta == null) throw new Exception("Erro ao depositar!");
            if (handledConta.saldoConta < valor) throw new Exception("Saldo Inferior ao solicitado!");

            handledConta.saldoConta -= valor;

            this._ContaRepository.persist(handledConta);
            handledConta = this.GetConta(clientAccount);

            return handledConta.saldoConta;

        }

        public decimal transferir(int origemClient, int destClient, decimal valor)
        {
            Conta handledConta = this.GetConta(origemClient);
            Conta destConta = this.GetConta(destClient);
            if (handledConta == null || destConta == null) throw new Exception("Erro ao depositar!");
            if (handledConta.saldoConta < valor) throw new Exception("Saldo Inferior ao solicitado!");

            handledConta.saldoConta -= valor;
            destConta.saldoConta += valor;
            this._ContaRepository.persist(handledConta);
            this._ContaRepository.persist(destConta);
            
            handledConta = this.GetConta(origemClient);

            return handledConta.saldoConta;

        }

        public Conta GetConta(int codCliente)
        {
            return _ContaRepository.GetConta(codCliente);
        }

        public List<Conta> GetContas(int clientId)
        {
            return _ContaRepository.GetContas(clientId);
        }
    }
}
