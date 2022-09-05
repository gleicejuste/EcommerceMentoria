using EM.Domain.Entidades;
using Microsoft.EntityFrameworkCore;


namespace EM.Data
{
    public class ContextoPrincipal : DbContext
    {

        public ContextoPrincipal(DbContextOptions opt) : base(opt)
        { 
        
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Telefone> Telefones { get; set; }

    }
}

