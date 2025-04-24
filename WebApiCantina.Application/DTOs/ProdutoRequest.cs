using WebApiCantina.Domain.VOs;

namespace WebApiCantina.Application.DTOs
{
    public class ProdutoRequest
    {
        public string NomeProduto { get; set; }
        public string DescricaoProduto { get; set; }
        public int IdCategoria { get; set; } 
        public int QuantidadeEstoque { get; set; }
        public Preco PrecoVenda { get; set; }
        public Preco PrecoCusto { get; set; } 
        public UrlImagem Imagem { get; set; }
    }
}
