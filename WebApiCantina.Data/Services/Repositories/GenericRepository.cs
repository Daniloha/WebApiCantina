using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WebApiCantina.Data.Context;
using WebApiCantina.Domain.Services.Interfaces;

namespace WebApiCantina.Data.Services.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly AppDbContext _context;
        protected readonly ILogger<GenericRepository<T>> _logger;

        // Construtor que recebe o ILogger para permitir logging
        public GenericRepository(AppDbContext context, ILogger<GenericRepository<T>> logger)
        {
            _context = context;
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));  // Garantir que o logger não seja nulo
        }

        // Método para adicionar uma entidade
        public async Task AddAsync(T entity)
        {
            try
            {
                await _context.Set<T>().AddAsync(entity);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao adicionar a entidade.");
            }
        }

        // Método para deletar uma entidade
        public async Task DeleteAsync(T entity)
        {
            try
            {
                _context.Set<T>().Remove(entity);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao deletar a entidade.");
            }
        }

        // Método para obter todas as entidades
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            try
            {
                return await _context.Set<T>().ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao buscar as entidades.");
                return null;
            }
        }

        // Método para obter uma entidade pelo id
        public async Task<T> GetByIdAsync(int id)
        {
            try
            {
                return await _context.Set<T>().FindAsync(id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao buscar a entidade.");
                return null;
            }
        }

        // Método para atualizar uma entidade
        public async Task UpdateAsync(T entity)
        {
            try
            {
                _context.Set<T>().Update(entity);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao atualizar a entidade.");
            }
        }
    }
}