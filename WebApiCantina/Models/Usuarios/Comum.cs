
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using WebApiCantina.Models.Estoque;
using WebApiCantina.Models.Usuarios.Base;

namespace WebApiCantina.Models.Usuarios
{
    public class Comum : Usuario
    {
        [Required]
        [StringLength(50, ErrorMessage = "O campo Nome deve ter no máximo 50 caracteres."), Display(Name = "Nome do Usuário")]
        public string? NomeUsuario { get; set; }

        [Required]
        public string TipoUsuario { get; set; } = "Comum";

        [JsonIgnore]
        public IEnumerable<Produto> Produtos { get; set; } = new List<Produto>();
    }
}