using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiCantina.Domain.Exceptions;

namespace WebApiCantina.Domain.VOs;

[Owned]
public class Telefone
{
    public string Numero { get; private set; }

    public Telefone(string numero)
    {
        if (string.IsNullOrWhiteSpace(numero) || numero.Length != 11 || !numero.All(char.IsDigit))
            throw new DomainException("Telefone inválido.");
        Numero = numero;
    }

    public override string ToString() => Numero;
}
