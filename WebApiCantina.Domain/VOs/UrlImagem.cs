using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using WebApiCantina.Domain.Exceptions;

namespace WebApiCantina.Domain.VOs;

[Owned]
public class UrlImagem
{
    public string Url { get; private set; }

    public UrlImagem(string url)
    {
        var pattern = @"^(https?://.*\.(?:png|jpg|jpeg|gif))$";
        if (string.IsNullOrWhiteSpace(url) || !Regex.IsMatch(url, pattern, RegexOptions.IgnoreCase))
            throw new DomainException("URL da imagem inválida.");
        Url = url;
    }

    public override string ToString() => Url;
}
