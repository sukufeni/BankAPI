using BankDomain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDAO.Int
{
    public interface IContaRepository
    {

        public Conta GetConta(int contaId);
        public List<Conta> GetContas(int contaId);

        public void persist(Conta conta);
    }
}
