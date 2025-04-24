using Microsoft.EntityFrameworkCore;
using WebApiCantina.Domain.Exceptions;

namespace WebApiCantina.Domain.VOs;

[Owned]
public class Cpf
{
    public string Numero { get; private set; }

    public Cpf(string numero)
    {
        if (string.IsNullOrWhiteSpace(numero) || numero.Length != 11 || !numero.All(char.IsDigit))
            throw new DomainException("CPF inválido.");
        Numero = numero;
    }

    public override string ToString() => Numero;
}