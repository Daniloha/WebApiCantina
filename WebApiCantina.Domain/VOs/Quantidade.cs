using Microsoft.EntityFrameworkCore;
using WebApiCantina.Domain.Exceptions;

namespace WebApiCantina.Domain.VOs;

[Owned]
public class Quantidade
{
    public int Valor { get; private set; }

    public Quantidade(int valor)
    {
        if (valor < 0)
            throw new DomainException("Quantidade não pode ser negativa.");
        Valor = valor;
    }

    public override string ToString() => Valor.ToString();
}
