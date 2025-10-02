using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using WebApiCantina.Domain.VOs;

namespace WebApiCantina.Domain.Models.Estoque
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
        public string ImagemCategoria { get; set; }

        [Required]
        public DateTime DataCriacao { get; set; } = DateTime.Now;

        [JsonIgnore]
        public  ICollection<Produto>? Produtos { get; set; }
    }
}