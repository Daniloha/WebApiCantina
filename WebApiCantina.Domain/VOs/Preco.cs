using Microsoft.EntityFrameworkCore;
using WebApiCantina.Domain.Exceptions;

namespace WebApiCantina.Domain.VOs;

[Owned]
public class Preco
{
    public double Valor { get; private set; }

    public Preco(double valor)
    {
        if (valor < 0)
            throw new DomainException("Preço não pode ser negativo.");
        Valor = Math.Round(valor, 2);
    }

    public override string ToString() => Valor.ToString("C2");
}
