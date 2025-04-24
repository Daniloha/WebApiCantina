using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApiCantina.Domain.Models.Estoque;
using WebApiCantina.Domain.Models.Usuarios;
using WebApiCantina.Domain.VOs;

namespace WebApiCantina.Domain.Models.Operacoes
{
    public class Carrinho
    {
        [Key]
        public int IdCarrinho { get; set; }

        [Required]
        public List<Produto> Produtos { get; set; } = new List<Produto>();

        [Required]
        public Preco ValorTotal { get; set; }

        [Required]
        public Comum? Cliente { get; set; }

        [Required]
        public Colaborador? Vendedor { get; set; }

        [Required]
        public bool Ativo { get; set; }
    }
}