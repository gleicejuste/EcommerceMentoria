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
            builder.Property(telefone => telefone.Id).IsRequired();
            builder.Property(telefone => telefone.Numero)
                .IsRequired()
                 .HasMaxLength(11)
                .IsUnicode(false);
            builder.Property(telefone => telefone.DataCadastro).IsRequired();
            builder.Property(telefone => telefone.Cliente).IsRequired();
            builder.Property(telefone => telefone.Tipo).IsRequired().HasMaxLength(1);



        }
    }
}
