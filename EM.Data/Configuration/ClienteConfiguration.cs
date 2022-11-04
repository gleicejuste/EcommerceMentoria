using EM.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EM.Data.Configuration
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(cliente => cliente.Id);

            builder.Property(cliente => cliente.Id)
                .IsRequired();

            builder.Property(cliente => cliente.Nome)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(cliente => cliente.Email)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.HasIndex(cliente => new { cliente.Email, cliente.Ativo })
                .IsUnique();

            builder.Property(cliente => cliente.Documento)
                .IsRequired()
                .IsUnicode(false)
                .HasMaxLength(11);

            builder.Property(cliente => cliente.HashSenha)
                .IsRequired()
                .IsUnicode(false)
                .HasMaxLength(255);

            builder.Property(cliente => cliente.DataCadastro)
                .IsRequired();

            builder.Property(cliente => cliente.Ativo)
                .IsRequired();

            builder.HasMany(cliente => cliente.Telefones).WithOne().HasForeignKey(telefone => telefone.ClienteId);

        }
    }
}
