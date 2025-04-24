using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using WebApiCantina.Domain.Exceptions;

namespace WebApiCantina.Domain.VOs;

[Owned]
public class Email
{
    public string Endereco { get; private set; }

    public Email(string endereco)
    {
        if (string.IsNullOrWhiteSpace(endereco) ||
            !new EmailAddressAttribute().IsValid(endereco))
            throw new DomainException("E-mail inválido.");
        Endereco = endereco;
    }

    public override string ToString() => Endereco;
}
