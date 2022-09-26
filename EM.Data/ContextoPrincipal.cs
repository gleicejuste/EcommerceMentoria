using EM.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace EM.Data
{
    public class ContextoPrincipal : DbContext
    {

        public ContextoPrincipal(DbContextOptions<ContextoPrincipal> opt) : base(opt)
        {
            
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Telefone> Telefones { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}

