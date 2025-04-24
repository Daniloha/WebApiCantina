
using System.ComponentModel.DataAnnotations;
using WebApiCantina.Domain.VOs;

namespace WebApiCantina.Domain.Models.Usuarios.Base
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }

        [Required]
        public Cpf CpfUsuario { get; set; }

        [Required]
        public Telefone Telefone { get; set; }

        [Required]
        public Email Email { get; set; }
        [Required]
        public DateOnly DataCriacao { get; set; } = new DateOnly(DateTime.Now.Year,
                                                                 DateTime.Now.Month,
                                                                  DateTime.Now.Day);


    }
}