using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
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

        public DbSet<Administrador> administradores { get; set; }

        public DbSet<Colaborador> colaboradores { get; set; }

        public DbSet<Comum> comuns { get; set; }

        internal async Task SaveChangesAsync<T>(EntityEntry<T> result) where T : class
        {
            throw new NotImplementedException();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new CategoriaConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());

            modelBuilder.Entity<Produto>()
                .HasOne(p => p.CategoriaProduto)
                .WithMany(c => c.Produtos)
                .HasForeignKey(p => p.IdCategoria)
                .OnDelete(DeleteBehavior.Restrict); // ou .Cascade, dependendo da regra de negócio
        }

    }
}