using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiCantina.Models.Estoque;
using WebApiCantina.Models.Operacoes;
using WebApiCantina.Models.Usuarios;

namespace WebApiCantina.Context
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