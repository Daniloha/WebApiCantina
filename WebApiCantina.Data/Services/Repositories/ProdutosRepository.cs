using WebApiCantina.Domain.Services.Interfaces;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using WebApiCantina.Data.Context;
using System.Linq.Expressions;
using WebApiCantina.Domain.Models.Estoque;

namespace WebApiCantina.Data.Services.Repositories
{
    public class ProdutosRepository : GenericRepository<Produto>, IProdutosRepository
    {
        // O ILogger já é herdado do GenericRepository
        public ProdutosRepository(AppDbContext context, ILogger<ProdutosRepository> logger)
            : base(context, logger)  // Passando o logger para o construtor da classe base
        { }

        // Método para obter todos os produtos, incluindo suas categorias (exemplo de uso de includes)
        public async Task<List<Produto>> GetAllIncludingAsync(params Expression<Func<Produto, object>>[] includes)
        {
            IQueryable<Produto> query = _context.Produtos;

            foreach (var include in includes)
            {
                query = query.Include(include);
            }

            return await query.ToListAsync();
        }
    }
}
