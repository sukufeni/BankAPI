using System.ComponentModel.DataAnnotations;

namespace BankDomain.Model
{
    public class Conta
    {
        [Key]
        public int nrConta { get; set; }
        [Required]
        public int titular { get; set; }

        public decimal saldoConta { get; set; }

    }
}