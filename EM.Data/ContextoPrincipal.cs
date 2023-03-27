using System.Reflection;
using EM.Domain.Entidades;
using Microsoft.EntityFrameworkCore;

namespace EM.Data
{
    public class ContextoPrincipal : DbContext
    {
        public ContextoPrincipal(DbContextOptions<ContextoPrincipal> opt) : base(opt)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Telefone> Telefones { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        //public DbSet<Pedido> Pedidos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
