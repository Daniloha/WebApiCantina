using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiCantina.Application.DTOs;
using WebApiCantina.Domain.Models.Estoque;

namespace WebApiCantina.Application.Services.Mapping;

public static class ProdutoExtensions
{
    public static ProdutoDto ToDto(this Produto produto)
    {
        return new ProdutoDto
        {
            IdProduto = produto.IdProduto,
            NomeProduto = produto.NomeProduto,
            DescricaoProduto = produto.DescricaoProduto,
            NomeCategoria = produto.CategoriaProduto?.NomeCategoria,
            QuantidadeEstoque = produto.QuantidadeEstoque,
            PrecoVenda = produto.PrecoVenda,
            Imagem = produto.Imagem,
            DataCriacao = produto.DataCriacao
        };
    }
    public static void AtualizarCom(this Produto destino, Produto origem)
    {
        destino.NomeProduto = origem.NomeProduto;
        destino.DescricaoProduto = origem.DescricaoProduto;
        destino.QuantidadeEstoque = origem.QuantidadeEstoque;
        destino.PrecoVenda = origem.PrecoVenda;
        destino.Imagem = origem.Imagem;
        // Se quiser proteger categoria nula, pode fazer uma verificação aqui também
        if (origem.CategoriaProduto == null) throw new Exception("Categoria não pode ser nula");
        destino.CategoriaProduto = origem.CategoriaProduto;

    }
}
