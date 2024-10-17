
using System.ComponentModel.DataAnnotations;

namespace WebApiCantina.Models.Usuarios.Base
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }

        [Required]
        [StringLength(11, ErrorMessage = "O CPF deve conter 11 caracteres.",
                                             MinimumLength = 11)]
        public string? CpfUsuario { get; set; }

        [Required]
        [StringLength(11, ErrorMessage = "O telefone deve conter 11 caracteres.",
                                             MinimumLength = 11)]
        public string? Telefone { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "O e-mail informado é inválido.")]
        public string? Email { get; set; }
        [Required]
        public DateOnly DataCriacao { get; set; } = new DateOnly(DateTime.Now.Year,
                                                                 DateTime.Now.Month,
                                                                  DateTime.Now.Day);


    }
}