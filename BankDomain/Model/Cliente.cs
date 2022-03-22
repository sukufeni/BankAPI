using System.ComponentModel.DataAnnotations;

namespace BankDomain.Model
{
    public class Cliente : Pessoa
    {

        [Required]
        public int nrCliente { get; set; }

        [Required]
        public List<Conta> Contas { get; set; }
        public Gerente gerenteCliente { get; set; }

    }
}
