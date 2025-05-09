﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApiCantina.Domain.Models.Estoque;
using WebApiCantina.Domain.VOs;

namespace WebApiCantina.Data.Services.EntityConfigurations;

public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
{
    public void Configure(EntityTypeBuilder<Categoria> builder)
    {
        // Table name
        builder.ToTable("Categorias");

        // Primary Key
        builder.HasKey(c => c.IdCategoria);

        // Properties
        builder.Property(c => c.IdCategoria)
            .ValueGeneratedOnAdd();

        builder.Property(c => c.NomeCategoria)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(c => c.DescricaoCategoria)
            .IsRequired()
            .HasMaxLength(500);

        builder.Property(c => c.ImagemCategoria)
            .IsRequired()
            .HasConversion(
                v => v.Url,
                v => new UrlImagem(v));

        builder.Property(c => c.DataCriacao)
            .IsRequired();

        // Relationships
        builder.HasMany(c => c.Produtos)
            .WithOne(p => p.CategoriaProduto)
            .HasForeignKey(p => p.IdCategoria)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
