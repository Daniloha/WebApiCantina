using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace WebApiCantina.Models.Estoque
{
    public class Categoria
    {
        [Key]
        public int IdCategoria { get; set; }

        [Required]
        public string? NomeCategoria { get; set; }

        [Required]
        public string? DescricaoCategoria { get; set; }

        [Required]
        [DataType(DataType.ImageUrl, ErrorMessage = "Imagem inválida")]
        public string? ImagemCategoria { get; set; }

        [Required]
        public DateOnly DataCriacao { get; set; } = new DateOnly(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

        [JsonIgnore]
        public  ICollection<Produto>? Produtos { get; set; }
    }
}