using WebApiCantina.Domain.VOs;
using static System.Net.Mime.MediaTypeNames;

namespace WebApiCantina.Application.DTOs;

public class ProdutoResponse
{
    public int IdProduto { get; set; }
    public string NomeProduto { get; set; }
    public string DescricaoProduto { get; set; }
    public string NomeCategoria { get; set; }  // Nome da categoria
    public int QuantidadeEstoque { get; set; }
    public Preco PrecoVenda { get; set; }
    public string Imagem { get; set; }
    public DateTime DataCriacao { get; set; }
}
