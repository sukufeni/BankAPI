using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDomain.Model
{
    public class Gerente : Pessoa
    {
        [Required]
        public int codGerente { get; set; }

    }
}
