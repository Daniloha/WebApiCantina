using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApiCantina.Domain.Models.Estoque;
using WebApiCantina.Domain.VOs;

namespace WebApiCantina.Data.Services.EntityConfigurations;

public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
{
    public void Configure(EntityTypeBuilder<Produto> builder)
    {
        // Table name
        builder.ToTable("Produtos");

        // Primary Key
        builder.HasKey(p => p.IdProduto);

        // Properties
        builder.Property(p => p.IdProduto)
            .ValueGeneratedOnAdd();

        builder.Property(p => p.NomeProduto)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(p => p.DescricaoProduto)
            .IsRequired()
            .HasMaxLength(500);

        builder.Property(p => p.IdCategoria)
            .IsRequired();

        builder.Property(p => p.QuantidadeEstoque)
            .IsRequired();

        builder.Property(p => p.PrecoVenda)
            .IsRequired()
            .HasConversion(
                v => v.Valor,
                v => new Preco(v));

        builder.Property(p => p.PrecoCusto)
            .HasConversion(
                v => v.Valor,
                v => new Preco(v));

        builder.Property(p => p.Imagem)
            .IsRequired()
            .HasConversion(
                v => v.Url,
                v => new UrlImagem(v));

        builder.Property(p => p.DataCriacao)
            .IsRequired();

        // Relationships
        builder.HasOne(p => p.CategoriaProduto)
            .WithMany(c => c.Produtos)
            .HasForeignKey(p => p.IdCategoria)
            .OnDelete(DeleteBehavior.Restrict); // Or Cascade if you want to delete products when category is deleted
    }
}
