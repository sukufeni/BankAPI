using System.ComponentModel.DataAnnotations;

namespace BankDomain.Model
{
    public class Pessoa
    {
        [Key]
        public Guid idPessoa { get; set; }

        [Required]
        public string nome { get; set; }

        [Required]
        public int NIF { get; set; }
        public DateTime DataNascimento { get; set; }

    }
}
