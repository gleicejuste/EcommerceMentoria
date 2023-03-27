using EM.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace EM.Data.Configuration
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(pedido => pedido.Id);

            builder.Property(pedido => pedido.Id)
                .IsRequired();
                                                           
            builder.Property(pedido => pedido.DataPedido)
                .IsRequired();

            builder.Property(pedido => pedido.StatusPedido)
                .IsRequired()
                .HasConversion<short>();

            builder.HasOne(pedido => pedido.Cliente)
                .WithMany(cliente => cliente.Pedidos)
                .HasForeignKey(pedido => pedido.ClienteId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
