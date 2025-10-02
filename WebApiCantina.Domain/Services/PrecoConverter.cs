using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiCantina.Domain.VOs;

namespace WebApiCantina.Domain.Services;

public class PrecoConverter : ValueConverter<Preco, decimal>
{
    public PrecoConverter() : base(
        preco => (decimal)preco.Valor,      // salvar no banco (decimal)
        valor => new Preco((double)valor))  // ler do banco (double)
    {
    }
}