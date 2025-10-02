using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using WebApiCantina.Domain.VOs;

namespace WebApiCantina.Domain.Models.Estoque
{
    public class Produto
    {
        [Key]
        public int IdProduto { get; set; }
        [Required]
        [StringLength(100)]
        public string? NomeProduto { get; set; }
        [Required]
        [StringLength(500)]
        public string? DescricaoProduto { get; set; }
        public int IdCategoria { get; set; }  // Apenas o ID da Categoria
        public virtual Categoria CategoriaProduto { get; set; } // Navegação para Categoria
        [Required]
        public int QuantidadeEstoque { get; set; }
        [Required]
        public Preco PrecoVenda { get; set; }
        [JsonIgnore]
        public Preco PrecoCusto { get; set; } 
        [Required]
        public string Imagem { get; set; }
        [Required]
        public DateTime DataCriacao { get; set; } = DateTime.Now;
    }
}