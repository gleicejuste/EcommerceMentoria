using EM.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EM.Data.Configuration
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
          public void Configure(EntityTypeBuilder<Produto> builder) 
          {
                builder.HasKey(produto => produto.Id);

                builder.Property(produto => produto.Id)
                    .IsRequired();

                builder.Property(produto => produto.Nome)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                builder.Property(produto => produto.Descricao)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                builder.Property(produto => produto.Ativo)
                    .IsRequired();

                builder.Property(produto => produto.Estoque)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasMaxLength(5);

                builder.Property(produto => produto.DataCadastro)
                    .IsRequired();
  
          }
    }
}
