using EM.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EM.Data.Configuration
{
    public class TelefoneConfiguration : IEntityTypeConfiguration<Telefone>
    {
        public void Configure(EntityTypeBuilder<Telefone> builder)
        {
            builder.HasKey(telefone => telefone.Id);

            builder.Property(telefone => telefone.Id)
                .IsRequired()
                .IsUnicode(false);

            builder.Property(telefone => telefone.Numero)
                .IsRequired()
                .HasMaxLength(11)
                .IsUnicode(false);

            builder.Property(telefone => telefone.DataCadastro)
                .IsRequired();

            builder.Property(telefone => telefone.ClienteId)
                .IsRequired();

            // Se o enumerador for uma cadeia de caracteres (string)
            // builder.Property(telefone => telefone.Tipo)
            //     .IsRequired()
            //     .HasConversion<string>()
            //     .IsUnicode(false)
            //     .HasMaxLength(10);

            // Se o enumerador for um inteiro ou short
            builder.Property(telefone => telefone.Tipo)
                .IsRequired()
                .HasConversion<short>();

            builder.HasOne(telefone => telefone.Cliente)
                .WithMany(cliente => cliente.Telefones)
                .HasForeignKey(telefone => telefone.ClienteId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
