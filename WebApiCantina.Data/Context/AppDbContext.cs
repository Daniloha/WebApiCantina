using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
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
    }
}