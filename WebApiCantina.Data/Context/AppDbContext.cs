using Microsoft.EntityFrameworkCore;
using WebApiCantina.Data.Services.EntityConfigurations;
using WebApiCantina.Domain.Models.Estoque;
using WebApiCantina.Domain.Models.Operacoes;
using WebApiCantina.Domain.Models.Usuarios;

namespace WebApiCantina.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Carrinho> Comandas { get; set; }
        public DbSet<Administrador> Administradores { get; set; }
        public DbSet<Colaborador> Colaboradores { get; set; }
        public DbSet<Comum> Comuns { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new CategoriaConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());

            // Seed das Categorias
            modelBuilder.Entity<Categoria>().HasData(
                new
                {
                    IdCategoria = 1,
                    NomeCategoria = "Bebidas geladas",
                    DescricaoCategoria = "Categoria para refrigerantes, sucos e outras bebidas.",
                    ImagemCategoria = "https://example.com/images/bebidas.jpg",
                    DataCriacao = new DateTime(2025, 5, 16)
                },
                new
                {
                    IdCategoria = 2,
                    NomeCategoria = "Salgados",
                    DescricaoCategoria = "Categoria para salgados como coxinhas, pastéis, etc.",
                    ImagemCategoria = "https://example.com/images/salgados.jpg",
                    DataCriacao = new DateTime(2025, 5, 16)
                },
                new
                {
                    IdCategoria = 3,
                    NomeCategoria = "Sobremesas",
                    DescricaoCategoria = "Categorias para sobremesas.",
                    ImagemCategoria = "https://example.com/images/sobremesas.jpg",
                    DataCriacao = new DateTime(2025, 5, 16)
                },
                new
                {
                    IdCategoria = 4,
                    NomeCategoria = "Doces",
                    DescricaoCategoria = "Categorias para doces.",
                    ImagemCategoria = "https://example.com/images/doces.jpg",
                    DataCriacao = new DateTime(2025, 5, 16)
                },
                new
                {
                    IdCategoria = 5,
                    NomeCategoria = "Cafés",
                    DescricaoCategoria = "Categorias para cafés",
                    ImagemCategoria = "https://example.com/images/cafes.jpg",
                    DataCriacao = new DateTime(2025, 5, 16)
                }
            );

            // Seed dos Produtos
            modelBuilder.Entity<Produto>().HasData(
                new
                {
                    IdProduto = 1,
                    NomeProduto = "Refrigerante Lata 350ml",
                    DescricaoProduto = "Refrigerante gelado de 350ml.",
                    IdCategoria = 1,
                    QuantidadeEstoque = 50,
                    PrecoVenda = 5.00,
                    Imagem = "https://example.com/images/refrigerante.jpg",
                    DataCriacao = new DateTime(2025, 5, 16)
                },
                new
                {
                    IdProduto = 2,
                    NomeProduto = "Coxinha de Frango",
                    DescricaoProduto = "Coxinha de frango crocante e saborosa.",
                    IdCategoria = 2,
                    QuantidadeEstoque = 30,
                    PrecoVenda = 4.00,
                    Imagem = "https://example.com/images/coxinha.jpg",
                    DataCriacao = new DateTime(2025, 5, 16)
                },
                new
                {
                    IdProduto = 3,
                    NomeProduto = "Suco de laranja 250ml",
                    DescricaoProduto = "Suco de laranja 250ml.",
                    IdCategoria = 1,
                    QuantidadeEstoque = 30,
                    PrecoVenda = 6.00,
                    Imagem = "https://example.com/images/suco.jpg",
                    DataCriacao = new DateTime(2025, 5, 16)
                },
                new
                {
                    IdProduto = 4,
                    NomeProduto = "Pastel de Frango",
                    DescricaoProduto = "Pastel de frango recheado com catupiry.",
                    IdCategoria = 2,
                    QuantidadeEstoque = 20,
                    PrecoVenda = 7.00,
                    Imagem = "https://example.com/images/pastel.jpg",
                    DataCriacao = new DateTime(2025, 5, 16)
                },
                new
                {
                    IdProduto = 5,
                    NomeProduto = "Cafe Americano 250ml",
                    DescricaoProduto = "Cafe Americano 250ml.",
                    IdCategoria = 5,
                    QuantidadeEstoque = 40,
                    PrecoVenda = 8.00,
                    Imagem = "https://example.com/images/cafe.jpg",
                    DataCriacao = new DateTime(2025, 5, 16)
                },
                new
                {
                    IdProduto = 6,
                    NomeProduto = "Cappuccino 250ml",
                    DescricaoProduto = "Cappuccino 250ml.",
                    IdCategoria = 5,
                    QuantidadeEstoque = 40,
                    PrecoVenda = 9.00,
                    PrecoCusto = 7.00,
                    Imagem = "https://example.com/images/cappuccino.jpg",
                    DataCriacao = new DateTime(2025, 5, 16)
                },
                new
                {
                    IdProduto = 7,
                    NomeProduto = "Bolo de Chocolate",
                    DescricaoProduto = "Bolo de chocolate recheado com morango.",
                    IdCategoria = 3,
                    QuantidadeEstoque = 30,
                    PrecoVenda = 10.00,
                    Imagem = "https://example.com/images/bolo.jpg",
                    DataCriacao = new DateTime(2025, 5, 16)
                },
                new
                {
                    IdProduto = 8,
                    NomeProduto = "Brigadeiro",
                    DescricaoProduto = "Brigadeiro.",
                    IdCategoria = 4,
                    QuantidadeEstoque = 30,
                    PrecoVenda = 11.00,
                    Imagem = "https://example.com/images/brigadeiro.jpg",
                    DataCriacao = new DateTime(2025, 5, 16)
                },
                new
                {
                    IdProduto = 9,
                    NomeProduto = "Torta de Chocolate",
                    DescricaoProduto = "Torta de chocolate recheada com chocolate.",
                    IdCategoria = 4,
                    QuantidadeEstoque = 30,
                    PrecoVenda = 12.00,
                    Imagem = "https://example.com/images/torta.jpg",
                    DataCriacao = new DateTime(2025, 5, 16)
                },
                new
                {
                    IdProduto = 10,
                    NomeProduto = "Coca-cola zero",
                    DescricaoProduto = "Coca-cola zero.",
                    IdCategoria = 1,
                    QuantidadeEstoque = 30,
                    PrecoVenda = 13.00,
                    Imagem = "https://example.com/images/coca-cola.jpg",
                    DataCriacao = new DateTime(2025, 5, 16)
                },
                new
                {
                    IdProduto = 11,
                    NomeProduto = "Pão de queijo",
                    DescricaoProduto = "Pão de queijo.",
                    IdCategoria = 4,
                    QuantidadeEstoque = 30,
                    PrecoVenda = 14.00,
                    Imagem = "https://example.com/images/pao.jpg",
                    DataCriacao = new DateTime(2025, 5, 16)
                },
                new
                {
                    IdProduto = 12,
                    NomeProduto = "Esfirra de carne",
                    DescricaoProduto = "Esfirra de carne.",
                    IdCategoria = 2,
                    QuantidadeEstoque = 30,
                    PrecoVenda = 15.00,
                    Imagem = "https://example.com/images/esfirra.jpg",
                    DataCriacao = new DateTime(2025, 5, 16)
                }
            );
        }
    }
}
