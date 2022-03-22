using BankDAO.Int;
using BankDomain;
using BankDomain.Model;

namespace BankDAO.Imp
{
    public class ContaRepository : IContaRepository
    {
        private ContextPrincipal contxext;

        public ContaRepository(ContextPrincipal contxext)
        {
            this.contxext = contxext;
        }

        public Conta GetConta(int contaId)
        {
            IQueryable<Conta> foundAccount = from conta in contxext.Contas
                                             where conta.titular == contaId
                                             select new Conta { nrConta = conta.nrConta, saldoConta = conta.saldoConta, titular = conta.titular };
            if (foundAccount.Any()) return foundAccount.First();

            return new Conta();
        }

        public List<Conta> GetContas(int contaId)
        {
            IQueryable<Conta> foundAccount = from conta in contxext.Contas
                                             where conta.titular == contaId
                                             select conta;

            return foundAccount.Any() ? foundAccount.ToList() : new List<Conta>();
        }
        public void persist(Conta conta)
        {
            this.contxext.Contas.Update(conta);
            this.contxext.SaveChanges();
        }
    }
}
