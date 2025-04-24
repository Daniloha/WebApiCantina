using WebApiCantina.Domain.VOs;

namespace WebApiCantina.Application.DTOs
{
    public class ProdutoDto
    {
        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public string DescricaoProduto { get; set; }
        public string NomeCategoria { get; set; }
        public int QuantidadeEstoque { get; set; }
        public Preco PrecoVenda { get; set; }
        public UrlImagem Imagem { get; set; }
        public DateOnly DataCriacao { get; set; }
    }
}
