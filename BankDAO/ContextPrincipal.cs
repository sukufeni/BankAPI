using BankDomain.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BankDomain
{
    public class ContextPrincipal : IdentityDbContext
    {

        public ContextPrincipal(DbContextOptions<ContextPrincipal> options) : base(options)
        {

        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Gerente> Gerentes { get; set; }


    }
}