using System.ComponentModel.DataAnnotations;
using WebApiCantina.Models.Usuarios.Base;

namespace WebApiCantina.Models.Usuarios
{
    public class Administrador : Usuario
    {
        [Required]
        [StringLength(50, ErrorMessage = "O campo Nome deve ter no máximo 50 caracteres."), Display(Name = "Nome do Usuário")]
        public string? NomeAdministrador { get; set; }

        [Required]
        [StringLength(6, ErrorMessage = "O campo Codigo deve ter 6 caracteres."), Display(Name = "Codigo do Usuário")]
        public string? CodigoAdministrador { get; set; }

        public string TipoUsuario { get; set; } = "Administrador";
    }
}