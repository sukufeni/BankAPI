using System.ComponentModel.DataAnnotations;

namespace BankDomain.Model
{
    public class Cliente : Pessoa
    {


        [Required]
        public int nrCliente { get; set; }

        private List<Conta> contas;
        public Gerente gerenteCliente { get; set; }

    }
}
