using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApiCantina.Models.Estoque;
using WebApiCantina.Models.Usuarios;

namespace WebApiCantina.Models.Operacoes
{
    public class Carrinho
    {
        [Key]
        public int IdCarrinho { get; set; }

        [Required]
        public List<Produto> Produtos { get; set; } = new List<Produto>();

        [Required]
        public double ValorTotal { get; set; } = 0;

        [Required]
        public Comum? Cliente { get; set; }

        [Required]
        public Colaborador? Vendedor { get; set; }

        [Required]
        public bool Ativo { get; set; }
    }
}