using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

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
        [Required]
        public Categoria? CategoriaProduto { get; set; }
        [Required]
        public int QuantidadeEstoque { get; set; }
        [Required]
        public double PrecoVenda { get; set; }
        [JsonIgnore]
        public double PrecoCusto { get; set; }
        [Required]
        [DataType(DataType.ImageUrl, ErrorMessage = "Imagem inválida")]
        public string? Imagem { get; set; }
        [Required]
        public DateOnly DataCriacao { get; set; } = new DateOnly(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
    }
}