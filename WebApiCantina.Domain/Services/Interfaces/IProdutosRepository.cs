using System.Linq.Expressions;
using WebApiCantina.Domain.Models.Estoque;

namespace WebApiCantina.Domain.Services.Interfaces
{
    public interface IProdutosRepository : IGenericRepository<Produto>
    {
        Task<List<Produto>> GetAllIncludingAsync(params Expression<Func<Produto, object>>[] includes);
    }
}
